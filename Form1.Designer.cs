
namespace ObfuscatorProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.renamer = new System.Windows.Forms.CheckBox();
            this.StringProtection = new System.Windows.Forms.CheckBox();
            this.StringProtect_2 = new System.Windows.Forms.CheckBox();
            this.Mutation = new System.Windows.Forms.CheckBox();
            this.protectbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "select file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // renamer
            // 
            this.renamer.AutoSize = true;
            this.renamer.Location = new System.Drawing.Point(44, 78);
            this.renamer.Name = "renamer";
            this.renamer.Size = new System.Drawing.Size(64, 17);
            this.renamer.TabIndex = 2;
            this.renamer.Text = "renamer";
            this.renamer.UseVisualStyleBackColor = true;
            // 
            // StringProtection
            // 
            this.StringProtection.AutoSize = true;
            this.StringProtection.Location = new System.Drawing.Point(44, 101);
            this.StringProtection.Name = "StringProtection";
            this.StringProtection.Size = new System.Drawing.Size(101, 17);
            this.StringProtection.TabIndex = 3;
            this.StringProtection.Text = "StringProtection";
            this.StringProtection.UseVisualStyleBackColor = true;
            // 
            // StringProtect_2
            // 
            this.StringProtect_2.AutoSize = true;
            this.StringProtect_2.Location = new System.Drawing.Point(44, 124);
            this.StringProtect_2.Name = "StringProtect_2";
            this.StringProtect_2.Size = new System.Drawing.Size(99, 17);
            this.StringProtect_2.TabIndex = 4;
            this.StringProtect_2.Text = "StringProtect_2";
            this.StringProtect_2.UseVisualStyleBackColor = true;
            // 
            // Mutation
            // 
            this.Mutation.AutoSize = true;
            this.Mutation.Location = new System.Drawing.Point(44, 147);
            this.Mutation.Name = "Mutation";
            this.Mutation.Size = new System.Drawing.Size(67, 17);
            this.Mutation.TabIndex = 5;
            this.Mutation.Text = "Mutation";
            this.Mutation.UseVisualStyleBackColor = true;
            // 
            // protectbtn
            // 
            this.protectbtn.Location = new System.Drawing.Point(609, 398);
            this.protectbtn.Name = "protectbtn";
            this.protectbtn.Size = new System.Drawing.Size(166, 50);
            this.protectbtn.TabIndex = 10;
            this.protectbtn.Text = "Protect";
            this.protectbtn.UseVisualStyleBackColor = true;
            this.protectbtn.Click += new System.EventHandler(this.protectbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(527, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password Hash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Salt Key";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(527, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "VI Key";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(527, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.protectbtn);
            this.Controls.Add(this.Mutation);
            this.Controls.Add(this.StringProtect_2);
            this.Controls.Add(this.StringProtection);
            this.Controls.Add(this.renamer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox renamer;
        private System.Windows.Forms.CheckBox StringProtection;
        private System.Windows.Forms.CheckBox StringProtect_2;
        private System.Windows.Forms.CheckBox Mutation;
        private System.Windows.Forms.Button protectbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

