
namespace Bank_management
{
    partial class CustomerDeposit
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
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(164, 128);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(75, 39);
            this.btn_50.TabIndex = 3;
            this.btn_50.Text = "50";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.Location = new System.Drawing.Point(164, 195);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(75, 39);
            this.btn_100.TabIndex = 4;
            this.btn_100.Text = "100";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_500
            // 
            this.btn_500.Location = new System.Drawing.Point(164, 274);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(75, 39);
            this.btn_500.TabIndex = 5;
            this.btn_500.Text = "500";
            this.btn_500.UseVisualStyleBackColor = true;
            this.btn_500.Click += new System.EventHandler(this.btn_500_Click);
            // 
            // btn_1000
            // 
            this.btn_1000.Location = new System.Drawing.Point(164, 345);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(75, 39);
            this.btn_1000.TabIndex = 6;
            this.btn_1000.Text = "1000";
            this.btn_1000.UseVisualStyleBackColor = true;
            this.btn_1000.Click += new System.EventHandler(this.btn_1000_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount: ";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(404, 231);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(125, 36);
            this.txt_amount.TabIndex = 8;
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_deposit.Location = new System.Drawing.Point(621, 359);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(121, 47);
            this.btn_deposit.TabIndex = 9;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 83);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Deposit";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(482, 359);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(121, 47);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Aqua;
            this.btn_back.Location = new System.Drawing.Point(18, 359);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 47);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CustomerDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_1000);
            this.Controls.Add(this.btn_500);
            this.Controls.Add(this.btn_100);
            this.Controls.Add(this.btn_50);
            this.Name = "CustomerDeposit";
            this.Text = "CustomerDeposit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.Button btn_1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
    }
}