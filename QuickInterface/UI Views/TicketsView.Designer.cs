namespace QuickInterface.UI_Views
{
    partial class TicketsView
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
            this.PullNewData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RunReportForITT = new System.Windows.Forms.Button();
            this.outTxtRunProcMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PullNewData
            // 
            this.PullNewData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PullNewData.Location = new System.Drawing.Point(36, 13);
            this.PullNewData.Name = "PullNewData";
            this.PullNewData.Size = new System.Drawing.Size(148, 23);
            this.PullNewData.TabIndex = 0;
            this.PullNewData.Text = "&Pull New Tickets";
            this.PullNewData.UseVisualStyleBackColor = true;
            this.PullNewData.Click += new System.EventHandler(this.PullNewData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Runs Stored Procedure [GatherAndCollate].[TicketsOfInterest]";
            // 
            // RunReportForITT
            // 
            this.RunReportForITT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunReportForITT.Location = new System.Drawing.Point(36, 42);
            this.RunReportForITT.Name = "RunReportForITT";
            this.RunReportForITT.Size = new System.Drawing.Size(148, 23);
            this.RunReportForITT.TabIndex = 2;
            this.RunReportForITT.Text = "Run &Report for ITT";
            this.RunReportForITT.UseVisualStyleBackColor = true;
            this.RunReportForITT.Click += new System.EventHandler(this.RunReportForITT_Click);
            // 
            // outTxtRunProcMessages
            // 
            this.outTxtRunProcMessages.AutoWordSelection = true;
            this.outTxtRunProcMessages.CausesValidation = false;
            this.outTxtRunProcMessages.EnableAutoDragDrop = true;
            this.outTxtRunProcMessages.Location = new System.Drawing.Point(13, 91);
            this.outTxtRunProcMessages.Name = "outTxtRunProcMessages";
            this.outTxtRunProcMessages.Size = new System.Drawing.Size(775, 347);
            this.outTxtRunProcMessages.TabIndex = 3;
            this.outTxtRunProcMessages.Text = "";
            this.outTxtRunProcMessages.WordWrap = false;
            this.outTxtRunProcMessages.ZoomFactor = 0.9F;
            // 
            // TicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outTxtRunProcMessages);
            this.Controls.Add(this.RunReportForITT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PullNewData);
            this.Name = "TicketsView";
            this.Text = "Tickets View";
            this.Load += new System.EventHandler(this.TicketsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PullNewData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunReportForITT;
        private System.Windows.Forms.RichTextBox outTxtRunProcMessages;
    }
}