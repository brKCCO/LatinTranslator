namespace LatinTranslator
{
    partial class latinTranslator
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
            this.translationLabel = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.centerButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.BackColor = System.Drawing.Color.Transparent;
            this.translationLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(137, 37);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(227, 21);
            this.translationLabel.TabIndex = 0;
            this.translationLabel.Text = "Click a word to see it in English!";
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leftButton.Location = new System.Drawing.Point(81, 83);
            this.leftButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 22);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Sinister";
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rightButton.Location = new System.Drawing.Point(210, 83);
            this.rightButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 22);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Dexter";
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // centerButton
            // 
            this.centerButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.centerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.centerButton.Location = new System.Drawing.Point(345, 83);
            this.centerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(75, 22);
            this.centerButton.TabIndex = 3;
            this.centerButton.Text = "Medium";
            this.centerButton.UseVisualStyleBackColor = false;
            this.centerButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(217, 139);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(0, 13);
            this.textLabel.TabIndex = 4;
            // 
            // latinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 216);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.centerButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.translationLabel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "latinTranslator";
            this.Text = "Latin Translator";
            this.Load += new System.EventHandler(this.latinTranslator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Label textLabel;
    }
}

