namespace Interface
{
    partial class Extrusions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extrusions));
            this.extrusionColor = new System.Windows.Forms.ComboBox();
            this.Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extrusionColor
            // 
            this.extrusionColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extrusionColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrusionColor.Items.AddRange(new object[] {
            "White",
            "Brown",
            "Black"});
            this.extrusionColor.Location = new System.Drawing.Point(540, 143);
            this.extrusionColor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.extrusionColor.Name = "extrusionColor";
            this.extrusionColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.extrusionColor.Size = new System.Drawing.Size(126, 33);
            this.extrusionColor.TabIndex = 14;
            this.extrusionColor.SelectedIndexChanged += new System.EventHandler(this.extrusionColor_SelectedIndexChanged);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.Silver;
            this.Finish.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish.ForeColor = System.Drawing.Color.Black;
            this.Finish.Location = new System.Drawing.Point(845, 421);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(175, 80);
            this.Finish.TabIndex = 19;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // UserControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.extrusionColor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl6";
            this.Size = new System.Drawing.Size(1052, 592);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox extrusionColor;
        private System.Windows.Forms.Button Finish;
    }
}
