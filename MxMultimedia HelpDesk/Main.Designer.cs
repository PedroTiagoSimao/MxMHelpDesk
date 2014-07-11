namespace MxMultimedia_HelpDesk
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalheAssistênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totaisServiçosComponentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoja = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusLojaLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusLoja = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaldoBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem1,
            this.clientesToolStripMenuItem1,
            this.pagamentosToolStripMenuItem,
            this.mapasToolStripMenuItem,
            this.sairToolStripMenuItem1,
            this.pagToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(984, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem1
            // 
            this.ficheiroToolStripMenuItem1.Image = global::MxMultimedia_HelpDesk.Properties.Resources.configuration_settings;
            this.ficheiroToolStripMenuItem1.Name = "ficheiroToolStripMenuItem1";
            this.ficheiroToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.ficheiroToolStripMenuItem1.Text = "Assistencias";
            this.ficheiroToolStripMenuItem1.Click += new System.EventHandler(this.ficheiroToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Image = global::MxMultimedia_HelpDesk.Properties.Resources.desktop;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Image = global::MxMultimedia_HelpDesk.Properties.Resources.rich_text_format;
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            this.pagamentosToolStripMenuItem.Click += new System.EventHandler(this.pagamentosToolStripMenuItem_Click);
            // 
            // mapasToolStripMenuItem
            // 
            this.mapasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalheAssistênciasToolStripMenuItem,
            this.totaisServiçosComponentesToolStripMenuItem,
            this.btnListaClientes});
            this.mapasToolStripMenuItem.Image = global::MxMultimedia_HelpDesk.Properties.Resources.write_document;
            this.mapasToolStripMenuItem.Name = "mapasToolStripMenuItem";
            this.mapasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mapasToolStripMenuItem.Text = "Mapas";
            // 
            // detalheAssistênciasToolStripMenuItem
            // 
            this.detalheAssistênciasToolStripMenuItem.Name = "detalheAssistênciasToolStripMenuItem";
            this.detalheAssistênciasToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.detalheAssistênciasToolStripMenuItem.Text = "Detalhe Assistências";
            this.detalheAssistênciasToolStripMenuItem.Click += new System.EventHandler(this.detalheAssistênciasToolStripMenuItem_Click);
            // 
            // totaisServiçosComponentesToolStripMenuItem
            // 
            this.totaisServiçosComponentesToolStripMenuItem.Name = "totaisServiçosComponentesToolStripMenuItem";
            this.totaisServiçosComponentesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.totaisServiçosComponentesToolStripMenuItem.Text = "Totais Serviços/Componentes";
            this.totaisServiçosComponentesToolStripMenuItem.Click += new System.EventHandler(this.totaisServiçosComponentesToolStripMenuItem_Click);
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(232, 22);
            this.btnListaClientes.Text = "Lista de Clientes";
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click_1);
            // 
            // pagToolStripMenuItem
            // 
            this.pagToolStripMenuItem.Name = "pagToolStripMenuItem";
            this.pagToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.pagToolStripMenuItem.Text = "pag";
            this.pagToolStripMenuItem.Visible = false;
            this.pagToolStripMenuItem.Click += new System.EventHandler(this.pagToolStripMenuItem_Click);
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // assistênciasToolStripMenuItem
            // 
            this.assistênciasToolStripMenuItem.Name = "assistênciasToolStripMenuItem";
            this.assistênciasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assistênciasToolStripMenuItem.Text = "Assistência";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aToolStripMenuItem.Text = "Listagem";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblLoja,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 740);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "Loja:";
            // 
            // lblLoja
            // 
            this.lblLoja.Name = "lblLoja";
            this.lblLoja.Size = new System.Drawing.Size(16, 17);
            this.lblLoja.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel3.Text = "Utilizador:";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(16, 17);
            this.lblUser.Text = "...";
            // 
            // lblStatusUserLabel
            // 
            this.lblStatusUserLabel.Name = "lblStatusUserLabel";
            this.lblStatusUserLabel.Size = new System.Drawing.Size(60, 17);
            this.lblStatusUserLabel.Text = "Utilizador:";
            // 
            // lblStatusUser
            // 
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(0, 17);
            // 
            // lblStatusLojaLabel
            // 
            this.lblStatusLojaLabel.Name = "lblStatusLojaLabel";
            this.lblStatusLojaLabel.Size = new System.Drawing.Size(32, 17);
            this.lblStatusLojaLabel.Text = "Loja:";
            // 
            // lblStatusLoja
            // 
            this.lblStatusLoja.Name = "lblStatusLoja";
            this.lblStatusLoja.Size = new System.Drawing.Size(0, 17);
            // 
            // SaldoBackgroundWorker
            // 
            this.SaldoBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SaldoBackgroundWorker_DoWork);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MxMultimedia_HelpDesk.Properties.Resources.logo_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MxMultimédia HelpDesk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUserLabel;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusLojaLabel;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusLoja;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoja;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mapasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalheAssistênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totaisServiçosComponentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnListaClientes;
        private System.Windows.Forms.ToolStripMenuItem pagToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker SaldoBackgroundWorker;
    }
}

