using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Text_Incripter1._1
{

    /// <summary>
    /// Main Windows Form UI MANAGER 
    /// </summary>
    /// 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Incript_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Text File txt | *.txt";

            if(openFile.ShowDialog() != DialogResult.Cancel)
            {
                Program.NewFile(openFile.FileName);
            }
            else
            {
                MessageBox.Show("There is no file to Read !");
            }
        }

        private void Decript_Click(object sender, EventArgs e)
        {
            openCodedFile.Filter = "Text File txt | *.txt";

            if (openCodedFile.ShowDialog() != DialogResult.Cancel)
            {
                Program.NewCodedFile(openCodedFile.FileName);
            }
            else
            {
                MessageBox.Show("There is no file to Read !");
            }
        }

    }
}
