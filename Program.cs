using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Text_Incripter1._1
{
    static class Program
    {
        /// <summary>
        /// Main Program where the file is prosseced and/or analysed to the other scripts
        /// </summary>
        public static string processedFile;

        public static string text;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #region New Incript
        public static void NewFile(string filepath)
        {
            try
            {
                FileStream userfile = new FileStream(filepath, FileMode.Open);
                using (StreamReader reader = new StreamReader(userfile))
                {
                    text = reader.ReadToEnd();
                }
                userfile.Close();
                
                Random random = new Random();
                int numRan;
                numRan = random.Next(1, 4);

                switch (numRan)
                {
                    case 1:
                        processedFile = Incript.Incript1(text);
                        break;
                    case 2:
                        processedFile = Incript.Incript2(text);
                        break;
                    case 3:
                        processedFile = Incript.Incript3(text);
                        break;
                }
                
                string newFileName;
                newFileName = Path.GetDirectoryName(filepath) + @"\incriptedText.txt";
                SaveFile(newFileName, processedFile);
                
                MessageBox.Show("File Created Sucefully!");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Did not Work, Something wrong with permissions!");
            }
        }
        #endregion

        #region Save
        public static void SaveFile(string filename, string filecontent)
        {
            try
            {
                FileStream newfile = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
                using (StreamWriter writer = new StreamWriter(newfile))
                {
                    writer.Write(filecontent);
                }
                newfile.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Did not Work, Something wrong with Saving the File and/or file already created with that name!");
            }
        }
        #endregion

        #region New Decript
        public static void NewCodedFile(string filepath)
        {
            try
            {
                FileStream userfile = new FileStream(filepath, FileMode.Open);
                using (StreamReader reader = new StreamReader(userfile))
                {
                    text = reader.ReadToEnd();
                }
                userfile.Close();
                
                processedFile = Decript.CheckIncript(text);
                
                string decriptedFileName;
                decriptedFileName = Path.GetDirectoryName(filepath) + @"\decriptedText.txt";
                SaveFile(decriptedFileName, processedFile);

                MessageBox.Show("File Created Sucefully!");

            }
            catch (Exception)
            {
                MessageBox.Show("Did not Work, Something wrong with permissions!");
            }
        }
        #endregion

    }
}
