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
    public partial class Admin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\users1\source\repos\NetMaster\NetMaster\Database1.mdf;Integrated Security=True");
      
        public Admin()
        {
            InitializeComponent();
            User();
        }

        SqlCommand com;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void User()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select  u_id as 'id', u_login 'Логин', u_password 'Пароль', u_role'Роль' from  user_t", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            datDisplayUser.DataSource = dt;
            connection.Close();
            Garage();
        }


        public void Garage()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select  m_id as 'id', m_name 'Название', m_adress 'Адресс', m_phone 'Телефон' from  garage_t", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            datDisplayGarage.DataSource = dt;
            connection.Close();

        }

        public void Work(int argument, SqlConnection conn)
        {
            switch (argument)
            {
                case 1:
                    {
                        
                    }
                    break;
            }
        }


                    private void user_tBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_tBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.garage_t". При необходимости она может быть перемещена или удалена.
            this.garage_tTableAdapter.Fill(this.database1DataSet.garage_t);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.user_t". При необходимости она может быть перемещена или удалена.
            this.user_tTableAdapter.Fill(this.database1DataSet.user_t);

        }

        private void user_tBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update user_t set u_login ='" + u_loginTextBox.Text + "', u_password ='" + u_passwordTextBox.Text + "', u_role=' "+ u_roleTextBox.Text + "'where u_id=" + u_idTextBox.Text + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            User();
            MessageBox.Show("Информация успешно изменена");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DatDisplayUser_MouseClick(object sender, MouseEventArgs e)
        {
       //     u_loginTextBox.Text = datDisplayUser.SelectedRows[0].Cells[1].Value.ToString();
        //    u_passwordTextBox.Text = datDisplayUser.SelectedRows[0].Cells[2].Value.ToString();
          //  u_roleTextBox.Text = datDisplayUser.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void DatDisplayGarage_MouseClick(object sender, MouseEventArgs e)
        {
        //    m_nameTextBox.Text = datDisplayGarage.SelectedRows[0].Cells[1].Value.ToString();
         //   m_adressTextBox.Text = datDisplayGarage.SelectedRows[0].Cells[2].Value.ToString();
         //   m_phoneTextBox.Text = datDisplayGarage.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update garage_t set m_name ='" + m_nameTextBox.Text + "', m_adress ='" + m_adressTextBox.Text + "', m_phone ='" + m_phoneTextBox.Text + "' where m_id ='" + m_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Garage();
            MessageBox.Show("Информация успешно изменена");
        }

        private void datDisplayUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //   u_loginTextBox.Text = datDisplayUser.SelectedRows[0].Cells[1].Value.ToString();
         //   u_passwordTextBox.Text = datDisplayUser.SelectedRows[0].Cells[2].Value.ToString();
         //   u_roleTextBox.Text = datDisplayUser.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void datDisplayGarage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  m_nameTextBox.Text = datDisplayGarage.SelectedRows[0].Cells[1].Value.ToString();
         //  m_adressTextBox.Text = datDisplayGarage.SelectedRows[0].Cells[2].Value.ToString();
         //   m_phoneTextBox.Text = datDisplayGarage.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            u_idTextBox.Text = "";
            u_loginTextBox.Text = "";
            u_passwordTextBox.Text = "";
            u_roleTextBox.Text = "";
          // connection.Open();
            MessageBox.Show("Введите данные");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into User_t values('" + u_loginTextBox.Text + "','" + u_passwordTextBox.Text + "','" + u_roleTextBox.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            u_idTextBox.Text = "";
            u_loginTextBox.Text = "";
            u_passwordTextBox.Text = "";
            u_roleTextBox.Text = "";

            User();

            MessageBox.Show("Данные успешно добавлены");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from User_t where u_id='" + u_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            User();
            MessageBox.Show("Пользователь удален");
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.garage_tTableAdapter.FillBy1(this.database1DataSet1.garage_t);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from garage_t where u_id='" + m_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Garage();
            MessageBox.Show("Мастерская удалена");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            m_idTextBox.Text = "";
            m_nameTextBox.Text = "";
            m_adressTextBox.Text = "";
            m_phoneTextBox.Text = "";
            // connection.Open();
            MessageBox.Show("Введите данные");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into garage_t values('" + m_nameTextBox.Text + "','" + m_adressTextBox.Text + "','" + m_phoneTextBox.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            m_idTextBox.Text = "";
            m_nameTextBox.Text = "";
            m_adressTextBox.Text = "";
            m_phoneTextBox.Text = "";

            User();

            MessageBox.Show("Данные успешно добавлены");
        }
    }
}
