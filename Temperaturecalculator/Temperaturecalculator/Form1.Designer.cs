namespace Temperaturecalculator
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
            this.components = new System.ComponentModel.Container();
            this.buttonconvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonconvert2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonconvert
            // 
            this.buttonconvert.Location = new System.Drawing.Point(188, 19);
            this.buttonconvert.Name = "buttonconvert";
            this.buttonconvert.Size = new System.Drawing.Size(75, 23);
            this.buttonconvert.TabIndex = 0;
            this.buttonconvert.Text = "Convert";
            this.buttonconvert.UseVisualStyleBackColor = true;
            this.buttonconvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "C";
            // 
            // textBoxC
            // 
            this.textBoxC.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBoxC.AllowDrop = true;
            this.textBoxC.Location = new System.Drawing.Point(34, 19);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 23);
            this.textBoxC.TabIndex = 3;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(34, 53);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 23);
            this.textBoxF.TabIndex = 4;
            this.textBoxF.TextChanged += new System.EventHandler(this.textBoxF_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "F";
            // 
            // buttonconvert2
            // 
            this.buttonconvert2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonconvert2.Location = new System.Drawing.Point(188, 52);
            this.buttonconvert2.Name = "buttonconvert2";
            this.buttonconvert2.Size = new System.Drawing.Size(75, 23);
            this.buttonconvert2.TabIndex = 6;
            this.buttonconvert2.Text = "Convert";
            this.buttonconvert2.UseVisualStyleBackColor = true;
            this.buttonconvert2.Click += new System.EventHandler(this.buttonconvert2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 93);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonconvert2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonconvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonconvert;
        private Label label1;
        private TextBox textBoxC;
        private TextBox textBoxF;
        private Label label2;
        private ToolTip toolTip1;
        private Button buttonconvert2;
        private Button button1;
    }
}