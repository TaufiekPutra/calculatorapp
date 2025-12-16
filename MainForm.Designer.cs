namespace TestingForm
{
    partial class MainForm
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
            numberTextBox = new TextBox();
            labelNumber = new Label();
            submitButton = new Button();
            SuspendLayout();
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(99, 25);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(125, 27);
            numberTextBox.TabIndex = 0;
            numberTextBox.TextChanged += NumberTextBox_TextChanged;
            numberTextBox.KeyPress += NumberTextBox_KeyPress;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(13, 28);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(63, 20);
            labelNumber.TabIndex = 2;
            labelNumber.Text = "Number";
            labelNumber.Click += LabelNumber_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(247, 25);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(125, 29);
            submitButton.TabIndex = 3;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 76);
            Controls.Add(submitButton);
            Controls.Add(labelNumber);
            Controls.Add(numberTextBox);
            Name = "Form1";
            Text = "Test Number";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberTextBox;
        private Label labelNumber;
        private Button submitButton;
    }
}
