using System;
using System.Windows.Forms;
using Tyuiu.PyrkinAA.Sprint6.Task3.V27.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] mas = new int[5, 5] {
            { 9, 13, -14, 23, 1 },
            { 15, -17, 21, 25, 23 },
            { -4, 29, -20, -10, 14 },
            { 27, 33, 12, 33, -12 },
            { 18, -9, -5, 6, 3 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mas.GetLength(0);
            int columns = mas.GetLength(1);

            dataGridViewMas_PAA.ColumnCount = columns;
            dataGridViewMas_PAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMas_PAA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMas_PAA.Rows[i].Cells[j].Value = mas[i, j].ToString();
                }
            }
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mas);

            int rows = res.GetLength(0);
            int columns = res.GetLength(1);

            // Очищаем DataGridView перед заполнением
            dataGridViewMas_PAA.Rows.Clear();
            dataGridViewMas_PAA.Columns.Clear();

            dataGridViewMas_PAA.ColumnCount = columns;
            dataGridViewMas_PAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMas_PAA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMas_PAA.Rows[i].Cells[j].Value = res[i, j].ToString();
                }
            }
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-2 Пыркин А. А.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}