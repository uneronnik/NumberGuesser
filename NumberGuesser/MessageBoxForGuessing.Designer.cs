
namespace NumberGuesser
{
    partial class MessageBoxForGuessing
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
            this.lowerButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.upperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(46, 144);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(150, 70);
            this.lowerButton.TabIndex = 1;
            this.lowerButton.Text = "Меньше";
            this.lowerButton.UseVisualStyleBackColor = true;
            this.lowerButton.Click += new System.EventHandler(this.lowerButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(240, 144);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 70);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Правильно";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // upperButton
            // 
            this.upperButton.Location = new System.Drawing.Point(434, 144);
            this.upperButton.Name = "upperButton";
            this.upperButton.Size = new System.Drawing.Size(150, 70);
            this.upperButton.TabIndex = 3;
            this.upperButton.Text = "Больше";
            this.upperButton.UseVisualStyleBackColor = true;
            this.upperButton.Click += new System.EventHandler(this.upperButton_Click);
            // 
            // MessageBoxForGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 244);
            this.Controls.Add(this.upperButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.label1);
            this.Name = "MessageBoxForGuess";
            this.Text = "MessageBoxForGuess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lowerButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button upperButton;
    }
}