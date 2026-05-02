
namespace Bank_management
{
    partial class SignUp
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
            this.label_signUp = new System.Windows.Forms.Label();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.label_userId = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_signUp
            // 
            this.label_signUp.AutoSize = true;
            this.label_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signUp.Location = new System.Drawing.Point(323, 43);
            this.label_signUp.Name = "label_signUp";
            this.label_signUp.Size = new System.Drawing.Size(106, 29);
            this.label_signUp.TabIndex = 0;
            this.label_signUp.Text = "Sign Up";
            // 
            // txt_UserId
            // 
            this.txt_UserId.ForeColor = System.Drawing.Color.Black;
            this.txt_UserId.Location = new System.Drawing.Point(328, 142);
            this.txt_UserId.Multiline = true;
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(123, 29);
            this.txt_UserId.TabIndex = 1;
            this.txt_UserId.Text = "Choose user ID";
            
            this.txt_UserId.Leave += new System.EventHandler(this.txt_UserId_Leave);
            // 
            // label_userId
            // 
            this.label_userId.AutoSize = true;
            this.label_userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userId.Location = new System.Drawing.Point(191, 142);
            this.label_userId.Name = "label_userId";
            this.label_userId.Size = new System.Drawing.Size(114, 29);
            this.label_userId.TabIndex = 2;
            this.label_userId.Text = "User ID :";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(191, 204);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(128, 29);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(328, 204);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(123, 29);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.Text = "Choose Password";
            // 
            // btn_Signup
            // 
            this.btn_Signup.Location = new System.Drawing.Point(350, 284);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(101, 47);
            this.btn_Signup.TabIndex = 5;
            this.btn_Signup.Text = "Sign Up";
            this.btn_Signup.UseVisualStyleBackColor = true;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(204, 284);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(101, 47);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Status.Location = new System.Drawing.Point(457, 152);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 17);
            this.label_Status.TabIndex = 7;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_userId);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.label_signUp);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_signUp;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Label label_userId;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label_Status;
    }
}