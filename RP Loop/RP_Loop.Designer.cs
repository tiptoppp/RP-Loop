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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPLoopForm));
            this.ToggleRPLoopcheckBox = new System.Windows.Forms.CheckBox();
            this.DiscordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MadebyLabel = new System.Windows.Forms.Label();
            this.ToggleRPLoopLabel = new System.Windows.Forms.Label();
            this.RPLoop = new System.Windows.Forms.GroupBox();
            this.PublicSoloLobby = new System.Windows.Forms.GroupBox();
            this.EmptyLobby = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.searchingProcess1 = new RP_Loop.SearchingProcess();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.RPLoop.SuspendLayout();
            this.PublicSoloLobby.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToggleRPLoopcheckBox
            // 
            this.ToggleRPLoopcheckBox.AutoSize = true;
            this.ToggleRPLoopcheckBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRPLoopcheckBox.ForeColor = System.Drawing.Color.White;
            this.ToggleRPLoopcheckBox.Location = new System.Drawing.Point(118, 24);
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
            this.DiscordLinkLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(231)))));
            this.DiscordLinkLabel.Location = new System.Drawing.Point(79, 162);
            this.DiscordLinkLabel.Name = "DiscordLinkLabel";
            this.DiscordLinkLabel.Size = new System.Drawing.Size(76, 14);
            this.DiscordLinkLabel.TabIndex = 7;
            this.DiscordLinkLabel.TabStop = true;
            this.DiscordLinkLabel.Text = "tiptop#9113";
            this.DiscordLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(231)))));
            this.DiscordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordLinkLabel_LinkClicked);
            // 
            // MadebyLabel
            // 
            this.MadebyLabel.AutoSize = true;
            this.MadebyLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadebyLabel.ForeColor = System.Drawing.Color.White;
            this.MadebyLabel.Location = new System.Drawing.Point(26, 162);
            this.MadebyLabel.Name = "MadebyLabel";
            this.MadebyLabel.Size = new System.Drawing.Size(57, 14);
            this.MadebyLabel.TabIndex = 6;
            this.MadebyLabel.Text = "Made by";
            // 
            // ToggleRPLoopLabel
            // 
            this.ToggleRPLoopLabel.AutoSize = true;
            this.ToggleRPLoopLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRPLoopLabel.ForeColor = System.Drawing.Color.White;
            this.ToggleRPLoopLabel.Location = new System.Drawing.Point(10, 24);
            this.ToggleRPLoopLabel.Name = "ToggleRPLoopLabel";
            this.ToggleRPLoopLabel.Size = new System.Drawing.Size(100, 14);
            this.ToggleRPLoopLabel.TabIndex = 5;
            this.ToggleRPLoopLabel.Text = "Toggle RP Loop";
            // 
            // RPLoop
            // 
            this.RPLoop.Controls.Add(this.ToggleRPLoopLabel);
            this.RPLoop.Controls.Add(this.ToggleRPLoopcheckBox);
            this.RPLoop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPLoop.ForeColor = System.Drawing.Color.White;
            this.RPLoop.Location = new System.Drawing.Point(10, 32);
            this.RPLoop.Name = "RPLoop";
            this.RPLoop.Size = new System.Drawing.Size(145, 55);
            this.RPLoop.TabIndex = 8;
            this.RPLoop.TabStop = false;
            this.RPLoop.Text = "RP Loop";
            // 
            // PublicSoloLobby
            // 
            this.PublicSoloLobby.Controls.Add(this.EmptyLobby);
            this.PublicSoloLobby.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicSoloLobby.ForeColor = System.Drawing.Color.White;
            this.PublicSoloLobby.Location = new System.Drawing.Point(10, 97);
            this.PublicSoloLobby.Name = "PublicSoloLobby";
            this.PublicSoloLobby.Size = new System.Drawing.Size(145, 55);
            this.PublicSoloLobby.TabIndex = 9;
            this.PublicSoloLobby.TabStop = false;
            this.PublicSoloLobby.Text = "Public Solo Lobby";
            // 
            // EmptyLobby
            // 
            this.EmptyLobby.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyLobby.ForeColor = System.Drawing.Color.Black;
            this.EmptyLobby.Location = new System.Drawing.Point(12, 19);
            this.EmptyLobby.Name = "EmptyLobby";
            this.EmptyLobby.Size = new System.Drawing.Size(121, 23);
            this.EmptyLobby.TabIndex = 0;
            this.EmptyLobby.Text = "Empty Lobby";
            this.EmptyLobby.UseVisualStyleBackColor = true;
            this.EmptyLobby.Click += new System.EventHandler(this.EmptyLobby_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.Exit);
            this.TitleBar.Controls.Add(this.Minimize);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(165, 22);
            this.TitleBar.TabIndex = 10;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::RP_Loop.Properties.Resources.Exit;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(137, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 22);
            this.Exit.TabIndex = 1;
            this.Exit.TabStop = false;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = global::RP_Loop.Properties.Resources.Minimize;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(109, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 22);
            this.Minimize.TabIndex = 0;
            this.Minimize.TabStop = false;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // searchingProcess1
            // 
            this.searchingProcess1.BackColor = System.Drawing.Color.Black;
            this.searchingProcess1.Location = new System.Drawing.Point(0, 22);
            this.searchingProcess1.Name = "searchingProcess1";
            this.searchingProcess1.Size = new System.Drawing.Size(165, 164);
            this.searchingProcess1.TabIndex = 11;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // RPLoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(165, 186);
            this.Controls.Add(this.searchingProcess1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.PublicSoloLobby);
            this.Controls.Add(this.RPLoop);
            this.Controls.Add(this.MadebyLabel);
            this.Controls.Add(this.DiscordLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPLoopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RP Loop";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RPLoopForm_Load);
            this.RPLoop.ResumeLayout(false);
            this.RPLoop.PerformLayout();
            this.PublicSoloLobby.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ToggleRPLoopcheckBox;
        private System.Windows.Forms.LinkLabel DiscordLinkLabel;
        private System.Windows.Forms.Label MadebyLabel;
        private System.Windows.Forms.Label ToggleRPLoopLabel;
        private System.Windows.Forms.GroupBox RPLoop;
        private System.Windows.Forms.GroupBox PublicSoloLobby;
        private System.Windows.Forms.Button EmptyLobby;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private SearchingProcess searchingProcess1;
        private System.Windows.Forms.Timer Timer;
    }
}

