using System;
using System.Windows.Forms;
using Tyuiu.PyrkinAA.Sprint6.Task1.V8.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonInfo_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-25-1 Писарев М. А.",
                           "Сообщение",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_PAA.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;

                textBoxResult_PAA.Text = "";
                textBoxResult_PAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_PAA.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
                textBoxResult_PAA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    string strline = String.Format("|{0,5:d}     |  {1,6:f2}  |", currentX, valueArray[i]);
                    textBoxResult_PAA.AppendText(strline + Environment.NewLine);
                }
                textBoxResult_PAA.AppendText("+----------+----------+");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены неверные данные. Введите целые числа.",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
    }
}