using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Query_db
{
    public partial class Query_DB : Form
    {

        string access = "Data Source =LAPTOP-TQHCDVHM\\SQLEXPRESS;Initial Catalog=Noleggi;Integrated Security = True; Trust Server Certificate=True";
        bool connected = false;
        public Query_DB()
        {
            InitializeComponent();
            Result.Enabled = false;
            ListColumnDB.Enabled = false;
            Column_name.Enabled = false;
            Operator.Enabled = false;
            Input_condition.Enabled = false;
            Execute_Query.Enabled = false;
            //Result.Text = "Prima riga\r\nSeconda riga\r\nTerza riga"; multi linea


        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListColumnDB.Items.Clear();
            try
            {
                //connect to db
                SqlConnection cn = new SqlConnection(access);
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader read;
                cn.Open();

                Console.WriteLine("Connected!");

                //query db
                string query = "SELECT * FROM Anagrafica_furgoni";
                cmd = new SqlCommand(query, cn);
                read = cmd.ExecuteReader();
                ListColumnDB.Items.Add("Tutte");

                for (int i = 0; i < read.FieldCount; i++)
                {
                    ListColumnDB.Items.Add(read.GetName(i));
                    Column_name.Items.Add(read.GetName(i));
                }

                ConnectDB.Enabled = false;
                ListColumnDB.Enabled = true;
                ConnectDB.Text = "Connected!!";
                Console.WriteLine("Finish read");

                read.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Not connected." + ex.Message);
            }
        }



        private void Query_DB_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListColumnDB.CheckedItems.Count > 0)
            {
                Execute_Query.Enabled = true;
            }
            else
            {
                Execute_Query.Enabled = false;
            }

            if (ListColumnDB.CheckedItems.Contains("Tutte"))
            {
                for (int i = 0; i < ListColumnDB.Items.Count; i++)
                {
                    ListColumnDB.SetItemChecked(i, true);
                }
            } 
            else if (ListColumnDB.SelectedIndex == 0)
            {
                for (int i = 0; i < ListColumnDB.Items.Count; i++)
                {
                    ListColumnDB.SetItemChecked(i, false);
                }
                    Execute_Query.Enabled = false;
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Condition.SelectedIndex != -1)
            {
                Column_name.Enabled = true;
                Execute_Query.Enabled = false;
            }
            else
            {
                Column_name.Enabled = false;
            }
        }

        private void Column_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Column_name.SelectedIndex != -1)
            {
                Operator.Enabled = true;
            }
            else
            {
                Operator.Enabled = false;
            }
        }

        private void Operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operator.SelectedIndex != -1)
            {
                Input_condition.Enabled = true;
            }
            else
            {
                Input_condition.Enabled = false;
            }

        }

        private void Input_condition_TextChanged(object sender, EventArgs e)
        {
            if (Input_condition.Text.Length > 1)
            {
                Execute_Query.Enabled = true;
            }
            else
            {
                Execute_Query.Enabled = false;
            }
        }

        private void Execute_Query_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Condition.SelectedIndex);
            Result.Enabled = true;

            if (Operator.SelectedIndex != -1)
            {
                ExecuteQueryOperator();
            }
            else
            {
                ExecuteQuerySimple();
            }

        }

        private void Clear_Form_Click(object sender, EventArgs e)
        {
            Condition.SelectedIndex = -1;
            Column_name.SelectedIndex = -1;
            Operator.SelectedIndex = -1;
            Input_condition.ResetText();
            Result.ResetText();

            for (int i = 0; i < ListColumnDB.Items.Count; i++)
            {
                ListColumnDB.SetItemChecked(i, false);
            }

            Execute_Query.Enabled = false;
        }

        private void ExecuteQueryOperator()
        {
            try
            {
                //connect to db
                SqlConnection cn = new SqlConnection(access);
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader read;
                cn.Open();

                Console.WriteLine("Connected!");

                List<string> itemChecked = new List<string>();

                if (ListColumnDB.CheckedItems.Count >= (ListColumnDB.Items.Count - 1))
                {
                    itemChecked.Add("*");
                }
                else
                {
                    foreach (string name in ListColumnDB.CheckedItems)
                    {
                        itemChecked.Add($"[{name}]");
                    }
                }
                string result = string.Join(",", itemChecked);
                //query db
                string query = $"SELECT {result} FROM Anagrafica_furgoni WHERE [{Column_name.Text}] {Operator.Text} {Input_condition.Text}";
                Console.WriteLine(query);
                cmd = new SqlCommand(query, cn);
                read = cmd.ExecuteReader();

                Result.AppendText(query + "\r\n");

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        Result.AppendText(read[i].ToString() + "\t\t");
                    }
                    Result.Text += "\r\n";
                }

                ListColumnDB.Enabled = true;
                Console.WriteLine("Finish read");

                read.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Not connected." + ex.Message);
            }
        }

        private void ExecuteQuerySimple()
        {
            try
            {
                //connect to db
                SqlConnection cn = new SqlConnection(access);
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader read;
                cn.Open();

                Console.WriteLine("Connected!");
                List<string> itemChecked = new List<string>();

                if (ListColumnDB.CheckedItems.Count >= (ListColumnDB.Items.Count - 1))
                {
                    itemChecked.Add("*");
                }
                else
                {
                    foreach (string name in ListColumnDB.CheckedItems)
                    {
                        itemChecked.Add($"[{name}]");
                    }
                }
                string result = string.Join(",", itemChecked);
                //query db
                string query = $"SELECT {result} FROM Anagrafica_furgoni";
                Console.WriteLine(query);
                cmd = new SqlCommand(query, cn);
                read = cmd.ExecuteReader();

                Result.AppendText(query + "\r\n");

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        Result.AppendText(read[i].ToString() + "\t\t");
                    }
                    Result.Text += "\r\n";
                }

                ListColumnDB.Enabled = true;
                Console.WriteLine("Finish read");

                read.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not connected." + ex.Message);
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
