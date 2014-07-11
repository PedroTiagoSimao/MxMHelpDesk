namespace MxMultimedia_HelpDesk
{
    partial class P_CLientesFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_CLientesFiltro));
            this.rLocal = new System.Windows.Forms.RadioButton();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cAll = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rLocal
            // 
            this.rLocal.AutoSize = true;
            this.rLocal.Location = new System.Drawing.Point(12, 36);
            this.rLocal.Name = "rLocal";
            this.rLocal.Size = new System.Drawing.Size(77, 17);
            this.rLocal.TabIndex = 2;
            this.rLocal.Text = "Localidade";
            this.rLocal.UseVisualStyleBackColor = true;
            this.rLocal.CheckedChanged += new System.EventHandler(this.Localidade_CheckedChanged);
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Enabled = false;
            this.txtLocalidade.Location = new System.Drawing.Point(95, 35);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(113, 20);
            this.txtLocalidade.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(133, 61);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cAll
            // 
            this.cAll.AutoSize = true;
            this.cAll.Checked = true;
            this.cAll.Location = new System.Drawing.Point(12, 10);
            this.cAll.Name = "cAll";
            this.cAll.Size = new System.Drawing.Size(55, 17);
            this.cAll.TabIndex = 7;
            this.cAll.TabStop = true;
            this.cAll.Text = "Todas";
            this.cAll.UseVisualStyleBackColor = true;
            this.cAll.CheckedChanged += new System.EventHandler(this.cAll_CheckedChanged);
            // 
            // P_CLientesFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 98);
            this.Controls.Add(this.cAll);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtLocalidade);
            this.Controls.Add(this.rLocal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P_CLientesFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Localidade";
            this.Load += new System.EventHandler(this.P_FiltroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rLocal;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton cAll;
    }
}