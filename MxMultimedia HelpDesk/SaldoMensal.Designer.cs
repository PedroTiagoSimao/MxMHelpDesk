namespace MxMultimedia_HelpDesk
{
    partial class SaldoMensal
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
            this.lblMes = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnChangeTarget = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.Black;
            this.lblMes.Location = new System.Drawing.Point(4, -2);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(129, 39);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Outubro";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldo.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.ForeColor = System.Drawing.Color.Maroon;
            this.txtSaldo.Location = new System.Drawing.Point(12, 42);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(233, 66);
            this.txtSaldo.TabIndex = 1;
            this.txtSaldo.Text = "-4.000,00";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChangeTarget
            // 
            this.btnChangeTarget.Location = new System.Drawing.Point(138, 111);
            this.btnChangeTarget.Name = "btnChangeTarget";
            this.btnChangeTarget.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTarget.TabIndex = 2;
            this.btnChangeTarget.Text = "Alterar";
            this.btnChangeTarget.UseVisualStyleBackColor = true;
            this.btnChangeTarget.Visible = false;
            this.btnChangeTarget.Click += new System.EventHandler(this.btnChangeTarget_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MxMultimedia_HelpDesk.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(12, 111);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SaldoMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 139);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnChangeTarget);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaldoMensal";
            this.Text = "Target Mensal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SaldoMensal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnChangeTarget;
        private System.Windows.Forms.Button btnRefresh;
    }
}