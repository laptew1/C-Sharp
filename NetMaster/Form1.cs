using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetMaster
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\users1\source\repos\NetMaster\NetMaster\Database1.mdf;Integrated Security=True");//подключение к бд

        public Form1()
        {
            InitializeComponent();

        }
        long login_in;
        SqlCommand com;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        private void Connection(int argument)
        {
           // SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\users1\source\repos\NetMaster\NetMaster\Database1.mdf;Integrated Security=True");//подключение к бд
            try
            {
                connection.Open();
               if (argument != 0) { Work(argument, connection); }
                connection.Close();
            }
            catch (Exception ex)
            {
                if (argument != 0) { MessageBox.Show(ex.Message, "Error!"); };
                connection.Close();
            }
        }

        public void Work(int argument, SqlConnection conn)
        {
            switch (argument)
            {
                case 1:// Авторизация
                    {
                        login_in = Convert.ToInt64(loginBox.Text);
                        if (argument != 0)
                        {
                            if (login_in / 10000000000 == 8)
                            {
                                com = new SqlCommand(@"SELECT * FROM client_t WHERE p_phone_number = '" + loginBox.Text + "' and Driving_license = '" + passwordBox.Text + "'", conn);
                                adapter.SelectCommand = com; // Указываем выполняемую команду
                                adapter.Fill(table);
                                //dataGridView1.DataSource = table;
                                if (table.Rows.Count != 0)
                                {
                                    Hide();
                                    Пользователь вход = new Пользователь(loginBox.Text, passwordBox.Text);
                                    вход.ShowDialog();
                                    Close();
                                }
                            }
                                    com = new SqlCommand(@"SELECT u_role FROM user_t WHERE u_login = '" + loginBox.Text + "' and u_password = '" + passwordBox.Text + "'", conn);
                            adapter.SelectCommand = com; // Указываем выполняемую команду
                            adapter.Fill(table);
                            //dataGridView1.DataSource = table;
                            // MessageBox.Show(table.Rows[0][0].ToString());
                            if (table.Rows[0][0].ToString() + " " == "admin ")
                            {
                                MessageBox.Show("Вы вошли как администратор");
                                Hide();
                                Admin вход = new Admin();
                                вход.ShowDialog();
                                Close();
                            }
                            if (table.Rows[0][0].ToString() + " " == "manager ")
                            {
                                MessageBox.Show("Вы вошли как менеджер");
                                Hide();
                                Manager вход2 = new Manager();
                                вход2.ShowDialog();
                                Close();
                            }
                            if (table.Rows[0][0].ToString() + " " == "lider ")
                            {
                                MessageBox.Show("Вы вошли как директор");
                                Hide();
                                Lider вход1 = new Lider();
                                вход1.ShowDialog();
                                Close();
                                
                            }

                                                        
                            if (login_in / 10000000000 == 8)
                            {
                                com = new SqlCommand(@"SELECT * FROM client_t WHERE p_phone_number = '" + loginBox.Text + "' and Driving_license = '" + passwordBox.Text + "'", conn);
                                adapter.SelectCommand = com; // Указываем выполняемую команду
                                adapter.Fill(table);
                                //dataGridView1.DataSource = table;
                                if (table.Rows.Count != 0)
                                {
                                    Hide();
                                    Пользователь вход = new Пользователь(loginBox.Text, passwordBox.Text);
                                    вход.ShowDialog();
                                    Close();
                                }
                                else
                                    MessageBox.Show("Не правильный логин или пароль");
                                table.Clear();
                            }


                            else
                            {
                                MessageBox.Show("Ошибка авторизации! Проверьте правильность ввода логина и пароля!");
                            }
                        }
                    }
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
          //  this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection(1);
          //  Hide();
          //  Пользователь вход = new Пользователь();
          //  вход.ShowDialog();
          //  Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  if (textBox1.text()= 8)_
        }

      
    }
}
