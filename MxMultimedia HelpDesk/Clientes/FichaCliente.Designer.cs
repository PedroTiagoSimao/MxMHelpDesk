namespace MxMultimedia_HelpDesk.Clientes
{
    partial class FichaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSkype = new System.Windows.Forms.Button();
            this.txtSkypeCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelemovelCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoradaCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveEquip = new System.Windows.Forms.Button();
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.contextMenuEquipamentos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAssistencias = new System.Windows.Forms.DataGridView();
            this.registo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoavaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDefinirSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.avisarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAvisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDataRegisto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAssistencia = new System.Windows.Forms.Button();
            this.numequip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoequip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.contextMenuEquipamentos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistencias)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNIF);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLocalidade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSkype);
            this.groupBox1.Controls.Add(this.txtSkypeCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelemovelCliente);
            this.groupBox1.Controls.Add(this.txtTelefoneCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCPCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmailCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMoradaCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes Cliente";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(351, 26);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(175, 20);
            this.txtNIF.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "NIF";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(627, 52);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(115, 20);
            this.txtLocalidade.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(562, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Localidade";
            // 
            // btnSkype
            // 
            this.btnSkype.Image = global::MxMultimedia_HelpDesk.Properties.Resources.skyp1;
            this.btnSkype.Location = new System.Drawing.Point(719, 76);
            this.btnSkype.Name = "btnSkype";
            this.btnSkype.Size = new System.Drawing.Size(23, 23);
            this.btnSkype.TabIndex = 13;
            this.btnSkype.UseVisualStyleBackColor = true;
            this.btnSkype.Click += new System.EventHandler(this.btnSkype_Click);
            // 
            // txtSkypeCliente
            // 
            this.txtSkypeCliente.Location = new System.Drawing.Point(552, 78);
            this.txtSkypeCliente.Name = "txtSkypeCliente";
            this.txtSkypeCliente.Size = new System.Drawing.Size(161, 20);
            this.txtSkypeCliente.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Skype";
            // 
            // txtTelemovelCliente
            // 
            this.txtTelemovelCliente.Location = new System.Drawing.Point(325, 78);
            this.txtTelemovelCliente.Name = "txtTelemovelCliente";
            this.txtTelemovelCliente.Size = new System.Drawing.Size(180, 20);
            this.txtTelemovelCliente.TabIndex = 5;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(65, 78);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(175, 20);
            this.txtTelefoneCliente.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telemóvel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefone";
            // 
            // txtCPCliente
            // 
            this.txtCPCliente.Location = new System.Drawing.Point(435, 52);
            this.txtCPCliente.Name = "txtCPCliente";
            this.txtCPCliente.Size = new System.Drawing.Size(91, 20);
            this.txtCPCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "C Postal";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(574, 26);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(168, 20);
            this.txtEmailCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtMoradaCliente
            // 
            this.txtMoradaCliente.Location = new System.Drawing.Point(63, 52);
            this.txtMoradaCliente.Name = "txtMoradaCliente";
            this.txtMoradaCliente.Size = new System.Drawing.Size(326, 20);
            this.txtMoradaCliente.TabIndex = 2;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(63, 26);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(252, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveEquip);
            this.groupBox2.Controls.Add(this.dgvEquipamentos);
            this.groupBox2.Location = new System.Drawing.Point(15, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipamentos";
            // 
            // btnSaveEquip
            // 
            this.btnSaveEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEquip.Location = new System.Drawing.Point(615, 178);
            this.btnSaveEquip.Name = "btnSaveEquip";
            this.btnSaveEquip.Size = new System.Drawing.Size(134, 23);
            this.btnSaveEquip.TabIndex = 1;
            this.btnSaveEquip.Text = "Gravar Equipamentos";
            this.btnSaveEquip.UseVisualStyleBackColor = true;
            this.btnSaveEquip.Click += new System.EventHandler(this.btnSaveEquip_Click);
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numequip,
            this.tipoequip,
            this.descr,
            this.serie,
            this.pass,
            this.tvid,
            this.tvpass});
            this.dgvEquipamentos.ContextMenuStrip = this.contextMenuEquipamentos;
            this.dgvEquipamentos.Location = new System.Drawing.Point(3, 16);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvEquipamentos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipamentos.Size = new System.Drawing.Size(746, 156);
            this.dgvEquipamentos.TabIndex = 0;
            this.dgvEquipamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellClick);
            this.dgvEquipamentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellValueChanged);
            // 
            // contextMenuEquipamentos
            // 
            this.contextMenuEquipamentos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelete});
            this.contextMenuEquipamentos.Name = "contextMenuEquipamentos";
            this.contextMenuEquipamentos.Size = new System.Drawing.Size(118, 26);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 22);
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvAssistencias);
            this.groupBox3.Location = new System.Drawing.Point(12, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 173);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assistências";
            // 
            // dgvAssistencias
            // 
            this.dgvAssistencias.AllowUserToAddRows = false;
            this.dgvAssistencias.AllowUserToDeleteRows = false;
            this.dgvAssistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registo,
            this.loja,
            this.equip,
            this.tipoavaria,
            this.datafim,
            this.id,
            this.avisos,
            this.pago,
            this.data});
            this.dgvAssistencias.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAssistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssistencias.Location = new System.Drawing.Point(3, 16);
            this.dgvAssistencias.Name = "dgvAssistencias";
            this.dgvAssistencias.ReadOnly = true;
            this.dgvAssistencias.RowHeadersVisible = false;
            this.dgvAssistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssistencias.Size = new System.Drawing.Size(752, 154);
            this.dgvAssistencias.TabIndex = 0;
            this.dgvAssistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssistencias_CellClick);
            this.dgvAssistencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssistencias_CellDoubleClick);
            // 
            // registo
            // 
            this.registo.HeaderText = "Registo";
            this.registo.Name = "registo";
            this.registo.ReadOnly = true;
            // 
            // loja
            // 
            this.loja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.loja.HeaderText = "Loja";
            this.loja.Name = "loja";
            this.loja.ReadOnly = true;
            this.loja.Width = 52;
            // 
            // equip
            // 
            this.equip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equip.HeaderText = "Equipamento";
            this.equip.Name = "equip";
            this.equip.ReadOnly = true;
            // 
            // tipoavaria
            // 
            this.tipoavaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipoavaria.HeaderText = "Tipo";
            this.tipoavaria.Name = "tipoavaria";
            this.tipoavaria.ReadOnly = true;
            this.tipoavaria.Width = 53;
            // 
            // datafim
            // 
            this.datafim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datafim.HeaderText = "Data Saída";
            this.datafim.Name = "datafim";
            this.datafim.ReadOnly = true;
            this.datafim.Width = 87;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // avisos
            // 
            this.avisos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.avisos.HeaderText = "Avisos";
            this.avisos.Name = "avisos";
            this.avisos.ReadOnly = true;
            this.avisos.Width = 63;
            // 
            // pago
            // 
            this.pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Width = 57;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDefinirSaida,
            this.avisarClienteToolStripMenuItem,
            this.listaDeAvisosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 70);
            // 
            // btnDefinirSaida
            // 
            this.btnDefinirSaida.Name = "btnDefinirSaida";
            this.btnDefinirSaida.Size = new System.Drawing.Size(206, 22);
            this.btnDefinirSaida.Text = "Definir Saída/Pagamento";
            this.btnDefinirSaida.Click += new System.EventHandler(this.btnDefinirSaida_Click);
            // 
            // avisarClienteToolStripMenuItem
            // 
            this.avisarClienteToolStripMenuItem.Name = "avisarClienteToolStripMenuItem";
            this.avisarClienteToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.avisarClienteToolStripMenuItem.Text = "Avisar Cliente";
            this.avisarClienteToolStripMenuItem.Click += new System.EventHandler(this.avisarClienteToolStripMenuItem_Click);
            // 
            // listaDeAvisosToolStripMenuItem
            // 
            this.listaDeAvisosToolStripMenuItem.Name = "listaDeAvisosToolStripMenuItem";
            this.listaDeAvisosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.listaDeAvisosToolStripMenuItem.Text = "Lista de Avisos";
            this.listaDeAvisosToolStripMenuItem.Click += new System.EventHandler(this.listaDeAvisosToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(684, 571);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(570, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Gravar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDataRegisto);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtNumCliente);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(752, 42);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registo e Data";
            // 
            // txtDataRegisto
            // 
            this.txtDataRegisto.Enabled = false;
            this.txtDataRegisto.Location = new System.Drawing.Point(546, 16);
            this.txtDataRegisto.Name = "txtDataRegisto";
            this.txtDataRegisto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDataRegisto.Size = new System.Drawing.Size(117, 20);
            this.txtDataRegisto.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Data de registo";
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.Enabled = false;
            this.txtNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCliente.Location = new System.Drawing.Point(106, 16);
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.Size = new System.Drawing.Size(132, 20);
            this.txtNumCliente.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero de Cliente";
            // 
            // btnAssistencia
            // 
            this.btnAssistencia.Location = new System.Drawing.Point(15, 571);
            this.btnAssistencia.Name = "btnAssistencia";
            this.btnAssistencia.Size = new System.Drawing.Size(159, 23);
            this.btnAssistencia.TabIndex = 8;
            this.btnAssistencia.Text = "Nova Assistência";
            this.btnAssistencia.UseVisualStyleBackColor = true;
            this.btnAssistencia.Click += new System.EventHandler(this.btnAssistencia_Click);
            // 
            // numequip
            // 
            this.numequip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numequip.HeaderText = "Nº";
            this.numequip.Name = "numequip";
            this.numequip.Width = 40;
            // 
            // tipoequip
            // 
            this.tipoequip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipoequip.HeaderText = "Tipo";
            this.tipoequip.Name = "tipoequip";
            this.tipoequip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipoequip.Width = 53;
            // 
            // descr
            // 
            this.descr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descr.HeaderText = "Descrição";
            this.descr.Name = "descr";
            // 
            // serie
            // 
            this.serie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.serie.HeaderText = "Nº Série";
            this.serie.Name = "serie";
            this.serie.Width = 71;
            // 
            // pass
            // 
            this.pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pass.HeaderText = "Pass";
            this.pass.Name = "pass";
            this.pass.Width = 55;
            // 
            // tvid
            // 
            this.tvid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tvid.HeaderText = "TeamViewer Id";
            this.tvid.Name = "tvid";
            this.tvid.Width = 110;
            // 
            // tvpass
            // 
            this.tvpass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tvpass.HeaderText = "TeamViewer Pass";
            this.tvpass.Name = "tvpass";
            this.tvpass.Width = 120;
            // 
            // FichaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 605);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAssistencia);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(798, 644);
            this.MinimumSize = new System.Drawing.Size(798, 644);
            this.Name = "FichaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FichaCliente";
            this.Load += new System.EventHandler(this.FichaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.contextMenuEquipamentos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistencias)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSkypeCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelemovelCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCPCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoradaCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAssistencias;
        private System.Windows.Forms.Button btnSkype;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDataRegisto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDefinirSaida;
        private System.Windows.Forms.Button btnSaveEquip;
        private System.Windows.Forms.Button btnAssistencia;
        private System.Windows.Forms.ToolStripMenuItem avisarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAvisosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuEquipamentos;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn registo;
        private System.Windows.Forms.DataGridViewTextBoxColumn loja;
        private System.Windows.Forms.DataGridViewTextBoxColumn equip;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoavaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafim;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn avisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn numequip;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoequip;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvpass;
    }
}