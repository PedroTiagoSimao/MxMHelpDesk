namespace MxMultimedia_HelpDesk
{
    partial class P_TotalServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_TotalServicos));
            this.totalassist_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mxmultim_TotalAssist = new MxMultimedia_HelpDesk.mxmultim_TotalAssist();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.totalassist_viewTableAdapter = new MxMultimedia_HelpDesk.mxmultim_TotalAssistTableAdapters.totalassist_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.totalassist_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_TotalAssist)).BeginInit();
            this.SuspendLayout();
            // 
            // totalassist_viewBindingSource
            // 
            this.totalassist_viewBindingSource.DataMember = "totalassist_view";
            this.totalassist_viewBindingSource.DataSource = this.mxmultim_TotalAssist;
            // 
            // mxmultim_TotalAssist
            // 
            this.mxmultim_TotalAssist.DataSetName = "mxmultim_TotalAssist";
            this.mxmultim_TotalAssist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TotalAssit";
            reportDataSource1.Value = this.totalassist_viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MxMultimedia_HelpDesk.Reports.TotalServicos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // totalassist_viewTableAdapter
            // 
            this.totalassist_viewTableAdapter.ClearBeforeFill = true;
            // 
            // P_TotalServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 452);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_TotalServicos";
            this.Text = "P_TotalServicos";
            this.Load += new System.EventHandler(this.P_TotalServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalassist_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_TotalAssist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource totalassist_viewBindingSource;
        private mxmultim_TotalAssist mxmultim_TotalAssist;
        private mxmultim_TotalAssistTableAdapters.totalassist_viewTableAdapter totalassist_viewTableAdapter;
    }
}