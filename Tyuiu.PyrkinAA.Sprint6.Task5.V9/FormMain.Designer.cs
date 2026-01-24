namespace Tyuiu.PyrkinAA.Sprint6.Task5.V9
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridViewResult_PAA = new DataGridView();
            groupBoxCondition_PAA = new GroupBox();
            labelCondition_PAA = new Label();
            buttonDone_PAA = new Button();
            buttonOpenFile_PAA = new Button();
            buttonHelp_PAA = new Button();
            labelOutput_PAA = new Label();
            textBoxInfo_PAA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PAA).BeginInit();
            groupBoxCondition_PAA.SuspendLayout();
            SuspendLayout();

            dataGridViewResult_PAA.AllowUserToAddRows = false;
            dataGridViewResult_PAA.AllowUserToDeleteRows = false;
            dataGridViewResult_PAA.AllowUserToResizeColumns = false;
            dataGridViewResult_PAA.AllowUserToResizeRows = false;
            dataGridViewResult_PAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewResult_PAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PAA.Location = new Point(12, 118);
            dataGridViewResult_PAA.Name = "dataGridViewResult_PAA";
            dataGridViewResult_PAA.ReadOnly = true;
            dataGridViewResult_PAA.RowHeadersVisible = false;
            dataGridViewResult_PAA.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_PAA.Size = new Size(300, 316);
            dataGridViewResult_PAA.TabIndex = 0;
            dataGridViewResult_PAA.CellContentClick += dataGridViewResult_PAA_CellContentClick;

            groupBoxCondition_PAA.Controls.Add(labelCondition_PAA);
            groupBoxCondition_PAA.Location = new Point(12, 12);
            groupBoxCondition_PAA.Name = "groupBoxCondition_PAA";
            groupBoxCondition_PAA.Size = new Size(451, 96);
            groupBoxCondition_PAA.TabIndex = 1;
            groupBoxCondition_PAA.TabStop = false;
            groupBoxCondition_PAA.Text = "Условие";

            labelCondition_PAA.AutoSize = true;
            labelCondition_PAA.Location = new Point(10, 19);
            labelCondition_PAA.Name = "labelCondition_PAA";
            labelCondition_PAA.Size = new Size(380, 60);
            labelCondition_PAA.TabIndex = 2;
            labelCondition_PAA.Text = "Прочитать данные из файла InPutFileTask5V9.txt. \r\nВывести все числа, равные 0. \r\nПостроить диаграмму по этим значениям. \r\nУ вещественных значений округлить до трёх знаков после запятой.";
            labelCondition_PAA.Click += labelCondition_PAA_Click;

            buttonDone_PAA.BackColor = Color.Green;
            buttonDone_PAA.Cursor = Cursors.Hand;
            buttonDone_PAA.Location = new Point(469, 22);
            buttonDone_PAA.Name = "buttonDone_PAA";
            buttonDone_PAA.Size = new Size(91, 66);
            buttonDone_PAA.TabIndex = 3;
            buttonDone_PAA.Text = "Выполнить";
            buttonDone_PAA.UseVisualStyleBackColor = false;
            buttonDone_PAA.Click += buttonDone_PAA_Click;

            buttonOpenFile_PAA.BackColor = SystemColors.HotTrack;
            buttonOpenFile_PAA.Cursor = Cursors.Hand;
            buttonOpenFile_PAA.Location = new Point(578, 22);
            buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            buttonOpenFile_PAA.Size = new Size(91, 65);
            buttonOpenFile_PAA.TabIndex = 4;
            buttonOpenFile_PAA.Text = "Открыть файл";
            buttonOpenFile_PAA.UseVisualStyleBackColor = false;
            buttonOpenFile_PAA.Click += buttonOpenFile_PAA_Click;

            buttonHelp_PAA.BackColor = Color.DodgerBlue;
            buttonHelp_PAA.Cursor = Cursors.Hand;
            buttonHelp_PAA.Location = new Point(687, 22);
            buttonHelp_PAA.Name = "buttonHelp_PAA";
            buttonHelp_PAA.Size = new Size(91, 64);
            buttonHelp_PAA.TabIndex = 5;
            buttonHelp_PAA.Text = "Справка";
            buttonHelp_PAA.UseVisualStyleBackColor = false;
            buttonHelp_PAA.Click += buttonHelp_PAA_Click;

            labelOutput_PAA.AutoSize = true;
            labelOutput_PAA.Location = new Point(12, 100);
            labelOutput_PAA.Name = "labelOutput_PAA";
            labelOutput_PAA.Size = new Size(125, 15);
            labelOutput_PAA.TabIndex = 6;
            labelOutput_PAA.Text = "Нулевые элементы:";

            textBoxInfo_PAA.Location = new Point(318, 118);
            textBoxInfo_PAA.Multiline = true;
            textBoxInfo_PAA.Name = "textBoxInfo_PAA";
            textBoxInfo_PAA.ReadOnly = true;
            textBoxInfo_PAA.ScrollBars = ScrollBars.Vertical;
            textBoxInfo_PAA.Size = new Size(460, 316);
            textBoxInfo_PAA.TabIndex = 7;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 446);
            Controls.Add(textBoxInfo_PAA);
            Controls.Add(labelOutput_PAA);
            Controls.Add(buttonHelp_PAA);
            Controls.Add(buttonOpenFile_PAA);
            Controls.Add(buttonDone_PAA);
            Controls.Add(groupBoxCondition_PAA);
            Controls.Add(dataGridViewResult_PAA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(806, 485);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 9 | Пыркин А. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PAA).EndInit();
            groupBoxCondition_PAA.ResumeLayout(false);
            groupBoxCondition_PAA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridViewResult_PAA;
        private GroupBox groupBoxCondition_PAA;
        private Label labelCondition_PAA;
        private Button buttonDone_PAA;
        private Button buttonOpenFile_PAA;
        private Button buttonHelp_PAA;
        private Label labelOutput_PAA;
        private TextBox textBoxInfo_PAA;
    }
}