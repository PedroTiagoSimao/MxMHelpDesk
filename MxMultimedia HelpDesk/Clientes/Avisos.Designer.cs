namespace MxMultimedia_HelpDesk.Clientes
{
    partial class Avisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avisos));
            this.dgvAvisos = new System.Windows.Forms.DataGridView();
            this.registo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvisos
            // 
            this.dgvAvisos.AllowUserToAddRows = false;
            this.dgvAvisos.AllowUserToDeleteRows = false;
            this.dgvAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registo,
            this.aviso,
            this.email});
            this.dgvAvisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvisos.Location = new System.Drawing.Point(0, 0);
            this.dgvAvisos.Name = "dgvAvisos";
            this.dgvAvisos.ReadOnly = true;
            this.dgvAvisos.RowHeadersVisible = false;
            this.dgvAvisos.Size = new System.Drawing.Size(464, 249);
            this.dgvAvisos.TabIndex = 0;
            // 
            // registo
            // 
            this.registo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.registo.HeaderText = "Registo";
            this.registo.Name = "registo";
            this.registo.ReadOnly = true;
            this.registo.Width = 68;
            // 
            // aviso
            // 
            this.aviso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aviso.HeaderText = "Data de Aviso";
            this.aviso.Name = "aviso";
            this.aviso.ReadOnly = true;
            this.aviso.Width = 99;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Avisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 249);
            this.Controls.Add(this.dgvAvisos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avisos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Avisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn registo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}