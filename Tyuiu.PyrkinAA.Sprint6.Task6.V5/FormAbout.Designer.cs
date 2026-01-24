namespace Tyuiu.PyrkinAA.Sprint6.Task6.V5
{
    partial class FormAboutSprint
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelUniversity = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.labelUniversity);
            this.groupBoxTask.Controls.Add(this.labelCourse);
            this.groupBoxTask.Controls.Add(this.labelGroup);
            this.groupBoxTask.Controls.Add(this.labelDeveloper);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(320, 130);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Информация о разработчике";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeveloper.Location = new System.Drawing.Point(15, 25);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(149, 15);
            this.labelDeveloper.TabIndex = 0;
            this.labelDeveloper.Text = "Разработчик: Пыркин А. А.";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.Location = new System.Drawing.Point(15, 45);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(120, 15);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Группа: АСОиУб-25-1";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCourse.Location = new System.Drawing.Point(15, 65);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(285, 15);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // labelUniversity
            // 
            this.labelUniversity.AutoSize = true;
            this.labelUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUniversity.Location = new System.Drawing.Point(15, 85);
            this.labelUniversity.Name = "labelUniversity";
            this.labelUniversity.Size = new System.Drawing.Size(290, 15);
            this.labelUniversity.TabIndex = 3;
            this.labelUniversity.Text = "Тюменский индустриальный университет. 2026 год.";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(257, 148);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAboutSprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 180);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutSprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelUniversity;
        private System.Windows.Forms.Button buttonOk;
    }
}