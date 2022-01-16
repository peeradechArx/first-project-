namespace CGPACalculator
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
            this.GPA_input = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GPAX = new System.Windows.Forms.Label();
            this.textBox1GPA_input = new System.Windows.Forms.TextBox();
            this.textBoxGPAX = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMAX = new System.Windows.Forms.TextBox();
            this.MAXgpa = new System.Windows.Forms.Label();
            this.textBoxMIN = new System.Windows.Forms.TextBox();
            this.MINgpa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GPA_input
            // 
            this.GPA_input.AutoSize = true;
            this.GPA_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GPA_input.Location = new System.Drawing.Point(30, 44);
            this.GPA_input.Name = "GPA_input";
            this.GPA_input.Size = new System.Drawing.Size(118, 25);
            this.GPA_input.TabIndex = 1;
            this.GPA_input.Text = "GPA INPUT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(329, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GPAX
            // 
            this.GPAX.AutoSize = true;
            this.GPAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GPAX.Location = new System.Drawing.Point(30, 130);
            this.GPAX.Name = "GPAX";
            this.GPAX.Size = new System.Drawing.Size(68, 25);
            this.GPAX.TabIndex = 4;
            this.GPAX.Text = "GPAX";
            // 
            // textBox1GPA_input
            // 
            this.textBox1GPA_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1GPA_input.Location = new System.Drawing.Point(165, 38);
            this.textBox1GPA_input.Name = "textBox1GPA_input";
            this.textBox1GPA_input.Size = new System.Drawing.Size(133, 45);
            this.textBox1GPA_input.TabIndex = 5;
            // 
            // textBoxGPAX
            // 
            this.textBoxGPAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxGPAX.Location = new System.Drawing.Point(144, 119);
            this.textBoxGPAX.Name = "textBoxGPAX";
            this.textBoxGPAX.Size = new System.Drawing.Size(133, 45);
            this.textBoxGPAX.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(302, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMAX
            // 
            this.textBoxMAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxMAX.Location = new System.Drawing.Point(144, 170);
            this.textBoxMAX.Name = "textBoxMAX";
            this.textBoxMAX.Size = new System.Drawing.Size(133, 45);
            this.textBoxMAX.TabIndex = 9;
            // 
            // MAXgpa
            // 
            this.MAXgpa.AutoSize = true;
            this.MAXgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MAXgpa.Location = new System.Drawing.Point(34, 184);
            this.MAXgpa.Name = "MAXgpa";
            this.MAXgpa.Size = new System.Drawing.Size(104, 25);
            this.MAXgpa.TabIndex = 8;
            this.MAXgpa.Text = "MAX GPA";
            // 
            // textBoxMIN
            // 
            this.textBoxMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxMIN.Location = new System.Drawing.Point(144, 221);
            this.textBoxMIN.Name = "textBoxMIN";
            this.textBoxMIN.Size = new System.Drawing.Size(133, 45);
            this.textBoxMIN.TabIndex = 11;
            // 
            // MINgpa
            // 
            this.MINgpa.AutoSize = true;
            this.MINgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MINgpa.Location = new System.Drawing.Point(34, 235);
            this.MINgpa.Name = "MINgpa";
            this.MINgpa.Size = new System.Drawing.Size(95, 25);
            this.MINgpa.TabIndex = 10;
            this.MINgpa.Text = "MIN GPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 329);
            this.Controls.Add(this.textBoxMIN);
            this.Controls.Add(this.MINgpa);
            this.Controls.Add(this.textBoxMAX);
            this.Controls.Add(this.MAXgpa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxGPAX);
            this.Controls.Add(this.textBox1GPA_input);
            this.Controls.Add(this.GPAX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GPA_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GPA_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GPAX;
        private System.Windows.Forms.TextBox textBox1GPA_input;
        private System.Windows.Forms.TextBox textBoxGPAX;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxMAX;
        private System.Windows.Forms.Label MAXgpa;
        private System.Windows.Forms.TextBox textBoxMIN;
        private System.Windows.Forms.Label MINgpa;
    }
}

