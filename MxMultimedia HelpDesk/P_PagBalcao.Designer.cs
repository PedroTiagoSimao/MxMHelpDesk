namespace MxMultimedia_HelpDesk
{
    partial class P_PagBalcao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_PagBalcao));
            this.PagBalcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mxmultim_PagBalcao = new MxMultimedia_HelpDesk.mxmultim_PagBalcao();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PagBalcaoTableAdapter = new MxMultimedia_HelpDesk.mxmultim_PagBalcaoTableAdapters.PagBalcaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PagBalcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_PagBalcao)).BeginInit();
            this.SuspendLayout();
            // 
            // PagBalcaoBindingSource
            // 
            this.PagBalcaoBindingSource.DataMember = "PagBalcao";
            this.PagBalcaoBindingSource.DataSource = this.mxmultim_PagBalcao;
            // 
            // mxmultim_PagBalcao
            // 
            this.mxmultim_PagBalcao.DataSetName = "mxmultim_PagBalcao";
            this.mxmultim_PagBalcao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PagBalcao";
            reportDataSource1.Value = this.PagBalcaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MxMultimedia_HelpDesk.Reports.PagBalcao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // PagBalcaoTableAdapter
            // 
            this.PagBalcaoTableAdapter.ClearBeforeFill = true;
            // 
            // P_PagBalcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 452);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_PagBalcao";
            this.Text = "P_PagBalcao";
            this.Load += new System.EventHandler(this.P_PagBalcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PagBalcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_PagBalcao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagBalcaoBindingSource;
        private mxmultim_PagBalcao mxmultim_PagBalcao;
        private mxmultim_PagBalcaoTableAdapters.PagBalcaoTableAdapter PagBalcaoTableAdapter;
    }
}