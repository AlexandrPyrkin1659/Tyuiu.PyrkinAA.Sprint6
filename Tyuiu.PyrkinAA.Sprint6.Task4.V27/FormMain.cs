using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.PyrkinAA.Sprint6.Task4.V27.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task4.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            textBoxStart_PAA.Text = "-5";
            textBoxStop_PAA.Text = "5";
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_PAA.Text);

                if (startStep > stopStep)
                {
                    MessageBox.Show("Стартовое значение не может быть больше конечного", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                
                textBoxResult_PAA.Text = "";
                
                
                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxResult_PAA.AppendText($"f({startStep + i}) = {valueArray[i]}" + Environment.NewLine);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены неверные данные. Убедитесь, что введены целые числа", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V27.txt";
                File.WriteAllText(path, textBoxResult_PAA.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранён успешно!\nОткрыть его в блокноте?", 
                    "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-2 Пыркин А. А.", 
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelCondition_PAA_Click(object sender, EventArgs e)
        {
        }

        private void textBoxResult_PAA_TextChanged(object sender, EventArgs e)
        {
        }
    }
}