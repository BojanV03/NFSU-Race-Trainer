using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Diagnostics;
using System.Windows.Forms;

namespace NFS_Underground_Race_Trainer
{
    //Class wasnt done by me
    //FULL CREDITS TO
    //http://forum.cheatengine.org/viewtopic.php?t=530207


    public class Memory
    {
        private Process m_ReadProcess = null;
        private IntPtr m_hProcess = IntPtr.Zero;

        public Process ReadProcess
        {
            get
            {
                return m_ReadProcess;
            }
            set
            {
                m_ReadProcess = value;
            }
        }

        public void Open()
        {
            ProcessAccessType access = ProcessAccessType.PROCESS_VM_READ
            | ProcessAccessType.PROCESS_VM_WRITE
            | ProcessAccessType.PROCESS_VM_OPERATION;
            m_hProcess = OpenProcess((uint)access, 1, (uint)m_ReadProcess.Id);
        }

        public void CloseHandle()
        {
            int iRetValue;
            iRetValue = CloseHandle(m_hProcess);
            if (iRetValue == 0)
            {
                throw new Exception("CloseHandle Failed");
            }
        }

        public byte[] Read(IntPtr MemoryAddress, uint bytesToRead, out int bytesRead)
        {
            byte[] buffer = new byte[bytesToRead];
            IntPtr ptrBytesRead;
            ReadProcessMemory(m_hProcess, MemoryAddress, buffer, bytesToRead, out ptrBytesRead);
            bytesRead = ptrBytesRead.ToInt32();
            return buffer;
        }

        public byte[] PointerRead(IntPtr MemoryAddress, uint bytesToRead, int[] Offset, out int bytesRead)
        {
            int iPointerCount = Offset.Length - 1;
            IntPtr ptrBytesRead;
            bytesRead = 0;
            byte[] buffer = new byte[4]; //DWORD to hold an Address
            int tempAddress = 0;

            if (iPointerCount == 0)
            {

                
                ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
                tempAddress = ToDec(Make(buffer)) + Offset[0]; //Final Address

                buffer = new byte[bytesToRead];
                ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

                bytesRead = ptrBytesRead.ToInt32();

                //MessageBox.Show(bytesRead.ToString());
                
                return buffer;


            }

            for (int i = 0; i <= iPointerCount; i++)
            {
                if (i == iPointerCount)
                {
                    ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = ToDec(Make(buffer)) + Offset[i]; //Final Address

                    buffer = new byte[bytesToRead];
                    ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

                    bytesRead = ptrBytesRead.ToInt32();
                    return buffer;
                }
                else if (i == 0)
                {
                    ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = ToDec(Make(buffer)) + Offset[1];
                }
                else
                {
                   ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = ToDec(Make(buffer)) + Offset[i];
                }
            }

            return buffer;
        }

        public void Write(IntPtr MemoryAddress, byte[] bytesToWrite, out int bytesWritten)
        {
            IntPtr ptrBytesWritten;
            WriteProcessMemory(m_hProcess, MemoryAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);
            bytesWritten = ptrBytesWritten.ToInt32();
        }

        public string PointerWrite(IntPtr MemoryAddress, byte[] bytesToWrite, int[] Offset, out int bytesWritten)
        {
            int iPointerCount = Offset.Length - 1;
            IntPtr ptrBytesWritten;
            bytesWritten = 0;
            byte[] buffer = new byte[4]; //DWORD to hold an Address
            int tempAddress = 0;

            if (iPointerCount == 0)
            {
                ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
                tempAddress = ToDec(Make(buffer)) + Offset[0]; //Final Address
                WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

                bytesWritten = ptrBytesWritten.ToInt32();
                return ToHex(tempAddress);
            }

            //only necessary for multiple OFFSETS
            for (int i = 0; i <= iPointerCount; i++)
            {
                if (i == iPointerCount)
                {
                    ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = ToDec(Make(buffer)) + Offset[i]; //Final Address
                    WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

                    bytesWritten = ptrBytesWritten.ToInt32();
                    return ToHex(tempAddress);
                }
                else if (i == 0)
                {
                    ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = ToDec(Make(buffer)) + Offset[i];
                }
                else
                {
                    ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = ToDec(Make(buffer)) + Offset[i];
                }
            }

            return ToHex(tempAddress);
        }

        public int PID()
        {
            return m_ReadProcess.Id;
        }

        public string BaseAddressH()
        {
            return ToHex(m_ReadProcess.MainModule.BaseAddress.ToInt32());
        }

        public int BaseAddressD()
        {
            return m_ReadProcess.MainModule.BaseAddress.ToInt32();
        }

        [Flags]
        public enum ProcessAccessType
        {
            PROCESS_TERMINATE = (0x0001),
            PROCESS_CREATE_THREAD = (0x0002),
            PROCESS_SET_SESSIONID = (0x0004),
            PROCESS_VM_OPERATION = (0x0008),
            PROCESS_VM_READ = (0x0010),
            PROCESS_VM_WRITE = (0x0020),
            PROCESS_DUP_HANDLE = (0x0040),
            PROCESS_CREATE_PROCESS = (0x0080),
            PROCESS_SET_QUOTA = (0x0100),
            PROCESS_SET_INFORMATION = (0x0200),
            PROCESS_QUERY_INFORMATION = (0x0400)
        }

        public static string Make(byte[] buffer)
        {
            string sTemp = "";

            for (int i = 0; i < buffer.Length; i++)
            {
                if (Convert.ToInt16(buffer[i]) < 10)
                {
                    sTemp = "0" + ToHex(buffer[i]) + sTemp;
                }
                else
                {
                    sTemp = ToHex(buffer[i]) + sTemp;
                }
            }
            return sTemp;
        }

        public static string ToHex(int Decimal)
        {
            return Decimal.ToString("X"); //Convert Decimal to Hexadecimal
        }

        public static int ToDec(string Hex)
        {
            return int.Parse(Hex, NumberStyles.HexNumber); //Convert Hexadecimal to Decimal
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);

    }
}
