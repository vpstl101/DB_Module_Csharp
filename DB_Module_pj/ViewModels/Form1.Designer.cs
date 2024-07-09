namespace DB_Module_pj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_SignIn = new Button();
            btn_SignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtPWD = new TextBox();
            SuspendLayout();
            // 
            // btn_SignIn
            // 
            btn_SignIn.Location = new Point(79, 205);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new Size(75, 23);
            btn_SignIn.TabIndex = 0;
            btn_SignIn.Text = "로그인";
            btn_SignIn.UseVisualStyleBackColor = true;
            btn_SignIn.Click += btn_SignIn_Click;
            // 
            // btn_SignUp
            // 
            btn_SignUp.Location = new Point(182, 205);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(75, 23);
            btn_SignUp.TabIndex = 0;
            btn_SignUp.Text = "회원가입";
            btn_SignUp.UseVisualStyleBackColor = true;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 42);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "로그인";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 98);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 145);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 1;
            label3.Text = "PWD";
            // 
            // txtID
            // 
            txtID.Location = new Point(171, 95);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // txtPWD
            // 
            txtPWD.Location = new Point(171, 142);
            txtPWD.Name = "txtPWD";
            txtPWD.Size = new Size(100, 23);
            txtPWD.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 295);
            Controls.Add(txtPWD);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_SignUp);
            Controls.Add(btn_SignIn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_SignIn;
        private Button btn_SignUp;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtPWD;
    }
}
