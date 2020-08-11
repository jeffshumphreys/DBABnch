namespace QuickInterface.UI_Views
{
    partial class PermissionsDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionsDialogue));
            this.label1 = new System.Windows.Forms.Label();
            this.ReceiverNamesSoughtOrFound = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverWherePermsWillBeAdded = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.databaseReceiverWillGainAccessTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fillInMissingDetails = new System.Windows.Forms.Button();
            this.checkActualPermissionsStatusInDb = new System.Windows.Forms.Button();
            this.grantAnyPartMissing = new System.Windows.Forms.Button();
            this.outTxtRunProcMessages = new System.Windows.Forms.RichTextBox();
            this.responseFromQueryAsGrid = new System.Windows.Forms.DataGridView();
            this.cancelOpAndCloseWindowCommand = new System.Windows.Forms.Button();
            this.sAMAccountsSearchedForOrFound = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lastStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.responseFromQueryAsGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receiver";
            // 
            // ReceiverNamesSoughtOrFound
            // 
            this.ReceiverNamesSoughtOrFound.FormattingEnabled = true;
            this.ReceiverNamesSoughtOrFound.Items.AddRange(new object[] {
            "Friday, Kristine"});
            this.ReceiverNamesSoughtOrFound.Location = new System.Drawing.Point(82, 19);
            this.ReceiverNamesSoughtOrFound.Name = "ReceiverNamesSoughtOrFound";
            this.ReceiverNamesSoughtOrFound.Size = new System.Drawing.Size(121, 21);
            this.ReceiverNamesSoughtOrFound.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server";
            // 
            // serverWherePermsWillBeAdded
            // 
            this.serverWherePermsWillBeAdded.FormattingEnabled = true;
            this.serverWherePermsWillBeAdded.Items.AddRange(new object[] {
            "OCC00DB006",
            "EDWPROD"});
            this.serverWherePermsWillBeAdded.Location = new System.Drawing.Point(262, 19);
            this.serverWherePermsWillBeAdded.Name = "serverWherePermsWillBeAdded";
            this.serverWherePermsWillBeAdded.Size = new System.Drawing.Size(121, 21);
            this.serverWherePermsWillBeAdded.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database";
            // 
            // databaseReceiverWillGainAccessTo
            // 
            this.databaseReceiverWillGainAccessTo.FormattingEnabled = true;
            this.databaseReceiverWillGainAccessTo.Items.AddRange(new object[] {
            "FG_Logility"});
            this.databaseReceiverWillGainAccessTo.Location = new System.Drawing.Point(448, 19);
            this.databaseReceiverWillGainAccessTo.Name = "databaseReceiverWillGainAccessTo";
            this.databaseReceiverWillGainAccessTo.Size = new System.Drawing.Size(121, 21);
            this.databaseReceiverWillGainAccessTo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tables";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "InterfaceActual Demand X-Ref",
            "Sales_Hierarchy_Xref_Base"});
            this.listBox1.Location = new System.Drawing.Point(621, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 95);
            this.listBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "sAMAccount";
            // 
            // fillInMissingDetails
            // 
            this.fillInMissingDetails.Location = new System.Drawing.Point(856, 19);
            this.fillInMissingDetails.Name = "fillInMissingDetails";
            this.fillInMissingDetails.Size = new System.Drawing.Size(135, 23);
            this.fillInMissingDetails.TabIndex = 6;
            this.fillInMissingDetails.Text = "Fill in Missing Detail";
            this.fillInMissingDetails.UseVisualStyleBackColor = true;
            this.fillInMissingDetails.Click += new System.EventHandler(this.fillInMissingDetails_Click);
            // 
            // checkActualPermissionsStatusInDb
            // 
            this.checkActualPermissionsStatusInDb.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.checkActualPermissionsStatusInDb.Location = new System.Drawing.Point(856, 46);
            this.checkActualPermissionsStatusInDb.Name = "checkActualPermissionsStatusInDb";
            this.checkActualPermissionsStatusInDb.Size = new System.Drawing.Size(135, 23);
            this.checkActualPermissionsStatusInDb.TabIndex = 8;
            this.checkActualPermissionsStatusInDb.Text = "Verify";
            this.checkActualPermissionsStatusInDb.UseVisualStyleBackColor = true;
            // 
            // grantAnyPartMissing
            // 
            this.grantAnyPartMissing.Location = new System.Drawing.Point(856, 75);
            this.grantAnyPartMissing.Name = "grantAnyPartMissing";
            this.grantAnyPartMissing.Size = new System.Drawing.Size(135, 23);
            this.grantAnyPartMissing.TabIndex = 9;
            this.grantAnyPartMissing.Text = "Grant";
            this.grantAnyPartMissing.UseVisualStyleBackColor = true;
            // 
            // outTxtRunProcMessages
            // 
            this.outTxtRunProcMessages.AutoWordSelection = true;
            this.outTxtRunProcMessages.CausesValidation = false;
            this.outTxtRunProcMessages.EnableAutoDragDrop = true;
            this.outTxtRunProcMessages.Location = new System.Drawing.Point(336, 169);
            this.outTxtRunProcMessages.Name = "outTxtRunProcMessages";
            this.outTxtRunProcMessages.Size = new System.Drawing.Size(784, 258);
            this.outTxtRunProcMessages.TabIndex = 11;
            this.outTxtRunProcMessages.Text = "";
            this.outTxtRunProcMessages.WordWrap = false;
            this.outTxtRunProcMessages.ZoomFactor = 0.9F;
            // 
            // responseFromQueryAsGrid
            // 
            this.responseFromQueryAsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.responseFromQueryAsGrid.Location = new System.Drawing.Point(16, 169);
            this.responseFromQueryAsGrid.Name = "responseFromQueryAsGrid";
            this.responseFromQueryAsGrid.Size = new System.Drawing.Size(314, 258);
            this.responseFromQueryAsGrid.TabIndex = 10;
            // 
            // cancelOpAndCloseWindowCommand
            // 
            this.cancelOpAndCloseWindowCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelOpAndCloseWindowCommand.Location = new System.Drawing.Point(985, 494);
            this.cancelOpAndCloseWindowCommand.Name = "cancelOpAndCloseWindowCommand";
            this.cancelOpAndCloseWindowCommand.Size = new System.Drawing.Size(135, 23);
            this.cancelOpAndCloseWindowCommand.TabIndex = 12;
            this.cancelOpAndCloseWindowCommand.Text = "&Cancel";
            this.cancelOpAndCloseWindowCommand.UseVisualStyleBackColor = true;
            this.cancelOpAndCloseWindowCommand.Click += new System.EventHandler(this.cancelOpAndCloseWindowCommand_Click);
            // 
            // sAMAccountsSearchedForOrFound
            // 
            this.sAMAccountsSearchedForOrFound.FormattingEnabled = true;
            this.sAMAccountsSearchedForOrFound.Items.AddRange(new object[] {
            "Friday, Kristine"});
            this.sAMAccountsSearchedForOrFound.Location = new System.Drawing.Point(82, 43);
            this.sAMAccountsSearchedForOrFound.Name = "sAMAccountsSearchedForOrFound";
            this.sAMAccountsSearchedForOrFound.Size = new System.Drawing.Size(121, 21);
            this.sAMAccountsSearchedForOrFound.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastStatusMessage,
            this.toolStripProgressBar1,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1132, 34);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lastStatusMessage
            // 
            this.lastStatusMessage.Name = "lastStatusMessage";
            this.lastStatusMessage.Size = new System.Drawing.Size(60, 29);
            this.lastStatusMessage.Text = "...pending";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(44, 32);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // PermissionsDialogue
            // 
            this.AcceptButton = this.fillInMissingDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelOpAndCloseWindowCommand;
            this.ClientSize = new System.Drawing.Size(1132, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.responseFromQueryAsGrid);
            this.Controls.Add(this.outTxtRunProcMessages);
            this.Controls.Add(this.cancelOpAndCloseWindowCommand);
            this.Controls.Add(this.grantAnyPartMissing);
            this.Controls.Add(this.checkActualPermissionsStatusInDb);
            this.Controls.Add(this.fillInMissingDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.databaseReceiverWillGainAccessTo);
            this.Controls.Add(this.serverWherePermsWillBeAdded);
            this.Controls.Add(this.sAMAccountsSearchedForOrFound);
            this.Controls.Add(this.ReceiverNamesSoughtOrFound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "PermissionsDialogue";
            this.Text = "Permissions Management";
            this.Load += new System.EventHandler(this.PermissionsDialogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.responseFromQueryAsGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ReceiverNamesSoughtOrFound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serverWherePermsWillBeAdded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox databaseReceiverWillGainAccessTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fillInMissingDetails;
        private System.Windows.Forms.Button checkActualPermissionsStatusInDb;
        private System.Windows.Forms.Button grantAnyPartMissing;
        private System.Windows.Forms.RichTextBox outTxtRunProcMessages;
        private System.Windows.Forms.DataGridView responseFromQueryAsGrid;
        private System.Windows.Forms.Button cancelOpAndCloseWindowCommand;
        private System.Windows.Forms.ComboBox sAMAccountsSearchedForOrFound;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lastStatusMessage;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}