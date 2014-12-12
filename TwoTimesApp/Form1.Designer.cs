namespace TwoTimesApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.twoTimesValueTextBox = new System.Windows.Forms.TextBox();
            this.twoTimesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Two times Value";
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(145, 41);
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.aNumberTextBox.TabIndex = 2;
            // 
            // twoTimesValueTextBox
            // 
            this.twoTimesValueTextBox.Location = new System.Drawing.Point(145, 86);
            this.twoTimesValueTextBox.Name = "twoTimesValueTextBox";
            this.twoTimesValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.twoTimesValueTextBox.TabIndex = 3;
            // 
            // twoTimesButton
            // 
            this.twoTimesButton.Location = new System.Drawing.Point(109, 150);
            this.twoTimesButton.Name = "twoTimesButton";
            this.twoTimesButton.Size = new System.Drawing.Size(124, 23);
            this.twoTimesButton.TabIndex = 4;
            this.twoTimesButton.Text = "Show Two Times";
            this.twoTimesButton.UseVisualStyleBackColor = true;
            this.twoTimesButton.Click += new System.EventHandler(this.twoTimesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.twoTimesButton);
            this.Controls.Add(this.twoTimesValueTextBox);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.TextBox twoTimesValueTextBox;
        private System.Windows.Forms.Button twoTimesButton;
    }
}

