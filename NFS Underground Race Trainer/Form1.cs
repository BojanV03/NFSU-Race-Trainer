using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;


namespace NFS_Underground_Race_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Memory myMemory = new Memory();
        Process[] NFSU2 = new Process[10];



        bool isGameAvailable;
        bool allInputsValid = true;
        int pointerAdress;
        Dictionary<string, int> races = new Dictionary<string, int>();
        bool isActive;

        string SelectedRace;
         

        private void Form1_Load(object sender, EventArgs e)
        {
            races = NFSU2_Race_Data.initializeRaceData();
            cbRaces.SelectedIndex = 0;
            cbReversed.SelectedIndex = 0;
            
        }

        private void gameAvailable_Tick(object sender, EventArgs e)
        {
            NFSU2 = Process.GetProcessesByName("speed");
            if(NFSU2.Length == 1)
            {
                activateTrainer(true);
            }
            else
            {
                activateTrainer(false);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (isGameAvailable && allInputsValid)
            {
                if (!isActive)
                {
                    isActive = true;
                    lblTrainerActivated.Text = "Trainer is active";
                    btnActivate.Text = "Deactivate";
                    lblTrainerActivated.ForeColor = Color.LightGreen;
                }
                else
                {
                    isActive = false;
                    lblTrainerActivated.Text = "Trainer is not active";
                    btnActivate.Text = "Activate";
                    lblTrainerActivated.ForeColor = Color.Red;
                }
            }
            else
                MessageBox.Show("Make sure you have the game running!");
        }

        private void activateTrainer(bool isAvailable)
        {
            if(isAvailable)
            {
                lblAvailable.Text = "Game is running";
                lblAvailable.ForeColor = Color.LightGreen;
                lblTrainerActivated.Visible = true;
            }
            else
            {
                lblAvailable.Text = "Game unavailable";
                lblAvailable.ForeColor = Color.Red;
                lblTrainerActivated.Visible = false;
                numTimeHours.Enabled = false;
                numTimeMinutes.Enabled = false;
                numTimeSeconds.Enabled = false;
            }
            isGameAvailable = isAvailable;
            cbReversed.Enabled = isAvailable;
            cbRaces.Enabled = isAvailable;
            chbLapCount.Enabled = isAvailable;
            updateCheats.Enabled = isAvailable;
            numLapCount.Enabled = isAvailable;
            btnActivate.Enabled = isAvailable;
            chbTimeTrial.Enabled = isAvailable;
        }
        private static int hexToDec(String hex)
        {
            return int.Parse(hex, NumberStyles.HexNumber);
        }
        private static string hexToDec(int dec)
        {
            return dec.ToString("x");
        }

        private void updateCheats_Tick(object sender, EventArgs e)
        {
            if(isActive && allInputsValid)
            {
                myMemory.ReadProcess = NFSU2[0];
                myMemory.Open();

                int raceID = races[SelectedRace];
                if (raceID != 0)
                {
                    int bytesWritten;
                    byte[] valueToWrite = BitConverter.GetBytes(raceID);
                    pointerAdress = Form1.hexToDec("004B4BCC");
                    int[] offset = { 0 };
                    myMemory.PointerWrite((IntPtr)pointerAdress, valueToWrite, offset, out bytesWritten);
                }
                if (chbTimeTrial.Checked)
                {
                    int bytesWritten;
                    byte[] valueToWrite = BitConverter.GetBytes(2);
                    pointerAdress = Form1.hexToDec("004B4BCC");
                    int[] offset = { 28 };
                    myMemory.PointerWrite((IntPtr)pointerAdress, valueToWrite, offset, out bytesWritten);
                    int time = 4000*(3600*(int)numTimeHours.Value + 60*(int)numTimeMinutes.Value + (int)numTimeSeconds.Value);
                    offset[0] = 32;
                    valueToWrite = BitConverter.GetBytes(time);
                    myMemory.PointerWrite((IntPtr)pointerAdress, valueToWrite, offset, out bytesWritten);

                }

                if (chbLapCount.Checked)
                {
                    int bytesWritten;
                    byte[] valueToWrite = BitConverter.GetBytes((int)numLapCount.Value);
                    pointerAdress = Form1.hexToDec("004B4BCC");
                    int[] offset = { 44 };
                    myMemory.PointerWrite((IntPtr)pointerAdress, valueToWrite, offset, out bytesWritten);
                }
                byte reverseValue;
                if(cbReversed.Text != "Don't Change")
                {
                    int bytesWritten;
                    if (cbReversed.Text == "Standard")
                        reverseValue = 0;
                    else
                        reverseValue = 1;

                    byte[] valueToWrite = BitConverter.GetBytes(reverseValue);
                    int[] offset = { 12 };
                    pointerAdress = Form1.hexToDec("004B4BCC");
                    string writtenAdress = myMemory.PointerWrite((IntPtr)pointerAdress, valueToWrite, offset, out bytesWritten);
                }
            }
        }

        private int stringToRaceCode(string s)
        {
            int result;
            try
            {
                result = races[s];
            }
            catch (Exception) { result = -1; }
            return result;
        }

        private void cbRaces_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> q in races)
                if (cbRaces.Text == q.Key)
                {
                    SelectedRace = (string)cbRaces.Items[cbRaces.SelectedIndex];
                    return;
                }
            MessageBox.Show("That is a race type, not a race. Selecting " + cbRaces.Items[cbRaces.SelectedIndex + 1]);
            cbRaces.SelectedIndex += 1;
            SelectedRace = (string)cbRaces.Items[cbRaces.SelectedIndex];
        }

        private void chbTimeTrial_CheckedChanged(object sender, EventArgs e)
        {
            if(chbTimeTrial.Checked)
            {
                numTimeHours.Enabled = true;
                numTimeMinutes.Enabled = true;
                numTimeSeconds.Enabled = true;
            }
            else
            {
                numTimeHours.Enabled = false;
                numTimeMinutes.Enabled = false;
                numTimeSeconds.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BojanV03/NFSU-Race-Trainer");
        }
    }
}
