using System;
using System.Windows.Forms;
using Tyuiu.PyrkinAA.Sprint6.Task6.V5.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = System.IO.File.ReadAllText(openFilePath);
            groupBoxOutPutFile.Text = "Вывод: " + openFileDialogTask.FileName;
            buttonOK.Enabled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAboutSprint formAbout = new FormAboutSprint();
            formAbout.ShowDialog();
        }
    }
}