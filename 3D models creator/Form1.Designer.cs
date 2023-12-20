namespace _3D_models_creator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openobjFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_objects = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyramideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_3d = new System.Windows.Forms.Panel();
            this.MainMenuStrip.SuspendLayout();
            this.panel_objects.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openobjFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openobjFileToolStripMenuItem
            // 
            this.openobjFileToolStripMenuItem.Name = "openobjFileToolStripMenuItem";
            this.openobjFileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openobjFileToolStripMenuItem.Text = "Open .obj file";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel_objects
            // 
            this.panel_objects.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_objects.Controls.Add(this.menuStrip1);
            this.panel_objects.Location = new System.Drawing.Point(13, 28);
            this.panel_objects.Name = "panel_objects";
            this.panel_objects.Size = new System.Drawing.Size(156, 421);
            this.panel_objects.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cubeToolStripMenuItem,
            this.planeToolStripMenuItem,
            this.pyramideToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.newToolStripMenuItem1.Text = "New....";
            // 
            // cubeToolStripMenuItem
            // 
            this.cubeToolStripMenuItem.Name = "cubeToolStripMenuItem";
            this.cubeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cubeToolStripMenuItem.Text = "Cube";
            // 
            // planeToolStripMenuItem
            // 
            this.planeToolStripMenuItem.Name = "planeToolStripMenuItem";
            this.planeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.planeToolStripMenuItem.Text = "Plane";
            // 
            // pyramideToolStripMenuItem
            // 
            this.pyramideToolStripMenuItem.Name = "pyramideToolStripMenuItem";
            this.pyramideToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pyramideToolStripMenuItem.Text = "Pyramide";
            // 
            // panel_3d
            // 
            this.panel_3d.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_3d.Location = new System.Drawing.Point(175, 28);
            this.panel_3d.Name = "panel_3d";
            this.panel_3d.Size = new System.Drawing.Size(655, 421);
            this.panel_3d.TabIndex = 2;
            this.panel_3d.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_3d_Paint);
            this.panel_3d.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_3d_MouseDown);
            this.panel_3d.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_3d_MouseMove);
            this.panel_3d.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_3d_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel_3d);
            this.Controls.Add(this.panel_objects);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D models creator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.panel_objects.ResumeLayout(false);
            this.panel_objects.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openobjFileToolStripMenuItem;
        private System.Windows.Forms.Panel panel_objects;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyramideToolStripMenuItem;
        private System.Windows.Forms.Panel panel_3d;
    }
}

