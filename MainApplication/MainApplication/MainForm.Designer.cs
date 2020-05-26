namespace MainApplication
{
    partial class MainForm
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
            this.requiredTextBox1 = new CustomControls.RequiredTextBox();
            this.requiredTextBox2 = new CustomControls.RequiredTextBox();
            this.requiredTextBox3 = new CustomControls.RequiredTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requiredTextBox1
            // 
            this.requiredTextBox1.Location = new System.Drawing.Point(121, 28);
            this.requiredTextBox1.Name = "requiredTextBox1";
            this.requiredTextBox1.Required = true;
            this.requiredTextBox1.Size = new System.Drawing.Size(100, 20);
            this.requiredTextBox1.TabIndex = 0;
            // 
            // requiredTextBox2
            // 
            this.requiredTextBox2.Location = new System.Drawing.Point(121, 64);
            this.requiredTextBox2.Name = "requiredTextBox2";
            this.requiredTextBox2.Required = false;
            this.requiredTextBox2.Size = new System.Drawing.Size(100, 20);
            this.requiredTextBox2.TabIndex = 1;
            // 
            // requiredTextBox3
            // 
            this.requiredTextBox3.Location = new System.Drawing.Point(121, 104);
            this.requiredTextBox3.Name = "requiredTextBox3";
            this.requiredTextBox3.Required = true;
            this.requiredTextBox3.Size = new System.Drawing.Size(100, 20);
            this.requiredTextBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requiredTextBox3);
            this.Controls.Add(this.requiredTextBox2);
            this.Controls.Add(this.requiredTextBox1);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RequiredTextBox requiredTextBox1;
        private CustomControls.RequiredTextBox requiredTextBox2;
        private CustomControls.RequiredTextBox requiredTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

