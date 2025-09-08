namespace LoginForm
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
             this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
             this.label7 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
             this.errorProvider = new ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
           #region  // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604,25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ready to Login";
            // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            #endregion
            #region // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            //
            #endregion 
            #region // textBox1
            // 
             this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
             this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.textBox1.Location = new System.Drawing.Point(564,145);
             this.textBox1.Name = "textBox1";
             this.textBox1.Size = new System.Drawing.Size(285, 36);
             this.textBox1.TabIndex = 3;
             this.textBox1.TextChanged += TextBox1_TextChanged;
             this.textBox1.KeyUp+=textBox1_KeyUp;// Add event handler for text change

        // Set properties for errorProvider
        this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        this.errorProvider.ContainerControl = this;

        // Add controls to the form
        this.Controls.Add(this.textBox1);
            // 
            #endregion
           #region  // label3
            // 
            // this.label3.AutoSize = true;
            // this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.label3.Location = new System.Drawing.Point(303, 233);
            // this.label3.Name = "label3";
            // this.label3.Size = new System.Drawing.Size(0, 17);
            // this.label3.TabIndex = 4;
            //
            #endregion 
           #region  // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password : ";
            
            // 
            #endregion
           #region  // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(564, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 36);
            this.textBox2.TabIndex = 8;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.KeyUp+=textBox2_KeyUp;
            #endregion
            #region // eye icon
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.pictureBoxEye.Image = System.Drawing.Image.FromFile("closeeye.png"); // Replace with your eye icon image
            this.pictureBoxEye.Location = new System.Drawing.Point(850,254);
            this.pictureBoxEye.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEye.Click += new System.EventHandler(this.pictureBoxEye_Click);

            this.Controls.Add(this.pictureBoxEye);
            #endregion
            #region // pictureBox1
            // 
            this.pictureBox1.Image = System.Drawing.Image.FromFile("ss1.png");
            this.pictureBox1.Location = new System.Drawing.Point(129,65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            #endregion
           #region  // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(727, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 18);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password ?";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_LinkClicked);
            // 
            #endregion
            this.lblMessage = new System.Windows.Forms.Label();
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red; // You can set the color as needed
            this.label6.Location = new System.Drawing.Point(564, 296); // Adjust the position
            this.label6.Name = "lblMessage";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.lblMessage.TabIndex = 6;
            this.Controls.Add(this.lblMessage);
//label 7
//this.lblMessage = new System.Windows.Forms.Label();
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red; // You can set the color as needed
            this.label7.Location = new System.Drawing.Point(564, 184); // Adjust the position
            this.label7.Name = "lblMessage";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.lblMessage.TabIndex = 6;
            this.Controls.Add(this.lblMessage);



           #region  // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Don't have an account?";
            // 
            #endregion
           #region  // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(564, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click); 
            // 
            #endregion
           #region  // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(766, 434);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(57, 18);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sign up";
            // 
            #endregion
             // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 483);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
             this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private ErrorProvider errorProvider;
        // private ErrorProvider errorProvider2;
        private bool isPasswordVisible = false;

// Inside the InitializeComponent method, after initializing other controls:
// Add PictureBox for the eye icon
private System.Windows.Forms.PictureBox pictureBoxEye;
    }
}