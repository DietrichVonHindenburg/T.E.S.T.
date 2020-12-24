using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Advenuture
{
    class Music
    {
        public static int BPM = 60;

        private static int[] frequencies = {
                                            16,17,18,19,21,22,23,24,26,27,29,31,
                                            33,35,37,39,41,44,46,49,52,55,58,62,
                                            65,69,73,78,82,87,92,98,104,110,116,123,
                                            131,139,147,155,165,175,185,196,208,220,233,245,
                                            262,277,294,311,330,349,370,392,415,440,466,494,
                                            523,554,587,622,659,698,740,784,831,880,932,988,
                                            1046,1109,1175,1244,1328,1397,1480,1568,1661,1760,1865,1975,
                                            2093,2217,2349,2489,2637,2794,2960,3136,3322,3520,3729,3951
                                        };
        private static string[] letters = { "C", "D", "E", "F", "G", "A", "H" };
        private static string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "H" };
        private static string[] noteSymbols = toStringArray(".,:;#".ToCharArray());

        public static readonly string FULL = noteSymbols[0];
        public static readonly string HALF = noteSymbols[1];
        public static readonly string QUARTER = noteSymbols[2];
        public static readonly string EIGTH = noteSymbols[3];
        public static readonly string SIXTEENTH = noteSymbols[4];

        public static string currentSong = "";

        public static readonly string rickroll = "f5-4.; g5-4.; c5-4;" +
                "g5-4.; a5-4.; c6-16; h5-16; a5-8;" +
                "f5-4.; g5-4.; c5-2.;" +
                "4; c5-16; c5-16; d5-16; f5-8; f5-16" +

                "f5-4.; g5-4.; c5-4;" +
                "g5-4.; a5-4.; c6-16; h5-16; a5-8;" +
                "f5-4.; g5-4.; c5-2.;" +
                "4; c5-16; c5-16; d5-16; f5-8; f5-16";
        public static readonly int rickrollBPM = 56;

        public static readonly string preußen =
            "g4-16; g4-16;" +
            //Erste Wiederholung Anfang
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; c5-16; d5-16;" +
            "e5-8; d5-8; c5-8; g4-16; g4-16;" +
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; e5-16; d5-16;" +
            "" +
            "c5-4.; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; e5-8; d5-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; g4-16; g4-16;" +
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; e5-16; d5-16;" +
            "" +
            "c5-4.; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; e5-8; d5-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; g4-16; g4-16;" +
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; e5-16; d5-16;" +
            "" +
            "c5-4; c5-8; d5-8; e5-8;" +
            "f5-4; 4;" +
            "c4-4; a3-8; c4-8;" +
            "f4-4; f4-4;" +
            "g4-4; c4-8; f4-16; g4-16;" +
            "a4-4; a4-4;" +
            "a4-4.; g4-8;" +
            "f4-4; a4-4;" +
            "c5-4.; hb-8;" +
            "a4-4; c4-4;" +
            "" +
            "c4-4; a3-8; c4-8;" +
            "f4-4; f4-4;" +
            "g4-4; c4-8; f4-16; g4-16;" +
            "a4-4; a4-4;" +
            "a4-4.; a4-8;" +
            "d5-4; h4-4;" +
            "c5-1;" +
            "c4-4.; g4-8;" +
            "g4-4; f4-4;" +
            "f4-4.; e4-8;" +
            "" +
            "g4-2;" +
            "c4-4.; hb4-8;" +
            "hb4-4; a4-4;" +
            "a4-4.; g4-8;" +
            "g4-2;" +
            "a4-4; c5-4;" +
            "hb4-4.; a4-8;" +
            "g4-4; hb4-4;" +
            "a4-2;" +
            "g4-4; g4-4;" +
            "a4-4; h4-4;" +
            //Erste Wiederholung Ende
            "c5-4; h4-4;" +
            "c5-4.; g4-16; g4-16;" +
            //Zweite Wiederholung
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; c5-16; d5-16;" +
            "e5-8; d5-8; c5-8; g4-16; g4-16;" +
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; e5-16; d5-16;" +
            "" +
            "c5-4.; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; e5-8; d5-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; g4-16; g4-16;" +
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; e5-16; d5-16;" +
            "" +
            "c5-4.; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; e5-8;" +
            "d5-8; e5-8; d5-8; e5-8;" +
            "d5-8; g4-16; g4-16; g4-8; g4-16; g4-16;" +
            "c5-8; g4-8; e4-8; g4-8;" +
            "e4-8; g4-8; c5-8; e5-8;" +
            "d5-8; d5-16; d5-16; d5-8; e5-16; d5-16;" +
            "" +
            "c5-4; c5-8; d5-8; e5-8;" +
            "f5-4; 4;" +
            "c4-4; a3-8; c4-8;" +
            "f4-4; f4-4;" +
            "g4-4; c4-8; f4-16; g4-16;" +
            "a4-4; a4-4;" +
            "a4-4.; g4-8;" +
            "f4-4; a4-4;" +
            "c5-4.; hb-8;" +
            "a4-4; c4-4;" +
            "" +
            "c4-4; a3-8; c4-8;" +
            "f4-4; f4-4;" +
            "g4-4; c4-8; f4-16; g4-16;" +
            "a4-4; a4-4;" +
            "a4-4.; a4-8;" +
            "d5-4; h4-4;" +
            "c5-1;" +
            "c4-4.; g4-8;" +
            "g4-4; f4-4;" +
            "f4-4.; e4-8;" +
            "" +
            "g4-2;" +
            "c4-4.; hb4-8;" +
            "hb4-4; a4-4;" +
            "a4-4.; g4-8;" +
            "g4-2;" +
            "a4-4; c5-4;" +
            "hb4-4.; a4-8;" +
            "g4-4; hb4-4;" +
            "a4-2;" +
            "g4-4; g4-4;" +
            "a4-4; h4-4;" +
            //Zweite Wiederholung Ende
            "e5-4; e5-4;" +
            "c5-2;";
        public static readonly int preußenBPM = 26;

        private static string[] toStringArray(char[] arr)
        {
            string[] strArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                strArr[i] = arr[i].ToString();
            }
            return strArr;
        }


        public static void playSong(string str)
        {
            string[] arr = str.Split(';');
            foreach (string s in arr)
            {
                Music.play(s.Trim());
            }
        }

        public static void playSong(string[] arr)
        {
            foreach (string s in arr)
            {
                Music.play(s.Trim());
            }
        }

        public static void playCurrent()
        {
            playSong(currentSong);
        }

        public static void playRickRoll()
        {
            BPM = 56;
            playSong(rickroll);
        }
        public static void playPreußen()
        {
            BPM = 26;
            playSong(preußen);
        }

        public static void play(string s)
        {
            string[] arr = s.Split('-');

            if (arr.Length > 1)
            {
                int frq = getFrequency(arr[0]);

                int len = 0;
                //: = staccato (shorter); . = longer
                if (!arr[1].Contains(".") && !arr[1].Contains(":"))
                    len = getNoteLength(arr[1]);
                else if (arr[1].Contains("."))
                    len = (int)(1.5 * getNoteLength(arr[1].Substring(0, arr[1].Length - 1)));
                else if (arr[1].Contains(":"))
                    len = (int)(0.5 * getNoteLength(arr[1].Substring(0, arr[1].Length - 1)));

                Console.Beep(frq, len);
                if (arr[1].Contains(":"))
                    System.Threading.Thread.Sleep(len);
            }
            else
            {
                int len = getNoteLength(arr[0]);
                System.Threading.Thread.Sleep(len);
            }
        }

        public static string replaceB(string s)
        {
            if (s.Contains("b"))
            {
                int index = Array.IndexOf(letters, s.Substring(0, s.Length - 1)) - 1;
                if (index < 0)
                    index += letters.Length;
                return (letters[index] + "#");
            }
            return s;
        }

        public static int getFrequency(string s)
        {
            int octave;
            bool failed = false;
            try
            {
                if (!int.TryParse(s.Substring(s.Length - 1, 1), out octave))
                {
                    octave = 4;
                    failed = true;
                }
            }
            catch
            {
                octave = 4;
            }

            string note = s.Substring(0, s.Length - (failed ? 0 : 1));
            note = replaceB(note).ToUpper();
            int noteIndex = Array.IndexOf(notes, note);
            int frequency = frequencies[octave * notes.Length + noteIndex];
            return frequency;
        }

        // 𝅝 𝅗𝅥 𝅘𝅥 𝅘𝅥𝅮 𝅘𝅥𝅯 𝅘𝅥𝅰 𝅘𝅥𝅱 𝅘𝅥𝅲
        public static int getNoteLength(string s)
        {
            int test;
            if (int.TryParse(s, out test))
                return (int)(60.0 * 1000.0 / BPM * 1.0 / test);

            //if (!noteSymbols.Contains(s))
            //    s = notes[0];
            //return (int)(60 * 1000.0 / BPM * Math.Pow(0.5, Array.IndexOf(noteSymbols, s)));
            return 1;
        }

        public static string getNoteSymbol(int i)
        {
            try
            {
                return noteSymbols[i];
            }
            catch
            { }
            return "ERROR";
        }
    }
}
