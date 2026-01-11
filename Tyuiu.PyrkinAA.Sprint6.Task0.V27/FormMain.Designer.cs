using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.PyrkinAA.Sprint6.Task0.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxVariable_PAA = new System.Windows.Forms.TextBox();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.groupBoxInput_PAA = new System.Windows.Forms.GroupBox();
            this.labelVariable_PAA = new System.Windows.Forms.Label();
            this.groupBoxOutput_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PAA = new System.Windows.Forms.TextBox();
            this.labelResult_PAA = new System.Windows.Forms.Label();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_PAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_PAA = new System.Windows.Forms.Label();
            this.pictureBoxFormula_PAA = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_PAA.SuspendLayout();
            this.groupBoxOutput_PAA.SuspendLayout();
            this.groupBoxCondition_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PAA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVariable_PAA
            // 
            this.textBoxVariable_PAA.Location = new System.Drawing.Point(32, 62);
            this.textBoxVariable_PAA.Name = "textBoxVariable_PAA";
            this.textBoxVariable_PAA.Size = new System.Drawing.Size(89, 23);
            this.textBoxVariable_PAA.TabIndex = 2;
            this.textBoxVariable_PAA.Text = "4";
            // 
            // buttonDone_PAA
            // 
            this.buttonDone_PAA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_PAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PAA.Location = new System.Drawing.Point(667, 393);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(106, 32);
            this.buttonDone_PAA.TabIndex = 0;
            this.buttonDone_PAA.Text = "Выполнить";
            this.buttonDone_PAA.UseVisualStyleBackColor = false;
            this.buttonDone_PAA.Click += new System.EventHandler(this.buttonDone_PAA_Click);
            // 
            // groupBoxInput_PAA
            // 
            this.groupBoxInput_PAA.Controls.Add(this.labelVariable_PAA);
            this.groupBoxInput_PAA.Controls.Add(this.textBoxVariable_PAA);
            this.groupBoxInput_PAA.Location = new System.Drawing.Point(12, 291);
            this.groupBoxInput_PAA.Name = "groupBoxInput_PAA";
            this.groupBoxInput_PAA.Size = new System.Drawing.Size(583, 134);
            this.groupBoxInput_PAA.TabIndex = 3;
            this.groupBoxInput_PAA.TabStop = false;
            this.groupBoxInput_PAA.Text = "Ввод данных";
            // 
            // labelVariable_PAA
            // 
            this.labelVariable_PAA.AutoSize = true;
            this.labelVariable_PAA.Location = new System.Drawing.Point(32, 44);
            this.labelVariable_PAA.Name = "labelVariable_PAA";
            this.labelVariable_PAA.Size = new System.Drawing.Size(88, 15);
            this.labelVariable_PAA.TabIndex = 4;
            this.labelVariable_PAA.Text = "Переменная x:";
            // 
            // groupBoxOutput_PAA
            // 
            this.groupBoxOutput_PAA.Controls.Add(this.textBoxResult_PAA);
            this.groupBoxOutput_PAA.Controls.Add(this.labelResult_PAA);
            this.groupBoxOutput_PAA.Location = new System.Drawing.Point(601, 291);
            this.groupBoxOutput_PAA.Name = "groupBoxOutput_PAA";
            this.groupBoxOutput_PAA.Size = new System.Drawing.Size(187, 96);
            this.groupBoxOutput_PAA.TabIndex = 4;
            this.groupBoxOutput_PAA.TabStop = false;
            this.groupBoxOutput_PAA.Text = "Вывод данных";
            // 
            // textBoxResult_PAA
            // 
            this.textBoxResult_PAA.Location = new System.Drawing.Point(22, 51);
            this.textBoxResult_PAA.Name = "textBoxResult_PAA";
            this.textBoxResult_PAA.ReadOnly = true;
            this.textBoxResult_PAA.Size = new System.Drawing.Size(150, 23);
            this.textBoxResult_PAA.TabIndex = 5;
            // 
            // labelResult_PAA
            // 
            this.labelResult_PAA.AutoSize = true;
            this.labelResult_PAA.Location = new System.Drawing.Point(22, 33);
            this.labelResult_PAA.Name = "labelResult_PAA";
            this.labelResult_PAA.Size = new System.Drawing.Size(63, 15);
            this.labelResult_PAA.TabIndex = 5;
            this.labelResult_PAA.Text = "Результат:";
            // 
            // buttonHelp_PAA
            // 
            this.buttonHelp_PAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_PAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PAA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PAA.Location = new System.Drawing.Point(601, 393);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(60, 40);
            this.buttonHelp_PAA.TabIndex = 5;
            this.buttonHelp_PAA.Text = "?";
            this.buttonHelp_PAA.UseVisualStyleBackColor = false;
            this.buttonHelp_PAA.Click += new System.EventHandler(this.buttonHelp_PAA_Click);
            // 
            // groupBoxCondition_PAA
            // 
            this.groupBoxCondition_PAA.Controls.Add(this.labelCondition_PAA);
            this.groupBoxCondition_PAA.Controls.Add(this.pictureBoxFormula_PAA);
            this.groupBoxCondition_PAA.Location = new System.Drawing.Point(15, 23);
            this.groupBoxCondition_PAA.Name = "groupBoxCondition_PAA";
            this.groupBoxCondition_PAA.Size = new System.Drawing.Size(773, 251);
            this.groupBoxCondition_PAA.TabIndex = 6;
            this.groupBoxCondition_PAA.TabStop = false;
            this.groupBoxCondition_PAA.Text = "Условие";
            // 
            // labelCondition_PAA
            // 
            this.labelCondition_PAA.AutoSize = true;
            this.labelCondition_PAA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition_PAA.Location = new System.Drawing.Point(29, 32);
            this.labelCondition_PAA.Name = "labelCondition_PAA";
            this.labelCondition_PAA.Size = new System.Drawing.Size(500, 34);
            this.labelCondition_PAA.TabIndex = 7;
            this.labelCondition_PAA.Text = "Дано выражение F(x) = -x³ + 4x² - (3/2)x, вычислить его значение при x = 4.\r\nРезультат вывести в TextBox и округлить до трёх знаков после запятой.";
            // 
            // pictureBoxFormula_PAA
            // 
            this.pictureBoxFormula_PAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PAA.Image")));
            this.pictureBoxFormula_PAA.Location = new System.Drawing.Point(608, 32);
            this.pictureBoxFormula_PAA.Name = "pictureBoxFormula_PAA";
            this.pictureBoxFormula_PAA.Size = new System.Drawing.Size(108, 61);
            this.pictureBoxFormula_PAA.TabIndex = 0;
            this.pictureBoxFormula_PAA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCondition_PAA);
            this.Controls.Add(this.buttonHelp_PAA);
            this.Controls.Add(this.groupBoxOutput_PAA);
            this.Controls.Add(this.groupBoxInput_PAA);
            this.Controls.Add(this.buttonDone_PAA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 27 | Писарев М. А.";
            this.groupBoxInput_PAA.ResumeLayout(false);
            this.groupBoxInput_PAA.PerformLayout();
            this.groupBoxOutput_PAA.ResumeLayout(false);
            this.groupBoxOutput_PAA.PerformLayout();
            this.groupBoxCondition_PAA.ResumeLayout(false);
            this.groupBoxCondition_PAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.TextBox textBoxVariable_PAA;
        private System.Windows.Forms.GroupBox groupBoxInput_PAA;
        private System.Windows.Forms.Label labelVariable_PAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_PAA;
        private System.Windows.Forms.TextBox textBoxResult_PAA;
        private System.Windows.Forms.Label labelResult_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.GroupBox groupBoxCondition_PAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PAA;
        private System.Windows.Forms.Label labelCondition_PAA;
    }
}