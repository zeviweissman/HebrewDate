namespace HebrewDate
{
    partial class Form1
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
            DaysCMBX = new ComboBox();
            DayMonthsCMBX = new ComboBox();
            MonthsCMBX = new ComboBox();
            YearsCMBX = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LogResults = new TextBox();
            GetHebrewDateBTN = new Button();
            SuspendLayout();
            // 
            // DaysCMBX
            // 
            DaysCMBX.FormattingEnabled = true;
            DaysCMBX.Location = new Point(316, 84);
            DaysCMBX.Name = "DaysCMBX";
            DaysCMBX.Size = new Size(71, 23);
            DaysCMBX.TabIndex = 0;
            // 
            // DayMonthsCMBX
            // 
            DayMonthsCMBX.FormattingEnabled = true;
            DayMonthsCMBX.Location = new Point(217, 84);
            DayMonthsCMBX.Name = "DayMonthsCMBX";
            DayMonthsCMBX.Size = new Size(71, 23);
            DayMonthsCMBX.TabIndex = 1;
            // 
            // MonthsCMBX
            // 
            MonthsCMBX.FormattingEnabled = true;
            MonthsCMBX.Location = new Point(118, 84);
            MonthsCMBX.Name = "MonthsCMBX";
            MonthsCMBX.Size = new Size(71, 23);
            MonthsCMBX.TabIndex = 2;
            // 
            // YearsCMBX
            // 
            YearsCMBX.FormattingEnabled = true;
            YearsCMBX.Location = new Point(24, 84);
            YearsCMBX.Name = "YearsCMBX";
            YearsCMBX.Size = new Size(71, 23);
            YearsCMBX.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 50);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "יום";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 50);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "היום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 50);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 50);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "שנה";
            // 
            // LogResults
            // 
            LogResults.Location = new Point(46, 167);
            LogResults.Multiline = true;
            LogResults.Name = "LogResults";
            LogResults.ReadOnly = true;
            LogResults.Size = new Size(341, 263);
            LogResults.TabIndex = 8;
            // 
            // GetHebrewDateBTN
            // 
            GetHebrewDateBTN.Location = new Point(146, 478);
            GetHebrewDateBTN.Name = "GetHebrewDateBTN";
            GetHebrewDateBTN.Size = new Size(115, 26);
            GetHebrewDateBTN.TabIndex = 9;
            GetHebrewDateBTN.Text = "בדוק תאריך";
            GetHebrewDateBTN.UseVisualStyleBackColor = true;
            GetHebrewDateBTN.Click += GetHebrewDateBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 621);
            Controls.Add(GetHebrewDateBTN);
            Controls.Add(LogResults);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(YearsCMBX);
            Controls.Add(MonthsCMBX);
            Controls.Add(DayMonthsCMBX);
            Controls.Add(DaysCMBX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DaysCMBX;
        private ComboBox DayMonthsCMBX;
        private ComboBox MonthsCMBX;
        private ComboBox YearsCMBX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox LogResults;
        private Button GetHebrewDateBTN;
    }
}
