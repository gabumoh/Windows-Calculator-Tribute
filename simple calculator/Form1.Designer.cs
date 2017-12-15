namespace simple_calculator
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
            this.equation = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.bttnclearevery = new System.Windows.Forms.Button();
            this.bttnclear = new System.Windows.Forms.Button();
            this.bttnequal = new System.Windows.Forms.Button();
            this.bttndivide = new System.Windows.Forms.Button();
            this.bttnmultiply = new System.Windows.Forms.Button();
            this.bttnsubtract = new System.Windows.Forms.Button();
            this.bttndot = new System.Windows.Forms.Button();
            this.bttnadd = new System.Windows.Forms.Button();
            this.bttn0 = new System.Windows.Forms.Button();
            this.bttn3 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.bttn1 = new System.Windows.Forms.Button();
            this.bttn6 = new System.Windows.Forms.Button();
            this.bttn5 = new System.Windows.Forms.Button();
            this.bttn4 = new System.Windows.Forms.Button();
            this.bttn9 = new System.Windows.Forms.Button();
            this.bttn8 = new System.Windows.Forms.Button();
            this.bttn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(18, 16);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 20);
            this.equation.TabIndex = 39;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(16, 14);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(253, 31);
            this.result.TabIndex = 38;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bttnclearevery
            // 
            this.bttnclearevery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnclearevery.Location = new System.Drawing.Point(220, 51);
            this.bttnclearevery.Name = "bttnclearevery";
            this.bttnclearevery.Size = new System.Drawing.Size(45, 45);
            this.bttnclearevery.TabIndex = 37;
            this.bttnclearevery.Text = "CE";
            this.bttnclearevery.UseVisualStyleBackColor = true;
            // 
            // bttnclear
            // 
            this.bttnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnclear.Location = new System.Drawing.Point(220, 102);
            this.bttnclear.Name = "bttnclear";
            this.bttnclear.Size = new System.Drawing.Size(45, 45);
            this.bttnclear.TabIndex = 36;
            this.bttnclear.Text = "C";
            this.bttnclear.UseVisualStyleBackColor = true;
            // 
            // bttnequal
            // 
            this.bttnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnequal.Location = new System.Drawing.Point(220, 153);
            this.bttnequal.Name = "bttnequal";
            this.bttnequal.Size = new System.Drawing.Size(45, 96);
            this.bttnequal.TabIndex = 35;
            this.bttnequal.Text = "=";
            this.bttnequal.UseVisualStyleBackColor = true;
            this.bttnequal.Click += new System.EventHandler(this.bttnequal_Click);
            // 
            // bttndivide
            // 
            this.bttndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttndivide.Location = new System.Drawing.Point(169, 51);
            this.bttndivide.Name = "bttndivide";
            this.bttndivide.Size = new System.Drawing.Size(45, 45);
            this.bttndivide.TabIndex = 34;
            this.bttndivide.Text = "/";
            this.bttndivide.UseVisualStyleBackColor = true;
            this.bttndivide.Click += new System.EventHandler(this.operator_Click);
            // 
            // bttnmultiply
            // 
            this.bttnmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnmultiply.Location = new System.Drawing.Point(169, 102);
            this.bttnmultiply.Name = "bttnmultiply";
            this.bttnmultiply.Size = new System.Drawing.Size(45, 45);
            this.bttnmultiply.TabIndex = 33;
            this.bttnmultiply.Text = "*";
            this.bttnmultiply.UseVisualStyleBackColor = true;
            this.bttnmultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // bttnsubtract
            // 
            this.bttnsubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsubtract.Location = new System.Drawing.Point(169, 153);
            this.bttnsubtract.Name = "bttnsubtract";
            this.bttnsubtract.Size = new System.Drawing.Size(45, 45);
            this.bttnsubtract.TabIndex = 32;
            this.bttnsubtract.Text = "-";
            this.bttnsubtract.UseVisualStyleBackColor = true;
            this.bttnsubtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // bttndot
            // 
            this.bttndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttndot.Location = new System.Drawing.Point(118, 204);
            this.bttndot.Name = "bttndot";
            this.bttndot.Size = new System.Drawing.Size(45, 45);
            this.bttndot.TabIndex = 31;
            this.bttndot.Text = ".";
            this.bttndot.UseVisualStyleBackColor = true;
            // 
            // bttnadd
            // 
            this.bttnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnadd.Location = new System.Drawing.Point(169, 204);
            this.bttnadd.Name = "bttnadd";
            this.bttnadd.Size = new System.Drawing.Size(45, 45);
            this.bttnadd.TabIndex = 30;
            this.bttnadd.Text = "+";
            this.bttnadd.UseVisualStyleBackColor = true;
            this.bttnadd.Click += new System.EventHandler(this.operator_Click);
            // 
            // bttn0
            // 
            this.bttn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn0.Location = new System.Drawing.Point(17, 203);
            this.bttn0.Name = "bttn0";
            this.bttn0.Size = new System.Drawing.Size(96, 45);
            this.bttn0.TabIndex = 29;
            this.bttn0.Text = "0";
            this.bttn0.UseVisualStyleBackColor = true;
            this.bttn0.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn3
            // 
            this.bttn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn3.Location = new System.Drawing.Point(118, 153);
            this.bttn3.Name = "bttn3";
            this.bttn3.Size = new System.Drawing.Size(45, 45);
            this.bttn3.TabIndex = 28;
            this.bttn3.Text = "3";
            this.bttn3.UseVisualStyleBackColor = true;
            this.bttn3.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn2
            // 
            this.bttn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn2.Location = new System.Drawing.Point(67, 153);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(45, 45);
            this.bttn2.TabIndex = 27;
            this.bttn2.Text = "2";
            this.bttn2.UseVisualStyleBackColor = true;
            this.bttn2.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn1
            // 
            this.bttn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn1.Location = new System.Drawing.Point(16, 153);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(45, 45);
            this.bttn1.TabIndex = 26;
            this.bttn1.Text = "1";
            this.bttn1.UseVisualStyleBackColor = true;
            this.bttn1.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn6
            // 
            this.bttn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn6.Location = new System.Drawing.Point(118, 102);
            this.bttn6.Name = "bttn6";
            this.bttn6.Size = new System.Drawing.Size(45, 45);
            this.bttn6.TabIndex = 25;
            this.bttn6.Text = "6";
            this.bttn6.UseVisualStyleBackColor = true;
            this.bttn6.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn5
            // 
            this.bttn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn5.Location = new System.Drawing.Point(67, 102);
            this.bttn5.Name = "bttn5";
            this.bttn5.Size = new System.Drawing.Size(45, 45);
            this.bttn5.TabIndex = 24;
            this.bttn5.Text = "5";
            this.bttn5.UseVisualStyleBackColor = true;
            this.bttn5.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn4
            // 
            this.bttn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn4.Location = new System.Drawing.Point(16, 102);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(45, 45);
            this.bttn4.TabIndex = 23;
            this.bttn4.Text = "4";
            this.bttn4.UseVisualStyleBackColor = true;
            this.bttn4.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn9
            // 
            this.bttn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn9.Location = new System.Drawing.Point(118, 51);
            this.bttn9.Name = "bttn9";
            this.bttn9.Size = new System.Drawing.Size(45, 45);
            this.bttn9.TabIndex = 22;
            this.bttn9.Text = "9";
            this.bttn9.UseVisualStyleBackColor = true;
            this.bttn9.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn8
            // 
            this.bttn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn8.Location = new System.Drawing.Point(67, 51);
            this.bttn8.Name = "bttn8";
            this.bttn8.Size = new System.Drawing.Size(45, 45);
            this.bttn8.TabIndex = 21;
            this.bttn8.Text = "8";
            this.bttn8.UseVisualStyleBackColor = true;
            this.bttn8.Click += new System.EventHandler(this.digitclick);
            // 
            // bttn7
            // 
            this.bttn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn7.Location = new System.Drawing.Point(16, 51);
            this.bttn7.Name = "bttn7";
            this.bttn7.Size = new System.Drawing.Size(45, 45);
            this.bttn7.TabIndex = 20;
            this.bttn7.Text = "7";
            this.bttn7.UseVisualStyleBackColor = true;
            this.bttn7.Click += new System.EventHandler(this.digitclick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 261);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.bttnclearevery);
            this.Controls.Add(this.bttnclear);
            this.Controls.Add(this.bttnequal);
            this.Controls.Add(this.bttndivide);
            this.Controls.Add(this.bttnmultiply);
            this.Controls.Add(this.bttnsubtract);
            this.Controls.Add(this.bttndot);
            this.Controls.Add(this.bttnadd);
            this.Controls.Add(this.bttn0);
            this.Controls.Add(this.bttn3);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.bttn1);
            this.Controls.Add(this.bttn6);
            this.Controls.Add(this.bttn5);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.bttn9);
            this.Controls.Add(this.bttn8);
            this.Controls.Add(this.bttn7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button bttnclearevery;
        private System.Windows.Forms.Button bttnclear;
        private System.Windows.Forms.Button bttnequal;
        private System.Windows.Forms.Button bttndivide;
        private System.Windows.Forms.Button bttnmultiply;
        private System.Windows.Forms.Button bttnsubtract;
        private System.Windows.Forms.Button bttndot;
        private System.Windows.Forms.Button bttnadd;
        private System.Windows.Forms.Button bttn0;
        private System.Windows.Forms.Button bttn3;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.Button bttn6;
        private System.Windows.Forms.Button bttn5;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.Button bttn9;
        private System.Windows.Forms.Button bttn8;
        private System.Windows.Forms.Button bttn7;
    }
}

