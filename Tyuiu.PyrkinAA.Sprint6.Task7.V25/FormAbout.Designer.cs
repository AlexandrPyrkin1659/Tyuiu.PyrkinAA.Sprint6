namespace Tyuiu.PyrkinAA.Sprint6.Task7.V25
{
    partial class FormAboutSprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutSprint));
            groupBoxTask_PAA = new System.Windows.Forms.GroupBox();
            groupBoxGroup_PAA = new System.Windows.Forms.GroupBox();
            groupBoxC_PAA = new System.Windows.Forms.GroupBox();
            groupBoxTyuiu_PAA = new System.Windows.Forms.GroupBox();
            buttonOk_PAA = new System.Windows.Forms.Button();
            groupBoxTask_PAA.SuspendLayout();
            groupBoxGroup_PAA.SuspendLayout();
            groupBoxC_PAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_PAA
            // 
            groupBoxTask_PAA.Controls.Add(groupBoxGroup_PAA);
            groupBoxTask_PAA.Location = new System.Drawing.Point(10, 9);
            groupBoxTask_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTask_PAA.Name = "groupBoxTask_PAA";
            groupBoxTask_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTask_PAA.Size = new System.Drawing.Size(327, 112);
            groupBoxTask_PAA.TabIndex = 0;
            groupBoxTask_PAA.TabStop = false;
            groupBoxTask_PAA.Text = "Разработчик: Пыркин А. А.";
            // 
            // groupBoxGroup_PAA
            // 
            groupBoxGroup_PAA.Controls.Add(groupBoxC_PAA);
            groupBoxGroup_PAA.Location = new System.Drawing.Point(0, 20);
            groupBoxGroup_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxGroup_PAA.Name = "groupBoxGroup_PAA";
            groupBoxGroup_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxGroup_PAA.Size = new System.Drawing.Size(327, 92);
            groupBoxGroup_PAA.TabIndex = 0;
            groupBoxGroup_PAA.TabStop = false;
            groupBoxGroup_PAA.Text = "Группа: (укажите свою группу)";
            // 
            // groupBoxC_PAA
            // 
            groupBoxC_PAA.Controls.Add(groupBoxTyuiu_PAA);
            groupBoxC_PAA.Location = new System.Drawing.Point(0, 20);
            groupBoxC_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxC_PAA.Name = "groupBoxC_PAA";
            groupBoxC_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxC_PAA.Size = new System.Drawing.Size(327, 73);
            groupBoxC_PAA.TabIndex = 0;
            groupBoxC_PAA.TabStop = false;
            groupBoxC_PAA.Text = "Программа разработана в рамках изучения языка C# ";
            // 
            // groupBoxTyuiu_PAA
            // 
            groupBoxTyuiu_PAA.Location = new System.Drawing.Point(0, 34);
            groupBoxTyuiu_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTyuiu_PAA.Name = "groupBoxTyuiu_PAA";
            groupBoxTyuiu_PAA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxTyuiu_PAA.Size = new System.Drawing.Size(327, 38);
            groupBoxTyuiu_PAA.TabIndex = 0;
            groupBoxTyuiu_PAA.TabStop = false;
            groupBoxTyuiu_PAA.Text = "Тюменский индустриальный университет. Высшая школа цифровых технологий.";
            // 
            // buttonOk_PAA
            // 
            buttonOk_PAA.Location = new System.Drawing.Point(220, 130);
            buttonOk_PAA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonOk_PAA.Name = "buttonOk_PAA";
            buttonOk_PAA.Size = new System.Drawing.Size(107, 26);
            buttonOk_PAA.TabIndex = 1;
            buttonOk_PAA.Text = "ОК";
            buttonOk_PAA.UseVisualStyleBackColor = true;
            buttonOk_PAA.Click += buttonOk_Click;
            // 
            // FormAboutSprint
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(348, 164);
            Controls.Add(buttonOk_PAA);
            Controls.Add(groupBoxTask_PAA);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FormAboutSprint";
            Text = "О программе";
            Load += FormAboutSprint_Load;
            groupBoxTask_PAA.ResumeLayout(false);
            groupBoxGroup_PAA.ResumeLayout(false);
            groupBoxC_PAA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PAA;
        private System.Windows.Forms.GroupBox groupBoxGroup_PAA;
        private System.Windows.Forms.GroupBox groupBoxC_PAA;
        private System.Windows.Forms.GroupBox groupBoxTyuiu_PAA;
        private System.Windows.Forms.Button buttonOk_PAA;
    }
}