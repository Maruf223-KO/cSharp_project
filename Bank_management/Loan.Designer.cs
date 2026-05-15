
namespace Bank_management
{
    partial class Loan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_grid_loan = new System.Windows.Forms.DataGridView();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Request = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_Duration = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.combobox_Duration = new System.Windows.Forms.ComboBox();
            this.btn_Request = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_loan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_grid_loan
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_loan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.data_grid_loan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid_loan.DefaultCellStyle = dataGridViewCellStyle14;
            this.data_grid_loan.Location = new System.Drawing.Point(56, 282);
            this.data_grid_loan.Name = "data_grid_loan";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_loan.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.data_grid_loan.RowHeadersWidth = 51;
            this.data_grid_loan.RowTemplate.Height = 24;
            this.data_grid_loan.Size = new System.Drawing.Size(707, 202);
            this.data_grid_loan.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(341, 251);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(148, 25);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "All loan status";
            // 
            // label_Request
            // 
            this.label_Request.AutoSize = true;
            this.label_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Request.Location = new System.Drawing.Point(64, 96);
            this.label_Request.Name = "label_Request";
            this.label_Request.Size = new System.Drawing.Size(144, 25);
            this.label_Request.TabIndex = 2;
            this.label_Request.Text = "Request loan ";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.Location = new System.Drawing.Point(64, 143);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(99, 25);
            this.label_Amount.TabIndex = 3;
            this.label_Amount.Text = "Amount :";
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Duration.Location = new System.Drawing.Point(497, 133);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(112, 25);
            this.label_Duration.TabIndex = 4;
            this.label_Duration.Text = "Duration : ";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(183, 137);
            this.txt_Amount.Multiline = true;
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 31);
            this.txt_Amount.TabIndex = 5;
            // 
            // combobox_Duration
            // 
            this.combobox_Duration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_Duration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_Duration.FormattingEnabled = true;
            this.combobox_Duration.Items.AddRange(new object[] {
            "3",
            "6 ",
            "12"});
            this.combobox_Duration.Location = new System.Drawing.Point(618, 133);
            this.combobox_Duration.Name = "combobox_Duration";
            this.combobox_Duration.Size = new System.Drawing.Size(75, 24);
            this.combobox_Duration.TabIndex = 6;
            // 
            // btn_Request
            // 
            this.btn_Request.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Request.Location = new System.Drawing.Point(648, 220);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(115, 47);
            this.btn_Request.TabIndex = 7;
            this.btn_Request.Text = "Request";
            this.btn_Request.UseVisualStyleBackColor = false;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Month";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 77);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loan";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_clear.Location = new System.Drawing.Point(527, 220);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(115, 47);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_back.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_back.Location = new System.Drawing.Point(69, 220);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 47);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 493);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Request);
            this.Controls.Add(this.combobox_Duration);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label_Duration);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label_Request);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.data_grid_loan);
            this.Name = "Loan";
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_loan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_loan;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Request;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.ComboBox combobox_Duration;
        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
    }
}