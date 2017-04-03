using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Underground_Race_Trainer
{
    class NFSU2_Race_Data
    {
        static string[] RaceNames = { "Don't Change", "Market Street", "Stadium", "Olympic Square", "Terminal", "Atlantica",
            "Inner City", "Port Royal", "National Rail", "Secret track", "Liberty Gardens", "Broadway",
            "Lock Up", "9th. & Frey", "Beddard Bridge", "Spillway", "1st Ave. Truck Stop", "7th & Sparkling",
            "14th and Vine Construction", "Highway 1", "Main street", "Commercial", "14th and Vine",
            "Main Street Construction", "Drift Track 1", "Drift Track 2", "Drift Track 3",
            "Drift Track 4", "Drift Track 5",  "Drift Track 6", "Drift Track 7", "Drift Track 8"};
        static int[] RaceIDs =
        {
            0, 1001,1002,1003,1004,1005,1006,1007,1008,1099,1102,1103,1104,1105,1106,1107,1108,1109,1201,
            1202,1206,1207,1210,1214,1301,1302,1303,1304,1305,1306,1307,1308
        };
        public static Dictionary<string, int> initializeRaceData()
        {
            Dictionary<string, int> raceDict = new Dictionary<string, int>();
            for(int i = 0; i < RaceNames.Length; i++)
            {
                raceDict.Add(RaceNames[i], RaceIDs[i]);
            }
            return raceDict;
        }
    }
}
