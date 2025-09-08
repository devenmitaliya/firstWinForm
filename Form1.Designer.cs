namespace FirstWinForm;

partial class CalcDemo
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

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        this.label1 = new System.Windows.Forms.Label();
        this.label1.Location = new System.Drawing.Point(100, 100);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(100, 23);
        this.label1.Text = "Num 1";
        this.Controls.Add(this.label1);

        this.textbox1 = new System.Windows.Forms.TextBox();
        this.textbox1.Location = new System.Drawing.Point(200, 100);
        this.textbox1.Name = "txt1";
        this.textbox1.Size = new System.Drawing.Size(100, 23);
        this.Controls.Add(this.textbox1);

        this.label2 = new System.Windows.Forms.Label();
        this.label2.Location = new System.Drawing.Point(100, 140);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(100, 23);
        this.label2.Text = "Num 2";
        this.Controls.Add(this.label2);

        this.textbox2 = new System.Windows.Forms.TextBox();
        this.textbox2.Location = new System.Drawing.Point(200, 140);
        this.textbox2.Name = "txt2";
        this.textbox2.Size = new System.Drawing.Size(100, 23);
        this.Controls.Add(this.textbox2);


        this.label3 = new System.Windows.Forms.Label();
        this.label3.Location = new System.Drawing.Point(100, 180);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(100, 23);
        this.label3.Text = "Result";
        this.Controls.Add(this.label3);

        this.textbox3 = new System.Windows.Forms.TextBox();
        this.textbox3.Location = new System.Drawing.Point(200, 180);
        this.textbox3.Name = "txt3";
        this.textbox3.Size = new System.Drawing.Size(100, 23);
        this.Controls.Add(this.textbox3);

        this.btn_1 = new System.Windows.Forms.Button();
        this.btn_1.Location = new System.Drawing.Point(100, 220);
        this.btn_1.Name = "btn_1";
        this.btn_1.Size = new System.Drawing.Size(35, 23);
        this.btn_1.Text = "+";
        this.Controls.Add(this.btn_1);
        this.btn_1.Click += new System.EventHandler(this.button_Click);

        this.btn_2 = new System.Windows.Forms.Button();
        this.btn_2.Location = new System.Drawing.Point(140, 220);
        this.btn_2.Name = "btn_2";
        this.btn_2.Size = new System.Drawing.Size(35, 23);
        this.btn_2.Text = "-";
        this.Controls.Add(this.btn_2);
        this.btn_2.Click += new System.EventHandler(this.button_Click);

        this.btn_3 = new System.Windows.Forms.Button();
        this.btn_3.Location = new System.Drawing.Point(180, 220);
        this.btn_3.Name = "btn_3";
        this.btn_3.Size = new System.Drawing.Size(35, 23);
        this.btn_3.Text = "*";
        this.Controls.Add(this.btn_3);
        this.btn_3.Click += new System.EventHandler(this.button_Click);

        this.btn_4 = new System.Windows.Forms.Button();
        this.btn_4.Location = new System.Drawing.Point(220, 220);
        this.btn_4.Name = "btn_4";
        this.btn_4.Size = new System.Drawing.Size(35, 23);
        this.btn_4.Text = "/";
        this.Controls.Add(this.btn_4);
        this.btn_4.Click += new System.EventHandler(this.button_Click);
    }
    #endregion
    
}
