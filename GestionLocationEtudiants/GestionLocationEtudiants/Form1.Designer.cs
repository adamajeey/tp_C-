namespace GestionLocationEtudiants
{
    partial class frmConnexion
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
            this.Identifiant = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotsDePasse = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(53, 41);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(63, 16);
            this.Identifiant.TabIndex = 0;
            this.Identifiant.Text = "Identifiant";
            this.Identifiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(56, 82);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(407, 22);
            this.txtIdentifiant.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mots de passe";
            // 
            // txtMotsDePasse
            // 
            this.txtMotsDePasse.Location = new System.Drawing.Point(56, 186);
            this.txtMotsDePasse.Name = "txtMotsDePasse";
            this.txtMotsDePasse.Size = new System.Drawing.Size(407, 22);
            this.txtMotsDePasse.TabIndex = 1;
            this.txtMotsDePasse.UseSystemPasswordChar = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(56, 275);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(169, 40);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(258, 275);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(205, 40);
            this.btnConnecter.TabIndex = 3;
            this.btnConnecter.Text = "&Se Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 352);
            this.ControlBox = false;
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtMotsDePasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.Identifiant);
            this.Name = "frmConnexion";
            this.Text = "Page de Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotsDePasse;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnConnecter;
    }
}

