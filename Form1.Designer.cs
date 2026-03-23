namespace HMD
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Input_Bit = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Detected_Human_Bit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 359);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(737, 27);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(143, 22);
            this.Count.TabIndex = 1;
            // 
            // Input_Bit
            // 
            this.Input_Bit.Location = new System.Drawing.Point(737, 159);
            this.Input_Bit.Name = "Input_Bit";
            this.Input_Bit.Size = new System.Drawing.Size(143, 22);
            this.Input_Bit.TabIndex = 2;
         //   this.Input_Bit.TextChanged += new System.EventHandler(this.Input_Bit_TextChanged_1);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(737, 227);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(143, 22);
            this.Input.TabIndex = 3;
            // 
            // Detected_Human_Bit
            // 
            this.Detected_Human_Bit.Location = new System.Drawing.Point(737, 289);
            this.Detected_Human_Bit.Name = "Detected_Human_Bit";
            this.Detected_Human_Bit.Size = new System.Drawing.Size(143, 22);
            this.Detected_Human_Bit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Detected_Human_Bit);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Input_Bit);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Input_Bit;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Detected_Human_Bit;
        private System.Windows.Forms.Label label1;
    }
}

