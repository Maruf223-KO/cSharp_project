
namespace Bank_management
{
    partial class CustomerCard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_request = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_radio_debit = new System.Windows.Forms.RadioButton();
            this.btn_radio_credit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_request
            // 
            this.btn_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_request.Location = new System.Drawing.Point(529, 160);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(120, 39);
            this.btn_request.TabIndex = 1;
            this.btn_request.Text = "Request";
            this.btn_request.UseVisualStyleBackColor = true;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card type";
            // 
            // btn_radio_debit
            // 
            this.btn_radio_debit.AutoSize = true;
            this.btn_radio_debit.Location = new System.Drawing.Point(95, 90);
            this.btn_radio_debit.Name = "btn_radio_debit";
            this.btn_radio_debit.Size = new System.Drawing.Size(96, 21);
            this.btn_radio_debit.TabIndex = 3;
            this.btn_radio_debit.TabStop = true;
            this.btn_radio_debit.Text = "Debit Card";
            this.btn_radio_debit.UseVisualStyleBackColor = true;
            // 
            // btn_radio_credit
            // 
            this.btn_radio_credit.AutoSize = true;
            this.btn_radio_credit.Location = new System.Drawing.Point(95, 131);
            this.btn_radio_credit.Name = "btn_radio_credit";
            this.btn_radio_credit.Size = new System.Drawing.Size(100, 21);
            this.btn_radio_credit.TabIndex = 4;
            this.btn_radio_credit.TabStop = true;
            this.btn_radio_credit.Text = "Credit Card";
            this.btn_radio_credit.UseVisualStyleBackColor = true;
            // 
            // CustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_radio_credit);
            this.Controls.Add(this.btn_radio_debit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerCard";
            this.Text = "CustomerCard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btn_radio_debit;
        private System.Windows.Forms.RadioButton btn_radio_credit;
    }
}