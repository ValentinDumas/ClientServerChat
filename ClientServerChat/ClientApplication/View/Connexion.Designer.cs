using System.Windows.Forms.VisualStyles;

namespace ClientApplication.View
{
    partial class Connexion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && (components != null) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.groupBoxConnexion = new System.Windows.Forms.GroupBox();
            this.textBoxServerIp = new System.Windows.Forms.TextBox();
            this.labelServerIp = new System.Windows.Forms.Label();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.groupBoxConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnexion
            // 
            this.groupBoxConnexion.Controls.Add(this.buttonConnexion);
            this.groupBoxConnexion.Controls.Add(this.textBoxServerIp);
            this.groupBoxConnexion.Controls.Add(this.labelServerIp);
            this.groupBoxConnexion.Controls.Add(this.labelPseudo);
            this.groupBoxConnexion.Controls.Add(this.textBoxPseudo);
            this.groupBoxConnexion.Location = new System.Drawing.Point(16, 18);
            this.groupBoxConnexion.Name = "groupBoxConnexion";
            this.groupBoxConnexion.Size = new System.Drawing.Size(245, 246);
            this.groupBoxConnexion.TabIndex = 0;
            this.groupBoxConnexion.TabStop = false;
            this.groupBoxConnexion.Text = "Connexion";
            // 
            // textBoxServerIp
            // 
            this.textBoxServerIp.Location = new System.Drawing.Point(26, 134);
            this.textBoxServerIp.Multiline = true;
            this.textBoxServerIp.Name = "textBoxServerIp";
            this.textBoxServerIp.Size = new System.Drawing.Size(191, 20);
            this.textBoxServerIp.TabIndex = 4;
            this.textBoxServerIp.Text = "192.168.1.13";
            this.textBoxServerIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelServerIp
            // 
            this.labelServerIp.AutoSize = true;
            this.labelServerIp.Location = new System.Drawing.Point(26, 114);
            this.labelServerIp.Name = "labelServerIp";
            this.labelServerIp.Size = new System.Drawing.Size(66, 17);
            this.labelServerIp.TabIndex = 3;
            this.labelServerIp.Text = "Server IP";
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Location = new System.Drawing.Point(26, 44);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(56, 17);
            this.labelPseudo.TabIndex = 2;
            this.labelPseudo.Text = "Pseudo";
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(26, 64);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(191, 20);
            this.textBoxPseudo.TabIndex = 0;
            this.textBoxPseudo.Text = "Sp4rk";
            this.textBoxPseudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(26, 194);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(191, 33);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Connect to Chat";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            // 
            // Connexion
            // 
            this.Controls.Add(this.groupBoxConnexion);
            this.Name = "Connexion";
            this.Size = new System.Drawing.Size(279, 284);
            this.groupBoxConnexion.ResumeLayout(false);
            this.groupBoxConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnexion;
        private System.Windows.Forms.Label labelServerIp;
        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.TextBox textBoxServerIp;
        private System.Windows.Forms.Button buttonConnexion;
    }
}
