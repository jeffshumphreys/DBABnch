namespace QuickInterface.UI_Views
{
    partial class GenericGridView
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
            this.genericGridViewDataGrid = new System.Windows.Forms.DataGridView();
            this.ticketsOverMidMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportGridDataToExcel = new System.Windows.Forms.Button();
            this.ticketsOverMidMonthBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBABnchLOCALDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBABnch_LOCALDataSet = new QuickInterface.DBABnch_LOCALDataSet();
            this.ticketsOverMidMonthTableAdapter = new QuickInterface.DBABnch_LOCALDataSetTableAdapters.TicketsOverMidMonthTableAdapter();
            this.ticketsOverMidMonthBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fromdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inProcessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.genericGridViewDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsOverMidMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsOverMidMonthBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBABnchLOCALDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBABnch_LOCALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsOverMidMonthBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // genericGridViewDataGrid
            // 
            this.genericGridViewDataGrid.AllowUserToAddRows = false;
            this.genericGridViewDataGrid.AllowUserToDeleteRows = false;
            this.genericGridViewDataGrid.AllowUserToOrderColumns = true;
            this.genericGridViewDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genericGridViewDataGrid.AutoGenerateColumns = false;
            this.genericGridViewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genericGridViewDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromdateDataGridViewTextBoxColumn,
            this.todateDataGridViewTextBoxColumn,
            this.ownedByDataGridViewTextBoxColumn,
            this.allDataGridViewTextBoxColumn,
            this.resolvedDataGridViewTextBoxColumn,
            this.closedDataGridViewTextBoxColumn,
            this.assignedDataGridViewTextBoxColumn,
            this.inProcessDataGridViewTextBoxColumn,
            this.pendingDataGridViewTextBoxColumn,
            this.newDataGridViewTextBoxColumn});
            this.genericGridViewDataGrid.DataSource = this.ticketsOverMidMonthBindingSource;
            this.genericGridViewDataGrid.Location = new System.Drawing.Point(25, 12);
            this.genericGridViewDataGrid.Name = "genericGridViewDataGrid";
            this.genericGridViewDataGrid.ReadOnly = true;
            this.genericGridViewDataGrid.Size = new System.Drawing.Size(1406, 400);
            this.genericGridViewDataGrid.TabIndex = 0;
            // 
            // ticketsOverMidMonthBindingSource
            // 
            this.ticketsOverMidMonthBindingSource.DataMember = "TicketsOverMidMonth";
            this.ticketsOverMidMonthBindingSource.DataSource = this.dBABnchLOCALDataSetBindingSource;
            // 
            // exportGridDataToExcel
            // 
            this.exportGridDataToExcel.Location = new System.Drawing.Point(25, 415);
            this.exportGridDataToExcel.Name = "exportGridDataToExcel";
            this.exportGridDataToExcel.Size = new System.Drawing.Size(138, 23);
            this.exportGridDataToExcel.TabIndex = 1;
            this.exportGridDataToExcel.Text = "export To Excel...";
            this.exportGridDataToExcel.UseVisualStyleBackColor = true;
            this.exportGridDataToExcel.Click += new System.EventHandler(this.exportGridDataToExcel_Click);
            // 
            // ticketsOverMidMonthBindingSource1
            // 
            this.ticketsOverMidMonthBindingSource1.DataMember = "TicketsOverMidMonth";
            this.ticketsOverMidMonthBindingSource1.DataSource = this.dBABnchLOCALDataSetBindingSource;
            // 
            // dBABnchLOCALDataSetBindingSource
            // 
            this.dBABnchLOCALDataSetBindingSource.DataSource = this.dBABnch_LOCALDataSet;
            this.dBABnchLOCALDataSetBindingSource.Position = 0;
            // 
            // dBABnch_LOCALDataSet
            // 
            this.dBABnch_LOCALDataSet.DataSetName = "DBABnch_LOCALDataSet";
            this.dBABnch_LOCALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsOverMidMonthTableAdapter
            // 
            this.ticketsOverMidMonthTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsOverMidMonthBindingSource2
            // 
            this.ticketsOverMidMonthBindingSource2.DataMember = "TicketsOverMidMonth";
            this.ticketsOverMidMonthBindingSource2.DataSource = this.dBABnch_LOCALDataSet;
            // 
            // fromdateDataGridViewTextBoxColumn
            // 
            this.fromdateDataGridViewTextBoxColumn.DataPropertyName = "fromdate";
            this.fromdateDataGridViewTextBoxColumn.HeaderText = "fromdate";
            this.fromdateDataGridViewTextBoxColumn.Name = "fromdateDataGridViewTextBoxColumn";
            this.fromdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // todateDataGridViewTextBoxColumn
            // 
            this.todateDataGridViewTextBoxColumn.DataPropertyName = "todate";
            this.todateDataGridViewTextBoxColumn.HeaderText = "todate";
            this.todateDataGridViewTextBoxColumn.Name = "todateDataGridViewTextBoxColumn";
            this.todateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownedByDataGridViewTextBoxColumn
            // 
            this.ownedByDataGridViewTextBoxColumn.DataPropertyName = "OwnedBy";
            this.ownedByDataGridViewTextBoxColumn.HeaderText = "OwnedBy";
            this.ownedByDataGridViewTextBoxColumn.Name = "ownedByDataGridViewTextBoxColumn";
            this.ownedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allDataGridViewTextBoxColumn
            // 
            this.allDataGridViewTextBoxColumn.DataPropertyName = "All";
            this.allDataGridViewTextBoxColumn.HeaderText = "All";
            this.allDataGridViewTextBoxColumn.Name = "allDataGridViewTextBoxColumn";
            this.allDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resolvedDataGridViewTextBoxColumn
            // 
            this.resolvedDataGridViewTextBoxColumn.DataPropertyName = "Resolved";
            this.resolvedDataGridViewTextBoxColumn.HeaderText = "Resolved";
            this.resolvedDataGridViewTextBoxColumn.Name = "resolvedDataGridViewTextBoxColumn";
            this.resolvedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closedDataGridViewTextBoxColumn
            // 
            this.closedDataGridViewTextBoxColumn.DataPropertyName = "Closed";
            this.closedDataGridViewTextBoxColumn.HeaderText = "Closed";
            this.closedDataGridViewTextBoxColumn.Name = "closedDataGridViewTextBoxColumn";
            this.closedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignedDataGridViewTextBoxColumn
            // 
            this.assignedDataGridViewTextBoxColumn.DataPropertyName = "Assigned";
            this.assignedDataGridViewTextBoxColumn.HeaderText = "Assigned";
            this.assignedDataGridViewTextBoxColumn.Name = "assignedDataGridViewTextBoxColumn";
            this.assignedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inProcessDataGridViewTextBoxColumn
            // 
            this.inProcessDataGridViewTextBoxColumn.DataPropertyName = "InProcess";
            this.inProcessDataGridViewTextBoxColumn.HeaderText = "InProcess";
            this.inProcessDataGridViewTextBoxColumn.Name = "inProcessDataGridViewTextBoxColumn";
            this.inProcessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pendingDataGridViewTextBoxColumn
            // 
            this.pendingDataGridViewTextBoxColumn.DataPropertyName = "Pending";
            this.pendingDataGridViewTextBoxColumn.HeaderText = "Pending";
            this.pendingDataGridViewTextBoxColumn.Name = "pendingDataGridViewTextBoxColumn";
            this.pendingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newDataGridViewTextBoxColumn
            // 
            this.newDataGridViewTextBoxColumn.DataPropertyName = "New";
            this.newDataGridViewTextBoxColumn.HeaderText = "New";
            this.newDataGridViewTextBoxColumn.Name = "newDataGridViewTextBoxColumn";
            this.newDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GenericGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 450);
            this.Controls.Add(this.exportGridDataToExcel);
            this.Controls.Add(this.genericGridViewDataGrid);
            this.Name = "GenericGridView";
            this.Text = "GenericGridView";
            this.Load += new System.EventHandler(this.GenericGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genericGridViewDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsOverMidMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsOverMidMonthBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBABnchLOCALDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBABnch_LOCALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsOverMidMonthBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView genericGridViewDataGrid;
        private System.Windows.Forms.BindingSource dBABnchLOCALDataSetBindingSource;
        private DBABnch_LOCALDataSet dBABnch_LOCALDataSet;
        private System.Windows.Forms.BindingSource ticketsOverMidMonthBindingSource;
        private DBABnch_LOCALDataSetTableAdapters.TicketsOverMidMonthTableAdapter ticketsOverMidMonthTableAdapter;
        private System.Windows.Forms.Button exportGridDataToExcel;
        private System.Windows.Forms.BindingSource ticketsOverMidMonthBindingSource1;
        private System.Windows.Forms.BindingSource ticketsOverMidMonthBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newDataGridViewTextBoxColumn;
    }
}