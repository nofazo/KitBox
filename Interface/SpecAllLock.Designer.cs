namespace Interface
{
    partial class SpecAllLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecAllLock));
            this.comboWidth = new System.Windows.Forms.ComboBox();
            this.comboDepth = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboWidth
            // 
            this.comboWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboWidth.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.comboWidth.Location = new System.Drawing.Point(511, 241);
            this.comboWidth.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboWidth.Name = "comboWidth";
            this.comboWidth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboWidth.Size = new System.Drawing.Size(161, 39);
            this.comboWidth.TabIndex = 13;
            this.comboWidth.SelectedIndexChanged += new System.EventHandler(this.comboWidth_SelectedIndexChanged);
            // 
            // comboDepth
            // 
            this.comboDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepth.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.comboDepth.Location = new System.Drawing.Point(511, 331);
            this.comboDepth.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboDepth.Name = "comboDepth";
            this.comboDepth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboDepth.Size = new System.Drawing.Size(161, 39);
            this.comboDepth.TabIndex = 14;
            this.comboDepth.SelectedIndexChanged += new System.EventHandler(this.comboDepth_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 90);
            this.button1.TabIndex = 15;
            this.button1.Text = "Choose Locker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(57, 477);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(394, 53);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Attention ! \r\nFor this width it\'s not possible to have a door.";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(57, 566);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 90);
            this.button2.TabIndex = 17;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpecAllLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboDepth);
            this.Controls.Add(this.comboWidth);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpecAllLock";
            this.Size = new System.Drawing.Size(1405, 729);
            this.Load += new System.EventHandler(this.SpecAllLock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWidth;
        private System.Windows.Forms.ComboBox comboDepth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}
