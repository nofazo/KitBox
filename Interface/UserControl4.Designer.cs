﻿namespace Interface
{
    partial class UserControl4
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl4));
            this.AddLocker = new System.Windows.Forms.Button();
            this.comboHeight = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Finish = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddLocker
            // 
            this.AddLocker.BackColor = System.Drawing.Color.Silver;
            this.AddLocker.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocker.ForeColor = System.Drawing.Color.Black;
            this.AddLocker.Location = new System.Drawing.Point(1065, 497);
            this.AddLocker.Margin = new System.Windows.Forms.Padding(4);
            this.AddLocker.Name = "AddLocker";
            this.AddLocker.Size = new System.Drawing.Size(333, 135);
            this.AddLocker.TabIndex = 0;
            this.AddLocker.Text = "Add locker";
            this.AddLocker.UseVisualStyleBackColor = false;
            this.AddLocker.Click += new System.EventHandler(this.AddLocker_Click);
            // 
            // comboHeight
            // 
            this.comboHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHeight.Items.AddRange(new object[] {
            "36",
            "46",
            "56",
            "72",
            "92",
            "108",
            "112",
            "138",
            "144",
            "168",
            "180",
            "184",
            "216",
            "224",
            "230",
            "252",
            "276",
            "280"});
            this.comboHeight.Location = new System.Drawing.Point(395, 246);
            this.comboHeight.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboHeight.Name = "comboHeight";
            this.comboHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboHeight.Size = new System.Drawing.Size(167, 39);
            this.comboHeight.TabIndex = 13;
            this.comboHeight.SelectedIndexChanged += new System.EventHandler(this.comboHeight_SelectedIndexChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBox.Items.AddRange(new object[] {
            "Brown",
            "White"});
            this.ColorBox.Location = new System.Drawing.Point(395, 319);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorBox.Size = new System.Drawing.Size(167, 39);
            this.ColorBox.TabIndex = 14;
            this.ColorBox.SelectedIndexChanged += new System.EventHandler(this.ColorBox_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(395, 396);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(477, 396);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yes";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.Silver;
            this.Finish.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish.ForeColor = System.Drawing.Color.Black;
            this.Finish.Location = new System.Drawing.Point(697, 497);
            this.Finish.Margin = new System.Windows.Forms.Padding(4);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(333, 135);
            this.Finish.TabIndex = 18;
            this.Finish.Text = "Next";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(885, 233);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(411, 150);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Interface.Properties.Resources.KITBOX_fond_basecorr;
            this.pictureBox1.Location = new System.Drawing.Point(85, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 59);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.comboHeight);
            this.Controls.Add(this.AddLocker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(1403, 729);
            this.Load += new System.EventHandler(this.UserControl4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLocker;
        private System.Windows.Forms.ComboBox comboHeight;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
