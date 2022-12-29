using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;
using System.Globalization;
using System.Reflection;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities.Collections;
using static System.Net.Mime.MediaTypeNames;
using MySqlX.XDevAPI.Relational;
using MySqlX.XDevAPI.Common;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        }


        private void RefreshDatagrid(DataGridView dgw)
        {
            try
            {
                //закончился тонер таблица
                MySqlConnection con = new MySqlConnection("server = 192.168.6.25;port = 3306; database = test123;user= test123;password = Ae344se53mkEiz");
                con.Open();
                string querystring = "SELECT * FROM oldcartriges";
                MySqlCommand test = new MySqlCommand(querystring, con);
                MySqlDataAdapter dataAdapder = new MySqlDataAdapter(test);
                DataTable dt = new DataTable();
                dataAdapder.Fill(dt);
                dataGridView2.DataSource = dt;
                //орг техника таблица
                var query = "SELECT * FROM technique";
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable datable = new DataTable();
                dataAdapter.Fill(datable);
                dataGridView4.DataSource = datable;


            //орг техника таблица
                var basedt = "SELECT * FROM BaseCartridge";
                MySqlCommand basecomand = new MySqlCommand(basedt, con);
                MySqlDataAdapter Baseadapter = new MySqlDataAdapter(basecomand);
                DataTable BaseTable = new DataTable();
                Baseadapter.Fill(BaseTable);
                dataGridView3.DataSource = BaseTable;
            }
            catch
            {
                MessageBox.Show("база не подключенна");
            }



}

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDatagrid(dataGridView2);
            RefreshDatagrid(dataGridView3);
            {
                string test = "server = 192.168.6.25;port = 3306; database = test123;user= test123;password = Ae344se53mkEiz;";
                MySqlConnection testcon = new MySqlConnection(test);
                testcon.Open();
            }
            string constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123;password = Ae344se53mkEiz;";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            bool allEmpty = true;
            bool someEmpty = false;
            string[] value, valueone, valuetwo;
            valueone = new string[dataGridView2.RowCount];
            for (int y = 0; y < dataGridView2.Rows.Count; y++)
            {

                valueone[y] = dataGridView2.Rows[y].Cells[1].Value.ToString();
            }
            value = new string[dataGridView3.RowCount];
            valuetwo = new string[dataGridView3.RowCount];
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                value[i] = dataGridView3.Rows[i].Cells[2].Value.ToString();

            }
            value = value;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                valuetwo[i] = dataGridView3.Rows[i].Cells[3].Value.ToString();

            }
            valuetwo = valuetwo;
            string v;
            int b = 0;
            var namecartridge = textBox7.Text;
            var compare = 0;
            var summ = -1;
            foreach (TextBox textBox in panel2.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    someEmpty = true;
                    textBox.BackColor = Color.Red;
                    MessageBox.Show("надо ввести данные");
                }
                else
                    allEmpty = false;
                textBox.BackColor = Color.White;
                allEmpty = false;
            }
            for (int counter = 0; counter < value.Length; counter++)
            {
                if (value[counter] == namecartridge)
                {

                    for (int i = 0; i < valuetwo.Length; i++)
                    {
                        var cartdt3 = dataGridView3.Rows[i].Cells[2].Value.ToString(); // проверка картриджа массивом
                        if (cartdt3 == textBox7.Text)
                        {
                            var entry = dataGridView3.Rows[i].Cells[3].Value.ToString();
                            int intentry = int.Parse(entry);
                                if (intentry > compare)
                                {

                                    MySqlCommand cmd = new MySqlCommand("UPDATE `BaseCartridge` set `summ` = `summ`" + summ + " where Cartridge = '" + textBox7.Text + "'", mycon);
                                    MySqlCommand record = new MySqlCommand("iNSERT INTO oldcartriges(Cartrige,Lastname,refill,Date) VAlUES ('" + textBox7.Text + "','" + textBox8.Text + "','" + "пустой" + "',now())", mycon);
                                    record.ExecuteNonQuery();
                                    int q = cmd.ExecuteNonQuery();
                                    RefreshDatagrid(dataGridView2);
                                    RefreshDatagrid(dataGridView3);
                                    if (q > 0)
                                    {
                                        MessageBox.Show("Записалось");
                                    }
                                    else
                                    {

                                        MessageBox.Show("Этого картриджа нет в базе");
                                    }
                                }
                            else
                            {
                                MessageBox.Show("Этого картриджа нет в базе");
                            }
                        }
                    }           
                }
            }  
        } 


        private void Form1_Load(object sender, EventArgs e)
        {

            RefreshDatagrid(dataGridView2);

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Заправленные_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                var constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123; password = Ae344se53mkEiz;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                var datesstart = dateTimePicker1.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                var dateend = dateTimePicker2.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                var query = "Select * FROM cartrige WHERE Date BETWEEN'" + datesstart + "' AND '" + dateend + "'";
                MySqlCommand command = new MySqlCommand(query, mycon);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                mycon.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123; password = Ae344se53mkEiz;";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string[] a, b, c;

            a = new string[dataGridView2.RowCount];
            b = new string[dataGridView2.RowCount];
            c = new string[dataGridView2.RowCount];
            for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            {
                a[i] = dataGridView2.SelectedRows[i].Cells[1].Value.ToString();
                b[i] = dataGridView2.SelectedRows[i].Cells[2].Value.ToString();
                c[i] = dataGridView2.SelectedRows[i].Cells[0].Value.ToString();

            }
            var sql = "INSERT INTO cartrige(Cartrige, Lastname, Date) VAlUES ";
            var valuetable = "";
            var update = "";//"UPDATE `BaseCartridge` SET `summ`= `summ` + '" + 1 + "' WHERE Cartridge =";
            var updatetwo = "";
            var test2 = "";
            var dlt = "";
            for (int counter = 0; counter < dataGridView2.SelectedRows.Count; counter++)
            {

                valuetable = valuetable + "('" + b[counter] + "','" + a[counter] + "', NOW())";
                if (counter < dataGridView2.SelectedRows.Count - 1)
                {
                    valuetable += ",";
                }

                dlt = dlt + "Delete from oldcartriges where id='" + c[counter] + "'";
                if (counter < dataGridView2.SelectedRows.Count - 1)
                {
                    dlt += ";";
                }
                updatetwo = updatetwo;
                if (counter < dataGridView2.SelectedRows.Count)
                {
                    updatetwo+= "UPDATE `BaseCartridge` SET `summ`= `summ` + 1 WHERE Cartridge = '" + a[counter] + "'; ";
                }
            }
            update = update + "" +  updatetwo  + ";";
            MySqlCommand updateone = new MySqlCommand(update, mycon);
            updateone.ExecuteNonQuery();
            test2 = dlt;
            MySqlCommand dltnew = new MySqlCommand(test2, mycon);
            dltnew.ExecuteNonQuery();
            sql = sql + valuetable + ";";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.ExecuteNonQuery();
            RefreshDatagrid(dataGridView3);
            RefreshDatagrid(dataGridView2);
            mycon.Close();



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            bool allEmpty = true;
            bool someEmpty = false;
            foreach (TextBox textBox in panel1.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    someEmpty = true;
                    textBox.BackColor = Color.Red;
                    MessageBox.Show("надо ввести данные");
                }
                else
                    allEmpty = false;
                    textBox.BackColor = Color.White;
                     allEmpty = false;
            }
            if (!someEmpty)
            {
                string constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123;password = Ae344se53mkEiz;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                MySqlCommand cmd = new MySqlCommand("iNSERT INTO technique(`tehnique`, `Lastname`, `invertnumber`, `date`) VAlUES ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',now())", mycon);
                cmd.ExecuteNonQuery();
                RefreshDatagrid(dataGridView4);
                mycon.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вам вернули технику?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123; password = Ae344se53mkEiz;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                string[] c;

                c = new string[dataGridView4.RowCount];
                for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
                {
                    c[i] = dataGridView4.SelectedRows[i].Cells[0].Value.ToString();

                }
                c = c;

                var test2 = "";
                var dlt = "";
                for (int counter = 0; counter < dataGridView4.SelectedRows.Count; counter++)
                {

                    dlt = dlt + "Delete from technique where id='" + c[counter] + "'";
                    if (counter < dataGridView4.RowCount - 1)
                    {
                        dlt += ";";
                    }

                }
                test2 = dlt;
                MySqlCommand dltnew = new MySqlCommand(test2, mycon);
                dltnew.ExecuteNonQuery();
                RefreshDatagrid(dataGridView4);
                mycon.Close();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string fs = saveFileDialog1.FileName;
            StreamWriter myWritet = new StreamWriter(fs);
            try
            {

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + " ");
                    }
                    myWritet.WriteLine();
                }
                MessageBox.Show("Обновлено успешно. Приятной работы! :)");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                myWritet.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранные данные из базы?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123; password = Ae344se53mkEiz;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                string[] a, c;
                a = new string[dataGridView2.RowCount];
                c = new string[dataGridView2.RowCount];
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {
                    a[i] = dataGridView2.SelectedRows[i].Cells[1].Value.ToString();
                    c[i] = dataGridView2.SelectedRows[i].Cells[0].Value.ToString();
                }
                c = c;
                var update = "";
                var updatetwo = "";
                var dltinsert = "Delete from oldcartriges where ";
                var dlt = "";
                for (int counter = 0; counter < dataGridView2.SelectedRows.Count; counter++)
                {
                    dltinsert = dltinsert + "id=" + c[counter] + "";
                    if (counter < dataGridView2.SelectedRows.Count - 1)
                    {
                        dltinsert += " OR ";
                    }
                    updatetwo = updatetwo;
                    if (counter < dataGridView2.SelectedRows.Count)
                    {
                        updatetwo += "UPDATE `BaseCartridge` SET `summ`= `summ` + 1 WHERE Cartridge = '" + a[counter] + "'; ";
                    }
                }
                dltinsert = dltinsert + ";";
                MySqlCommand dltnew = new MySqlCommand(dltinsert, mycon);
                dltnew.ExecuteNonQuery();
                update = update + "" + updatetwo + ";";
                MySqlCommand updateone = new MySqlCommand(update, mycon);
                updateone.ExecuteNonQuery();
                RefreshDatagrid(dataGridView2);
                mycon.Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                bool allEmpty = true;
                bool someEmpty = false;
                foreach (TextBox textBox in panel4.Controls.OfType<TextBox>())
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        someEmpty = true;
                        textBox.BackColor = Color.Red;
                        MessageBox.Show("надо ввести данные");
                    }
                    else
                        allEmpty = false;
                    textBox.BackColor = Color.White;
                    allEmpty = false;
                }
                {
                if (!someEmpty)
                    {
                        try
                        {
                            string constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123;password = Ae344se53mkEiz;";
                            MySqlConnection mycon = new MySqlConnection(constr);
                            mycon.Open();
                            MySqlCommand cmd = new MySqlCommand("iNSERT INTO BaseCartridge(`Invent №`, `Cartridge`, `summ`) VAlUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "')", mycon);
                            cmd.ExecuteNonQuery();
                            RefreshDatagrid(dataGridView3);
                            mycon.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Введите корректные данные");
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {

                string constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123;password = Ae344se53mkEiz;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                string[]  c;
                c = new string[dataGridView2.RowCount];
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {

                    c[i] = dataGridView2.SelectedRows[i].Cells[0].Value.ToString();
                }
                c = c;
                var sql = "";
                var valuetable = "";

                for (int counter = 0; counter < dataGridView2.SelectedRows.Count; counter++)
                {
                    valuetable = valuetable + "UPDATE oldcartriges SET `refill` = \"Отправлен\" WHERE ID = " + c[counter] + "";
                    if (counter < dataGridView2.SelectedRows.Count)
                    {
                        valuetable += ";";
                    }
                }
                sql = sql + valuetable;
                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                RefreshDatagrid(dataGridView2);
                cmd.ExecuteNonQuery();
                mycon.Close();
            }

            RefreshDatagrid(dataGridView2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            var constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123; password = Ae344se53mkEiz;";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string[] a ;
            a = new string[dataGridView3.RowCount];
            for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
            {
                a[i] = dataGridView3.SelectedRows[i].Cells[2].Value.ToString();
            }
            var b = textBox9.Text;
            var update = "";
            var updatetwo = "";
            updatetwo = updatetwo;
            for (int counter = 0; counter < dataGridView3.SelectedRows.Count; counter++)
            {
                if (counter < dataGridView3.SelectedRows.Count)
                {
                updatetwo += "UPDATE `BaseCartridge` SET `summ`= `summ` "+ b +" WHERE Cartridge = '" + a[counter] + "'; ";
                }
            }
            try
            {
                update = update + "" + updatetwo + ";";
                MySqlCommand updateone = new MySqlCommand(update, mycon);
                updateone.ExecuteNonQuery();
                RefreshDatagrid(dataGridView2);
            }
            catch {
                MessageBox.Show("Введите данные");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранные данные из базы?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var constr = "server = 192.168.6.25;port = 3306; database = test123;user= test123; password = Ae344se53mkEiz;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                string[]  c;

                c = new string[dataGridView3.RowCount];
                for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
                {

                    c[i] = dataGridView3.SelectedRows[i].Cells[0].Value.ToString();
                }
                c = c;

                var dltinsert = "Delete from BaseCartridge where ";
                var dlt = "";
                for (int counter = 0; counter < dataGridView3.SelectedRows.Count; counter++)
                {
                    dltinsert = dltinsert + "id=" + c[counter] + "";
                    if (counter < dataGridView3.SelectedRows.Count - 1)
                    {
                        dltinsert += " OR ";
                    }

                }
                dltinsert = dltinsert + ";";
                MySqlCommand dltnew = new MySqlCommand(dltinsert, mycon);
                dltnew.ExecuteNonQuery();
                RefreshDatagrid(dataGridView3);
                mycon.Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }
    }
}
 

