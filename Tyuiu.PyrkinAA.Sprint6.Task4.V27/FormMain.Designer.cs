using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.PyrkinAA.Sprint6.Task4.V27
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
            textBoxResult_PAA = new TextBox();
            groupBoxCondition_PAA = new GroupBox();
            labelCondition_PAA = new Label();
            groupBoxInput_PAA = new GroupBox();
            labelStart_PAA = new Label();
            labelStop_PAA = new Label();
            textBoxStart_PAA = new TextBox();
            textBoxStop_PAA = new TextBox();
            labelOutput_PAA = new Label();
            buttonDone_PAA = new Button();
            buttonSave_PAA = new Button();
            buttonHelp_PAA = new Button();
            groupBoxCondition_PAA.SuspendLayout();
            groupBoxInput_PAA.SuspendLayout();
            SuspendLayout();

            // textBoxResult_PAA
            textBoxResult_PAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult_PAA.Location = new Point(12, 104);
            textBoxResult_PAA.Multiline = true;
            textBoxResult_PAA.Name = "textBoxResult_PAA";
            textBoxResult_PAA.ReadOnly = true;
            textBoxResult_PAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PAA.Size = new Size(350, 346);
            textBoxResult_PAA.TabIndex = 0;
            textBoxResult_PAA.TextChanged += textBoxResult_PAA_TextChanged;

            // groupBoxCondition_PAA
            groupBoxCondition_PAA.Controls.Add(labelCondition_PAA);
            groupBoxCondition_PAA.Location = new Point(12, 12);
            groupBoxCondition_PAA.Name = "groupBoxCondition_PAA";
            groupBoxCondition_PAA.Size = new Size(350, 86);
            groupBoxCondition_PAA.TabIndex = 1;
            groupBoxCondition_PAA.TabStop = false;
            groupBoxCondition_PAA.Text = "Условие";

            // labelCondition_PAA
            labelCondition_PAA.AutoSize = true;
            labelCondition_PAA.Location = new Point(6, 19);
            labelCondition_PAA.Name = "labelCondition_PAA";
            labelCondition_PAA.Size = new Size(313, 45);
            labelCondition_PAA.TabIndex = 2;
            labelCondition_PAA.Text = "F(x) = cos(x)/(x+1) - cos(x)*1.3 + 3x\r\nТабулировать на диапазоне [-5; 5] с шагом 1.\r\nПри делении на ноль вернуть 0.\r\nОкруглить до двух знаков.";
            labelCondition_PAA.Click += labelCondition_PAA_Click;

            // groupBoxInput_PAA
            groupBoxInput_PAA.Controls.Add(labelStart_PAA);
            groupBoxInput_PAA.Controls.Add(labelStop_PAA);
            groupBoxInput_PAA.Controls.Add(textBoxStart_PAA);
            groupBoxInput_PAA.Controls.Add(textBoxStop_PAA);
            groupBoxInput_PAA.Location = new Point(368, 12);
            groupBoxInput_PAA.Name = "groupBoxInput_PAA";
            groupBoxInput_PAA.Size = new Size(289, 86);
            groupBoxInput_PAA.TabIndex = 0;
            groupBoxInput_PAA.TabStop = false;
            groupBoxInput_PAA.Text = "Ввод данных";

            // labelStart_PAA
            labelStart_PAA.AutoSize = true;
            labelStart_PAA.Location = new Point(38, 28);
            labelStart_PAA.Name = "labelStart_PAA";
            labelStart_PAA.Size = new Size(72, 15);
            labelStart_PAA.TabIndex = 7;
            labelStart_PAA.Text = "Старт шага:";

            // labelStop_PAA
            labelStop_PAA.AutoSize = true;
            labelStop_PAA.Location = new Point(173, 28);
            labelStop_PAA.Name = "labelStop_PAA";
            labelStop_PAA.Size = new Size(75, 15);
            labelStop_PAA.TabIndex = 8;
            labelStop_PAA.Text = "Конец шага:";

            // textBoxStart_PAA
            textBoxStart_PAA.Location = new Point(25, 46);
            textBoxStart_PAA.Name = "textBoxStart_PAA";
            textBoxStart_PAA.Size = new Size(100, 23);
            textBoxStart_PAA.TabIndex = 2;

            // textBoxStop_PAA
            textBoxStop_PAA.Location = new Point(161, 46);
            textBoxStop_PAA.Name = "textBoxStop_PAA";
            textBoxStop_PAA.Size = new Size(100, 23);
            textBoxStop_PAA.TabIndex = 3;

            // labelOutput_PAA
            labelOutput_PAA.AutoSize = true;
            labelOutput_PAA.Location = new Point(12, 86);
            labelOutput_PAA.Name = "labelOutput_PAA";
            labelOutput_PAA.Size = new Size(86, 15);
            labelOutput_PAA.TabIndex = 2;
            labelOutput_PAA.Text = "Вывод данных";

            // buttonDone_PAA
            buttonDone_PAA.BackColor = Color.Green;
            buttonDone_PAA.Cursor = Cursors.Hand;
            buttonDone_PAA.Location = new Point(663, 104);
            buttonDone_PAA.Name = "buttonDone_PAA";
            buttonDone_PAA.Size = new Size(97, 68);
            buttonDone_PAA.TabIndex = 4;
            buttonDone_PAA.Text = "Выполнить";
            buttonDone_PAA.UseVisualStyleBackColor = false;
            buttonDone_PAA.Click += buttonDone_PAA_Click;

            // buttonSave_PAA
            buttonSave_PAA.BackColor = Color.RoyalBlue;
            buttonSave_PAA.Cursor = Cursors.Hand;
            buttonSave_PAA.Location = new Point(663, 178);
            buttonSave_PAA.Name = "buttonSave_PAA";
            buttonSave_PAA.Size = new Size(97, 68);
            buttonSave_PAA.TabIndex = 5;
            buttonSave_PAA.Text = "Сохранить";
            buttonSave_PAA.UseVisualStyleBackColor = false;
            buttonSave_PAA.Click += buttonSave_PAA_Click;

            // buttonHelp_PAA
            buttonHelp_PAA.BackColor = Color.CornflowerBlue;
            buttonHelp_PAA.Cursor = Cursors.Hand;
            buttonHelp_PAA.Location = new Point(663, 252);
            buttonHelp_PAA.Name = "buttonHelp_PAA";
            buttonHelp_PAA.Size = new Size(97, 68);
            buttonHelp_PAA.TabIndex = 6;
            buttonHelp_PAA.Text = "Справка";
            buttonHelp_PAA.UseVisualStyleBackColor = false;
            buttonHelp_PAA.Click += buttonHelp_PAA_Click;

            // FormMain
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 462);
            Controls.Add(buttonHelp_PAA);
            Controls.Add(buttonSave_PAA);
            Controls.Add(buttonDone_PAA);
            Controls.Add(labelOutput_PAA);
            Controls.Add(groupBoxInput_PAA);
            Controls.Add(groupBoxCondition_PAA);
            Controls.Add(textBoxResult_PAA);
            MinimumSize = new Size(788, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 27 | Пыркин А. А.";
            Load += FormMain_Load;
            groupBoxCondition_PAA.ResumeLayout(false);
            groupBoxCondition_PAA.PerformLayout();
            groupBoxInput_PAA.ResumeLayout(false);
            groupBoxInput_PAA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_PAA;
        private GroupBox groupBoxCondition_PAA;
        private Label labelCondition_PAA;
        private GroupBox groupBoxInput_PAA;
        private TextBox textBoxStart_PAA;
        private TextBox textBoxStop_PAA;
        private Label labelOutput_PAA;
        private Label labelStart_PAA;
        private Label labelStop_PAA;
        private Button buttonDone_PAA;
        private Button buttonSave_PAA;
        private Button buttonHelp_PAA;
    }
}