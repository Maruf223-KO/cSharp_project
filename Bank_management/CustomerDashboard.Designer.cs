
namespace Bank_management
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Balance = new System.Windows.Forms.Label();
            this.label_customername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SentMoney = new System.Windows.Forms.Button();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Card = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_Transcation = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label_Balance);
            this.panel1.Controls.Add(this.label_customername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 112);
            this.panel1.TabIndex = 0;
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.BackColor = System.Drawing.Color.White;
            this.label_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Balance.Location = new System.Drawing.Point(99, 60);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(179, 24);
            this.label_Balance.TabIndex = 2;
            this.label_Balance.Text = "Click to see Balance";
            this.label_Balance.Click += new System.EventHandler(this.label_Balance_Click);
            // 
            // label_customername
            // 
            this.label_customername.AutoSize = true;
            this.label_customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customername.Location = new System.Drawing.Point(98, 19);
            this.label_customername.Name = "label_customername";
            this.label_customername.Size = new System.Drawing.Size(31, 29);
            this.label_customername.TabIndex = 1;
            this.label_customername.Text = "\"\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SentMoney
            // 
            this.btn_SentMoney.Image = ((System.Drawing.Image)(resources.GetObject("btn_SentMoney.Image")));
            this.btn_SentMoney.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SentMoney.Location = new System.Drawing.Point(85, 203);
            this.btn_SentMoney.Name = "btn_SentMoney";
            this.btn_SentMoney.Size = new System.Drawing.Size(138, 83);
            this.btn_SentMoney.TabIndex = 1;
            this.btn_SentMoney.Text = "Sent money";
            this.btn_SentMoney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SentMoney.UseVisualStyleBackColor = true;
            this.btn_SentMoney.Click += new System.EventHandler(this.btn_SentMoney_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.Image = ((System.Drawing.Image)(resources.GetObject("btn_Loan.Image")));
            this.btn_Loan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Loan.Location = new System.Drawing.Point(410, 203);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(138, 83);
            this.btn_Loan.TabIndex = 2;
            this.btn_Loan.Text = "Loan";
            this.btn_Loan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Image = ((System.Drawing.Image)(resources.GetObject("btn_Withdraw.Image")));
            this.btn_Withdraw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Withdraw.Location = new System.Drawing.Point(734, 203);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(138, 83);
            this.btn_Withdraw.TabIndex = 3;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Card
            // 
            this.btn_Card.Image = ((System.Drawing.Image)(resources.GetObject("btn_Card.Image")));
            this.btn_Card.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Card.Location = new System.Drawing.Point(85, 368);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(138, 83);
            this.btn_Card.TabIndex = 4;
            this.btn_Card.Text = "Card";
            this.btn_Card.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Card.UseVisualStyleBackColor = true;
            // 
            // btn_deposit
            // 
            this.btn_deposit.Image = ((System.Drawing.Image)(resources.GetObject("btn_deposit.Image")));
            this.btn_deposit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deposit.Location = new System.Drawing.Point(410, 368);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(138, 83);
            this.btn_deposit.TabIndex = 5;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_Transcation
            // 
            this.btn_Transcation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Transcation.Image")));
            this.btn_Transcation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Transcation.Location = new System.Drawing.Point(734, 368);
            this.btn_Transcation.Name = "btn_Transcation";
            this.btn_Transcation.Size = new System.Drawing.Size(138, 83);
            this.btn_Transcation.TabIndex = 6;
            this.btn_Transcation.Text = "Trasncation Histroy";
            this.btn_Transcation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Transcation.UseVisualStyleBackColor = true;
            this.btn_Transcation.Click += new System.EventHandler(this.btn_Transcation_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 540);
            this.Controls.Add(this.btn_Transcation);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.btn_Card);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_Loan);
            this.Controls.Add(this.btn_SentMoney);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_customername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SentMoney;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Card;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_Transcation;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Timer timer1;
    }
}