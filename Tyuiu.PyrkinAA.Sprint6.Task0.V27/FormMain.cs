using System;
using System.Windows.Forms;
using Tyuiu.PyrkinAA.Sprint6.Task0.V27.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task0.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-25-1 Писарев М. А.",
                          "Сообщение",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int x = Convert.ToInt32(textBoxVariable_PAA.Text);
                double result = ds.Calculate(x);
                textBoxResult_PAA.Text = result.ToString("F3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число в поле переменной x",
                              "Ошибка ввода",
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
