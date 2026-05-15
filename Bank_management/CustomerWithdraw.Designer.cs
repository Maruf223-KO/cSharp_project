
namespace Bank_management
{
    partial class CustomerWithdraw
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label_balance = new System.Windows.Forms.Label();
            this.label_show_balance = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount: ";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(375, 236);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(139, 35);
            this.txt_amount.TabIndex = 1;
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(155, 121);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(75, 39);
            this.btn_50.TabIndex = 2;
            this.btn_50.Text = "50";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.Location = new System.Drawing.Point(155, 200);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(75, 39);
            this.btn_100.TabIndex = 3;
            this.btn_100.Text = "100";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_500
            // 
            this.btn_500.Location = new System.Drawing.Point(155, 281);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(75, 39);
            this.btn_500.TabIndex = 4;
            this.btn_500.Text = "500";
            this.btn_500.UseVisualStyleBackColor = true;
            this.btn_500.Click += new System.EventHandler(this.btn_500_Click);
            // 
            // btn_1000
            // 
            this.btn_1000.Location = new System.Drawing.Point(155, 365);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(75, 39);
            this.btn_1000.TabIndex = 5;
            this.btn_1000.Text = "1000";
            this.btn_1000.UseVisualStyleBackColor = true;
            this.btn_1000.Click += new System.EventHandler(this.btn_1000_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_withdraw.Location = new System.Drawing.Point(648, 363);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(112, 43);
            this.btn_withdraw.TabIndex = 6;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 87);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Withdraw";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(507, 363);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 43);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_balance.Location = new System.Drawing.Point(415, 101);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(204, 25);
            this.label_balance.TabIndex = 9;
            this.label_balance.Text = "Available Balance : ";
            // 
            // label_show_balance
            // 
            this.label_show_balance.AutoSize = true;
            this.label_show_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_balance.Location = new System.Drawing.Point(625, 101);
            this.label_show_balance.Name = "label_show_balance";
            this.label_show_balance.Size = new System.Drawing.Size(28, 25);
            this.label_show_balance.TabIndex = 10;
            this.label_show_balance.Text = "\"\"";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Aqua;
            this.btn_back.Location = new System.Drawing.Point(12, 365);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 43);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CustomerWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label_show_balance);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_1000);
            this.Controls.Add(this.btn_500);
            this.Controls.Add(this.btn_100);
            this.Controls.Add(this.btn_50);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label1);
            this.Name = "CustomerWithdraw";
            this.Text = "CustomerWithdraw";
            this.Load += new System.EventHandler(this.CustomerWithdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.Button btn_1000;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_show_balance;
        private System.Windows.Forms.Button btn_back;
    }
}