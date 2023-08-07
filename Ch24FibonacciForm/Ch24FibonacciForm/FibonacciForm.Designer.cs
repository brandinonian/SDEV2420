namespace Ch24FibonacciForm {
    partial class FibonacciForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Title = new Label();
            RecursiveTextBox = new TextBox();
            TextBoxLabel = new Label();
            RecursiveBtn = new Button();
            RecursiveResult = new Label();
            RecursiveResultLabel = new Label();
            TimeResultLabel = new Label();
            TimeResult = new Label();
            IterativeBtn = new Button();
            IterativeBtnLabel = new Label();
            IterativeResult = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(317, 38);
            Title.TabIndex = 0;
            Title.Text = "Calculate Synchronously";
            // 
            // RecursiveTextBox
            // 
            RecursiveTextBox.Location = new Point(289, 65);
            RecursiveTextBox.Name = "RecursiveTextBox";
            RecursiveTextBox.Size = new Size(125, 27);
            RecursiveTextBox.TabIndex = 1;
            // 
            // TextBoxLabel
            // 
            TextBoxLabel.AutoSize = true;
            TextBoxLabel.Location = new Point(12, 68);
            TextBoxLabel.Name = "TextBoxLabel";
            TextBoxLabel.Size = new Size(244, 20);
            TextBoxLabel.TabIndex = 2;
            TextBoxLabel.Text = "Enter number of Fibonacci numbers";
            // 
            // RecursiveBtn
            // 
            RecursiveBtn.Location = new Point(289, 98);
            RecursiveBtn.Name = "RecursiveBtn";
            RecursiveBtn.Size = new Size(125, 55);
            RecursiveBtn.TabIndex = 3;
            RecursiveBtn.Text = "Calculate Recursively";
            RecursiveBtn.UseVisualStyleBackColor = true;
            RecursiveBtn.Click += RecursiveBtn_Click;
            // 
            // RecursiveResult
            // 
            RecursiveResult.AutoSize = true;
            RecursiveResult.Location = new Point(289, 192);
            RecursiveResult.Name = "RecursiveResult";
            RecursiveResult.Size = new Size(30, 20);
            RecursiveResult.TabIndex = 4;
            RecursiveResult.Text = "NA";
            // 
            // RecursiveResultLabel
            // 
            RecursiveResultLabel.AutoSize = true;
            RecursiveResultLabel.Location = new Point(113, 192);
            RecursiveResultLabel.Name = "RecursiveResultLabel";
            RecursiveResultLabel.Size = new Size(143, 20);
            RecursiveResultLabel.TabIndex = 5;
            RecursiveResultLabel.Text = "Result of calculation";
            // 
            // TimeResultLabel
            // 
            TimeResultLabel.AutoSize = true;
            TimeResultLabel.Location = new Point(214, 238);
            TimeResultLabel.Name = "TimeResultLabel";
            TimeResultLabel.Size = new Size(42, 20);
            TimeResultLabel.TabIndex = 7;
            TimeResultLabel.Text = "Time";
            // 
            // TimeResult
            // 
            TimeResult.AutoSize = true;
            TimeResult.Location = new Point(289, 238);
            TimeResult.Name = "TimeResult";
            TimeResult.Size = new Size(30, 20);
            TimeResult.TabIndex = 6;
            TimeResult.Text = "NA";
            // 
            // IterativeBtn
            // 
            IterativeBtn.Location = new Point(289, 293);
            IterativeBtn.Name = "IterativeBtn";
            IterativeBtn.Size = new Size(125, 55);
            IterativeBtn.TabIndex = 8;
            IterativeBtn.Text = "Calculate Iteratively";
            IterativeBtn.UseVisualStyleBackColor = true;
            IterativeBtn.Click += IterativeBtn_Click;
            // 
            // IterativeBtnLabel
            // 
            IterativeBtnLabel.AutoSize = true;
            IterativeBtnLabel.Location = new Point(111, 293);
            IterativeBtnLabel.Name = "IterativeBtnLabel";
            IterativeBtnLabel.Size = new Size(145, 20);
            IterativeBtnLabel.TabIndex = 9;
            IterativeBtnLabel.Text = "Display next number";
            // 
            // IterativeResult
            // 
            IterativeResult.AutoSize = true;
            IterativeResult.Location = new Point(113, 328);
            IterativeResult.Name = "IterativeResult";
            IterativeResult.Size = new Size(30, 20);
            IterativeResult.TabIndex = 10;
            IterativeResult.Text = Program.GetResult().ToString();
            // 
            // FibonacciForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(IterativeResult);
            Controls.Add(IterativeBtnLabel);
            Controls.Add(IterativeBtn);
            Controls.Add(TimeResultLabel);
            Controls.Add(TimeResult);
            Controls.Add(RecursiveResultLabel);
            Controls.Add(RecursiveResult);
            Controls.Add(RecursiveBtn);
            Controls.Add(TextBoxLabel);
            Controls.Add(RecursiveTextBox);
            Controls.Add(Title);
            Name = "FibonacciForm";
            Text = "Fibonacci Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox RecursiveTextBox;
        private Label TextBoxLabel;
        private Button RecursiveBtn;
        private Label RecursiveResult;
        private Label RecursiveResultLabel;
        private Label TimeResultLabel;
        private Label TimeResult;
        private Button IterativeBtn;
        private Label IterativeBtnLabel;
        private Label IterativeResult;
    }
}