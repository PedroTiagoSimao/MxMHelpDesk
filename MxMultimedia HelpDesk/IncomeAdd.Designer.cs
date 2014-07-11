namespace MxMultimedia_HelpDesk
{
    partial class IncomeAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIncomeAdd = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumIncome = new System.Windows.Forms.TextBox();
            this.artigo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncomeAdd
            // 
            this.dgvIncomeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncomeAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomeAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artigo,
            this.descr,
            this.quant,
            this.value,
            this.total});
            this.dgvIncomeAdd.Location = new System.Drawing.Point(12, 58);
            this.dgvIncomeAdd.Name = "dgvIncomeAdd";
            this.dgvIncomeAdd.RowHeadersVisible = false;
            this.dgvIncomeAdd.Size = new System.Drawing.Size(662, 223);
            this.dgvIncomeAdd.TabIndex = 0;
            this.dgvIncomeAdd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellValueChanged);
            this.dgvIncomeAdd.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvIncomeAdd_DefaulValuesNeeded);
            this.dgvIncomeAdd.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvIncome_EditingControlShowing);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(599, 287);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(518, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Gravar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNumCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumCliente.Location = new System.Drawing.Point(54, 6);
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNumCliente.TabIndex = 5;
            this.txtNumCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumCliente_KeyDown);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeCliente.Location = new System.Drawing.Point(160, 6);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(308, 20);
            this.txtNomeCliente.TabIndex = 6;
            this.txtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCliente_KeyDown);
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(474, 6);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(200, 20);
            this.dtData.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero";
            // 
            // txtNumIncome
            // 
            this.txtNumIncome.Location = new System.Drawing.Point(54, 32);
            this.txtNumIncome.Name = "txtNumIncome";
            this.txtNumIncome.Size = new System.Drawing.Size(100, 20);
            this.txtNumIncome.TabIndex = 9;
            // 
            // artigo
            // 
            this.artigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.artigo.HeaderText = "Artigo";
            this.artigo.Name = "artigo";
            this.artigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artigo.Width = 150;
            // 
            // descr
            // 
            this.descr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descr.HeaderText = "Descrição";
            this.descr.Name = "descr";
            // 
            // quant
            // 
            this.quant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.quant.HeaderText = "Quant";
            this.quant.Name = "quant";
            this.quant.Width = 61;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.value.DefaultCellStyle = dataGridViewCellStyle1;
            this.value.HeaderText = "Preço";
            this.value.Name = "value";
            this.value.Width = 60;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle2;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 56;
            // 
            // IncomeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 322);
            this.Controls.Add(this.txtNumIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtNumCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvIncomeAdd);
            this.Name = "IncomeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeAdd";
            this.Load += new System.EventHandler(this.IncomeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncomeAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNumCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumIncome;
        private System.Windows.Forms.DataGridViewComboBoxColumn artigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}