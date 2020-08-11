namespace QuickInterface.UI_Views
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.openTicketsView = new System.Windows.Forms.Button();
            this.openJobsView = new System.Windows.Forms.Button();
            this.openPermissionsDialogue = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.auditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storedProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tVFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLRsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalUseCommandTip = new System.Windows.Forms.ToolTip(this.components);
            this.cancelMainMenuAndExitApplication = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openTicketsView
            // 
            this.openTicketsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTicketsView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openTicketsView.Location = new System.Drawing.Point(27, 27);
            this.openTicketsView.Name = "openTicketsView";
            this.openTicketsView.Size = new System.Drawing.Size(194, 27);
            this.openTicketsView.TabIndex = 0;
            this.openTicketsView.Text = "Tickets";
            this.openTicketsView.UseVisualStyleBackColor = true;
            this.openTicketsView.Click += new System.EventHandler(this.openTicketsView_Click);
            // 
            // openJobsView
            // 
            this.openJobsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openJobsView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openJobsView.Location = new System.Drawing.Point(27, 60);
            this.openJobsView.Name = "openJobsView";
            this.openJobsView.Size = new System.Drawing.Size(194, 27);
            this.openJobsView.TabIndex = 1;
            this.openJobsView.Text = "Jobs";
            this.openJobsView.UseVisualStyleBackColor = true;
            this.openJobsView.Click += new System.EventHandler(this.openJobsView_Click);
            // 
            // openPermissionsDialogue
            // 
            this.openPermissionsDialogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPermissionsDialogue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openPermissionsDialogue.Location = new System.Drawing.Point(27, 93);
            this.openPermissionsDialogue.Name = "openPermissionsDialogue";
            this.openPermissionsDialogue.Size = new System.Drawing.Size(194, 27);
            this.openPermissionsDialogue.TabIndex = 2;
            this.openPermissionsDialogue.Text = "Permissions";
            this.generalUseCommandTip.SetToolTip(this.openPermissionsDialogue, "Grant, Revoke, review permissions on a user or a group from AD");
            this.openPermissionsDialogue.UseVisualStyleBackColor = true;
            this.openPermissionsDialogue.Click += new System.EventHandler(this.openPermissionsDialogue_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditToolStripMenuItem,
            this.scanToolStripMenuItem,
            this.captureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // auditToolStripMenuItem
            // 
            this.auditToolStripMenuItem.Name = "auditToolStripMenuItem";
            this.auditToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.auditToolStripMenuItem.Text = "Audit";
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.scanToolStripMenuItem.Text = "Scan";
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem,
            this.codeToolStripMenuItem});
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.captureToolStripMenuItem.Text = "Capture";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databasesToolStripMenuItem,
            this.serversToolStripMenuItem,
            this.datasetsToolStripMenuItem,
            this.schemasToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.valuesToolStripMenuItem});
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.databasesToolStripMenuItem.Text = "Databases";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.serversToolStripMenuItem.Text = "Servers";
            // 
            // datasetsToolStripMenuItem
            // 
            this.datasetsToolStripMenuItem.Name = "datasetsToolStripMenuItem";
            this.datasetsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.datasetsToolStripMenuItem.Text = "Datasets";
            // 
            // schemasToolStripMenuItem
            // 
            this.schemasToolStripMenuItem.Name = "schemasToolStripMenuItem";
            this.schemasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.schemasToolStripMenuItem.Text = "Schemas";
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.columnsToolStripMenuItem.Text = "Columns";
            // 
            // valuesToolStripMenuItem
            // 
            this.valuesToolStripMenuItem.Name = "valuesToolStripMenuItem";
            this.valuesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.valuesToolStripMenuItem.Text = "Values";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulesToolStripMenuItem,
            this.scriptToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storedProceduresToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.computedToolStripMenuItem});
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.modulesToolStripMenuItem.Text = "Modules";
            // 
            // storedProceduresToolStripMenuItem
            // 
            this.storedProceduresToolStripMenuItem.Name = "storedProceduresToolStripMenuItem";
            this.storedProceduresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.storedProceduresToolStripMenuItem.Text = "Stored Procedures";
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tVFsToolStripMenuItem,
            this.cLRsToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // tVFsToolStripMenuItem
            // 
            this.tVFsToolStripMenuItem.Name = "tVFsToolStripMenuItem";
            this.tVFsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.tVFsToolStripMenuItem.Text = "TVFs";
            // 
            // cLRsToolStripMenuItem
            // 
            this.cLRsToolStripMenuItem.Name = "cLRsToolStripMenuItem";
            this.cLRsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.cLRsToolStripMenuItem.Text = "CLRs";
            // 
            // computedToolStripMenuItem
            // 
            this.computedToolStripMenuItem.Name = "computedToolStripMenuItem";
            this.computedToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.computedToolStripMenuItem.Text = "Computed";
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerShellToolStripMenuItem,
            this.bATToolStripMenuItem,
            this.cMDToolStripMenuItem,
            this.shToolStripMenuItem});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // powerShellToolStripMenuItem
            // 
            this.powerShellToolStripMenuItem.Name = "powerShellToolStripMenuItem";
            this.powerShellToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.powerShellToolStripMenuItem.Text = "PowerShell";
            // 
            // bATToolStripMenuItem
            // 
            this.bATToolStripMenuItem.Name = "bATToolStripMenuItem";
            this.bATToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.bATToolStripMenuItem.Text = "BAT";
            // 
            // cMDToolStripMenuItem
            // 
            this.cMDToolStripMenuItem.Name = "cMDToolStripMenuItem";
            this.cMDToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cMDToolStripMenuItem.Text = "CMD";
            // 
            // shToolStripMenuItem
            // 
            this.shToolStripMenuItem.Name = "shToolStripMenuItem";
            this.shToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.shToolStripMenuItem.Text = ".sh";
            // 
            // generalUseCommandTip
            // 
            this.generalUseCommandTip.AutomaticDelay = 50;
            this.generalUseCommandTip.AutoPopDelay = 5000;
            this.generalUseCommandTip.InitialDelay = 50;
            this.generalUseCommandTip.ReshowDelay = 10;
            this.generalUseCommandTip.ToolTipTitle = "Command";
            // 
            // cancelMainMenuAndExitApplication
            // 
            this.cancelMainMenuAndExitApplication.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelMainMenuAndExitApplication.Location = new System.Drawing.Point(713, 415);
            this.cancelMainMenuAndExitApplication.Name = "cancelMainMenuAndExitApplication";
            this.cancelMainMenuAndExitApplication.Size = new System.Drawing.Size(75, 23);
            this.cancelMainMenuAndExitApplication.TabIndex = 4;
            this.cancelMainMenuAndExitApplication.Text = "Cancel";
            this.cancelMainMenuAndExitApplication.UseVisualStyleBackColor = true;
            this.cancelMainMenuAndExitApplication.Click += new System.EventHandler(this.cancelMainMenuAndExitApplication_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelMainMenuAndExitApplication;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelMainMenuAndExitApplication);
            this.Controls.Add(this.openPermissionsDialogue);
            this.Controls.Add(this.openJobsView);
            this.Controls.Add(this.openTicketsView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "DBABnch Quick Interface Main View";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openTicketsView;
        private System.Windows.Forms.Button openJobsView;
        private System.Windows.Forms.Button openPermissionsDialogue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem auditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datasetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tVFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLRsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shToolStripMenuItem;
        private System.Windows.Forms.ToolTip generalUseCommandTip;
        private System.Windows.Forms.Button cancelMainMenuAndExitApplication;
    }
}

