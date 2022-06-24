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

namespace AutoServiceMrUDD.TechnicForms
{
    public partial class TechnicForm : Form
    {
        public TechnicForm()
        {
            InitializeComponent();
        }

        private void TechnicForm_Load(object sender, EventArgs e)
        {
            //Загрузка в грид
            this.деталиTableAdapter.Fill(this.mrudd12DataSet.Детали);

            //Айдишник техника из логин формы
            LoginForm loginform = (LoginForm)this.Owner;
            int idUser = loginform.idUser;

            //Подгрузка активных накладных для техника
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable naklfortechnic = new DataTable();

            SqlCommand findnaklcommand = new SqlCommand("SELECT Накладные.idНакладная AS 'Номер накладной', Накладные.дата AS 'Дата создания накладной', Клиенты.Фамилия AS 'Фамилия клиента', Клиенты.Имя AS 'Имя клиента', Машины.марка AS 'Марка машины', Машины.модель AS 'Модель машины' FROM Накладные INNER JOIN Клиенты ON Клиенты.idКлиента = Накладные.idКлиента INNER JOIN Машины ON Машины.idМашины = Накладные.idМашины WHERE idПользователя = @UID AND Состояние = N'Активно'", db.getConnection());
            findnaklcommand.Parameters.Add("@UID", SqlDbType.Int).Value = idUser;
            adapter.SelectCommand = findnaklcommand;
            adapter.Fill(naklfortechnic);
            dataGridViewListNakl.DataSource = naklfortechnic;

            //Убирает вкладку работа с накладной
            tabPageWorkWithNakl.Parent = null;
        }

        //Подгрузка услуг техника в грид
        private void TechnicForm_Activated(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable servicestable = new DataTable();

            SqlCommand findservicescommand = new SqlCommand("SELECT Услуги.idУслуги AS 'Номер услуги', Услуги.название AS 'Название услуги', Услуги.Цена AS 'Стоимость услуги', ВидУслуги.наименование AS 'Вид услуги' FROM Услуги INNER JOIN ВидУслуги ON ВидУслуги.idВидУслуги = Услуги.idВидУслуги", db.getConnection());
            adapter.SelectCommand = findservicescommand;
            adapter.Fill(servicestable);
            dataGridViewListServices.DataSource = servicestable;
        }

        //Кнопка для открытия накладной
        private void nextbutton_Click(object sender, EventArgs e)
        {
            //Номер накладной
            DataGridViewRow currentnaklRow = dataGridViewListNakl.CurrentRow;
            int naklid = Convert.ToInt32(currentnaklRow.Cells[0].Value);

            //Загрузка корзины для накладной
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable nakltable = new DataTable();

            SqlCommand naklcommand = new SqlCommand("SELECT idКорзина AS 'Номер позиции', Услуги.название AS 'Услуга', Корзина.Цена AS 'Детали+Услуга' FROM Корзина INNER JOIN Услуги ON Услуги.idУслуги = Корзина.idУслуги WHERE idНакладная = @NID", db.getConnection());
            naklcommand.Parameters.Add("@NID", SqlDbType.Int).Value = naklid;
            adapter.SelectCommand = naklcommand;
            adapter.Fill(nakltable);
            dataGridViewCartList.DataSource = nakltable;

            //Добавление самой вкладки для работы с накладной
            tabControl1.TabPages.Insert(1, tabPageWorkWithNakl);
            tabControl1.SelectedIndex = 1;

            //Отключение всех возможностей на первой вкладке
            nextbutton.Enabled = false;
            dataGridViewListNakl.Enabled = false;
        }

        //Создание новой услуги
        private void createservicebutton_Click(object sender, EventArgs e)
        {
            //Если поля не пустые
            if (NameServicetextBox.Text != "" && VidscomboBox.SelectedValue != null)
            {
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable insertnewservicetable = new DataTable();

                SqlCommand insertnewservicecommand = new SqlCommand("INSERT Услуги(название, цена, idВидУслуги)VALUES(@NS,@PS,@VI)", db.getConnection());
                insertnewservicecommand.Parameters.Add("@NS", SqlDbType.NVarChar).Value = NameServicetextBox.Text; //Информация из полей
                insertnewservicecommand.Parameters.Add("@PS", SqlDbType.Float).Value = PriceServicenumericUpDown.Text;
                insertnewservicecommand.Parameters.Add("@VI", SqlDbType.Int).Value = VidscomboBox.SelectedValue;
                adapter.SelectCommand = insertnewservicecommand;
                adapter.Fill(insertnewservicetable);
                MessageBox.Show("Услуга создана!");
            }
        }

        /*
         * 
         * Добавление в корзину через номер услуги
         * 
         * Для начала - проверка есть ли у услуги связанные детали
         * 
         * Если есть, то сумма деталей+услуги = запись в бд
         * 
         * Иначе просто стоимость услуги
         * 
         */
        private void serviceaddtocartbutton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Номер услуги
            DataGridViewRow currentServiceRow = dataGridViewListServices.CurrentRow;
            int serviceid = Convert.ToInt32(currentServiceRow.Cells[0].Value);
            int priceservice = Convert.ToInt32(currentServiceRow.Cells[2].Value);

            //Номер накладной
            DataGridViewRow currentnaklRow = dataGridViewListNakl.CurrentRow;
            int naklid = Convert.ToInt32(currentnaklRow.Cells[0].Value);


            // (!) Проверка наличия детали у услуги (!)
            SqlCommand havedetailservicecommand = new SqlCommand("SELECT Детали.Название AS 'Всего' FROM Детали INNER JOIN Услуги ON Услуги.idУслуги = Детали.idУслуги WHERE Услуги.idУслуги = @SI", db.getConnection());
            havedetailservicecommand.Parameters.Add("@SI", SqlDbType.Int).Value = serviceid;
            adapter.SelectCommand = havedetailservicecommand;
            DataTable havedetailservicetable = new DataTable();
            adapter.Fill(havedetailservicetable);

            // (!) Если у услуги есть деталь (!)
            if (havedetailservicetable.Rows.Count > 0)
            {
                //Сумма деталей к услуге
                SqlCommand totalsumdetailcommand = new SqlCommand("SELECT sum(Детали.цена) AS 'ВсегоДетали' FROM Детали INNER JOIN Услуги ON Услуги.idУслуги = Детали.idУслуги WHERE Услуги.idУслуги = @SI", db.getConnection());
                totalsumdetailcommand.Parameters.Add("@SI", SqlDbType.Int).Value = serviceid;
                adapter.SelectCommand = totalsumdetailcommand;
                DataTable totalsumdetailtable = new DataTable();
                adapter.Fill(totalsumdetailtable);

                //Цена услуги
                SqlCommand sumservicecommand = new SqlCommand("SELECT цена AS 'ВсегоУслуга' FROM Услуги WHERE idУслуги = @SI", db.getConnection());
                sumservicecommand.Parameters.Add("@SI", SqlDbType.Int).Value = serviceid;
                adapter.SelectCommand = sumservicecommand;
                adapter.Fill(totalsumdetailtable);

                //Сумма и цена в переменные
                double pricedetail = totalsumdetailtable.Rows[0].Field<double>("ВсегоДетали");
                double pricesumservice = totalsumdetailtable.Rows[1].Field<double>("ВсегоУслуга");

                //Сумма деталей+услуги
                double sumdetailservice = pricedetail + pricesumservice;

                //Вывод всего в консоль для проверки
                Console.WriteLine("Detail: " + pricedetail + "\n" + "Service: " + pricesumservice + "\n" + "Sum: " + sumdetailservice);

                //Добавление в бд корзины
                SqlCommand addtocardcommand = new SqlCommand("INSERT Корзина(idУслуги, idНакладная, цена)VALUES(@SI,@NID, @TS)", db.getConnection());
                addtocardcommand.Parameters.Add("@SI", SqlDbType.Int).Value = serviceid;
                addtocardcommand.Parameters.Add("@NID", SqlDbType.Int).Value = naklid;
                addtocardcommand.Parameters.Add("@TS", SqlDbType.Float).Value = sumdetailservice;
                adapter.SelectCommand = addtocardcommand;
                DataTable addtocardtable = new DataTable();
                adapter.Fill(addtocardtable);
            }
            else
            {
                //Цена услуги
                SqlCommand sumservicecommand = new SqlCommand("SELECT Услуги.Цена AS 'ВсегоУслуга' FROM Услуги WHERE Услуги.idУслуги = @SI", db.getConnection());
                sumservicecommand.Parameters.Add("@SI", SqlDbType.Int).Value = serviceid;
                adapter.SelectCommand = sumservicecommand;
                DataTable totalsumservicetable = new DataTable();
                adapter.Fill(totalsumservicetable);

                //Переменная для цены
                double pricesumservice = totalsumservicetable.Rows[0].Field<double>("ВсегоУслуга");

                //Добавление в бд корзины
                SqlCommand addtocardcommand = new SqlCommand("INSERT Корзина(idУслуги, idНакладная, цена)VALUES(@SI,@NID, @PS)", db.getConnection());
                addtocardcommand.Parameters.Add("@SI", SqlDbType.Int).Value = serviceid;
                addtocardcommand.Parameters.Add("@NID", SqlDbType.Int).Value = naklid;
                addtocardcommand.Parameters.Add("@PS", SqlDbType.Float).Value = pricesumservice;
                adapter.SelectCommand = addtocardcommand;
                DataTable addtocardtable = new DataTable();
                adapter.Fill(addtocardtable);
            }

            MessageBox.Show("Услуга добавлена в корзину!");
            
            //Обновление корзины после добавления услуги
            SqlCommand naklcommand = new SqlCommand("SELECT idКорзина AS 'Номер позиции', Услуги.название AS 'Услуга', Корзина.Цена AS 'Детали+Услуга' FROM Корзина INNER JOIN Услуги ON Услуги.idУслуги = Корзина.idУслуги WHERE idНакладная = @NID", db.getConnection());
            naklcommand.Parameters.Add("@NID", SqlDbType.Int).Value = naklid;
            adapter.SelectCommand = naklcommand;
            DataTable nakltable = new DataTable();
            adapter.Fill(nakltable);
            dataGridViewCartList.DataSource = nakltable;
        }

        //Кнопка обновления деталей
        private void updatedetailsbutton_Click(object sender, EventArgs e)
        {
            this.деталиTableAdapter.Update(this.mrudd12DataSet.Детали);
            this.деталиTableAdapter.Fill(this.mrudd12DataSet.Детали);
        }

        //Выход из работы над накладной
        private void backbutton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tabPageWorkWithNakl.Parent = null;

            nextbutton.Enabled = true;
            dataGridViewListNakl.Enabled = true;
        }

        //Удалить услугу из корзины
        private void removepositionbutton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentcartRow = dataGridViewCartList.CurrentRow;
            if (currentcartRow != null)
            {
                int positionid = Convert.ToInt32(currentcartRow.Cells[0].Value);


                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand delposcommand = new SqlCommand("DELETE FROM Корзина WHERE idКорзина = @PI", db.getConnection());
                delposcommand.Parameters.Add("@PI", SqlDbType.Int).Value = positionid;
                adapter.SelectCommand = delposcommand;
                DataTable delpostable = new DataTable();
                adapter.Fill(delpostable);

                MessageBox.Show("Позиция удалена!");

                DataGridViewRow currentnaklRow = dataGridViewListNakl.CurrentRow;
                int naklid = Convert.ToInt32(currentnaklRow.Cells[0].Value);

                DataTable nakltable = new DataTable();

                SqlCommand naklcommand = new SqlCommand("SELECT idКорзина AS 'Номер позиции', Услуги.название AS 'Услуга', Корзина.Цена AS 'Детали+Услуга' FROM Корзина INNER JOIN Услуги ON Услуги.idУслуги = Корзина.idУслуги WHERE idНакладная = @NID", db.getConnection());
                naklcommand.Parameters.Add("@NID", SqlDbType.Int).Value = naklid;
                adapter.SelectCommand = naklcommand;
                adapter.Fill(nakltable);
                dataGridViewCartList.DataSource = nakltable;
            }
            else { MessageBox.Show("У вас ничего не выбрано!"); }
        }

        //Кнопка для завершения работы над накладной
        private void finishbutton_Click(object sender, EventArgs e)
        {
            //Номер накладной
            DataGridViewRow currentnaklRow = dataGridViewListNakl.CurrentRow;
            int naklid = Convert.ToInt32(currentnaklRow.Cells[0].Value);

            //Обновление состояния накладной
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand finishnaklcommand = new SqlCommand("UPDATE Накладные SET Состояние = N'Завершена' WHERE idНакладная = @NI", db.getConnection());
            finishnaklcommand.Parameters.Add("NI", SqlDbType.Int).Value = naklid;
            adapter.SelectCommand = finishnaklcommand;
            DataTable finishnakltable = new DataTable();
            adapter.Fill(finishnakltable);

            //Айди техника и подгрузка для него накладных в форму
            LoginForm loginform = (LoginForm)this.Owner;
            int idUser = loginform.idUser;

            DataTable naklfortechnic = new DataTable();

            SqlCommand findnaklcommand = new SqlCommand("SELECT Накладные.idНакладная AS 'Номер накладной', Накладные.дата AS 'Дата создания накладной', Клиенты.Фамилия AS 'Фамилия клиента', Клиенты.Имя AS 'Имя клиента', Машины.марка AS 'Марка машины', Машины.модель AS 'Модель машины' FROM Накладные INNER JOIN Клиенты ON Клиенты.idКлиента = Накладные.idКлиента INNER JOIN Машины ON Машины.idМашины = Накладные.idМашины WHERE idПользователя = @UID AND Состояние = N'Активно'", db.getConnection());
            findnaklcommand.Parameters.Add("@UID", SqlDbType.Int).Value = idUser;
            adapter.SelectCommand = findnaklcommand;
            adapter.Fill(naklfortechnic);
            dataGridViewListNakl.DataSource = naklfortechnic;

            //Возврат вкладок к начальному виду
            tabControl1.SelectedIndex = 0;
            tabPageWorkWithNakl.Parent = null;
            nextbutton.Enabled = true;
            dataGridViewListNakl.Enabled = true;
        }
    }
}
