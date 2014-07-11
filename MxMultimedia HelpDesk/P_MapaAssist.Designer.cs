namespace MxMultimedia_HelpDesk
{
    partial class P_MapaAssist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_MapaAssist));
            this.mapaassist_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mxmultim_MapaAssist = new MxMultimedia_HelpDesk.mxmultim_MapaAssist();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mapaassist_viewTableAdapter = new MxMultimedia_HelpDesk.mxmultim_MapaAssistTableAdapters.mapaassist_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mapaassist_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_MapaAssist)).BeginInit();
            this.SuspendLayout();
            // 
            // mapaassist_viewBindingSource
            // 
            this.mapaassist_viewBindingSource.DataMember = "mapaassist_view";
            this.mapaassist_viewBindingSource.DataSource = this.mxmultim_MapaAssist;
            // 
            // mxmultim_MapaAssist
            // 
            this.mxmultim_MapaAssist.DataSetName = "mxmultim_MapaAssist";
            this.mxmultim_MapaAssist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MapaAssist";
            reportDataSource1.Value = this.mapaassist_viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MxMultimedia_HelpDesk.Reports.MapaAssist.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // mapaassist_viewTableAdapter
            // 
            this.mapaassist_viewTableAdapter.ClearBeforeFill = true;
            // 
            // P_MapaAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 452);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_MapaAssist";
            this.Text = "P_MapaAssist";
            this.Load += new System.EventHandler(this.P_MapaAssist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapaassist_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxmultim_MapaAssist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mapaassist_viewBindingSource;
        private mxmultim_MapaAssist mxmultim_MapaAssist;
        private mxmultim_MapaAssistTableAdapters.mapaassist_viewTableAdapter mapaassist_viewTableAdapter;
    }
}