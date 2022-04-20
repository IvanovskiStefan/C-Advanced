namespace SEDC.Oop.C_Advanced.Class08.App
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
            this.myFirstLabel = new System.Windows.Forms.Label();
            this.clickcounterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myFirstLabel
            // 
            this.myFirstLabel.AutoSize = true;
            this.myFirstLabel.Location = new System.Drawing.Point(27, 9);
            this.myFirstLabel.Name = "myFirstLabel";
            this.myFirstLabel.Size = new System.Drawing.Size(38, 15);
            this.myFirstLabel.TabIndex = 0;
            this.myFirstLabel.Text = "label1";
            // 
            // clickcounterButton
            // 
            this.clickcounterButton.Location = new System.Drawing.Point(27, 27);
            this.clickcounterButton.Name = "clickcounterButton";
            this.clickcounterButton.Size = new System.Drawing.Size(75, 23);
            this.clickcounterButton.TabIndex = 1;
            this.clickcounterButton.Text = "click me :D";
            this.clickcounterButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 594);
            this.Controls.Add(this.clickcounterButton);
            this.Controls.Add(this.myFirstLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label myFirstLabel;
        private Button clickcounterButton;
    }
}