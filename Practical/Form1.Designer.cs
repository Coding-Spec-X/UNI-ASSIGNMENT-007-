namespace Practical
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
            this.buttonDrawPhone = new System.Windows.Forms.Button();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.drawBallsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ballAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawPhone
            // 
            this.buttonDrawPhone.Location = new System.Drawing.Point(16, 14);
            this.buttonDrawPhone.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDrawPhone.Name = "buttonDrawPhone";
            this.buttonDrawPhone.Size = new System.Drawing.Size(149, 37);
            this.buttonDrawPhone.TabIndex = 3;
            this.buttonDrawPhone.Text = "Draw Phone";
            this.buttonDrawPhone.UseVisualStyleBackColor = true;
            this.buttonDrawPhone.Click += new System.EventHandler(this.buttonDrawPhone_Click);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(285, 14);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(533, 898);
            this.pictureBoxDisplay.TabIndex = 2;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // drawBallsButton
            // 
            this.drawBallsButton.Location = new System.Drawing.Point(16, 137);
            this.drawBallsButton.Name = "drawBallsButton";
            this.drawBallsButton.Size = new System.Drawing.Size(149, 39);
            this.drawBallsButton.TabIndex = 4;
            this.drawBallsButton.Text = "Draw Balls";
            this.drawBallsButton.UseVisualStyleBackColor = true;
            this.drawBallsButton.Click += new System.EventHandler(this.drawBallsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(16, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 39);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(16, 182);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(149, 39);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ballAmountTextBox
            // 
            this.ballAmountTextBox.Location = new System.Drawing.Point(16, 109);
            this.ballAmountTextBox.Name = "ballAmountTextBox";
            this.ballAmountTextBox.Size = new System.Drawing.Size(149, 22);
            this.ballAmountTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number balls in a row:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 924);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballAmountTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.drawBallsButton);
            this.Controls.Add(this.buttonDrawPhone);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawPhone;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button drawBallsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox ballAmountTextBox;
        private System.Windows.Forms.Label label1;
    }
}

