using System.Data;
using Npgsql;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.VisualBasic.FileIO;

namespace FirstWinForm;

public partial class CRUDdemo : Form
{
    DataTable dt = new DataTable();
    private NpgsqlConnection cn = new NpgsqlConnection("Server=cipg01;port=5432;Database=GROUPD;User Id=postgres;Password=123456;");
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Button button11;
    private Button button12;
    private DataGridView dataGridView1;
    private FontDialog fontDialog = new FontDialog();
    private ColorDialog colorDialog = new ColorDialog();
    private OpenFileDialog openFileDialog1 = new OpenFileDialog();
    private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
    // private DataGridViewTextBoxColumn Book_ID;
    // private DataGridViewTextBoxColumn Book_Name;
    // private DataGridViewTextBoxColumn Author;
    // private DataGridViewTextBoxColumn Price;
    // private DataGridViewTextBoxColumn Pages;

    public CRUDdemo()
    {
        InitializeComponent();
        LoadData();
        dataGridView1.CellClick += dataGridView1_CellClick;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) // Check if a valid row is clicked
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Set TextBox values based on the clicked row
            textBox1.Text = row.Cells["c_bookid"].Value.ToString();
            textBox2.Text = row.Cells["c_bookname"].Value.ToString();
            textBox3.Text = row.Cells["c_author"].Value.ToString();
            textBox4.Text = row.Cells["c_price"].Value.ToString();
            textBox5.Text = row.Cells["c_pages"].Value.ToString();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        NpgsqlCommand cm = new NpgsqlCommand("insert into t_book(c_bookname,c_author,c_price,c_pages) values (@bookname,@author,@price,@pages)", cn);
        // cm.Parameters.AddWithValue("@bookid", Convert.ToInt32(textBox1.Text));
        cm.Parameters.AddWithValue("@bookname", Convert.ToString(textBox2.Text));
        cm.Parameters.AddWithValue("@author", Convert.ToString(textBox3.Text));
        cm.Parameters.AddWithValue("@price", Convert.ToInt32(textBox4.Text));
        cm.Parameters.AddWithValue("@pages", Convert.ToInt32(textBox5.Text));

        try
        {
            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Record insert successfully");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error inserting data" + ex.Message);
        }
        finally
        {
            cn.Close();
        }
        clear();
        LoadData();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        NpgsqlCommand cm = new NpgsqlCommand("update t_book set c_bookname = @bookname , c_author = @author , c_price = @price , c_pages = @pages where c_bookid=@bookid ", cn);
        cm.Parameters.AddWithValue("@bookid", Convert.ToInt32(textBox1.Text));
        cm.Parameters.AddWithValue("@bookname", textBox2.Text);
        cm.Parameters.AddWithValue("@author", textBox3.Text);
        cm.Parameters.AddWithValue("@price", Convert.ToInt32(textBox4.Text));
        cm.Parameters.AddWithValue("@pages", Convert.ToInt32(textBox5.Text));

        try
        {
            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Record updated successfully");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error inserting data" + ex.Message);
        }
        finally
        {
            cn.Close();
        }
        clear();
        LoadData();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        NpgsqlCommand cm = new NpgsqlCommand("delete from t_book where c_bookid=@bookid", cn);
        cm.Parameters.AddWithValue("@bookid", Convert.ToInt32(textBox1.Text));

        try
        {
            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted successfully");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error inserting data" + ex.Message);
        }
        finally
        {
            cn.Close();
        }
        LoadData();
        clear();

    }
    private void button4_Click(object sender, EventArgs e)
    {
        clear();
    }

    private void clear()
    {
        textBox1.Clear();
        textBox2.Clear();
        textBox3.Clear();
        textBox4.Clear();
        textBox5.Clear();
    }

    //Read XML File
    private void button5_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        openFileDialog1.FileName = "";
        openFileDialog1.Filter = "XML Files| *.xml| All Files|*.*";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            // dt.Clear();
            // dt.Columns.Clear();
            ds.ReadXml(openFileDialog1.FileName);
            dataGridView1.DataSource = ds.Tables[0];
            SaveDataToDatabase(ds.Tables[0]);
        }
    }
    private void SaveDataToDatabase(DataTable dataTable)
    {
        try
        {
            cn.Open();

            foreach (DataRow row in dataTable.Rows)
            {
                int b_i = Convert.ToInt32(row["c_bookid"]);
                string b_n = row["c_bookname"].ToString();
                string a = row["c_author"].ToString();
                int price = Convert.ToInt32(row["c_price"]);
                int pages = Convert.ToInt32(row["c_pages"]);

                NpgsqlCommand cm = new NpgsqlCommand("insert into t_book(c_bookname,c_author,c_price,c_pages) values (@bookname,@author,@price,@pages)", cn);
                cm.Parameters.AddWithValue("@bookname", b_n);
                cm.Parameters.AddWithValue("@author", a);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@pages", pages);

                cm.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            cn.Close();
        }
        MessageBox.Show("Data save to database successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    // Write XML File
    private void button6_Click(object sender, EventArgs e)
    {
        try
        {
            cn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select c_bookid,c_bookname,c_author,c_price,c_pages from t_book ORDER BY c_bookid", cn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cm);

            saveFileDialog1.Filter = "XML Files| *.xml| All Files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "t_book");
                ds.WriteXml(saveFileDialog1.FileName);
                MessageBox.Show("File written successfully!", "Write", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    //Read CSV File
    private void button7_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        openFileDialog1.FileName = "";
        openFileDialog1.Filter = "CSV Files|*.csv|All Files|*.*";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            try
            {
                using (TextFieldParser parser = new TextFieldParser(openFileDialog1.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Read header
                    string[] headers = parser.ReadFields();
                    DataTable dataTable = new DataTable();

                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    // Read data
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        dataTable.Rows.Add(fields);
                    }

                    ds.Tables.Add(dataTable);
                }

                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No data found in the CSV file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading CSV file: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }


    //Write CSV File
    private void button8_Click(object sender, EventArgs e)
    {
        try
        {
            cn.Open();

            NpgsqlCommand cm = new NpgsqlCommand("select c_bookid,c_bookname,c_author,c_price,c_pages from t_book ORDER BY c_bookid", cn);
            NpgsqlDataReader reader = cm.ExecuteReader();

            saveFileDialog1.Filter = "CSV Files| .csv| All Files|.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        sw.Write($"\"{reader.GetName(i)}\"");
                        if (i < reader.FieldCount - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            sw.Write($"\"{reader[i]}\"");
                            if (i < reader.FieldCount - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("File Written Successfully!", "Write", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }


    //Write PDF File
    private void button9_Click(object sender, EventArgs e)
    {
        try
        {
            cn.Open();

            NpgsqlCommand cm = new NpgsqlCommand("select c_bookid,c_bookname,c_author,c_price,c_pages from t_book ORDER BY c_bookid", cn);
            NpgsqlDataReader reader = cm.ExecuteReader();

            saveFileDialog1.Filter = "PDF Files|*.pdf|All Files|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Create a new PDF document
                using (PdfWriter writer = new PdfWriter(saveFileDialog1.FileName))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Create a Table to hold the data
                        iText.Layout.Element.Table table = new iText.Layout.Element.Table(reader.FieldCount);

                        // Add headers to the table
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Cell cell = new Cell().Add(new Paragraph(reader.GetName(i)));
                            table.AddCell(cell);
                        }

                        // Add data rows to the table
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Cell cell = new Cell().Add(new Paragraph(reader[i].ToString()));
                                table.AddCell(cell);
                            }
                        }

                        // Add the table to the document
                        document.Add(table);
                    }
                }


                MessageBox.Show("Pdf created Successfully!", "Write", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error creating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        finally
        {
            cn.Close();
        }
    }

    private void button10_Click(object sender, EventArgs e)
    {
        fontDialog.ShowColor = true;

        if (fontDialog.ShowDialog() == DialogResult.OK)
        {
            // Set the font for the DataGridView
            dataGridView1.Font = fontDialog.Font;
            dataGridView1.ForeColor = fontDialog.Color;
        }

    }
    private void button11_Click(object sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            // dataGridView1.BackgroundColor = colorDialog.Color;
            dataGridView1.RowsDefaultCellStyle.BackColor = colorDialog.Color;
        }
    }
    private void LoadData()
    {
        NpgsqlCommand cmd = new NpgsqlCommand("select c_bookid,c_bookname,c_author,c_price,c_pages from t_book ORDER BY c_bookid", cn);
        try
        {
            cn.Open();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data:" + ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }


    // private void button5_Click(object sender, EventArgs e)
    // {
    //     // Save File Dialog for choosing where to save the XML file
    //     using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    //     {
    //         saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
    //         saveFileDialog.RestoreDirectory = true;

    //         if (saveFileDialog.ShowDialog() == DialogResult.OK)
    //         {
    //             string filePath = saveFileDialog.FileName;

    //             // Write DataTable to XML file
    //             WriteXmlFile(filePath);
    //             MessageBox.Show("XML file saved successfully.");
    //         }
    //     }
    // }

    // private void WriteXmlFile(string filePath)
    // {
    //     try
    //     {
    //         // Create a new DataSet and add DataTable to it
    //         DataSet dataSet = new DataSet();
    //         dataSet.Tables.Add(dt);

    //         // Write the DataSet to an XML file
    //         dataSet.WriteXml(filePath);
    //     }
    //     catch (Exception ex)
    //     {
    //         MessageBox.Show($"Error writing XML file: {ex.Message}");
    //     }
    // }

    // private void button6_Click(object sender, EventArgs e)
    // {
    //     // Open File Dialog for selecting an XML file to read
    //     using (OpenFileDialog openFileDialog = new OpenFileDialog())
    //     {
    //         openFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
    //         openFileDialog.RestoreDirectory = true;

    //         if (openFileDialog.ShowDialog() == DialogResult.OK)
    //         {
    //             string filePath = openFileDialog.FileName;

    //             // Read XML file and populate DataTable
    //             ReadXmlFile(filePath);

    //             // Display DataTable in a DataGridView or perform any other actions
    //             dataGridView1.DataSource = dt;
    //         }
    //     }
    // }

    // private void ReadXmlFile(string filePath)
    // {
    //     try
    //     {
    //         // Load XML file into a DataSet
    //         DataSet dataSet = new DataSet();
    //         dataSet.ReadXml(filePath);

    //         // Assuming the first table in the DataSet contains the desired data
    //         if (dataSet.Tables.Count > 0)
    //         {
    //             dt = dataSet.Tables[0];
    //         }
    //         else
    //         {
    //             MessageBox.Show("The selected XML file does not contain any data.");
    //         }
    //     }
    //     catch (Exception ex)
    //     {
    //         MessageBox.Show($"Error reading XML file: {ex.Message}");
    //     }
    // }
}
