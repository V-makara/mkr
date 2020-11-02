//១.Name: វណ្ណថន មករា
//  Address: Phnom Penh
//  ការតម្រូវ: ត្រូវបង្កើត Projectមួយ ដែលមាន richtextbox ចំនួន ២ ។
//                     richtextbox មួយ បង្ហាញពី Tuner របស់ណោតទាំង ៨៨ ដែលប្រែប្រូលតាមលេខ បញ្ចូលក្នុង 
//           textbox របស់ tuner។ និង richtextbox មួយទៀត បង្ហាញពី frequency, Key#, Scale 
//                     អាស្រ័យតាមណោតនីមួយៗ ដែលបញ្ចូលក្នុង textbox របស់ណោត។

//២.Fuction: A. If, else if
//           B. 440*Math.Pow(2,n/12)
//           C. If Loop
//           D. Foreach Loop
//           E. Array

//៣.Test Case
//I. richtextbox tuner:
//   បញ្ចូលលេខ​ ក្នុង texbox tuner:
//     440 => លទ្ធផលត្រឹមត្រូវ =>ok
//     441 => លទ្ធផលត្រឹមត្រូវ =>ok
//     1 => លទ្ធផលត្រឹមត្រូវ
//     0 => លទ្ធផល: សូមបញ្ចូលលេខវិជ្ជមាន => ok
//     -5 => លទ្ធផល: សូមបញ្ចូលលេខវិជ្ជមាន => ok
//II. richtextbox note:
// ​​  - ក្នុង combox ជ្រើសរើស frequency រួចបញ្ចូលណោតក្នុង textbox2:
//     C,Db,D,Eb,E,F,Gb,G,Ab,A,Bb,B=> លទ្ធផលត្រឹមត្រូវ (ប្រែប្រួលតាមលេខក្នុងtextboxt1) => ok

// ​​  - ក្នុង combox ជ្រើសរើស Key# រួចបញ្ចូលណោតក្នុង textbox2:
//     C,Db,D,Eb,E,F,Gb,G,Ab,A,Bb,B=> លទ្ធផលត្រឹមត្រូវ => ok

// ​​  - ក្នុង combox ជ្រើសរើស Scale រួចបញ្ចូលណោតក្នុង textbox2:
//     C,Db,D,Eb,E,F,Gb,G,Ab,A,Bb,B=> លទ្ធផលត្រឹមត្រូវ => ok

//   - ក្នុង combox: ទទេរ រួចបញ្ចូលណោតក្នុង textbox2:
//     C,Db,D,Eb,E,F,Gb,G,Ab,A,Bb,B=> លទ្ធផល: សូមជ្រើសរើសលក្ខខណ្ឌ => ok

// ​​  - ក្នុងcomboxជ្រើសរើស frequency ឬKey# ឬScale រួចបញ្ចូលអក្សរ ឬលេខក្នុង textbox2​​ផ្សេងពីណោតទាំង ១២:
//     ក្រៅពី (C,Db,D,Eb,E,F,Gb,G,Ab,A,Bb,B)=> សូមបញ្ចូលណោតត្រឹមត្រូវ => ok

// ​​  - ក្នុងcomboxជ្រើសរើស frequency ឬKey# ឬScale តែក្នុងtextbox2:ទទេរ => លទ្ធផល: សូមបញ្ចូលណោត => ok
// ​​  - ក្នុងcombox: ទទេរ និង textbox2:ទទេរ => លទ្ធផល: សូមពិនិត្យព័ត៌មាន និងសាកល្បងម្តងទៀត => ok

//៤. កាលបរិចេ្ឆទធ្វើ: ១៣ កញ្ញា ២០២០ ពីម៉ោង ២០:០០ ដល់ ២២:១៥
//                 ១៤ កញ្ញា ២០២០ ពីម៉ោង ១១:២៥ ដល់ ១៤:០០
//                 ១៦ កញ្ញា ២០២០ ពីម៉ោង ១៩:៣០ ដល់ ២០:១០
//                 ១៧ កញ្ញា ២០២០ ពីម៉ោង ១៣:៤០ ដល់ ១៧:៤០
//                 ១៧ កញ្ញា ២០២០ ពីម៉ោង ១៩:១៥ ដល់ ២០:៣០
//    កែតម្រូវ:      ១៨ កញ្ញា ២០២០ ពីម៉ោង ២១:៤០ ដល់ ២២:១០
//                 ២១ កញ្ញា ២០២០ ពីម៉ោង ២០:២០ ដល់ ២១:២០
//                 ២៥ កញ្ញា ២០២០ ពីម៉ោង ២០:៣០ ដល់ ២៣:១០
//                 ៣០ កញ្ញា ២០២០ ពីម៉ោង ២០:៤០ ដល់ ២២:១០

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lesson_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Combo_condition.Items.Add("Frequency");
            Combo_condition.Items.Add("Key#");
            Combo_condition.Items.Add("Scale");
            Combo_condition.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtxb_Tuner.Clear();
            if (String.IsNullOrEmpty(txb_Tuner.Text))
                return;

            int n = 0;
            n = int.Parse(txb_Tuner.Text);

            if (n > 0)
            {
                for (byte i = 1; i <= 88; i++)
                {
                    double a = i - 49;
                    double c = a / 12;
                    double d = Math.Pow(2, c);
                    double answer = Math.Round(n * d, 3);

                    rtxb_Tuner.Text += i + "=" + answer.ToString(".000") + Environment.NewLine;
                }
            }
            else
                rtxb_Tuner.Text = "សូមបញ្ចូលេខវិជ្ជមាន";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtxb_note.Clear();

            string condition = null;
            condition = Combo_condition.Text;
            string note = null;
            note = txb_Note.Text;

            if (condition != "" && note == "")
                rtxb_note.Text = "សូមបញ្ចលណោត";
            else if (condition != "" && note != "A" && note != "Bb" &&
                     note != "B" && note != "Cb" && note != "C" && note != "Db" &&
                     note != "D" && note != "Eb" && note != "E" && note != "F" &&
                     note != "Gb" && note != "G" && note != "Ab")
                rtxb_note.Text = "សូមបញ្ចូលណោតអោយត្រឹមត្រូវ";
            else if (condition == "" && note != "")
                rtxb_note.Text = "សូមជ្រើសរើសលក្ខខណ្ឌ";
            else if (condition == "" && note == "")
                rtxb_note.Text = "សូមពិនិត្យព័ត៌មាន និងសាកល្បងម្តងទៀត";

            #region Frequency
            int tuner = 0;
            if (txb_Tuner.Text == "")
                tuner = 440;
            else
                tuner = int.Parse(txb_Tuner.Text);

            if (condition == "Frequency" && note == "A" && tuner > 0)
            {
                double A = Math.Pow(2, 0);
                double result1 = A * tuner;
                rtxb_note.Text = "A0=" + (result1 / 16).ToString(".000") + Environment.NewLine +
                                    "A1=" + (result1 / 8).ToString(".000") + Environment.NewLine +
                                    "A2=" + (result1 / 4).ToString(".000") + Environment.NewLine +
                                    "A3=" + (result1 / 2).ToString(".000") + Environment.NewLine +
                                    "A4=" + (result1).ToString(".000") + Environment.NewLine +
                                    "A5=" + (result1 * 2).ToString(".000") + Environment.NewLine +
                                    "A6=" + (result1 * 4).ToString(".000") + Environment.NewLine +
                                    "A7=" + (result1 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "Bb" && tuner > 0)
            {
                double x2 = 1;
                double y2 = x2 / 12;
                double Bb = Math.Pow(2, y2);
                double result2 = Bb * tuner;
                rtxb_note.Text = "Bb0=" + (result2 / 16).ToString(".000") + Environment.NewLine +
                                    "Bb1=" + (result2 / 8).ToString(".000") + Environment.NewLine +
                                    "Bb2=" + (result2 / 4).ToString(".000") + Environment.NewLine +
                                    "Bb3=" + (result2 / 2).ToString(".000") + Environment.NewLine +
                                    "Bb4=" + (result2).ToString(".000") + Environment.NewLine +
                                    "Bb5=" + (result2 * 2).ToString(".000") + Environment.NewLine +
                                    "Bb6=" + (result2 * 4).ToString(".000") + Environment.NewLine +
                                    "Bb7=" + (result2 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "B" && tuner > 0)
            {
                double x3 = 2;
                double y3 = x3 / 12;
                double B = Math.Pow(2, y3);
                double result3 = B * tuner;
                rtxb_note.Text = "B0=" + (result3 / 16).ToString(".000") + Environment.NewLine +
                                    "B1=" + (result3 / 8).ToString(".000") + Environment.NewLine +
                                    "B2=" + (result3 / 4).ToString(".000") + Environment.NewLine +
                                    "B3=" + (result3 / 2).ToString(".000") + Environment.NewLine +
                                    "B4=" + (result3).ToString(".000") + Environment.NewLine +
                                    "B5=" + (result3 * 2).ToString(".000") + Environment.NewLine +
                                    "B6=" + (result3 * 4).ToString(".000") + Environment.NewLine +
                                    "Bb7=" + (result3 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "C" && tuner > 0)
            {
                double x4 = -9;
                double y4 = x4 / 12;
                double C = Math.Pow(2, y4);
                double result4 = C * tuner;
                rtxb_note.Text = "C1=" + (result4 / 8).ToString(".000") + Environment.NewLine +
                                    "C2=" + (result4 / 4).ToString(".000") + Environment.NewLine +
                                    "C3=" + (result4 / 2).ToString(".000") + Environment.NewLine +
                                    "C4=" + (result4).ToString(".000") + Environment.NewLine +
                                    "C5=" + (result4 * 2).ToString(".000") + Environment.NewLine +
                                    "C6=" + (result4 * 4).ToString(".000") + Environment.NewLine +
                                    "C7=" + (result4 * 8).ToString(".000") + Environment.NewLine +
                                    "C8=" + (result4 * 16).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "Db" && tuner > 0)
            {
                double x5 = -8;
                double y5 = x5 / 12;
                double Db = Math.Pow(2, y5);
                double result5 = Db * tuner;
                rtxb_note.Text = "Db1=" + (result5 / 8).ToString(".000") + Environment.NewLine +
                                    "Db2=" + (result5 / 4).ToString(".000") + Environment.NewLine +
                                    "Db3=" + (result5 / 2).ToString(".000") + Environment.NewLine +
                                    "Db4=" + (result5).ToString(".000") + Environment.NewLine +
                                    "Db5=" + (result5 * 2).ToString(".000") + Environment.NewLine +
                                    "Db6=" + (result5 * 4).ToString(".000") + Environment.NewLine +
                                    "Db7=" + (result5 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "D" && tuner > 0)
            {
                double x6 = -7;
                double y6 = x6 / 12;
                double D = Math.Pow(2, y6);
                double result6 = D * tuner;
                rtxb_note.Text = "D1=" + (result6 / 8).ToString(".000") + Environment.NewLine +
                                    "D2=" + (result6 / 4).ToString(".000") + Environment.NewLine +
                                    "D3=" + (result6 / 2).ToString(".000") + Environment.NewLine +
                                    "D4=" + (result6).ToString(".000") + Environment.NewLine +
                                    "D5=" + (result6 * 2).ToString(".000") + Environment.NewLine +
                                    "D6=" + (result6 * 4).ToString(".000") + Environment.NewLine +
                                    "D7=" + (result6 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "Eb" && tuner > 0)
            {
                double x7 = -6;
                double y7 = x7 / 12;
                double Eb = Math.Pow(2, y7);
                double result7 = Eb * tuner;
                rtxb_note.Text = "Eb1=" + (result7 / 8).ToString(".000") + Environment.NewLine +
                                    "Eb2=" + (result7 / 4).ToString(".000") + Environment.NewLine +
                                    "Eb3=" + (result7 / 2).ToString(".000") + Environment.NewLine +
                                    "Eb4=" + (result7).ToString(".000") + Environment.NewLine +
                                    "Eb5=" + (result7 * 2).ToString(".000") + Environment.NewLine +
                                    "Eb6=" + (result7 * 4).ToString(".000") + Environment.NewLine +
                                    "Eb7=" + (result7 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "E" && tuner > 0)
            {
                double x8 = -5;
                double y8 = x8 / 12;
                double E = Math.Pow(2, y8);
                double result8 = E * tuner;
                rtxb_note.Text = "E1=" + (result8 / 8).ToString(".000") + Environment.NewLine +
                                    "E2=" + (result8 / 4).ToString(".000") + Environment.NewLine +
                                    "E3=" + (result8 / 2).ToString(".000") + Environment.NewLine +
                                    "E4=" + (result8).ToString(".000") + Environment.NewLine +
                                    "E5=" + (result8 * 2).ToString(".000") + Environment.NewLine +
                                    "E6=" + (result8 * 4).ToString(".000") + Environment.NewLine +
                                    "E7=" + (result8 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "F" && tuner > 0)
            {
                double x9 = -4;
                double y9 = x9 / 12;
                double F = Math.Pow(2, y9);
                double result9 = F * tuner;
                rtxb_note.Text = "F1=" + (result9 / 8).ToString(".000") + Environment.NewLine +
                                    "F2=" + (result9 / 4).ToString(".000") + Environment.NewLine +
                                    "F3=" + (result9 / 2).ToString(".000") + Environment.NewLine +
                                    "F4=" + (result9).ToString(".000") + Environment.NewLine +
                                    "F5=" + (result9 * 2).ToString(".000") + Environment.NewLine +
                                    "F6=" + (result9 * 4).ToString(".000") + Environment.NewLine +
                                    "F7=" + (result9 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "Gb" && tuner > 0)
            {
                double x10 = -3;
                double y10 = x10 / 12;
                double Gb = Math.Pow(2, y10);
                double result10 = Gb * tuner;
                rtxb_note.Text = "Gb1=" + (result10 / 8).ToString(".000") + Environment.NewLine +
                                    "Gb2=" + (result10 / 4).ToString(".000") + Environment.NewLine +
                                    "Gb3=" + (result10 / 2).ToString(".000") + Environment.NewLine +
                                    "Gb4=" + (result10).ToString(".000") + Environment.NewLine +
                                    "Gb5=" + (result10 * 2).ToString(".000") + Environment.NewLine +
                                    "Gb6=" + (result10 * 4).ToString(".000") + Environment.NewLine +
                                    "Gb7=" + (result10 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "G" && tuner > 0)
            {
                double x11 = -2;
                double y11 = x11 / 12;
                double G = Math.Pow(2, y11);
                double result11 = G * tuner;
                rtxb_note.Text = "G1=" + (result11 / 8).ToString(".000") + Environment.NewLine +
                                    "G2=" + (result11 / 4).ToString(".000") + Environment.NewLine +
                                    "G3=" + (result11 / 2).ToString(".000") + Environment.NewLine +
                                    "G4=" + (result11).ToString(".000") + Environment.NewLine +
                                    "G5=" + (result11 * 2).ToString(".000") + Environment.NewLine +
                                    "G6=" + (result11 * 4).ToString(".000") + Environment.NewLine +
                                    "G7=" + (result11 * 8).ToString(".000") + Environment.NewLine;
            }
            else if (condition == "Frequency" && note == "Ab" && tuner > 0)
            {
                double x12 = -1;
                double y12 = x12 / 12;
                double Ab = Math.Pow(2, y12);
                double result12 = Ab * tuner;
                rtxb_note.Text = "Ab1=" + (result12 / 8).ToString(".000") + Environment.NewLine +
                                    "Ab2=" + (result12 / 4).ToString(".000") + Environment.NewLine +
                                    "Ab3=" + (result12 / 2).ToString(".000") + Environment.NewLine +
                                    "Ab4=" + (result12).ToString(".000") + Environment.NewLine +
                                    "Ab5=" + (result12 * 2).ToString(".000") + Environment.NewLine +
                                    "Ab6=" + (result12 * 4).ToString(".000") + Environment.NewLine +
                                    "Ab7=" + (result12 * 8).ToString(".000") + Environment.NewLine;
            }
            #endregion

            #region Key#
            if (condition == "Key#" && note == "A")
            {
                string[] Anote = new string[8] { "A0 = 1", "A1 = 13", "A2 = 25", "A3 = 37", "A4 = 49", "A5 = 61", "A6 = 73", "A7 = 85" };
                foreach (string x1 in Anote)
                    rtxb_note.Text += x1 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "Bb")
            {
                string[] Bbnote = new string[8] { "Bb0 = 2", "Bb1 = 14", "Bb2 = 26", "Bb3 = 38", "Bb4 = 50", "Bb5 = 62", "Bb6 = 74", "Bb7 = 86" };
                foreach (string x2 in Bbnote)
                    rtxb_note.Text += x2 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "B")
            {
                string[] Bnote = new string[8] { "B0 = 3", "B1 = 15", "B2 = 27", "B3 = 39", "B4 = 51", "B5 = 63", "B6 = 75", "B7 = 87" };
                foreach (string x3 in Bnote)
                    rtxb_note.Text += x3 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "C")
            {
                string[] Cnote = new string[8] { "C1 = 4", "C2 = 16", "C3 = 28", "C4 = 40", "C5 = 52", "C6 = 64", "C7 = 76", "C8 = 88" };
                foreach (string x4 in Cnote)
                    rtxb_note.Text += x4 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "Db")
            {
                string[] Dbnote = new string[7] { "Db1 =5", "Db2 =17", "Db3 = 29", "Db4 = 41", "Db5 = 53", "Db6 = 65", "Db7 = 77" };
                foreach (string x5 in Dbnote)
                    rtxb_note.Text += x5 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "D")
            {
                string[] Dnote = new string[7] { "D1 = 6", "D2 = 18", "D3 = 30", "D4 = 42", "D5 = 54", "D6 = 66", "D7 = 78" };
                foreach (string x6 in Dnote)
                    rtxb_note.Text += x6 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "Eb")
            {
                string[] Ebnote = new string[7] { "Eb1 = 7", "Eb2 = 19", "Eb3 = 31", "Eb4 = 43", "Eb5 = 55", "Eb6 = 67", "Eb7 = 79" };
                foreach (string x7 in Ebnote)
                    rtxb_note.Text += x7 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "E")
            {
                string[] Enote = new string[7] { "E1 = 8", "E2 = 20", "E3 = 32", "E4 = 44", "E5 = 56", "E6 = 68", "E7 = 80" };
                foreach (string x8 in Enote)
                    rtxb_note.Text += x8 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "F")
            {
                string[] Fnote = new string[7] { "F1 = 9", "F2 = 21", "F3 = 33", "F4 = 45", "F5 = 57", "F6 = 69", "F7 = 81" };
                foreach (string x9 in Fnote)
                    rtxb_note.Text += x9 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "Gb")
            {
                string[] Gbnote = new string[7] { "Gb1 = 10", "Gb2 = 22", "Gb3 = 34", "Gb4 = 46", "Gb5 = 58", "Gb6 = 70", "Gb7 = 82" };
                foreach (string x10 in Gbnote)
                    rtxb_note.Text += x10 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "G")
            {
                string[] Gnote = new string[7] { "G1 = 11", "G2 = 23", "G3 = 35", "G4 = 47", "G5 = 59", "G6 = 71", "G7 = 83" };
                foreach (string x11 in Gnote)
                    rtxb_note.Text += x11 + Environment.NewLine;
            }
            else if (condition == "Key#" && note == "Ab")
            {
                string[] Abnote = new string[7] { "Ab1 = 12", "Ab2 = 24", "Ab3 = 36", "Ab4 = 48", "Ab5 = 60", "Ab6 = 72", "Ab7 = 84" };
                foreach (string x12 in Abnote)
                    rtxb_note.Text += x12 + Environment.NewLine;
            }
            #endregion

            #region Scale
            if (condition == "Scale" && note == "A")
                rtxb_note.Text = "A, B, C#, D, E, F#, G#, A";
            else if (condition == "Scale" && note == "Bb")
                rtxb_note.Text = "Bb, C, D, Eb, F, G, A, Bb";
            else if (condition == "Scale" && note == "B")
                rtxb_note.Text = "B, C#, D#, E, F#, G#, A#, B";
            else if (condition == "Scale" && note == "C")
                rtxb_note.Text = "C, D, E, F, G, A, B, C";
            else if (condition == "Scale" && note == "Db")
                rtxb_note.Text = "Db, Eb, F, Gb, Ab, C, Db";
            else if (condition == "Scale" && note == "D")
                rtxb_note.Text = "D, E, F#, G, A, B, C#, D";
            else if (condition == "Scale" && note == "Eb")
                rtxb_note.Text = "Eb, F, G, Ab, Bb, C, D, Eb";
            else if (condition == "Scale" && note == "E")
                rtxb_note.Text = "E, F#, G#, A, B, C#, D#, E";
            else if (condition == "Scale" && note == "F")
                rtxb_note.Text = "F, G, A, Bb, C, D, E, F";
            else if (condition == "Scale" && note == "Gb")
                rtxb_note.Text = "Gb, Ab, Bb, Cb, Db, Eb, F, Gb";
            else if (condition == "Scale" && note == "G")
                rtxb_note.Text = "G, A, B, C, D, E, F#, G";
            else if (condition == "Scale" && note == "Ab")
                rtxb_note.Text = "AB, Bb, C, Db, Eb, F, G, Ab"; 
            #endregion
        }
    }
}