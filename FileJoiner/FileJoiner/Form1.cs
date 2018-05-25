using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileJoiner
{
    public partial class Form1 : Form
    {
        private FileJoiner joiner;

        public Form1()
        {
            joiner = new FileJoiner();
            InitializeComponent();
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                joiner.ProjectPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void JoinFilesButton_Click(object sender, EventArgs e)
        {
            if (joiner.ProjectPath != null)
            {
                joiner.JoinFiles();
            }
        }

        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (joiner.Result != null)
            {
                Clipboard.SetText(joiner.Result);
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if(joiner.Result != null)
            {
                saveFileDialog1.Filter = "(*.cs)|*.cs";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    using (var stream = new StreamWriter(File.Create(path)))
                    {
                        stream.Write(joiner.Result);
                    }
                }
            }
        }
    }
}
