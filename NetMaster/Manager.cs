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

      public partial class Manager : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\users1\source\repos\NetMaster\NetMaster\Database1.mdf;Integrated Security=True");

        public Manager()
        {
            InitializeComponent();
           
        }

        private void Client()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select  p_id  , p_name , p_adress , p_phone_number, DRIVING_LICENSE, dop_phone_number, dop_DRIVING_LICENSE from  client_t", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            client_tDataGridView.DataSource = dt;
            connection.Close();

        }

        private void Car()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select  c_id  , c_number , c_brand , c_color from  car_t", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            car_tDataGridView.DataSource = dt;
            connection.Close();

        }

        
        private void Order()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select  id  , DESCRIPT , PRICE , id_worker, id_garage , id_car , id_client, DATATIME_fix_start, DATATIME_fix_finish from  ORDER_t", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            oRDER_TDataGridView.DataSource = dt;
            connection.Close();

        }
        private void oRDER_TBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDER_TBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.car_t". При необходимости она может быть перемещена или удалена.
            this.car_tTableAdapter.Fill(this.database1DataSet.car_t);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.client_t". При необходимости она может быть перемещена или удалена.
            this.client_tTableAdapter.Fill(this.database1DataSet.client_t);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ORDER_T". При необходимости она может быть перемещена или удалена.
            this.oRDER_TTableAdapter.Fill(this.database1DataSet.ORDER_T);

        }

        private void bindingNavigator3_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update client_t set p_name ='" + p_nameTextBox.Text + "', p_adress ='" + p_adressTextBox.Text + "', p_phone_number ='" + p_phone_numberTextBox.Text + "', DRIVING_LICENSE ='" + dRIVING_LICENSETextBox.Text + "', dop_phone_nuber ='" + dop_phone_numberTextBox.Text + "', dop_DRIVING_LICENSE ='" + dop_DRIVING_LICENSETextBox.Text + "' where p_id ='" + p_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Client();
            MessageBox.Show("Информация успешно изменена");
            p_idTextBox.Text = "";
            p_nameTextBox.Text = "";
            p_adressTextBox.Text = "";
            p_phone_numberTextBox.Text = "";
            dRIVING_LICENSETextBox.Text = "";
            dop_phone_numberTextBox.Text = "";
            dop_DRIVING_LICENSETextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update car_t set p_name ='" + c_numberTextBox.Text + "', p_adress ='" + c_brandTextBox.Text + "', p_phone_number ='" + c_colorTextBox.Text + "' where p_id ='" + c_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Car();
            MessageBox.Show("Информация успешно изменена");
            c_idTextBox.Text = "";
            c_numberTextBox.Text = "";
            c_brandTextBox.Text = "";
            c_colorTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update ORDER_T set DESCRIPT ='" + dESCRIPTTextBox.Text + "', PRICE ='" + pRICETextBox.Text + "', id_worker ='" + id_workerTextBox.Text + "', id_garage ='" + id_garageTextBox.Text + "', id_car ='" + id_carTextBox.Text + "', id_client ='" + id_clientTextBox.Text + "', DATATIME_fix_start ='" + dATATIME_fix_startDateTimePicker.Text + "', DATATIME_fix_finish ='" + dATATIME_fix_finishDateTimePicker.Text + "' where id ='" + idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Order();
            MessageBox.Show("Информация успешно изменена");
            idTextBox.Text = "";
            dESCRIPTTextBox.Text = "";
            pRICETextBox.Text = "";
            id_workerTextBox.Text = "";

            id_garageTextBox.Text = "";
            id_carTextBox.Text = "";
            id_clientTextBox.Text = "";
            dATATIME_fix_startDateTimePicker.Text = "";
            dATATIME_fix_finishDateTimePicker.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into order_T values('" + idTextBox .Text + "','" + dESCRIPTTextBox.Text + "','" + pRICETextBox.Text + "','" + id_workerTextBox.Text + "','" + id_garageTextBox.Text + "','" + id_carTextBox.Text + "','" + id_clientTextBox.Text + "','" + dATATIME_fix_startDateTimePicker.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Order();
            MessageBox.Show("Заказ принят");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update ORDER_T set DATATIME_fix_finish ='" + dATATIME_fix_finishDateTimePicker.Text + "' where DATATIME_fix_finish = Null and id ='" + p_idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Order();
            MessageBox.Show("Заказ завершен");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from order_t where id='" + toolStripTextBox1.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Order();
            MessageBox.Show("Заказ удален");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from order_t where id='" + idTextBox.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Order();
            MessageBox.Show("Заказ удален");
        }

        private void oRDER_TBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dATATIME_fix_startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
