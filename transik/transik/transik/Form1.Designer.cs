namespace transik
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
            this.label1 = new System.Windows.Forms.Label();
            this.eth = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loguj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // eth
            // 
            this.eth.AutoSize = true;
            this.eth.Location = new System.Drawing.Point(25, 107);
            this.eth.Name = "eth";
            this.eth.Size = new System.Drawing.Size(60, 15);
            this.eth.TabIndex = 1;
            this.eth.Text = "Password:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(16, 54);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(137, 23);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(14, 130);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(141, 23);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // loguj
            // 
            this.loguj.Location = new System.Drawing.Point(59, 190);
            this.loguj.Name = "loguj";
            this.loguj.Size = new System.Drawing.Size(86, 22);
            this.loguj.TabIndex = 5;
            this.loguj.Text = "zaloguj";
            this.loguj.UseVisualStyleBackColor = true;
            this.loguj.Click += new System.EventHandler(this.loguj_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 29F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.MinimumSize = new System.Drawing.Size(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 94);
            this.label2.TabIndex = 20;
            this.label2.Text = "FOOTBALLMARKET";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::transik.Properties.Resources.FT;
            this.pictureBox2.Location = new System.Drawing.Point(398, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 361);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "załóż konto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loguj);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.eth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label eth;
        private TextBox login;
        private TextBox password;
        private Button loguj;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button1;
    }
}