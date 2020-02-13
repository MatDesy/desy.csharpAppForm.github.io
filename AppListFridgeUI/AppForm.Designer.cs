namespace AppListFridgeUI
{
    partial class AppForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnContent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecipe
            // 
            this.btnRecipe.Font = new System.Drawing.Font("Eras Bold ITC", 12F);
            this.btnRecipe.Location = new System.Drawing.Point(56, 166);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(177, 479);
            this.btnRecipe.TabIndex = 0;
            this.btnRecipe.Text = "Recipe";
            this.btnRecipe.UseVisualStyleBackColor = true;
            this.btnRecipe.Click += new System.EventHandler(this.BtnRecipe_Click);
            // 
            // btnContent
            // 
            this.btnContent.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContent.Location = new System.Drawing.Point(324, 166);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(174, 479);
            this.btnContent.TabIndex = 1;
            this.btnContent.Text = "Aliment";
            this.btnContent.UseVisualStyleBackColor = true;
            this.btnContent.Click += new System.EventHandler(this.BtnContent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 34F);
            this.label1.Location = new System.Drawing.Point(169, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenue";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 848);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContent);
            this.Controls.Add(this.btnRecipe);
            this.Name = "AppForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Button btnContent;
        private System.Windows.Forms.Label label1;
    }
}

