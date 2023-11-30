namespace ProductViewUI
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            welcomeLabel = new Label();
            goToCatalogButton = new Button();
            menuStrip = new MenuStrip();
            súborToolStripMenuItem = new ToolStripMenuItem();
            ukončiťToolStripMenuItem = new ToolStripMenuItem();
            katalógToolStripMenuItem = new ToolStripMenuItem();
            katalógToolStripMenuItem1 = new ToolStripMenuItem();
            pomocníkToolStripMenuItem = new ToolStripMenuItem();
            oAplikáciiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            welcomeLabel.Location = new Point(203, 92);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(501, 47);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Vitajte v prehľade produktov";
            // 
            // goToCatalogButton
            // 
            goToCatalogButton.Location = new Point(333, 246);
            goToCatalogButton.Name = "goToCatalogButton";
            goToCatalogButton.Size = new Size(195, 61);
            goToCatalogButton.TabIndex = 1;
            goToCatalogButton.Text = "Katalóg";
            goToCatalogButton.UseVisualStyleBackColor = true;
            goToCatalogButton.Click += goToCatalogButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { súborToolStripMenuItem, katalógToolStripMenuItem, pomocníkToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(922, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // súborToolStripMenuItem
            // 
            súborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ukončiťToolStripMenuItem });
            súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            súborToolStripMenuItem.Size = new Size(50, 20);
            súborToolStripMenuItem.Text = "&Súbor";
            // 
            // ukončiťToolStripMenuItem
            // 
            ukončiťToolStripMenuItem.Name = "ukončiťToolStripMenuItem";
            ukončiťToolStripMenuItem.Size = new Size(116, 22);
            ukončiťToolStripMenuItem.Text = "&Ukončiť";
            ukončiťToolStripMenuItem.Click += ukončiťToolStripMenuItem_Click;
            // 
            // katalógToolStripMenuItem
            // 
            katalógToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { katalógToolStripMenuItem1 });
            katalógToolStripMenuItem.Name = "katalógToolStripMenuItem";
            katalógToolStripMenuItem.Size = new Size(59, 20);
            katalógToolStripMenuItem.Text = "&Katalóg";
            // 
            // katalógToolStripMenuItem1
            // 
            katalógToolStripMenuItem1.Name = "katalógToolStripMenuItem1";
            katalógToolStripMenuItem1.Size = new Size(180, 22);
            katalógToolStripMenuItem1.Text = "&Katalóg";
            katalógToolStripMenuItem1.Click += katalógToolStripMenuItem1_Click;
            // 
            // pomocníkToolStripMenuItem
            // 
            pomocníkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikáciiToolStripMenuItem });
            pomocníkToolStripMenuItem.Name = "pomocníkToolStripMenuItem";
            pomocníkToolStripMenuItem.Size = new Size(73, 20);
            pomocníkToolStripMenuItem.Text = "&Pomocník";
            // 
            // oAplikáciiToolStripMenuItem
            // 
            oAplikáciiToolStripMenuItem.Name = "oAplikáciiToolStripMenuItem";
            oAplikáciiToolStripMenuItem.Size = new Size(129, 22);
            oAplikáciiToolStripMenuItem.Text = "&O aplikácii";
            oAplikáciiToolStripMenuItem.Click += oAplikáciiToolStripMenuItem_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 495);
            Controls.Add(goToCatalogButton);
            Controls.Add(welcomeLabel);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.RoyalBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "WelcomeForm";
            Text = "Welcome";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button goToCatalogButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem súborToolStripMenuItem;
        private ToolStripMenuItem ukončiťToolStripMenuItem;
        private ToolStripMenuItem katalógToolStripMenuItem;
        private ToolStripMenuItem pomocníkToolStripMenuItem;
        private ToolStripMenuItem oAplikáciiToolStripMenuItem;
        private ToolStripMenuItem katalógToolStripMenuItem1;
    }
}
