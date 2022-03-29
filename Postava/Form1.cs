using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Postava
{
    public partial class Form1 : Form
    {
        Character character1;
        Character character2;

        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Characters; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Character GetCharacter(string name)
        {
            using(SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = $"SELECT * FROM Character WHERE NAME LIKE '{name}'";
                    command.Parameters.AddWithValue("name", name);
                    connection.Open();
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            return new Character(dataReader["Name"].ToString() 
                               ,Convert.ToInt32(dataReader["Health"])
                                ,Convert.ToInt32(dataReader["Shield"])
                                ,Convert.ToInt32(dataReader["Damage"]));
                        }
                    }
                    connection.Close();
                }
            }
            return new Character(name);
        }


        public Form1()
        {
            InitializeComponent();
            character1 = new Character("Adam");
            character2 = new Character("Jakub");
            textBox1.Text = character1.ToString();
            textBox2.Text = character2.ToString();
        }

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            character2.GetHit(character1.Damage);
            textBox2.Text = character2.ToString();
        }

        private void btnHeal1_Click(object sender, EventArgs e)
        {
            character1.Heal();
            textBox1.Text = character1.ToString();
        }

        private void btnAttack2_Click(object sender, EventArgs e)
        {
            character1.GetHit(character2.Damage);
            textBox1.Text = character1.ToString();
        }

        private void btnHeal2_Click(object sender, EventArgs e)
        {
            character2.Heal();
            textBox2.Text = character2.ToString();
        }
    }
}
