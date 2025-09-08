namespace FirstWinForm;
using WinFormLabel = System.Windows.Forms.Label;
partial class CRUDdemo
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
        this.Text = "CRUDdemo";

        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        textBox5 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button10 = new Button();
        button11 = new Button();
        button12 = new Button();

        dataGridView1 = new DataGridView();
        // Book_ID = new DataGridViewTextBoxColumn();
        // Book_Name = new DataGridViewTextBoxColumn();
        // Author = new DataGridViewTextBoxColumn();
        // Price = new DataGridViewTextBoxColumn();
        // Pages = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(57, 26);
        label1.Name = "label1";
        label1.Size = new Size(65, 20);
        label1.TabIndex = 0;
        label1.Text = "Book ID:";
        // label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(57, 60);
        label2.Name = "label2";
        label2.Size = new Size(90, 20);
        label2.TabIndex = 1;
        label2.Text = "Book Name:";
        // label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(57, 99);
        label3.Name = "label3";
        label3.Size = new Size(54, 20);
        label3.TabIndex = 2;
        label3.Text = "Author";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(57, 133);
        label4.Name = "label4";
        label4.Size = new Size(41, 20);
        label4.TabIndex = 3;
        label4.Text = "Price";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(57, 169);
        label5.Name = "label5";
        label5.Size = new Size(47, 20);
        label5.TabIndex = 4;
        label5.Text = "Pages";
        // label5.Click += label5_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(194, 23);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(142, 27);
        textBox1.TabIndex = 5;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(194, 57);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(142, 27);
        textBox2.TabIndex = 6;
        // textBox2.TextChanged += textBox2_TextChanged;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(194, 92);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(142, 27);
        textBox3.TabIndex = 7;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(194, 130);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(142, 27);
        textBox4.TabIndex = 8;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(194, 162);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(142, 27);
        textBox5.TabIndex = 9;
        // 
        // button1
        // 
        button1.Location = new Point(50, 232);
        button1.Name = "button1";
        button1.Size = new Size(100, 30);
        button1.TabIndex = 10;
        button1.Text = "Insert";
        button1.UseVisualStyleBackColor = true;
        button1.Click += new System.EventHandler(button1_Click);
        // 
        // button2
        // 
        button2.Location = new Point(150, 232);
        button2.Name = "button2";
        button2.Size = new Size(100, 30);
        button2.TabIndex = 11;
        button2.Text = "Update";
        button2.UseVisualStyleBackColor = true;
        button2.Click += new System.EventHandler(button2_Click);
        // 
        // button3
        // 
        button3.Location = new Point(250, 232);
        button3.Name = "button3";
        button3.Size = new Size(100, 30);
        button3.TabIndex = 12;
        button3.Text = "Delete";
        button3.UseVisualStyleBackColor = true;
        button3.Click += new System.EventHandler(button3_Click);
        // 
        // button4
        // 
        button4.Location = new Point(350, 232);
        button4.Name = "button4";
        button4.Size = new Size(100, 30);
        button4.TabIndex = 13;
        button4.Text = "Clear";
        button4.UseVisualStyleBackColor = true;
        button4.Click += new System.EventHandler(button4_Click);
        // button4.Click += button4_Click;
        //
        //button5
        //
        button5.Location = new Point(50, 332);
        button5.Name = "button5";
        button5.Size = new Size(100, 30);
        button5.TabIndex = 14;
        button5.Text = "Read XML";
        button5.Click += new System.EventHandler(button5_Click);
        //
        //button6
        //
        button6.Location = new Point(150, 332);
        button6.Name = "button6";
        button6.Size = new Size(100, 30);
        button6.TabIndex = 15;
        button6.Text = "Write XML";
        button6.Click += new System.EventHandler(button6_Click);
        //
        //button7
        //
        button7.Location = new Point(250, 332);
        button7.Name = "button7";
        button7.Size = new Size(100, 30);
        button7.TabIndex = 15;
        button7.Text = "Read CSV";
        button7.Click += new System.EventHandler(button7_Click);
        //
        //button8
        //
        button8.Location = new Point(350, 332);
        button8.Name = "button8";
        button8.Size = new Size(100, 30);
        button8.TabIndex = 15;
        button8.Text = "Write CSV";
        button8.Click += new System.EventHandler(button8_Click);
        //
        //button9
        //
        button9.Location = new Point(450, 332);
        button9.Name = "button9";
        button9.Size = new Size(100, 30);
        button9.TabIndex = 16;
        button9.Text = "PDF Write";
        button9.Click += new System.EventHandler(button9_Click);

        button10.Location = new Point(550, 232);
        button10.Name = "button10";
        button10.Size = new Size(100, 30);
        button10.TabIndex = 16;
        button10.Text = "Font";
        button10.Click += new System.EventHandler(button10_Click);

        button11.Location = new Point(550, 332);
        button11.Name = "button11";
        button11.Size = new Size(100, 30);
        button11.TabIndex = 16;
        button11.Text = "Color";
        button11.Click += new System.EventHandler(button11_Click);
        //
        //button12
        //
        this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.button12.Location = new System.Drawing.Point(691, 12);
        this.button12.Name = "button12";
        this.button12.Size = new System.Drawing.Size(99, 35);
        this.button12.TabIndex = 16;
        this.button12.Text = "Log out";
        this.button12.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        // dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Book_ID, Book_Name, Author, Price, Pages });
        dataGridView1.Location = new Point(29, 434);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.Size = new Size(681, 258);
        dataGridView1.TabIndex = 14;
        // dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // Book_ID
        // 
        // Book_ID.HeaderText = "Book_ID";
        // Book_ID.MinimumWidth = 6;
        // Book_ID.Name = "Book_ID";
        // Book_ID.Width = 125;
        // // 
        // // Book_Name
        // // 
        // Book_Name.HeaderText = "Book_Name";
        // Book_Name.MinimumWidth = 6;
        // Book_Name.Name = "Book_Name";
        // Book_Name.Width = 125;
        // // 
        // // Author
        // // 
        // Author.HeaderText = "Author";
        // Author.MinimumWidth = 6;
        // Author.Name = "Author";
        // Author.Width = 125;
        // // 
        // // Price
        // // 
        // Price.HeaderText = "Price";
        // Price.MinimumWidth = 6;
        // Price.Name = "Price";
        // Price.Width = 125;
        // // 
        // // Pages
        // // 
        // Pages.HeaderText = "Pages";
        // Pages.MinimumWidth = 6;
        // Pages.Name = "Pages";
        // Pages.Width = 125;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 729);
        Controls.Add(dataGridView1);
        Controls.Add(button12);
        Controls.Add(button11);
        Controls.Add(button10);
        Controls.Add(button9);
        Controls.Add(button8);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox5);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "CRUDdemo";
        Text = "CRUDdemo";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
#endregion

