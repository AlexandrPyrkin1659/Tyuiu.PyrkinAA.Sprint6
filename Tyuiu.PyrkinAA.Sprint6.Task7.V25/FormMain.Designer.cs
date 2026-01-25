namespace Tyuiu.PyrkinAA.Sprint6.Task7.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile_PAA = new Button();
            panel1_PAA = new Panel();
            groupBoxTask_PAA = new GroupBox();
            groupBoxTask1_PAA = new GroupBox();
            buttonSaveFile_PAA = new Button();
            buttonHelp_PAA = new Button();
            buttonDone_PAA = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip_PAA = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panel2_PAA = new Panel();
            groupBoxVvod_PAA = new GroupBox();
            dataGridViewInMatrix_PAA = new DataGridView();
            panel3_PAA = new Panel();
            groupBoxVyvod_PAA = new GroupBox();
            dataGridViewOutMatrix_PAA = new DataGridView();
            panel1_PAA.SuspendLayout();
            groupBoxTask_PAA.SuspendLayout();
            panel2_PAA.SuspendLayout();
            groupBoxVvod_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_PAA).BeginInit();
            panel3_PAA.SuspendLayout();
            groupBoxVyvod_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_PAA).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile_PAA
            // 
            buttonOpenFile_PAA.Image = (System.Drawing.Image)resources.GetObject("buttonOpenFile_PAA.Image");
            buttonOpenFile_PAA.Location = new System.Drawing.Point(10, 9);
            buttonOpenFile_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            buttonOpenFile_PAA.Size = new System.Drawing.Size(58, 44);
            buttonOpenFile_PAA.TabIndex = 0;
            toolTip_PAA.SetToolTip(buttonOpenFile_PAA, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_PAA.UseVisualStyleBackColor = true;
            buttonOpenFile_PAA.Click += buttonOpenFile_PAA_Click;
            // 
            // panel1_PAA
            // 
            panel1_PAA.Controls.Add(groupBoxTask_PAA);
            panel1_PAA.Controls.Add(buttonSaveFile_PAA);
            panel1_PAA.Controls.Add(buttonHelp_PAA);
            panel1_PAA.Controls.Add(buttonDone_PAA);
            panel1_PAA.Controls.Add(buttonOpenFile_PAA);
            panel1_PAA.Dock = System.Windows.Forms.DockStyle.Top;
            panel1_PAA.Location = new System.Drawing.Point(0, 0);
            panel1_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1_PAA.Name = "panel1_PAA";
            panel1_PAA.Size = new System.Drawing.Size(700, 147);
            panel1_PAA.TabIndex = 1;
            // 
            // groupBoxTask_PAA
            // 
            groupBoxTask_PAA.Controls.Add(groupBoxTask1_PAA);
            groupBoxTask_PAA.Location = new System.Drawing.Point(10, 58);
            groupBoxTask_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTask_PAA.Name = "groupBoxTask_PAA";
            groupBoxTask_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTask_PAA.Size = new System.Drawing.Size(682, 91);
            groupBoxTask_PAA.TabIndex = 4;
            groupBoxTask_PAA.TabStop = false;
            groupBoxTask_PAA.Text = "Условие";
            // 
            // groupBoxTask1_PAA
            // 
            groupBoxTask1_PAA.Location = new System.Drawing.Point(0, 20);
            groupBoxTask1_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTask1_PAA.Name = "groupBoxTask1_PAA";
            groupBoxTask1_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTask1_PAA.Size = new System.Drawing.Size(683, 68);
            groupBoxTask1_PAA.TabIndex = 0;
            groupBoxTask1_PAA.TabStop = false;
            groupBoxTask1_PAA.Text = "Дан файл InPutFileTask7V25.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в седьмом столбце элементы кратные 5 на 2.";
            // 
            // buttonSaveFile_PAA
            // 
            buttonSaveFile_PAA.Image = (System.Drawing.Image)resources.GetObject("buttonSaveFile_PAA.Image");
            buttonSaveFile_PAA.Location = new System.Drawing.Point(133, 9);
            buttonSaveFile_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonSaveFile_PAA.Name = "buttonSaveFile_PAA";
            buttonSaveFile_PAA.Size = new System.Drawing.Size(54, 44);
            buttonSaveFile_PAA.TabIndex = 3;
            buttonSaveFile_PAA.UseVisualStyleBackColor = true;
            buttonSaveFile_PAA.Click += buttonSaveFile_PAA_Click;
            // 
            // buttonHelp_PAA
            // 
            buttonHelp_PAA.Image = (System.Drawing.Image)resources.GetObject("buttonHelp_PAA.Image");
            buttonHelp_PAA.Location = new System.Drawing.Point(633, 9);
            buttonHelp_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonHelp_PAA.Name = "buttonHelp_PAA";
            buttonHelp_PAA.Size = new System.Drawing.Size(57, 44);
            buttonHelp_PAA.TabIndex = 2;
            toolTip_PAA.SetToolTip(buttonHelp_PAA, "Справка \r\nСведение о программисте");
            buttonHelp_PAA.UseVisualStyleBackColor = true;
            buttonHelp_PAA.Click += buttonHelp_PAA_Click;
            // 
            // buttonDone_PAA
            // 
            buttonDone_PAA.Enabled = false;
            buttonDone_PAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDone_PAA.Image = (System.Drawing.Image)resources.GetObject("buttonDone_PAA.Image");
            buttonDone_PAA.Location = new System.Drawing.Point(74, 9);
            buttonDone_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonDone_PAA.Name = "buttonDone_PAA";
            buttonDone_PAA.Size = new System.Drawing.Size(54, 44);
            buttonDone_PAA.TabIndex = 1;
            toolTip_PAA.SetToolTip(buttonDone_PAA, "Выполнить обработку файла");
            buttonDone_PAA.UseVisualStyleBackColor = true;
            buttonDone_PAA.Click += buttonDone_PAA_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip_PAA
            // 
            toolTip_PAA.IsBalloon = true;
            toolTip_PAA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_PAA.ToolTipTitle = "Подсказка";
            // 
            // panel2_PAA
            // 
            panel2_PAA.Controls.Add(groupBoxVvod_PAA);
            panel2_PAA.Dock = System.Windows.Forms.DockStyle.Left;
            panel2_PAA.Location = new System.Drawing.Point(0, 147);
            panel2_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2_PAA.Name = "panel2_PAA";
            panel2_PAA.Size = new System.Drawing.Size(338, 207);
            panel2_PAA.TabIndex = 2;
            // 
            // groupBoxVvod_PAA
            // 
            groupBoxVvod_PAA.Controls.Add(dataGridViewInMatrix_PAA);
            groupBoxVvod_PAA.Location = new System.Drawing.Point(10, 6);
            groupBoxVvod_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxVvod_PAA.Name = "groupBoxVvod_PAA";
            groupBoxVvod_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxVvod_PAA.Size = new System.Drawing.Size(325, 197);
            groupBoxVvod_PAA.TabIndex = 0;
            groupBoxVvod_PAA.TabStop = false;
            groupBoxVvod_PAA.Text = "Ввод";
            // 
            // dataGridViewInMatrix_PAA
            // 
            dataGridViewInMatrix_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_PAA.ColumnHeadersVisible = false;
            dataGridViewInMatrix_PAA.Location = new System.Drawing.Point(7, 18);
            dataGridViewInMatrix_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridViewInMatrix_PAA.Name = "dataGridViewInMatrix_PAA";
            dataGridViewInMatrix_PAA.RowHeadersVisible = false;
            dataGridViewInMatrix_PAA.RowHeadersWidth = 51;
            dataGridViewInMatrix_PAA.Size = new System.Drawing.Size(312, 174);
            dataGridViewInMatrix_PAA.TabIndex = 0;
            // 
            // panel3_PAA
            // 
            panel3_PAA.Controls.Add(groupBoxVyvod_PAA);
            panel3_PAA.Dock = System.Windows.Forms.DockStyle.Right;
            panel3_PAA.Location = new System.Drawing.Point(341, 147);
            panel3_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel3_PAA.Name = "panel3_PAA";
            panel3_PAA.Size = new System.Drawing.Size(359, 207);
            panel3_PAA.TabIndex = 3;
            // 
            // groupBoxVyvod_PAA
            // 
            groupBoxVyvod_PAA.Controls.Add(dataGridViewOutMatrix_PAA);
            groupBoxVyvod_PAA.Location = new System.Drawing.Point(4, 7);
            groupBoxVyvod_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxVyvod_PAA.Name = "groupBoxVyvod_PAA";
            groupBoxVyvod_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxVyvod_PAA.Size = new System.Drawing.Size(346, 196);
            groupBoxVyvod_PAA.TabIndex = 0;
            groupBoxVyvod_PAA.TabStop = false;
            groupBoxVyvod_PAA.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_PAA
            // 
            dataGridViewOutMatrix_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_PAA.ColumnHeadersVisible = false;
            dataGridViewOutMatrix_PAA.Location = new System.Drawing.Point(5, 17);
            dataGridViewOutMatrix_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridViewOutMatrix_PAA.Name = "dataGridViewOutMatrix_PAA";
            dataGridViewOutMatrix_PAA.RowHeadersVisible = false;
            dataGridViewOutMatrix_PAA.RowHeadersWidth = 51;
            dataGridViewOutMatrix_PAA.Size = new System.Drawing.Size(335, 172);
            dataGridViewOutMatrix_PAA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 354);
            Controls.Add(panel3_PAA);
            Controls.Add(panel2_PAA);
            Controls.Add(panel1_PAA);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Пыркин А. А.";
            Load += new System.EventHandler(FormMain_Load);
            panel1_PAA.ResumeLayout(false);
            groupBoxTask_PAA.ResumeLayout(false);
            panel2_PAA.ResumeLayout(false);
            groupBoxVvod_PAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_PAA).EndInit();
            panel3_PAA.ResumeLayout(false);
            groupBoxVyvod_PAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_PAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_PAA;
        private System.Windows.Forms.Panel panel1_PAA;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip_PAA;
        private System.Windows.Forms.Button buttonSaveFile_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.GroupBox groupBoxTask_PAA;
        private System.Windows.Forms.GroupBox groupBoxTask1_PAA;
        private System.Windows.Forms.Panel panel2_PAA;
        private System.Windows.Forms.GroupBox groupBoxVvod_PAA;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_PAA;
        private System.Windows.Forms.Panel panel3_PAA;
        private System.Windows.Forms.GroupBox groupBoxVyvod_PAA;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_PAA;
    }
}