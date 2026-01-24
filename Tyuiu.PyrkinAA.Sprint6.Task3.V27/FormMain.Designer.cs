using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.PyrkinAA.Sprint6.Task3.V27
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_PAA = new GroupBox();
            textBoxCondition_PAA = new TextBox();
            dataGridViewMas_PAA = new DataGridView();
            groupBoxOutput_PAA = new GroupBox();
            labelResult_PAA = new Label();
            buttonDone_PAA = new Button();
            buttonHelp_PAA = new Button();
            groupBoxCondition_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMas_PAA).BeginInit();
            groupBoxOutput_PAA.SuspendLayout();
            SuspendLayout();
            
            groupBoxCondition_PAA.Controls.Add(textBoxCondition_PAA);
            groupBoxCondition_PAA.Location = new Point(12, 12);
            groupBoxCondition_PAA.Name = "groupBoxCondition_PAA";
            groupBoxCondition_PAA.Size = new Size(480, 426);
            groupBoxCondition_PAA.TabIndex = 0;
            groupBoxCondition_PAA.TabStop = false;
            groupBoxCondition_PAA.Text = "Условие";
           
            textBoxCondition_PAA.Location = new Point(20, 28);
            textBoxCondition_PAA.Multiline = true;
            textBoxCondition_PAA.Name = "textBoxCondition_PAA";
            textBoxCondition_PAA.ReadOnly = true;
            textBoxCondition_PAA.Size = new Size(440, 380);
            textBoxCondition_PAA.TabIndex = 2;
            textBoxCondition_PAA.Text = "Дан массив 5 на 5 элементов.\r\n9  13 -14  23   1\r\n15 -17  21  25   23\r\n-4  29 -20 -10  14\r\n27  33  12  33 -12\r\n18 -9  -5   6   3\r\nВыполнить сортировку по возрастанию в четвертом столбце.";
            
            dataGridViewMas_PAA.AllowUserToResizeColumns = false;
            dataGridViewMas_PAA.AllowUserToResizeRows = false;
            dataGridViewMas_PAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMas_PAA.ColumnHeadersVisible = false;
            dataGridViewMas_PAA.Location = new Point(19, 46);
            dataGridViewMas_PAA.Name = "dataGridViewMas_PAA";
            dataGridViewMas_PAA.ReadOnly = true;
            dataGridViewMas_PAA.RowHeadersVisible = false;
            dataGridViewMas_PAA.Size = new Size(253, 128);
            dataGridViewMas_PAA.TabIndex = 1;
           
            groupBoxOutput_PAA.Controls.Add(labelResult_PAA);
            groupBoxOutput_PAA.Controls.Add(dataGridViewMas_PAA);
            groupBoxOutput_PAA.Location = new Point(498, 12);
            groupBoxOutput_PAA.Name = "groupBoxOutput_PAA";
            groupBoxOutput_PAA.Size = new Size(290, 199);
            groupBoxOutput_PAA.TabIndex = 1;
            groupBoxOutput_PAA.TabStop = false;
            groupBoxOutput_PAA.Text = "Вывод данных";
            
            labelResult_PAA.AutoSize = true;
            labelResult_PAA.Location = new Point(6, 19);
            labelResult_PAA.Name = "labelResult_PAA";
            labelResult_PAA.Size = new Size(63, 15);
            labelResult_PAA.TabIndex = 0;
            labelResult_PAA.Text = "Результат:";
           
            buttonDone_PAA.Cursor = Cursors.Hand;
            buttonDone_PAA.Location = new Point(579, 381);
            buttonDone_PAA.Name = "buttonDone_PAA";
            buttonDone_PAA.Size = new Size(209, 57);
            buttonDone_PAA.TabIndex = 2;
            buttonDone_PAA.Text = "Выполнить";
            buttonDone_PAA.UseVisualStyleBackColor = true;
            buttonDone_PAA.Click += buttonDone_PAA_Click;
           
            buttonHelp_PAA.Cursor = Cursors.Hand;
            buttonHelp_PAA.Location = new Point(498, 381);
            buttonHelp_PAA.Name = "buttonHelp_PAA";
            buttonHelp_PAA.Size = new Size(75, 57);
            buttonHelp_PAA.TabIndex = 3;
            buttonHelp_PAA.Text = "?";
            buttonHelp_PAA.UseVisualStyleBackColor = true;
            buttonHelp_PAA.Click += buttonHelp_PAA_Click;
           
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_PAA);
            Controls.Add(buttonDone_PAA);
            Controls.Add(groupBoxOutput_PAA);
            Controls.Add(groupBoxCondition_PAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 27 | Пыркин А. А.";
            Load += FormMain_Load;
            groupBoxCondition_PAA.ResumeLayout(false);
            groupBoxCondition_PAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMas_PAA).EndInit();
            groupBoxOutput_PAA.ResumeLayout(false);
            groupBoxOutput_PAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_PAA;
        private DataGridView dataGridViewMas_PAA;
        private GroupBox groupBoxOutput_PAA;
        private Label labelResult_PAA;
        private Button buttonDone_PAA;
        private Button buttonHelp_PAA;
        private TextBox textBoxCondition_PAA;
    }
}
