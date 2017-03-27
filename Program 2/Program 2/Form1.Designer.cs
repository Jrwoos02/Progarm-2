namespace Program_2
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
            this.FreshmanRadio = new System.Windows.Forms.RadioButton();
            this.SophomoreRadio = new System.Windows.Forms.RadioButton();
            this.JuniorRadio = new System.Windows.Forms.RadioButton();
            this.SeniorRadio = new System.Windows.Forms.RadioButton();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FreshmanRadio
            // 
            this.FreshmanRadio.AutoSize = true;
            this.FreshmanRadio.Location = new System.Drawing.Point(268, 133);
            this.FreshmanRadio.Name = "FreshmanRadio";
            this.FreshmanRadio.Size = new System.Drawing.Size(106, 24);
            this.FreshmanRadio.TabIndex = 0;
            this.FreshmanRadio.TabStop = true;
            this.FreshmanRadio.Text = "Freshman";
            this.FreshmanRadio.UseVisualStyleBackColor = true;
            // 
            // SophomoreRadio
            // 
            this.SophomoreRadio.AutoSize = true;
            this.SophomoreRadio.Location = new System.Drawing.Point(268, 190);
            this.SophomoreRadio.Name = "SophomoreRadio";
            this.SophomoreRadio.Size = new System.Drawing.Size(117, 24);
            this.SophomoreRadio.TabIndex = 1;
            this.SophomoreRadio.TabStop = true;
            this.SophomoreRadio.Text = "Sophomore";
            this.SophomoreRadio.UseVisualStyleBackColor = true;
            // 
            // JuniorRadio
            // 
            this.JuniorRadio.AutoSize = true;
            this.JuniorRadio.Location = new System.Drawing.Point(268, 242);
            this.JuniorRadio.Name = "JuniorRadio";
            this.JuniorRadio.Size = new System.Drawing.Size(77, 24);
            this.JuniorRadio.TabIndex = 2;
            this.JuniorRadio.TabStop = true;
            this.JuniorRadio.Text = "Junior";
            this.JuniorRadio.UseVisualStyleBackColor = true;
            // 
            // SeniorRadio
            // 
            this.SeniorRadio.AutoSize = true;
            this.SeniorRadio.Location = new System.Drawing.Point(268, 298);
            this.SeniorRadio.Name = "SeniorRadio";
            this.SeniorRadio.Size = new System.Drawing.Size(80, 24);
            this.SeniorRadio.TabIndex = 3;
            this.SeniorRadio.TabStop = true;
            this.SeniorRadio.Text = "Senior";
            this.SeniorRadio.UseVisualStyleBackColor = true;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(264, 91);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(204, 20);
            this.GradeLabel.TabIndex = 4;
            this.GradeLabel.Text = "What is your current grade?";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(60, 91);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(184, 47);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "What is the first letter of your last name?";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(64, 187);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(145, 26);
            this.NameText.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(490, 290);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(94, 32);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(486, 133);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(281, 80);
            this.Output.TabIndex = 8;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(486, 91);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(147, 20);
            this.OutputLabel.TabIndex = 9;
            this.OutputLabel.Text = "You can register on";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 449);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.SeniorRadio);
            this.Controls.Add(this.JuniorRadio);
            this.Controls.Add(this.SophomoreRadio);
            this.Controls.Add(this.FreshmanRadio);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FreshmanRadio;
        private System.Windows.Forms.RadioButton SophomoreRadio;
        private System.Windows.Forms.RadioButton JuniorRadio;
        private System.Windows.Forms.RadioButton SeniorRadio;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label OutputLabel;
    }
}

