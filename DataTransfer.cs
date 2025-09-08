using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWinForm
{
    public partial class DataTransfer : Form
    {
        private Button button1, button2, button3, button4, button5, button6;
        private ListBox listBox1, listBox2;
        private TextBox textBox;
        private Label label;
        private Label label1;


        public DataTransfer()
        {
            InitializeComponent();
            // LoadItemsleft("list1.txt");
            // LoadItemsright("list2.txt");
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox2.SelectionMode = SelectionMode.MultiExtended;

        }
    }


    partial class DataTransfer
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

        private void LoadItemsleft(string filePath)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Add each line to the ListBox
                listBox1.Items.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items from file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ConvertToUppercase2();
        }

        private void LoadItemsright(string filePath)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Add each line to the ListBox
                listBox2.Items.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items from file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ConvertToUppercase();
        }

        private void ConvertToUppercase()
        {
            // Convert each item to uppercase
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string currentItem = listBox1.Items[i].ToString();
                listBox1.Items[i] = currentItem.ToUpper();
            }
        }
        private void ConvertToUppercase2()
        {
            // Convert each item to uppercase
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string currentItem = listBox1.Items[i].ToString();
                listBox2.Items[i] = currentItem.ToUpper();
            }
        }

        private void button1_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string file = openFileDialog.FileName;
                    FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Console.WriteLine("Content of the test file");
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    string str = sr.ReadLine();
                    while (str != null)
                    {
                        listBox1.Items.Add(str);
                        str = sr.ReadLine();
                    }
                    Console.ReadLine();
                    sr.Close();
                    fs.Close();
                }
                catch (IOException) { }
            }
        }

        private void button2_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Write);
                    StreamWriter sr = new StreamWriter(fs);

                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        sr.WriteLine(listBox2.Items[i].ToString());
                    }
                    MessageBox.Show($"Items are saved in file {file}");
                    sr.Flush();
                    sr.Close();
                    fs.Close();
                }
                catch (IOException) { }
            }
        }

        private void button3_click(object sender, EventArgs e)
        {
            foreach (var selectedItem in listBox1.SelectedItems)
            {
                listBox2.Items.Add(selectedItem);
            }
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
            //  if (listBox1.SelectedItem != null)
            // {
            //     // Move the selected item from listBox1 to listBox2
            //     listBox2.Items.Add(listBox1.SelectedItem);
            //     listBox1.Items.Remove(listBox1.SelectedItem);
            // }
        }

        private void button4_click(object sender, EventArgs e)
        {
            foreach (var selectedItem in listBox2.SelectedItems)
            {
                listBox1.Items.Add(selectedItem);
            }
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
            // if (listBox2.SelectedItem != null)
            // {
            //     listBox1.Items.Add(listBox2.SelectedItem);
            //     listBox2.Items.Remove(listBox2.SelectedItem);
            // }
        }

        private void button5_click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button6_click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label = new Label();
            label1 = new Label();
            textBox = new TextBox();

            button1.Location = new Point(100, 23);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.Text = "Open File";
            button1.TabIndex = 1;
            Controls.Add(button1);
            button1.Click += new System.EventHandler(button1_click);

            button2.Location = new Point(300, 23);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.Text = "Save File";
            button2.TabIndex = 2;
            Controls.Add(button2);
            button2.Click += new System.EventHandler(button2_click);

            listBox1.Location = new Point(40, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 250);
            listBox1.TabIndex = 3;
            Controls.Add(listBox1);

            listBox2.Location = new Point(340, 90);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 250);
            listBox2.TabIndex = 4;
            Controls.Add(listBox2);

            button3.Location = new Point(225, 95);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.Text = " > ";
            button3.TabIndex = 5;
            Controls.Add(button3);
            button3.Click += new System.EventHandler(button3_click);

            button4.Location = new Point(225, 155);
            button4.Name = "button4";
            button4.Size = new Size(90, 30);
            button4.Text = " < ";
            button4.TabIndex = 6;
            Controls.Add(button4);
            button4.Click += new System.EventHandler(button4_click);

            button5.Location = new Point(225, 215);
            button5.Name = "button5";
            button5.Size = new Size(90, 30);
            button5.Text = " >> ";
            button5.TabIndex = 7;
            Controls.Add(button5);
            button5.Click += new System.EventHandler(button5_click);

            button6.Location = new Point(225, 275);
            button6.Name = "button6";
            button6.Size = new Size(90, 30);
            button6.Text = " << ";
            button6.TabIndex = 8;
            Controls.Add(button6);
            button6.Click += new System.EventHandler(button6_click);

            label.Location = new Point(535, 30);
            label.Name = "label";
            label.AutoSize = true;
            label.Text = "TextBox Content Convert into TitleCase";
            label.TabIndex = 9;
            Controls.Add(label);

            textBox.Location = new Point(535, 60);
            textBox.Name = "textBox";
            textBox.Size = new Size(250, 27);
            textBox.TabIndex = 10;
            textBox.TextChanged += (object sender, EventArgs e) => { textBox.Text = textBox.Text.ToUpper(); textBox.SelectionStart = textBox.Text.Length; };
            Controls.Add(textBox);

            label1.Location = new Point(535, 90);
            label.Name = "label1";
            label.AutoSize = true;
            label1.TabIndex = 11;
            Controls.Add(label1);
        }
        #endregion

    }

}