using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoServiceMrUDD.ManagerForms;
using AutoServiceMrUDD.TechnicForms;

namespace AutoServiceMrUDD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public int idUser = 0;

        public void loginButton_Click(object sender, EventArgs e)
        {
            if (loginField.Text != "" && passField.Text != "")
            {
                DB db = new DB();

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand logincommand = new SqlCommand("SELECT * FROM Пользователи WHERE Логин = @UL ANd Пароль = @UP", db.getConnection());
                logincommand.Parameters.Add("@UL", SqlDbType.NVarChar).Value = loginField.Text;
                logincommand.Parameters.Add("@UP", SqlDbType.NVarChar).Value = passField.Text;
                adapter.SelectCommand = logincommand;

                DataTable logintable = new DataTable();
                adapter.Fill(logintable);

                if (logintable.Rows.Count > 0)
                {
                    idUser = logintable.Rows[0].Field<int>("idПользователя");

                    MessageBox.Show("Вы авторизованы");

                    if (logintable.Rows[0].Field<int>("idРоль") == 1)
                    {
                        this.Hide();
                        ManagerForm managerform = new ManagerForm();
                        managerform.Show();
                    }
                    else
                    {
                        this.Hide();
                        TechnicForm technicform = new TechnicForm();
                        technicform.Owner = this;
                        technicform.Show();
                    }
                }
                else { MessageBox.Show("Такого пользователя не существует!"); }
            }
            else { MessageBox.Show("Ваши поля пустые!"); }
        }
    }
}
