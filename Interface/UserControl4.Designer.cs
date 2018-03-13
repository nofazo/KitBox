namespace Interface
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboLargeur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(799, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add locker";
            this.button1.UseVisualStyleBackColor = false;
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
            this.comboLargeur.Location = new System.Drawing.Point(296, 200);
            this.comboLargeur.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboLargeur.Name = "comboLargeur";
            this.comboLargeur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboLargeur.Size = new System.Drawing.Size(126, 33);
            this.comboLargeur.TabIndex = 13;
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interface.Properties.Resources.locker;
            this.Controls.Add(this.comboLargeur);
            this.Controls.Add(this.button1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(1052, 592);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLargeur;
    }
}
