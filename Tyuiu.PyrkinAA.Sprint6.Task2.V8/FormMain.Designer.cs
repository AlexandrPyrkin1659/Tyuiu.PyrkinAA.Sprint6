namespace Tyuiu.PyrkinAA.Sprint6.Task2.V8
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxInfo_PAA = new GroupBox();
            buttonFuncStart_PAA = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            labelStopValue_PAA = new Label();
            labelStartValue_PAA = new Label();
            labelFuncImage_PAA = new Label();
            labelInfo_PAA = new Label();
            groupBoxInfo_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo_PAA
            // 
            groupBoxInfo_PAA.Controls.Add(buttonFuncStart_PAA);
            groupBoxInfo_PAA.Controls.Add(dataGridView1);
            groupBoxInfo_PAA.Controls.Add(labelStopValue_PAA);
            groupBoxInfo_PAA.Controls.Add(labelStartValue_PAA);
            groupBoxInfo_PAA.Controls.Add(labelFuncImage_PAA);
            groupBoxInfo_PAA.Controls.Add(labelInfo_PAA);
            groupBoxInfo_PAA.Location = new Point(12, 12);
            groupBoxInfo_PAA.Name = "groupBoxInfo_PAA";
            groupBoxInfo_PAA.Size = new Size(776, 426);
            groupBoxInfo_PAA.TabIndex = 0;
            groupBoxInfo_PAA.TabStop = false;
            groupBoxInfo_PAA.Enter += groupBoxInfo_PAA_Enter;
            // 
            // buttonFuncStart_PAA
            // 
            buttonFuncStart_PAA.Location = new Point(312, 373);
            buttonFuncStart_PAA.Name = "buttonFuncStart_PAA";
            buttonFuncStart_PAA.Size = new Size(102, 47);
            buttonFuncStart_PAA.TabIndex = 5;
            buttonFuncStart_PAA.Text = "Выполнить";
            buttonFuncStart_PAA.UseVisualStyleBackColor = true;
            buttonFuncStart_PAA.Click += buttonFuncStart_PAA_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(500, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(202, 342);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.Name = "Column2";
            // 
            // labelStopValue_PAA
            // 
            labelStopValue_PAA.AutoSize = true;
            labelStopValue_PAA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStopValue_PAA.Location = new Point(18, 345);
            labelStopValue_PAA.Name = "labelStopValue_PAA";
            labelStopValue_PAA.Size = new Size(145, 32);
            labelStopValue_PAA.TabIndex = 3;
            labelStopValue_PAA.Text = "StopValue: 5";
            // 
            // labelStartValue_PAA
            // 
            labelStartValue_PAA.AutoSize = true;
            labelStartValue_PAA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStartValue_PAA.Location = new Point(18, 275);
            labelStartValue_PAA.Name = "labelStartValue_PAA";
            labelStartValue_PAA.Size = new Size(155, 32);
            labelStartValue_PAA.TabIndex = 2;
            labelStartValue_PAA.Text = "StartValue: -5";
            labelStartValue_PAA.Click += labelStartValue_PAA_Click;
            // 
            // labelFuncImage_PAA
            // 
            labelFuncImage_PAA.AutoSize = true;
            labelFuncImage_PAA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFuncImage_PAA.Location = new Point(18, 163);
            labelFuncImage_PAA.Name = "labelFuncImage_PAA";
            labelFuncImage_PAA.Size = new Size(342, 21);
            labelFuncImage_PAA.TabIndex = 1;
            labelFuncImage_PAA.Text = "F(x) = cos(2x) + sin(x)/(x+2.5) + 2x";
            // 
            // labelInfo_PAA
            // 
            labelInfo_PAA.AutoSize = true;
            labelInfo_PAA.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_PAA.Location = new Point(18, 32);
            labelInfo_PAA.Name = "labelInfo_PAA";
            labelInfo_PAA.Size = new Size(414, 90);
            labelInfo_PAA.TabIndex = 0;
            labelInfo_PAA.Text = "Условие:\r\nПроизвести табуляцию функции с -5 до 5\r\nФункция:\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInfo_PAA);
            Name = "FormMain";
            Text = "Табулирование функции";
            groupBoxInfo_PAA.ResumeLayout(false);
            groupBoxInfo_PAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo_PAA;
        private DataGridView dataGridView1;
        private Label labelStopValue_PAA;
        private Label labelStartValue_PAA;
        private Label labelFuncImage_PAA;
        private Label labelInfo_PAA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonFuncStart_PAA;
    }
}