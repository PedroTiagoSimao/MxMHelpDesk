namespace MxMultimedia_HelpDesk
{
    partial class ListagemAssistencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemAssistencias));
            this.dgvAssistencias = new System.Windows.Forms.DataGridView();
            this.datain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.definirSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbLoja = new System.Windows.Forms.ToolStripComboBox();
            this.btnAssistencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilterAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPendentes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtRegisto = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistencias)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssistencias
            // 
            this.dgvAssistencias.AllowUserToAddRows = false;
            this.dgvAssistencias.AllowUserToDeleteRows = false;
            this.dgvAssistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssistencias.ColumnHeadersHeight = 30;
            this.dgvAssistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datain,
            this.registo,
            this.cliente,
            this.loja,
            this.datafim});
            this.dgvAssistencias.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAssistencias.Location = new System.Drawing.Point(0, 28);
            this.dgvAssistencias.Name = "dgvAssistencias";
            this.dgvAssistencias.ReadOnly = true;
            this.dgvAssistencias.RowHeadersVisible = false;
            this.dgvAssistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssistencias.Size = new System.Drawing.Size(659, 506);
            this.dgvAssistencias.TabIndex = 0;
            this.dgvAssistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssistencias_CellClick);
            this.dgvAssistencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssistencias_CellDoubleClick);
            // 
            // datain
            // 
            this.datain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.datain.DefaultCellStyle = dataGridViewCellStyle1;
            this.datain.HeaderText = "Data";
            this.datain.Name = "datain";
            this.datain.ReadOnly = true;
            this.datain.Width = 55;
            // 
            // registo
            // 
            this.registo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.registo.HeaderText = "Registo";
            this.registo.Name = "registo";
            this.registo.ReadOnly = true;
            this.registo.Width = 68;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // loja
            // 
            this.loja.HeaderText = "Loja";
            this.loja.Name = "loja";
            this.loja.ReadOnly = true;
            // 
            // datafim
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.datafim.DefaultCellStyle = dataGridViewCellStyle2;
            this.datafim.HeaderText = "Data Saída";
            this.datafim.Name = "datafim";
            this.datafim.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definirSaídaToolStripMenuItem,
            this.btnEliminar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            // 
            // definirSaídaToolStripMenuItem
            // 
            this.definirSaídaToolStripMenuItem.Name = "definirSaídaToolStripMenuItem";
            this.definirSaídaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.definirSaídaToolStripMenuItem.Text = "Definir Saída";
            this.definirSaídaToolStripMenuItem.Click += new System.EventHandler(this.definirSaídaToolStripMenuItem_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbLoja,
            this.btnAssistencia,
            this.toolStripSeparator2,
            this.btnFilterAll,
            this.toolStripSeparator1,
            this.btnPendentes,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.txtRegisto,
            this.btnSearch,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(659, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "Loja";
            // 
            // cmbLoja
            // 
            this.cmbLoja.Name = "cmbLoja";
            this.cmbLoja.Size = new System.Drawing.Size(121, 25);
            this.cmbLoja.DropDownClosed += new System.EventHandler(this.cmbLoja_DropDownClosed);
            // 
            // btnAssistencia
            // 
            this.btnAssistencia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAssistencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAssistencia.Image = global::MxMultimedia_HelpDesk.Properties.Resources.write_document;
            this.btnAssistencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssistencia.Name = "btnAssistencia";
            this.btnAssistencia.Size = new System.Drawing.Size(23, 22);
            this.btnAssistencia.Text = "Nova Assistencia";
            this.btnAssistencia.Click += new System.EventHandler(this.btnAssistencia_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFilterAll.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterAll.Image")));
            this.btnFilterAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(61, 22);
            this.btnFilterAll.Text = "Ver todos";
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPendentes
            // 
            this.btnPendentes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPendentes.Image = ((System.Drawing.Image)(resources.GetObject("btnPendentes.Image")));
            this.btnPendentes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPendentes.Name = "btnPendentes";
            this.btnPendentes.Size = new System.Drawing.Size(66, 22);
            this.btnPendentes.Text = "Pendentes";
            this.btnPendentes.Click += new System.EventHandler(this.btnPendentes_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel2.Text = "Registo/Nº Série";
            // 
            // txtRegisto
            // 
            this.txtRegisto.Name = "txtRegisto";
            this.txtRegisto.Size = new System.Drawing.Size(100, 25);
            this.txtRegisto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegisto_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::MxMultimedia_HelpDesk.Properties.Resources.search;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.Text = "toolStripButton1";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MxMultimedia_HelpDesk.Properties.Resources.excel_ico;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Exportar Lista";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ListagemAssistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 535);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAssistencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListagemAssistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem Assistências";
            this.Load += new System.EventHandler(this.ListagemAssistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistencias)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssistencias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbLoja;
        private System.Windows.Forms.ToolStripButton btnAssistencia;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem definirSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnFilterAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtRegisto;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.ToolStripButton btnPendentes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datain;
        private System.Windows.Forms.DataGridViewTextBoxColumn registo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn loja;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafim;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}