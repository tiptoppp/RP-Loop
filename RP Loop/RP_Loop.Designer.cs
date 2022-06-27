namespace RP_Loop
{
    partial class RPLoopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPLoopForm));
            this.ToggleRPLoopcheckBox = new System.Windows.Forms.CheckBox();
            this.DiscordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MadebyLabel = new System.Windows.Forms.Label();
            this.ToggleRPLoopLabel = new System.Windows.Forms.Label();
            this.AppExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToggleRPLoopcheckBox
            // 
            this.ToggleRPLoopcheckBox.AutoSize = true;
            this.ToggleRPLoopcheckBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRPLoopcheckBox.ForeColor = System.Drawing.Color.White;
            this.ToggleRPLoopcheckBox.Location = new System.Drawing.Point(120, 11);
            this.ToggleRPLoopcheckBox.Name = "ToggleRPLoopcheckBox";
            this.ToggleRPLoopcheckBox.Size = new System.Drawing.Size(15, 14);
            this.ToggleRPLoopcheckBox.TabIndex = 4;
            this.ToggleRPLoopcheckBox.UseVisualStyleBackColor = true;
            this.ToggleRPLoopcheckBox.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // DiscordLinkLabel
            // 
            this.DiscordLinkLabel.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.DiscordLinkLabel.AutoSize = true;
            this.DiscordLinkLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordLinkLabel.LinkColor = System.Drawing.Color.Magenta;
            this.DiscordLinkLabel.Location = new System.Drawing.Point(60, 34);
            this.DiscordLinkLabel.Name = "DiscordLinkLabel";
            this.DiscordLinkLabel.Size = new System.Drawing.Size(71, 12);
            this.DiscordLinkLabel.TabIndex = 7;
            this.DiscordLinkLabel.TabStop = true;
            this.DiscordLinkLabel.Text = "tiptop#9113";
            this.DiscordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordLinkLabel_LinkClicked);
            // 
            // MadebyLabel
            // 
            this.MadebyLabel.AutoSize = true;
            this.MadebyLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadebyLabel.ForeColor = System.Drawing.Color.White;
            this.MadebyLabel.Location = new System.Drawing.Point(11, 34);
            this.MadebyLabel.Name = "MadebyLabel";
            this.MadebyLabel.Size = new System.Drawing.Size(51, 12);
            this.MadebyLabel.TabIndex = 6;
            this.MadebyLabel.Text = "Made by";
            // 
            // ToggleRPLoopLabel
            // 
            this.ToggleRPLoopLabel.AutoSize = true;
            this.ToggleRPLoopLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRPLoopLabel.ForeColor = System.Drawing.Color.White;
            this.ToggleRPLoopLabel.Location = new System.Drawing.Point(10, 10);
            this.ToggleRPLoopLabel.Name = "ToggleRPLoopLabel";
            this.ToggleRPLoopLabel.Size = new System.Drawing.Size(107, 15);
            this.ToggleRPLoopLabel.TabIndex = 5;
            this.ToggleRPLoopLabel.Text = "Toggle RP Loop";
            // 
            // AppExit
            // 
            this.AppExit.BackColor = System.Drawing.Color.Transparent;
            this.AppExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AppExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppExit.Location = new System.Drawing.Point(0, 0);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(10, 10);
            this.AppExit.TabIndex = 8;
            this.AppExit.UseVisualStyleBackColor = false;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // RPLoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(145, 57);
            this.Controls.Add(this.AppExit);
            this.Controls.Add(this.ToggleRPLoopcheckBox);
            this.Controls.Add(this.DiscordLinkLabel);
            this.Controls.Add(this.MadebyLabel);
            this.Controls.Add(this.ToggleRPLoopLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPLoopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RP Loop";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ToggleRPLoopcheckBox;
        private System.Windows.Forms.LinkLabel DiscordLinkLabel;
        private System.Windows.Forms.Label MadebyLabel;
        private System.Windows.Forms.Label ToggleRPLoopLabel;
        private System.Windows.Forms.Button AppExit;
    }
}

