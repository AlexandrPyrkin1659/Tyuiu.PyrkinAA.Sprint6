using Tyuiu.PyrkinAA.Sprint6.Task2.V8.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelStartValue_PAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonFuncStart_PAA_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            try
            {
                int StartValue = -5;
                int StopValue = 5;
                int len = dataService.GetMassFunction(StartValue, StopValue).Length;

                double[] ArrayFunc = new double[len];
                ArrayFunc = dataService.GetMassFunction(StartValue, StopValue);

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(StartValue), Convert.ToString(ArrayFunc[i]));
                    StartValue++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так: {ex}");
            }
        }

        private void groupBoxInfo_PAA_Enter(object sender, EventArgs e)
        {

        }
    }
}