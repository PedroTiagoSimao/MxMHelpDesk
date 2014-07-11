namespace MxMultimedia_HelpDesk
{
    partial class Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.assistencias_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mxmultim_Assistencias = new MxMultimedia_HelpDesk.mxmultim_Assistencias();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.assistencias_viewTableAdapter = new MxMultimedia_HelpDesk.mxmultim_AssistenciasTableAdapters.assistencias_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assistencias_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_Assistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // assistencias_viewBindingSource
            // 
            this.assistencias_viewBindingSource.DataMember = "assistencias_view";
            this.assistencias_viewBindingSource.DataSource = this.mxmultim_Assistencias;
            this.assistencias_viewBindingSource.Filter = "";
            // 
            // mxmultim_Assistencias
            // 
            this.mxmultim_Assistencias.DataSetName = "mxmultim_Assistencias";
            this.mxmultim_Assistencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AssistenciasView_DataSet";
            reportDataSource1.Value = this.assistencias_viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MxMultimedia_HelpDesk.Reports.AssistA4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // assistencias_viewTableAdapter
            // 
            this.assistencias_viewTableAdapter.ClearBeforeFill = true;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assistencias_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_Assistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private mxmultim_Assistencias mxmultim_Assistencias;
        private mxmultim_AssistenciasTableAdapters.assistencias_viewTableAdapter assistencias_viewTableAdapter;
        private System.Windows.Forms.BindingSource assistencias_viewBindingSource;
    }
}