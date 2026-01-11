using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.PyrkinAA.Sprint6.Task1.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_PAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_PAA = new System.Windows.Forms.Label();
            this.groupBoxInput_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_PAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_PAA = new System.Windows.Forms.TextBox();
            this.labelStart_PAA = new System.Windows.Forms.Label();
            this.labelEnd_PAA = new System.Windows.Forms.Label();
            this.labelResult_PAA = new System.Windows.Forms.Label();
            this.groupBoxOutput_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PAA = new System.Windows.Forms.TextBox();
            this.buttonInfo_PAA = new System.Windows.Forms.Button();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_PAA.SuspendLayout();
            this.groupBoxInput_PAA.SuspendLayout();
            this.groupBoxOutput_PAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PAA
            // 
            this.groupBoxCondition_PAA.Controls.Add(this.labelCondition_PAA);
            this.groupBoxCondition_PAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_PAA.Name = "groupBoxCondition_PAA";
            this.groupBoxCondition_PAA.Size = new System.Drawing.Size(522, 324);
            this.groupBoxCondition_PAA.TabIndex = 0;
            this.groupBoxCondition_PAA.TabStop = false;
            this.groupBoxCondition_PAA.Text = "Условие";
            // 
            // labelCondition_PAA
            // 
            this.labelCondition_PAA.AutoSize = true;
            this.labelCondition_PAA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition_PAA.Location = new System.Drawing.Point(17, 25);
            this.labelCondition_PAA.Name = "labelCondition_PAA";
            this.labelCondition_PAA.Size = new System.Drawing.Size(492, 51);
            this.labelCondition_PAA.TabIndex = 4;
            this.labelCondition_PAA.Text = "Протабулировать функцию:\r\nF(x) = cos(x)/(x-0.4) + sin(x) * 8x + 2\r\nна диапазоне [-5; 5] с шагом 1. При делении на ноль вернуть 0.";
            // 
            // groupBoxInput_PAA
            // 
            this.groupBoxInput_PAA.Controls.Add(this.textBoxStart_PAA);
            this.groupBoxInput_PAA.Controls.Add(this.textBoxStop_PAA);
            this.groupBoxInput_PAA.Controls.Add(this.labelStart_PAA);
            this.groupBoxInput_PAA.Controls.Add(this.labelEnd_PAA);
            this.groupBoxInput_PAA.Location = new System.Drawing.Point(12, 352);
            this.groupBoxInput_PAA.Name = "groupBoxInput_PAA";
            this.groupBoxInput_PAA.Size = new System.Drawing.Size(253, 83);
            this.groupBoxInput_PAA.TabIndex = 1;
            this.groupBoxInput_PAA.TabStop = false;
            this.groupBoxInput_PAA.Text = "Ввод данных";
            // 
            // textBoxStart_PAA
            // 
            this.textBoxStart_PAA.Location = new System.Drawing.Point(17, 37);
            this.textBoxStart_PAA.Name = "textBoxStart_PAA";
            this.textBoxStart_PAA.Size = new System.Drawing.Size(100, 23);
            this.textBoxStart_PAA.TabIndex = 6;
            this.textBoxStart_PAA.Text = "-5";
            // 
            // textBoxStop_PAA
            // 
            this.textBoxStop_PAA.Location = new System.Drawing.Point(138, 37);
            this.textBoxStop_PAA.Name = "textBoxStop_PAA";
            this.textBoxStop_PAA.Size = new System.Drawing.Size(100, 23);
            this.textBoxStop_PAA.TabIndex = 7;
            this.textBoxStop_PAA.Text = "5";
            // 
            // labelStart_PAA
            // 
            this.labelStart_PAA.AutoSize = true;
            this.labelStart_PAA.Location = new System.Drawing.Point(28, 19);
            this.labelStart_PAA.Name = "labelStart_PAA";
            this.labelStart_PAA.Size = new System.Drawing.Size(72, 15);
            this.labelStart_PAA.TabIndex = 2;
            this.labelStart_PAA.Text = "Старт шага:";
            // 
            // labelEnd_PAA
            // 
            this.labelEnd_PAA.AutoSize = true;
            this.labelEnd_PAA.Location = new System.Drawing.Point(153, 19);
            this.labelEnd_PAA.Name = "labelEnd_PAA";
            this.labelEnd_PAA.Size = new System.Drawing.Size(75, 15);
            this.labelEnd_PAA.TabIndex = 3;
            this.labelEnd_PAA.Text = "Конец шага:";
            // 
            // labelResult_PAA
            // 
            this.labelResult_PAA.AutoSize = true;
            this.labelResult_PAA.Location = new System.Drawing.Point(6, 19);
            this.labelResult_PAA.Name = "labelResult_PAA";
            this.labelResult_PAA.Size = new System.Drawing.Size(63, 15);
            this.labelResult_PAA.TabIndex = 5;
            this.labelResult_PAA.Text = "Результат:";
            // 
            // groupBoxOutput_PAA
            // 
            this.groupBoxOutput_PAA.Controls.Add(this.textBoxResult_PAA);
            this.groupBoxOutput_PAA.Controls.Add(this.labelResult_PAA);
            this.groupBoxOutput_PAA.Location = new System.Drawing.Point(540, 21);
            this.groupBoxOutput_PAA.Name = "groupBoxOutput_PAA";
            this.groupBoxOutput_PAA.Size = new System.Drawing.Size(248, 414);
            this.groupBoxOutput_PAA.TabIndex = 8;
            this.groupBoxOutput_PAA.TabStop = false;
            this.groupBoxOutput_PAA.Text = "Вывод данных";
            // 
            // textBoxResult_PAA
            // 
            this.textBoxResult_PAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_PAA.Location = new System.Drawing.Point(6, 43);
            this.textBoxResult_PAA.Multiline = true;
            this.textBoxResult_PAA.Name = "textBoxResult_PAA";
            this.textBoxResult_PAA.ReadOnly = true;
            this.textBoxResult_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PAA.Size = new System.Drawing.Size(236, 365);
            this.textBoxResult_PAA.TabIndex = 11;
            // 
            // buttonInfo_PAA
            // 
            this.buttonInfo_PAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_PAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_PAA.Location = new System.Drawing.Point(271, 361);
            this.buttonInfo_PAA.Name = "buttonInfo_PAA";
            this.buttonInfo_PAA.Size = new System.Drawing.Size(97, 74);
            this.buttonInfo_PAA.TabIndex = 9;
            this.buttonInfo_PAA.Text = "Справка";
            this.buttonInfo_PAA.UseVisualStyleBackColor = false;
            this.buttonInfo_PAA.Click += new System.EventHandler(this.buttonInfo_PAA_Click);
            // 
            // buttonDone_PAA
            // 
            this.buttonDone_PAA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_PAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PAA.Location = new System.Drawing.Point(383, 361);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(151, 74);
            this.buttonDone_PAA.TabIndex = 10;
            this.buttonDone_PAA.Text = "Выполнить";
            this.buttonDone_PAA.UseVisualStyleBackColor = false;
            this.buttonDone_PAA.Click += new System.EventHandler(this.buttonDone_PAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_PAA);
            this.Controls.Add(this.buttonInfo_PAA);
            this.Controls.Add(this.groupBoxOutput_PAA);
            this.Controls.Add(this.groupBoxInput_PAA);
            this.Controls.Add(this.groupBoxCondition_PAA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 8 | Писарев М. А.";
            this.groupBoxCondition_PAA.ResumeLayout(false);
            this.groupBoxCondition_PAA.PerformLayout();
            this.groupBoxInput_PAA.ResumeLayout(false);
            this.groupBoxInput_PAA.PerformLayout();
            this.groupBoxOutput_PAA.ResumeLayout(false);
            this.groupBoxOutput_PAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PAA;
        private System.Windows.Forms.Label labelCondition_PAA;
        private System.Windows.Forms.GroupBox groupBoxInput_PAA;
        private System.Windows.Forms.TextBox textBoxStart_PAA;
        private System.Windows.Forms.TextBox textBoxStop_PAA;
        private System.Windows.Forms.Label labelStart_PAA;
        private System.Windows.Forms.Label labelEnd_PAA;
        private System.Windows.Forms.Label labelResult_PAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_PAA;
        private System.Windows.Forms.Button buttonInfo_PAA;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.TextBox textBoxResult_PAA;
    }
}