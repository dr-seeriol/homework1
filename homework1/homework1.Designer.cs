namespace homework1
{
    partial class homework1
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
            firstLabel = new Label();
            lastLabel = new Label();
            hourLable = new Label();
            summary = new Button();
            clearButton = new Button();
            firstBox = new TextBox();
            lastBox = new TextBox();
            hourBox = new TextBox();
            superLabel = new Label();
            SuspendLayout();
            // 
            // firstLabel
            // 
            firstLabel.AutoSize = true;
            firstLabel.Location = new Point(91, 56);
            firstLabel.Name = "firstLabel";
            firstLabel.Size = new Size(80, 20);
            firstLabel.TabIndex = 0;
            firstLabel.Text = "&First Name";
            firstLabel.Click += firstLabel_Click;
            // 
            // lastLabel
            // 
            lastLabel.AutoSize = true;
            lastLabel.Location = new Point(325, 56);
            lastLabel.Name = "lastLabel";
            lastLabel.Size = new Size(79, 20);
            lastLabel.TabIndex = 1;
            lastLabel.Text = "&Last Name";
            lastLabel.UseWaitCursor = true;
            lastLabel.Click += label1_Click;
            // 
            // hourLable
            // 
            hourLable.AutoSize = true;
            hourLable.Location = new Point(571, 56);
            hourLable.Name = "hourLable";
            hourLable.Size = new Size(103, 20);
            hourLable.TabIndex = 4;
            hourLable.Text = "&Hours Worked";
            // 
            // summary
            // 
            summary.Location = new Point(77, 195);
            summary.Name = "summary";
            summary.Size = new Size(94, 29);
            summary.TabIndex = 3;
            summary.Text = "&Summary";
            summary.UseVisualStyleBackColor = true;
            summary.Click += summary_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(224, 195);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 4;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // firstBox
            // 
            firstBox.Location = new Point(77, 103);
            firstBox.Name = "firstBox";
            firstBox.Size = new Size(125, 27);
            firstBox.TabIndex = 1;
            firstBox.TextChanged += firstBox_TextChanged;
            // 
            // lastBox
            // 
            lastBox.Location = new Point(304, 103);
            lastBox.Name = "lastBox";
            lastBox.Size = new Size(125, 27);
            lastBox.TabIndex = 2;
            lastBox.TextChanged += lastBox_TextChanged;
            // 
            // hourBox
            // 
            hourBox.Location = new Point(561, 103);
            hourBox.Name = "hourBox";
            hourBox.Size = new Size(125, 27);
            hourBox.TabIndex = 5;
            hourBox.TextChanged += hourBox_TextChanged;
            // 
            // superLabel
            // 
            superLabel.BorderStyle = BorderStyle.FixedSingle;
            superLabel.Location = new Point(77, 255);
            superLabel.Name = "superLabel";
            superLabel.Size = new Size(611, 150);
            superLabel.TabIndex = 8;
            superLabel.TextAlign = ContentAlignment.MiddleCenter;
            superLabel.Click += superLabel_Click;
            // 
            // homework1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(superLabel);
            Controls.Add(hourBox);
            Controls.Add(lastBox);
            Controls.Add(firstBox);
            Controls.Add(clearButton);
            Controls.Add(summary);
            Controls.Add(hourLable);
            Controls.Add(lastLabel);
            Controls.Add(firstLabel);
            Name = "homework1";
            Text = "assignment1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstLabel;
        private Label lastLabel;
        private Label hourLable;
        private Button summary;
        private Button clearButton;
        private TextBox firstBox;
        private TextBox lastBox;
        private TextBox hourBox;
        private Label superLabel;
    }
}
