namespace Donutliciousss
{
    partial class Form5
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
            this.Order = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.MistyRose;
            this.Order.Font = new System.Drawing.Font("DEATHE MAACH NCV", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.FormattingEnabled = true;
            this.Order.ItemHeight = 22;
            this.Order.Location = new System.Drawing.Point(68, 59);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(402, 466);
            this.Order.TabIndex = 0;
            this.Order.SelectedIndexChanged += new System.EventHandler(this.DONUTLICIOUS_SelectedIndexChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("DEATHE MAACH NCV", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(555, 92);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(182, 74);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "order list";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("DEATHE MAACH NCV", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(555, 203);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(182, 74);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "total";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("DEATHE MAACH NCV", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(555, 313);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(182, 74);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Change";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("DEATHE MAACH NCV", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(555, 533);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(182, 74);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Done";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("DEATHE MAACH NCV", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(555, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 564);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 44);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 637);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 44);
            this.textBox2.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(807, 732);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Order);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        public System.Windows.Forms.ListBox Order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}