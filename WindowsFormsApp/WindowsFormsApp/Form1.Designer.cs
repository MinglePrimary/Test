namespace WindowsFormsApp
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
            this.RealLabel = new System.Windows.Forms.Label();
            this.ImaginaryLabel = new System.Windows.Forms.Label();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.ImaginaryTextBox = new System.Windows.Forms.TextBox();
            this.RealTextBox = new System.Windows.Forms.TextBox();
            this.NoticeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RealLabel
            // 
            this.RealLabel.AutoSize = true;
            this.RealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealLabel.Location = new System.Drawing.Point(140, 41);
            this.RealLabel.Name = "RealLabel";
            this.RealLabel.Size = new System.Drawing.Size(37, 16);
            this.RealLabel.TabIndex = 0;
            this.RealLabel.Text = "Real";
            // 
            // ImaginaryLabel
            // 
            this.ImaginaryLabel.AutoSize = true;
            this.ImaginaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImaginaryLabel.Location = new System.Drawing.Point(140, 93);
            this.ImaginaryLabel.Name = "ImaginaryLabel";
            this.ImaginaryLabel.Size = new System.Drawing.Size(67, 16);
            this.ImaginaryLabel.TabIndex = 1;
            this.ImaginaryLabel.Text = "Imaginary";
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(571, 34);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(103, 30);
            this.FirstButton.TabIndex = 2;
            this.FirstButton.Text = "set No 1";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(571, 86);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(103, 30);
            this.SecondButton.TabIndex = 3;
            this.SecondButton.Text = "set No 2";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(195, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 35);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(390, 216);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(98, 35);
            this.SubtractButton.TabIndex = 5;
            this.SubtractButton.Text = "SUB";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(571, 216);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(99, 35);
            this.MultiplyButton.TabIndex = 6;
            this.MultiplyButton.Text = "MUL";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // ImaginaryTextBox
            // 
            this.ImaginaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImaginaryTextBox.Location = new System.Drawing.Point(317, 86);
            this.ImaginaryTextBox.Name = "ImaginaryTextBox";
            this.ImaginaryTextBox.Size = new System.Drawing.Size(147, 22);
            this.ImaginaryTextBox.TabIndex = 7;
            // 
            // RealTextBox
            // 
            this.RealTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealTextBox.Location = new System.Drawing.Point(317, 34);
            this.RealTextBox.Name = "RealTextBox";
            this.RealTextBox.Size = new System.Drawing.Size(147, 22);
            this.RealTextBox.TabIndex = 8;
            // 
            // NoticeLabel
            // 
            this.NoticeLabel.AutoSize = true;
            this.NoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoticeLabel.Location = new System.Drawing.Point(143, 285);
            this.NoticeLabel.Name = "NoticeLabel";
            this.NoticeLabel.Size = new System.Drawing.Size(50, 16);
            this.NoticeLabel.TabIndex = 9;
            this.NoticeLabel.Text = "Notice:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 353);
            this.Controls.Add(this.NoticeLabel);
            this.Controls.Add(this.RealTextBox);
            this.Controls.Add(this.ImaginaryTextBox);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.ImaginaryLabel);
            this.Controls.Add(this.RealLabel);
            this.Name = "Form1";
            this.Text = "Complex Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RealLabel;
        private System.Windows.Forms.Label ImaginaryLabel;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.TextBox ImaginaryTextBox;
        private System.Windows.Forms.TextBox RealTextBox;
        private System.Windows.Forms.Label NoticeLabel;
    }
}

