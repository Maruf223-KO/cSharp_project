
namespace Bank_management
{
    partial class EmployeeLoan
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
            this.datagridloanemployee = new System.Windows.Forms.DataGridView();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridloanemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridloanemployee
            // 
            this.datagridloanemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridloanemployee.Location = new System.Drawing.Point(110, 210);
            this.datagridloanemployee.Name = "datagridloanemployee";
            this.datagridloanemployee.RowHeadersWidth = 51;
            this.datagridloanemployee.RowTemplate.Height = 24;
            this.datagridloanemployee.Size = new System.Drawing.Size(541, 184);
            this.datagridloanemployee.TabIndex = 0;
            this.datagridloanemployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridloanemployee_CellClick);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(137, 122);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 39);
            this.btn_accept.TabIndex = 1;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.Location = new System.Drawing.Point(563, 122);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(75, 39);
            this.btn_reject.TabIndex = 2;
            this.btn_reject.Text = "Reject";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // EmployeeLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.datagridloanemployee);
            this.Name = "EmployeeLoan";
            this.Text = "EmployeeLoan";
            this.Load += new System.EventHandler(this.EmployeeLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridloanemployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridloanemployee;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_reject;
    }
}