namespace Interface
{
    partial class UserControl3
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
            this.comboLargeur = new System.Windows.Forms.ComboBox();
            this.comboProfondeur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.comboLargeur.Location = new System.Drawing.Point(511, 241);
            this.comboLargeur.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboLargeur.Name = "comboLargeur";
            this.comboLargeur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboLargeur.Size = new System.Drawing.Size(161, 39);
            this.comboLargeur.TabIndex = 13;
            this.comboLargeur.SelectedIndexChanged += new System.EventHandler(this.comboLargeur_SelectedIndexChanged);
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
            this.comboProfondeur.Location = new System.Drawing.Point(511, 331);
            this.comboProfondeur.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboProfondeur.Name = "comboProfondeur";
            this.comboProfondeur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboProfondeur.Size = new System.Drawing.Size(161, 39);
            this.comboProfondeur.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 90);
            this.button1.TabIndex = 15;
            this.button1.Text = "Choose Locker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interface.Properties.Resources._long;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboProfondeur);
            this.Controls.Add(this.comboLargeur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1405, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboLargeur;
        private System.Windows.Forms.ComboBox comboProfondeur;
        private System.Windows.Forms.Button button1;
    }
}
