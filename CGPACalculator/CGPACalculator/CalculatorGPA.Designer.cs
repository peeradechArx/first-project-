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
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxGPAMAX = new System.Windows.Forms.TextBox();
            this.MAXgpa = new System.Windows.Forms.Label();
            this.textBoxGPAMIN = new System.Windows.Forms.TextBox();
            this.MINgpa = new System.Windows.Forms.Label();
            this.textBoxGPAX = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.textBoxminName = new System.Windows.Forms.TextBox();
            this.textBoxGPAname_input = new System.Windows.Forms.TextBox();
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GPA_input
            // 
            this.GPA_input.AutoSize = true;
            this.GPA_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GPA_input.Location = new System.Drawing.Point(30, 20);
            this.GPA_input.Name = "GPA_input";
            this.GPA_input.Size = new System.Drawing.Size(118, 25);
            this.GPA_input.TabIndex = 1;
            this.GPA_input.Text = "GPA INPUT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(441, 23);
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
            this.GPAX.Location = new System.Drawing.Point(52, 81);
            this.GPAX.Name = "GPAX";
            this.GPAX.Size = new System.Drawing.Size(68, 25);
            this.GPAX.TabIndex = 4;
            this.GPAX.Text = "GPAX";
            // 
            // textBox1GPA_input
            // 
            this.textBox1GPA_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1GPA_input.Location = new System.Drawing.Point(283, 12);
            this.textBox1GPA_input.Name = "textBox1GPA_input";
            this.textBox1GPA_input.Size = new System.Drawing.Size(133, 45);
            this.textBox1GPA_input.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(441, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxGPAMAX
            // 
            this.textBoxGPAMAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxGPAMAX.Location = new System.Drawing.Point(283, 128);
            this.textBoxGPAMAX.Name = "textBoxGPAMAX";
            this.textBoxGPAMAX.Size = new System.Drawing.Size(133, 45);
            this.textBoxGPAMAX.TabIndex = 9;
            // 
            // MAXgpa
            // 
            this.MAXgpa.AutoSize = true;
            this.MAXgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MAXgpa.Location = new System.Drawing.Point(44, 142);
            this.MAXgpa.Name = "MAXgpa";
            this.MAXgpa.Size = new System.Drawing.Size(104, 25);
            this.MAXgpa.TabIndex = 8;
            this.MAXgpa.Text = "MAX GPA";
            // 
            // textBoxGPAMIN
            // 
            this.textBoxGPAMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxGPAMIN.Location = new System.Drawing.Point(283, 179);
            this.textBoxGPAMIN.Name = "textBoxGPAMIN";
            this.textBoxGPAMIN.Size = new System.Drawing.Size(133, 45);
            this.textBoxGPAMIN.TabIndex = 11;
            // 
            // MINgpa
            // 
            this.MINgpa.AutoSize = true;
            this.MINgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MINgpa.Location = new System.Drawing.Point(44, 193);
            this.MINgpa.Name = "MINgpa";
            this.MINgpa.Size = new System.Drawing.Size(95, 25);
            this.MINgpa.TabIndex = 10;
            this.MINgpa.Text = "MIN GPA";
            // 
            // textBoxGPAX
            // 
            this.textBoxGPAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxGPAX.Location = new System.Drawing.Point(283, 81);
            this.textBoxGPAX.Name = "textBoxGPAX";
            this.textBoxGPAX.Size = new System.Drawing.Size(133, 45);
            this.textBoxGPAX.TabIndex = 12;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxMaxName.Location = new System.Drawing.Point(149, 128);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(133, 45);
            this.textBoxMaxName.TabIndex = 13;
            // 
            // textBoxminName
            // 
            this.textBoxminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxminName.Location = new System.Drawing.Point(149, 179);
            this.textBoxminName.Name = "textBoxminName";
            this.textBoxminName.Size = new System.Drawing.Size(133, 45);
            this.textBoxminName.TabIndex = 14;
            // 
            // textBoxGPAname_input
            // 
            this.textBoxGPAname_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxGPAname_input.Location = new System.Drawing.Point(149, 12);
            this.textBoxGPAname_input.Name = "textBoxGPAname_input";
            this.textBoxGPAname_input.Size = new System.Drawing.Size(133, 45);
            this.textBoxGPAname_input.TabIndex = 15;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxAllData.Location = new System.Drawing.Point(35, 239);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.Size = new System.Drawing.Size(561, 138);
            this.textBoxAllData.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 389);
            this.Controls.Add(this.textBoxAllData);
            this.Controls.Add(this.textBoxGPAname_input);
            this.Controls.Add(this.textBoxminName);
            this.Controls.Add(this.textBoxMaxName);
            this.Controls.Add(this.textBoxGPAX);
            this.Controls.Add(this.textBoxGPAMIN);
            this.Controls.Add(this.MINgpa);
            this.Controls.Add(this.textBoxGPAMAX);
            this.Controls.Add(this.MAXgpa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1GPA_input);
            this.Controls.Add(this.GPAX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GPA_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GPA_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GPAX;
        private System.Windows.Forms.TextBox textBox1GPA_input;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxGPAMAX;
        private System.Windows.Forms.Label MAXgpa;
        private System.Windows.Forms.TextBox textBoxGPAMIN;
        private System.Windows.Forms.Label MINgpa;
        private System.Windows.Forms.TextBox textBoxGPAX;
        private System.Windows.Forms.TextBox textBoxMaxName;
        private System.Windows.Forms.TextBox textBoxminName;
        private System.Windows.Forms.TextBox textBoxGPAname_input;
        private System.Windows.Forms.TextBox textBoxAllData;
    }
}

