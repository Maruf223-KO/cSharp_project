
namespace Bank_management
{
    partial class SentMoney
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
            this.top_Panel = new System.Windows.Forms.Panel();
            this.label_TitleSentMoney = new System.Windows.Forms.Label();
            this.label_SelectAccount = new System.Windows.Forms.Label();
            this.label_TO = new System.Windows.Forms.Label();
            this.label_RecevierAccount = new System.Windows.Forms.Label();
            this.txt_ReceiverAccount = new System.Windows.Forms.TextBox();
            this.label_AccountFind = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.btn_Sent = new System.Windows.Forms.Button();
            this.label_Amount = new System.Windows.Forms.Label();
            this.txt_SenterAccount = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.top_Panel.Controls.Add(this.label_TitleSentMoney);
            this.top_Panel.Location = new System.Drawing.Point(-1, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(802, 92);
            this.top_Panel.TabIndex = 0;
            // 
            // label_TitleSentMoney
            // 
            this.label_TitleSentMoney.AutoSize = true;
            this.label_TitleSentMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleSentMoney.Location = new System.Drawing.Point(13, 28);
            this.label_TitleSentMoney.Name = "label_TitleSentMoney";
            this.label_TitleSentMoney.Size = new System.Drawing.Size(174, 36);
            this.label_TitleSentMoney.TabIndex = 0;
            this.label_TitleSentMoney.Text = "Sent Money";
            // 
            // label_SelectAccount
            // 
            this.label_SelectAccount.AutoSize = true;
            this.label_SelectAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectAccount.Location = new System.Drawing.Point(75, 160);
            this.label_SelectAccount.Name = "label_SelectAccount";
            this.label_SelectAccount.Size = new System.Drawing.Size(142, 25);
            this.label_SelectAccount.TabIndex = 1;
            this.label_SelectAccount.Text = "Your Account";
            // 
            // label_TO
            // 
            this.label_TO.AutoSize = true;
            this.label_TO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TO.Location = new System.Drawing.Point(322, 220);
            this.label_TO.Name = "label_TO";
            this.label_TO.Size = new System.Drawing.Size(39, 24);
            this.label_TO.TabIndex = 2;
            this.label_TO.Text = "TO";
            // 
            // label_RecevierAccount
            // 
            this.label_RecevierAccount.AutoSize = true;
            this.label_RecevierAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RecevierAccount.Location = new System.Drawing.Point(425, 160);
            this.label_RecevierAccount.Name = "label_RecevierAccount";
            this.label_RecevierAccount.Size = new System.Drawing.Size(226, 25);
            this.label_RecevierAccount.TabIndex = 3;
            this.label_RecevierAccount.Text = "Write Account number";
            // 
            // txt_ReceiverAccount
            // 
            this.txt_ReceiverAccount.Location = new System.Drawing.Point(430, 214);
            this.txt_ReceiverAccount.Multiline = true;
            this.txt_ReceiverAccount.Name = "txt_ReceiverAccount";
            this.txt_ReceiverAccount.Size = new System.Drawing.Size(185, 30);
            this.txt_ReceiverAccount.TabIndex = 4;
            // 
            // label_AccountFind
            // 
            this.label_AccountFind.AutoSize = true;
            this.label_AccountFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountFind.Location = new System.Drawing.Point(621, 224);
            this.label_AccountFind.Name = "label_AccountFind";
            this.label_AccountFind.Size = new System.Drawing.Size(23, 20);
            this.label_AccountFind.TabIndex = 5;
            this.label_AccountFind.Text = "\"\"";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(432, 311);
            this.txt_Amount.Multiline = true;
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(185, 30);
            this.txt_Amount.TabIndex = 6;
            // 
            // btn_Sent
            // 
            this.btn_Sent.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Sent.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Sent.Location = new System.Drawing.Point(660, 379);
            this.btn_Sent.Name = "btn_Sent";
            this.btn_Sent.Size = new System.Drawing.Size(115, 47);
            this.btn_Sent.TabIndex = 7;
            this.btn_Sent.Text = "Sent";
            this.btn_Sent.UseVisualStyleBackColor = false;
            this.btn_Sent.Click += new System.EventHandler(this.btn_Sent_Click);
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.Location = new System.Drawing.Point(427, 255);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(153, 25);
            this.label_Amount.TabIndex = 8;
            this.label_Amount.Text = "Select Amount";
            // 
            // txt_SenterAccount
            // 
            this.txt_SenterAccount.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_SenterAccount.Location = new System.Drawing.Point(80, 220);
            this.txt_SenterAccount.Multiline = true;
            this.txt_SenterAccount.Name = "txt_SenterAccount";
            this.txt_SenterAccount.ReadOnly = true;
            this.txt_SenterAccount.Size = new System.Drawing.Size(185, 30);
            this.txt_SenterAccount.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_clear.Location = new System.Drawing.Point(500, 379);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(115, 47);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_back.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_back.Location = new System.Drawing.Point(80, 379);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 47);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SentMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_SenterAccount);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.btn_Sent);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label_AccountFind);
            this.Controls.Add(this.txt_ReceiverAccount);
            this.Controls.Add(this.label_RecevierAccount);
            this.Controls.Add(this.label_TO);
            this.Controls.Add(this.label_SelectAccount);
            this.Controls.Add(this.top_Panel);
            this.Name = "SentMoney";
            this.Text = "SentMoney";
            this.Load += new System.EventHandler(this.SentMoney_Load);
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_Panel;
        private System.Windows.Forms.Label label_TitleSentMoney;
        private System.Windows.Forms.Label label_SelectAccount;
        private System.Windows.Forms.Label label_TO;
        private System.Windows.Forms.Label label_RecevierAccount;
        private System.Windows.Forms.TextBox txt_ReceiverAccount;
        private System.Windows.Forms.Label label_AccountFind;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Button btn_Sent;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.TextBox txt_SenterAccount;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
    }
}