using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.PyrkinAA.Sprint6.Task5.V9.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelCondition_PAA_Click(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();

        private string GetFilePath()
        {
            return $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V9.txt";
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = GetFilePath();

                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файл не найден: {path}\nНажмите 'Открыть файл' для создания примера",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridViewResult_PAA.ColumnCount = 2;
                dataGridViewResult_PAA.Columns[0].Width = 40;
                dataGridViewResult_PAA.Columns[1].Width = 125;
                dataGridViewResult_PAA.Columns[0].HeaderText = "№";
                dataGridViewResult_PAA.Columns[1].HeaderText = "Значение";

                dataGridViewResult_PAA.Rows.Clear();
                textBoxInfo_PAA.Clear();

                double[] numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_PAA.Rows.Add(
                        Convert.ToString(i + 1),
                        numsMass[i].ToString("F3")
                    );

                    textBoxInfo_PAA.AppendText($"Элемент {i + 1}: {numsMass[i]:F3}\r\n");
                }

                MessageBox.Show($"Обработка завершена. Найдено {numsMass.Length} нулевых элементов.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = GetFilePath();

                if (!File.Exists(path))
                {
                    CreateSampleFile(path);
                    MessageBox.Show($"Файл не найден. Создан пример файла: {path}",
                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                System.Diagnostics.Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateSampleFile(string path)
        {
            string[] sampleData = {
                "1.234567",
                "0.000000",
                "-2.345678",
                "0",
                "3.456789",
                "-0.000123",
                "4.567890",
                "0.000000",
                "-5.678901",
                "0.001000",
                "6.789012",
                "0.000000",
                "-7.890123",
                "0.000500",
                "8.901234",
                "0.000000"
            };

            File.WriteAllLines(path, sampleData);
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-2 Пыркин А. А.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewResult_PAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}