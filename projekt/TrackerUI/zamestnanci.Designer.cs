
namespace TrackerUI
{
    partial class zamestnanci
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputJmeno = new System.Windows.Forms.TextBox();
            this.inputPrijmeni = new System.Windows.Forms.TextBox();
            this.InputVEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.inputUvazek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vytvoreni zamestnance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jmeno";
            // 
            // inputJmeno
            // 
            this.inputJmeno.Location = new System.Drawing.Point(21, 36);
            this.inputJmeno.Name = "inputJmeno";
            this.inputJmeno.Size = new System.Drawing.Size(100, 23);
            this.inputJmeno.TabIndex = 2;
            this.inputJmeno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputPrijmeni
            // 
            this.inputPrijmeni.Location = new System.Drawing.Point(21, 65);
            this.inputPrijmeni.Name = "inputPrijmeni";
            this.inputPrijmeni.Size = new System.Drawing.Size(100, 23);
            this.inputPrijmeni.TabIndex = 3;
            this.inputPrijmeni.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // InputVEmail
            // 
            this.InputVEmail.Location = new System.Drawing.Point(21, 94);
            this.InputVEmail.Name = "InputVEmail";
            this.InputVEmail.Size = new System.Drawing.Size(100, 23);
            this.InputVEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "prijmeni";
            // 
            // inputSEmail
            // 
            this.inputSEmail.Location = new System.Drawing.Point(21, 123);
            this.inputSEmail.Name = "inputSEmail";
            this.inputSEmail.Size = new System.Drawing.Size(100, 23);
            this.inputSEmail.TabIndex = 6;
            this.inputSEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Verejny email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "soukromi email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "doktorant";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // inputUvazek
            // 
            this.inputUvazek.Location = new System.Drawing.Point(21, 177);
            this.inputUvazek.Name = "inputUvazek";
            this.inputUvazek.Size = new System.Drawing.Size(100, 23);
            this.inputUvazek.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Uvazek";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(21, 206);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Vytvorit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zamestnanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputUvazek);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputSEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputVEmail);
            this.Controls.Add(this.inputPrijmeni);
            this.Controls.Add(this.inputJmeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "zamestnanci";
            this.Text = "t";
            this.Load += new System.EventHandler(this.zamestnanci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputJmeno;
        private System.Windows.Forms.TextBox inputPrijmeni;
        private System.Windows.Forms.TextBox InputVEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputSEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox inputUvazek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
    }
}