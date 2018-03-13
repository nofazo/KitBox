namespace Interface
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboLargeur = new System.Windows.Forms.ComboBox();
            this.comboProfondeur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIT BOX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(20, 94);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1044, 98);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Largeur";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(17, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 29);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Profondeur";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.comboBox1.Location = new System.Drawing.Point(463, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "  - Choisir -";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.comboBox2.Location = new System.Drawing.Point(463, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = " - Choisir -";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboLargeur
            // 
            this.comboLargeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLargeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLargeur.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.comboLargeur.Location = new System.Drawing.Point(168, 225);
            this.comboLargeur.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboLargeur.Name = "comboLargeur";
            this.comboLargeur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboLargeur.Size = new System.Drawing.Size(126, 33);
            this.comboLargeur.TabIndex = 12;
            // 
            // comboProfondeur
            // 
            this.comboProfondeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfondeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProfondeur.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.comboProfondeur.Location = new System.Drawing.Point(168, 306);
            this.comboProfondeur.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboProfondeur.Name = "comboProfondeur";
            this.comboProfondeur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboProfondeur.Size = new System.Drawing.Size(126, 33);
            this.comboProfondeur.TabIndex = 13;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.comboProfondeur);
            this.Controls.Add(this.comboLargeur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1100, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLargeur;
        private System.Windows.Forms.ComboBox comboProfondeur;
    }
}
