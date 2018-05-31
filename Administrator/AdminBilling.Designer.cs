namespace WindowsFormsApp7
{
    partial class AdminBilling
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCmdID = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCmdID
            // 
            this.comboBoxCmdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxCmdID.FormattingEnabled = true;
            this.comboBoxCmdID.Location = new System.Drawing.Point(322, 122);
            this.comboBoxCmdID.Name = "comboBoxCmdID";
            this.comboBoxCmdID.Size = new System.Drawing.Size(212, 26);
            this.comboBoxCmdID.TabIndex = 0;
            this.comboBoxCmdID.SelectedIndexChanged += new System.EventHandler(this.comboBoxCmdID_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(24, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(234, 15);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Command reference :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get the bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Item List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxCmdID);
            this.Name = "AdminBilling";
            this.Size = new System.Drawing.Size(620, 582);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCmdID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
