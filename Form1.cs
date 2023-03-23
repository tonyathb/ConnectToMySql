
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConnectToMySql
{
    public partial class Form1 : Form
    {
        //List<string> names = new List<string>();
        string connstr = "server=192.168.1.235;" +//192.168.137.1//"server=10.42.41.215;" +   87.97.181.216" +
                "port=3306;" +
                "user=REMOTE;" +
                "password=Aa123456@;" +
                "database=minions";
        MySqlConnection connect;
        MySqlCommand query;
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecords()
        {
            connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();//connection string
            MessageBox.Show("Connection NOW opened");
            //text query
            string sql = "SELECT minions.id, minions.Name,minions.Age" +//, towns.Name " +
                         "FROM minions ";//+
                         //"INNER JOIN towns ON towns.id=minions.town_id";
//puskam query
            query = new MySqlCommand(sql, connect);
            //izpalnyava query
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add($"{reader[0]} --> {reader[1]} Age: {reader["Age"]}");
            }
            reader.Close();


            //var sql = "SELECT minions.Name, minions.Age, towns.Name " +
            //    "FROM minions " +
            //    "INNER JOIN towns " +
            //    "ON towns.id = minions.TownId";//"SELECT name,age FROM minions;";



            //listBox1.Items.Clear();
            //while (reader.Read())
            //{
            //    listBox1.Items.Add(reader[0].ToString() + ". " + reader["Name"] + " Age: " + reader[2] + " >> Town: " + reader[3]);
            //}
            ////listBox1.DataSource = names;
            //reader.Close();
        }
        private void LoadComboBox()
        {
            string sql = "SELECT towns.Id, towns.Name FROM towns ";
            query = new MySqlCommand(sql, connect);

            MySqlDataReader readerTowns = query.ExecuteReader();
            //READ a selected records
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            while (readerTowns.Read())
            {
                ComboBoxItem item = new ComboBoxItem()
                {
                    Text = readerTowns[1].ToString(),
                    Value = (int)readerTowns[0]
                };
                items.Add(item);
            }

            comboBox1.DataSource = items;//towns.ToList();
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            readerTowns.Close();
            //  connect.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecords();
            LoadComboBox();
        }

        private void btnAddNewMinion_Click(object sender, EventArgs e)
        {
            // connect.Open();
            if (string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("No data for adding!!!");
                return;
            }
            string sql = "INSERT INTO minions(Name, Age, town_id ) VALUES (@minionName, @minionAge, @townId)";
            query = new MySqlCommand(sql, connect);
            query.Parameters.AddWithValue("@minionName", textBox2.Text);
            int age = -1;
            if (!int.TryParse(textBox3.Text, out age))
            {
                MessageBox.Show("Age is not a number");
                return;
            }
            query.Parameters.AddWithValue("@minionAge", age);
            query.Parameters.AddWithValue("@townId", comboBox1.SelectedValue);
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
            query.ExecuteNonQuery();
            connect.Close();
            LoadRecords();
        }


        private void btnDeleteMinion_Click(object sender, EventArgs e)
        {
            //connect.Open();

            btnFind_Click(sender, e);
            string sql = "Delete from minions WHERE id=@id;";
            query = new MySqlCommand(sql, connect);
            query.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            query.ExecuteNonQuery();
            connect.Close();
            LoadRecords();



        }

        private void btnUpdMinion_Click(object sender, EventArgs e)
        {
            //connect.Open();
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                btnFind_Click(sender, e);
            }
            string sql = "UPDATE minions SET Name = @minionName, Age=@minionAge, TownId=@townId " +
                         " WHERE id=@id;";
            query = new MySqlCommand(sql, connect);
            query.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            query.Parameters.AddWithValue("@minionName", textBox2.Text);
            int age = -1;
            if (!int.TryParse(textBox3.Text, out age))
            {
                MessageBox.Show("Age is not a number");
                return;
            }
            query.Parameters.AddWithValue("@minionAge", age);
            query.Parameters.AddWithValue("@townId", comboBox1.SelectedValue);
            query.ExecuteNonQuery();
            connect.Close();
            LoadRecords();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (string.IsNullOrEmpty(textBox1.Text) || !int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("No id for searching!!!");
                return;
            }
            string sql = "Select minions.*, towns.* " +
                         "From minions " +
                         "Inner Join towns " + "ON towns.id=minions.town_id " +
                         "WHERE minions.id=@id;";
            query = new MySqlCommand(sql, connect);
            query.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = query.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                comboBox1.Text = reader[5].ToString();
            }
            else
            {
                MessageBox.Show("No record");
            }
            reader.Close();
        }
    }
}
