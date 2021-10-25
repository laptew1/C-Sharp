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
    public partial class Lider : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\users1\source\repos\NetMaster\NetMaster\Database1.mdf;Integrated Security=True");

        public Lider()
        {
            InitializeComponent();
        }

        public void Worker()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select  w_id  , w_name ,  w_phone_number, skill from  worker_t", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            worker_tDataGridView.DataSource = dt;
            connection.Close();
           
        }

        private void worker_tBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.worker_tBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

            connection.Open();
            SqlCommand command = new SqlCommand("insert into worker_t values('" + w_nameTextBox.Text + "','" + w_phone_numberTextBox.Text + "','" + skillTextBox.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            w_idTextBox.Text = "";
            w_nameTextBox.Text = "";
            w_phone_numberTextBox.Text = "";
            skillTextBox.Text = "";

            Worker();

            MessageBox.Show("Данные успешно добавлены");




        }

        private void Lider_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.worker_t". При необходимости она может быть перемещена или удалена.
            this.worker_tTableAdapter.Fill(this.database1DataSet.worker_t);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void skillTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from worker_t where w_id='" + w_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Worker();
            MessageBox.Show("Пользователь удален");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update worker_t set W_name ='" + w_nameTextBox.Text + "', W_phone_number ='" + w_phone_numberTextBox.Text + "', skill ='" + skillTextBox.Text + "' where W_id ='" + w_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Worker();
            MessageBox.Show("Информация успешно изменена");
            w_idTextBox.Text = "";
            w_nameTextBox.Text = "";
            w_phone_numberTextBox.Text = "";
            skillTextBox.Text = "";
        }
    }
}
