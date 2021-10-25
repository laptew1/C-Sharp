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
    public partial class Пользователь : Form
    {
       

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\users1\source\repos\NetMaster\NetMaster\Database1.mdf;Integrated Security=True");
       // conn.Open();
        public Пользователь(string login, string password)
        {
            InitializeComponent();
            
            connection.Open();
            SqlCommand command = new SqlCommand("select  c.p_name 'Ваше имя', O.DESCRIPT 'Описание услуги', O.PRICE 'Цена услуги (в рублях)', m.m_name'Название Мастерской', m.m_adress'Адрс мастеской', w.w_name'Имя механика', O.Datatime_fix_start'Время поступления', O.datatime_fix_finish'Время завершения' from client_t as c JOIN ORDER_T as O ON O.id_client = c .p_id join garage_t as m on m.m_id=O.id_garage join worker_t as w on w.w_id=O.id_worker where p_phone_number='"+login+ "' and Driving_license='" + password + "'", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            datDisplayClient.DataSource = dt;
            textBox1.Text = login;
            SumCheck(login,password);
        }

        private void SumCheck(string login, string password)
        {
            SqlCommand command = new SqlCommand("select  price from client_t as c JOIN ORDER_T as O ON O.id_client = c .p_id  where p_phone_number='" + login + "' and Driving_license='" + password + "'", connection);
           
            SqlDataReader thisReader = command.ExecuteReader();
            int u = 0;
            
            while (thisReader.Read())
             u += Convert.ToInt32(thisReader["price"]);         
            thisReader.Close();
            textSumZak.Text = u.ToString();
            connection.Close();



        }
            private void oRDER_TBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        //    this.Validate();
         //   this.oRDER_TBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Пользователь_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.user_t". При необходимости она может быть перемещена или удалена.
          //  this.user_tTableAdapter.Fill(this.database1DataSet.user_t);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
          //  this.tableTableAdapter.Fill(this.database1DataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.client_t". При необходимости она может быть перемещена или удалена.
            // this.client_tTableAdapter.Fill(this.database1DataSet.client_t);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ORDER_T". При необходимости она может быть перемещена или удалена.
            //   this.oRDER_TTableAdapter.Fill(this.database1DataSet.ORDER_T);
            //     this.car_tTableAdapter.Fill(this.database1DataSet.ORDER_T);

        }

        private void datDisplayClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
