namespace Lab_9
{
    partial class Form2
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(97, 65);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(86, 20);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "First Name";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(97, 118);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(86, 20);
            this.lastname_label.TabIndex = 3;
            this.lastname_label.Text = "Last Name";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(113, 172);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(38, 20);
            this.age_label.TabIndex = 4;
            this.age_label.Text = "Age";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(249, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(207, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // save_button
            // 
            this.save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_button.Location = new System.Drawing.Point(101, 259);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(146, 36);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(281, 259);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(175, 36);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}