namespace PKHeX.WinForms
{
    partial class Main
    {
        public System.Windows.Forms.ToolStripMenuItem EnableAutoLegality(System.ComponentModel.ComponentResourceManager resources)
        {
            this.Menu_ShowdownImportPKMModded = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ShowdownImportPKMModded.Image = ((System.Drawing.Image)(resources.GetObject("Menu_ShowdownImportPKM.Image")));
            this.Menu_ShowdownImportPKMModded.Name = "Menu_ShowdownImportPKMModded";
            this.Menu_ShowdownImportPKMModded.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.Menu_ShowdownImportPKMModded.ShowShortcutKeys = false;
            this.Menu_ShowdownImportPKMModded.Size = new System.Drawing.Size(231, 22);
            this.Menu_ShowdownImportPKMModded.Text = "Import with Auto-Legality Mod";
            this.Menu_ShowdownImportPKMModded.Click += new System.EventHandler(this.ClickShowdownImportPKMModded);
            return this.Menu_ShowdownImportPKMModded;
        }
        private System.Windows.Forms.ToolStripMenuItem Menu_ShowdownImportPKMModded;
    }
}