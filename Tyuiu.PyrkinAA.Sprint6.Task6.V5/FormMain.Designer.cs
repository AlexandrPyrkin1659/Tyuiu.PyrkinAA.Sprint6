using System.Windows.Forms;

namespace Tyuiu.PyrkinAA.Sprint6.Task6.V5
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutFile = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            this.groupBoxOutPutFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBox1);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 70);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(1032, 100);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1020, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дан файл InPutFileTask6V5.txt который может находится в любом месте на диске. Заг" +
    "рузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречаетс" +
    "я l в результирующею строку и вывести ее в textBoxOut.";
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.textBoxLoadFromFile);
            this.groupBoxValue.Location = new System.Drawing.Point(12, 180);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(450, 300);
            this.groupBoxValue.TabIndex = 1;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Ввод данных";
            // 
            // textBoxLoadFromFile
            // 
            this.textBoxLoadFromFile.Location = new System.Drawing.Point(6, 19);
            this.textBoxLoadFromFile.Multiline = true;
            this.textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            this.textBoxLoadFromFile.ReadOnly = true;
            this.textBoxLoadFromFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile.Size = new System.Drawing.Size(438, 275);
            this.textBoxLoadFromFile.TabIndex = 0;
            // 
            // groupBoxOutPutFile
            // 
            this.groupBoxOutPutFile.Controls.Add(this.textBoxResult);
            this.groupBoxOutPutFile.Location = new System.Drawing.Point(470, 180);
            this.groupBoxOutPutFile.Name = "groupBoxOutPutFile";
            this.groupBoxOutPutFile.Size = new System.Drawing.Size(574, 300);
            this.groupBoxOutPutFile.TabIndex = 2;
            this.groupBoxOutPutFile.TabStop = false;
            this.groupBoxOutPutFile.Text = "Вывод (слова с буквой \'l\')";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(562, 275);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(12, 12);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(60, 50);
            this.buttonFile.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonFile, "Выберите файл для обработки");
            this.buttonFile.Text = "Файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(78, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(60, 50);
            this.buttonOK.TabIndex = 4;
            this.toolTip.SetToolTip(this.buttonOK, "Найти слова с буквой \'l\' в файле");
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(984, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(60, 50);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            this.openFileDialogTask.Title = "Выберите файл InPutFileTask6V5.txt";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 492);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.groupBoxOutPutFile);
            this.Controls.Add(this.groupBoxValue);
            this.Controls.Add(this.groupBoxTask);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 5 | Пыркин А. А.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxValue.ResumeLayout(false);
            this.groupBoxValue.PerformLayout();
            this.groupBoxOutPutFile.ResumeLayout(false);
            this.groupBoxOutPutFile.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxValue;
        private System.Windows.Forms.TextBox textBoxLoadFromFile;
        private System.Windows.Forms.GroupBox groupBoxOutPutFile;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
    }
}