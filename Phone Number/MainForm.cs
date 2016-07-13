using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Excel=Microsoft.Office.Interop.Excel;
namespace Phone_Number
{
    public partial class MainForm : Form
    {
        int i = 0;
        int j = 0;
        public MainForm()
        {
            InitializeComponent();
        }
       
        // in the name of god
        SQLiteConnection connect = new SQLiteConnection("Data Source=db.sqlite;Version=3");
        public void s()
        {
            string q = "select * from tbl1";
            SQLiteCommand cmd = new SQLiteCommand(q,connect);
            SQLiteDataAdapter query = new SQLiteDataAdapter(cmd);
            DataTable tbl = new DataTable();
            query.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }
        public void ss()
        {
            string q = "select * from tbl1";
            SQLiteCommand cmd = new SQLiteCommand(q, connect);
            SQLiteDataAdapter query = new SQLiteDataAdapter(cmd);
            DataTable tbl = new DataTable();
            query.Fill(tbl);
            dgv.DataSource = tbl;
        }
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000, "Soft Rash", "دفترچه تلفن سافت رش", ToolTipIcon.Info);
            notifyIcon1.Text = "جهت خروج از برنامه کلیک کنید";
            this.skinEngine1.SkinFile = Environment.CurrentDirectory + @"\" + "8" + @".ssk";
            this.skinEngine1.Active = true;
            s();
            ss();
            
            
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.Show();
        }

        private void aboutProgrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program By MR8R3Z4 Coding","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Q = "INSERT INTO tbl1 (name,family,number,home,website,social,address) VALUES (@name,@family,@number,@home,@website,@social,@address)";
            SQLiteCommand cmd = new SQLiteCommand(Q, connect);
            SQLiteDataAdapter query = new SQLiteDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@family", txt_family.Text);
            cmd.Parameters.AddWithValue("@number", txt_mobile.Text);
            cmd.Parameters.AddWithValue("@home", txt_house.Text);
            cmd.Parameters.AddWithValue("@website", txt_website.Text);
            cmd.Parameters.AddWithValue("@social", txtsocial.Text);
            cmd.Parameters.AddWithValue("@address", txt_address.Text);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            s();
            txt_name.Text = "";
            txt_family.Text = "";
            txt_website.Text = "";
            txtsocial.Text = "";
            txt_address.Text = "";
            txt_mobile.Text = "";
            txt_house.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q_d = "DELETE FROM tbl1 WHERE id=@id";
            SQLiteCommand cmd = new SQLiteCommand(q_d, connect);
            SQLiteDataAdapter query = new SQLiteDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@id", txt_delete.Text);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            txt_id.Text = "";
            s();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM tbl1 WHERE id=@id";
            SQLiteCommand cmd = new SQLiteCommand(q, connect);
            SQLiteDataAdapter query = new SQLiteDataAdapter(cmd);
            connect.Open();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            SQLiteDataReader read = cmd.ExecuteReader();
            if(read.Read())
            {
                up_name.Text = read["name"].ToString();
                up_family.Text = read["family"].ToString();
                up_home.Text = read["home"].ToString();
                up_mobile.Text = read["number"].ToString();
                up_social.Text = read["social"].ToString();
                up_address.Text = read["address"].ToString();
                up_web.Text = read["website"].ToString();
            }
            connect.Close();
            s();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i=0;i<dgv.Rows.Count;i++)
                {
                    txt_search.AutoCompleteCustomSource.Add(dgv.Rows[i].Cells[1].Value.ToString());    
                }
            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM tbl1 WHERE name=@name";
            SQLiteCommand cmd = new SQLiteCommand(q, connect);
            SQLiteDataAdapter query = new SQLiteDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@name", txt_search.Text);
            
            DataTable tbl = new DataTable();
            connect.Open();
            query.Fill(tbl);
            dataGridView2.DataSource = tbl;
            connect.Close();
            txt_search.Text = "";
            s();
            ss();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "";
            saveFileDialog2.FileName = "";
            if(saveFileDialog2.ShowDialog()==DialogResult.OK)
            { 
            int k;
            saveFileDialog2.Filter = "All Files|*.doc";          
            k = dgv.Rows.Count;
            TextWriter s = new StreamWriter(saveFileDialog2.FileName.ToString()+@".doc");
           for (int i = 0; i < k-1; i++)
           {
               s.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + dataGridView1.Rows[i].Cells[2].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[3].Value.ToString()+dataGridView1.Rows[i].Cells[4].Value.ToString()+"\t"+dataGridView1.Rows[i].Cells[5].Value.ToString());
           }
           MessageBox.Show(saveFileDialog2.FileName.ToString()+@".doc");
           s.Close();
            }
       }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "";
            saveFileDialog2.FileName = "";
            if(saveFileDialog2.ShowDialog()==DialogResult.OK)
            { 
            int k;
            saveFileDialog2.Filter = "All Files|*.txt";
            k = dgv.Rows.Count;
            // برای نوشتن در فایل ها به کار می رود
            TextWriter s = new StreamWriter(saveFileDialog2.FileName.ToString()+@".txt");
            for (int i = 0; i < k - 1; i++)
            {
                s.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + dataGridView1.Rows[i].Cells[2].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[3].Value.ToString() + dataGridView1.Rows[i].Cells[4].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            MessageBox.Show(saveFileDialog2.FileName.ToString()+@".txt");
            s.Close();
            }
       }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            s();
            ss();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string x = ". In The Name Of Allah .";
            string m = ": MR8R3Z4 Coding :";
            string f = new string(' ', x.Length / 2 - 1)  + new string(' ', x.Length / 2 - 1);
            string ch = "";

            if (i <= x.Length - 1)
            {
                ch = x.Substring(i, 1);
                toolStripStatusLabel1.Text += ch;
            }
            else if (i >= x.Length - 1 && j <= m.Length - 1)
            {
                ch = m.Substring(j, 1);

                toolStripStatusLabel1.Text += ch;
                j++;
            }
            else if (j >= m.Length - 1)
            {

                toolStripStatusLabel1.Text += f;
                timer1.Enabled = false;
            }
            i++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s();
            ss();
            PrintDataGrid.PrintDGV.Print_DataGridView(dgv);
            s();
            ss();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.DisplayRightToLeft = true;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString()+@" ";
                }
            }

            if(saveFileDialog2.ShowDialog()==DialogResult.OK)
            { 
            xlWorkBook.SaveAs(saveFileDialog2.FileName.ToString()+@".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Success Full", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        
    }
}
