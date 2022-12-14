namespace RC4
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
            this.cipher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(68, 66);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(126, 40);
            this.cipher.TabIndex = 0;
            this.cipher.Text = "Сделать";
            this.cipher.UseVisualStyleBackColor = true;
            this.cipher.Click += new System.EventHandler(this.cipher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 57);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(200, 23);
            this.input.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Key);
            this.groupBox2.Controls.Add(this.cipher);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(6, 30);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(188, 23);
            this.Key.TabIndex = 5;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 130);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(200, 23);
            this.output.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вывод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RC4";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

        private Button cipher;
        private Label label1;
        private TextBox input;
        private GroupBox groupBox2;
        private TextBox Key;
        private TextBox output;
        private Label label2;
    }
}