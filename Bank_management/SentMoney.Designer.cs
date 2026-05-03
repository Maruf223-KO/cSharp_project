
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label_TitleSentMoney.Location = new System.Drawing.Point(13, 22);
            this.label_TitleSentMoney.Name = "label_TitleSentMoney";
            this.label_TitleSentMoney.Size = new System.Drawing.Size(174, 36);
            this.label_TitleSentMoney.TabIndex = 0;
            this.label_TitleSentMoney.Text = "Sent Money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // SentMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.top_Panel);
            this.Name = "SentMoney";
            this.Text = "SentMoney";
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_Panel;
        private System.Windows.Forms.Label label_TitleSentMoney;
        private System.Windows.Forms.Label label1;
    }
}