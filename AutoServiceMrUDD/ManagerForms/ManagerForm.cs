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

namespace AutoServiceMrUDD.ManagerForms
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        //При загрузке формы
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            //Загрузка в гриды
            this.пользователиТехникиTableAdapter.FillTechnicList(this.mrudd12DataSet.ПользователиТехники);
            this.автосервисTableAdapter.Fill(this.mrudd12DataSet.Автосервис);
            this.машиныTableAdapter.Fill(this.mrudd12DataSet.Машины);
            this.клиентыTableAdapter.Fill(this.mrudd12DataSet.Клиенты);

            //Убирает вкладки "Выбор клиента", "Готово" и "Заказ"
            tabPageStageSecond.Parent = null;
            tabPageStageFinished.Parent = null;
            tabPageNaklCart.Parent = null;

            //Загружает законченные техником накладные
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand findfinishednaklscommand = new SqlCommand("SELECT Накладные.idНакладная  AS 'Номер накладной', Клиенты.Фамилия AS 'Фамилия клиента', Клиенты.Имя  AS 'Имя клиента', Клиенты.Отчество  AS 'Отчество клиента', Клиенты.Телефон  AS 'Номер телефона', Машины.марка  AS 'Марка машины', Машины.модель  AS 'Модель машины', Накладные.дата  AS 'Дата создания' FROM Накладные INNER JOIN Клиенты ON Накладные.idКлиента = Клиенты.idКлиента INNER JOIN Машины ON Накладные.idКлиента = Машины.idКлиента WHERE Состояние = N'Завершена'", db.getConnection());
            adapter.SelectCommand = findfinishednaklscommand;
            DataTable findfinishednaklstable = new DataTable();
            adapter.Fill(findfinishednaklstable);
            dataGridViewListNakl.DataSource = findfinishednaklstable;

        }


        /*
         * 
         * 
         * ВСЁ что с созданием накладной
         * 
         */
        //Обновление табличек изнутри
        private void updateclientbutton_Click(object sender, EventArgs e)
        {
            this.клиентыTableAdapter.Update(this.mrudd12DataSet.Клиенты);
        }
        private void updateautobutton_Click(object sender, EventArgs e)
        {
            this.машиныTableAdapter.Update(this.mrudd12DataSet.Машины);
        }

        //Кнопка "дальше" для выбора техника
        private void nextbutton_Click(object sender, EventArgs e)
        {
            //Вставляет вкладку и переключает на неё
            tabControlStages.TabPages.Insert(1, tabPageStageSecond);
            tabControlStages.SelectedIndex = 1;

            //Выключает кнопки
            nextbutton.Enabled = false;
            updateclientbutton.Enabled = false;
            updateautobutton.Enabled = false;

            //Выключает гриды
            dataGridViewClients.Enabled = false;
            dataGridViewClientsAuto.Enabled = false;
        }

        //ВСЁ что с созданием накладной (Страница - выбор техника)
        private void backbutton_Click(object sender, EventArgs e)
        {
            //При нажатии назад - возврат всего что отобрал
            tabControlStages.SelectedIndex = 0;
            tabPageStageSecond.Parent = null;
            nextbutton.Enabled = true;
            updateclientbutton.Enabled = true;
            updateautobutton.Enabled = true;
            dataGridViewClients.Enabled = true;
            dataGridViewClientsAuto.Enabled = true;
        }

        //Создание накладной
        private void createbutton_Click(object sender, EventArgs e)
        {
            DateTime timenow = DateTime.Now;

            //Переменные с текущеми выделенными строчками в гриде
            DataGridViewRow currentClientRow = dataGridViewClients.CurrentRow;
            DataGridViewRow currentClientAutoRow = dataGridViewClientsAuto.CurrentRow;
            DataGridViewRow currentAutoServiceRow = dataGridViewAutoServices.CurrentRow;
            DataGridViewRow currentTechnicRow = dataGridViewTechnics.CurrentRow;

            //Если они не пустые ^^^
            if (currentClientRow != null && currentClientAutoRow != null && currentAutoServiceRow != null && currentTechnicRow != null)
            {
                //Вытаскивают нужные поля из стобцов ^^^
                int clientid = Convert.ToInt32(currentClientRow.Cells[0].Value);
                int clientautoid = Convert.ToInt32(currentClientAutoRow.Cells[0].Value);
                int autoserviceid = Convert.ToInt32(currentAutoServiceRow.Cells[0].Value);
                int technicid = Convert.ToInt32(currentTechnicRow.Cells[0].Value);

                //Ввод данных в базу данных
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable createnakltable = new DataTable();

                SqlCommand createnaklcommand = new SqlCommand("INSERT Накладные(idПользователя, дата, idКлиента, idАвтосервиса, idМашины, Состояние)VALUES(@TI,@TD,@CI,@AI,@CAI, N'Активно')", db.getConnection());
                createnaklcommand.Parameters.Add("@TI", SqlDbType.Int).Value = technicid;
                createnaklcommand.Parameters.Add("@TD", SqlDbType.DateTime).Value = timenow;
                createnaklcommand.Parameters.Add("@CI", SqlDbType.Int).Value = clientid;
                createnaklcommand.Parameters.Add("@AI", SqlDbType.Int).Value = autoserviceid;
                createnaklcommand.Parameters.Add("@CAI", SqlDbType.Int).Value = clientautoid;
                adapter.SelectCommand = createnaklcommand;
                adapter.Fill(createnakltable);

                //Переход к вкладке готово и выключение всех прошлых кнопок
                backbutton.Enabled = false;
                createbutton.Enabled = false;
                tabControlStages.TabPages.Insert(2, tabPageStageFinished);
                tabControlStages.SelectedIndex = 2;
                dataGridViewAutoServices.Enabled = false;
                dataGridViewTechnics.Enabled = false;
            }
            else { MessageBox.Show("Вы где-то допустили ошибку!"); }
        }

        //Кнопка ОК, чисто откат к начальному состоянию
        private void okbutton_Click(object sender, EventArgs e)
        {
            tabControlStages.SelectedIndex = 0;
            tabPageStageSecond.Parent = null;
            tabPageStageFinished.Parent = null;
            backbutton.Enabled = true;
            nextbutton.Enabled = true;
            createbutton.Enabled = true;
            updateclientbutton.Enabled = true;
            updateautobutton.Enabled = true;
            dataGridViewClients.Enabled = true;
            dataGridViewClientsAuto.Enabled = true;
            dataGridViewAutoServices.Enabled = true;
            dataGridViewTechnics.Enabled = true;
        }


        /*
         * 
         * Вкладка накладные
         * 
         */
        //Открытие корзины конкретной накладной
        private void infonaklbutton_Click(object sender, EventArgs e)
        {
            //Добавление вкладки корзины
            tabControl1.TabPages.Insert(1, tabPageNaklCart);
            tabControl1.SelectedIndex = 1;
            dataGridViewListNakl.Enabled = false;
            infonaklbutton.Enabled = false;

            //Уже было такое - просто айди накладной и загрузка корзины в грид
            DataGridViewRow currentListNaklRow = dataGridViewListNakl.CurrentRow;
            int naklid = Convert.ToInt32(currentListNaklRow.Cells[0].Value);

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable infonakltable = new DataTable();

            SqlCommand infonaklcommand = new SqlCommand("SELECT Корзина.idУслуги AS 'Номер услуги', Услуги.название AS 'Название услуги', Корзина.цена AS 'Стоимость' FROM Корзина INNER JOIN Услуги ON корзина.idУслуги = Услуги.idУслуги WHERE idНакладная = @NI", db.getConnection());
            infonaklcommand.Parameters.Add("@NI", SqlDbType.Int).Value = naklid;
            adapter.SelectCommand = infonaklcommand;
            adapter.Fill(infonakltable);
            dataGridViewInfoNakl.DataSource = infonakltable;

            //На случай если в накладной нет услуг, если есть то подсчитывает общий итог и вставляет в строчку
            if (infonakltable.Rows.Count > 0)
            {

                DataTable sumtable = new DataTable();

                SqlCommand sumcommand = new SqlCommand("SELECT sum(Корзина.цена) AS 'Итог' FROM Корзина INNER JOIN Услуги ON корзина.idУслуги = Услуги.idУслуги WHERE idНакладная = @NI", db.getConnection());
                sumcommand.Parameters.Add("@NI", SqlDbType.Int).Value = naklid;
                adapter.SelectCommand = sumcommand;
                adapter.Fill(sumtable);

                sumlabel.Text = sumtable.Rows[0].Field<double>("Итог").ToString();
            }
            else { sumlabel.Text = ("Услуги не добавлены!"); }
        }

        //Выход из накладной, без утверждения оплаты
        private void backlistnaklbutton_Click(object sender, EventArgs e)
        {
            //Подобный приём как при создании
            dataGridViewListNakl.Enabled = true;
            infonaklbutton.Enabled = true;
            tabControl1.SelectedIndex = 0;
            tabPageNaklCart.Parent = null;

            //Подгрузка накладных в грид
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable findfinishednaklstable = new DataTable();
            SqlCommand findfinishednaklscommand = new SqlCommand("SELECT Накладные.idНакладная  AS 'Номер накладной', Клиенты.Фамилия AS 'Фамилия клиента', Клиенты.Имя  AS 'Имя клиента', Клиенты.Отчество  AS 'Отчество клиента', Клиенты.Телефон  AS 'Номер телефона', Машины.марка  AS 'Марка машины', Машины.модель  AS 'Модель машины', Накладные.дата  AS 'Дата создания' FROM Накладные INNER JOIN Клиенты ON Накладные.idКлиента = Клиенты.idКлиента INNER JOIN Машины ON Накладные.idКлиента = Машины.idКлиента WHERE Состояние = N'Завершена'", db.getConnection());
            adapter.SelectCommand = findfinishednaklscommand;
            adapter.Fill(findfinishednaklstable);
            dataGridViewListNakl.DataSource = findfinishednaklstable;

        }

        //Кнопка для отметки оплаты накладной
        private void paymentdonebutton_Click(object sender, EventArgs e)
        {
            //Номер накладной из первой вкладки
            DataGridViewRow currentListNaklRow = dataGridViewListNakl.CurrentRow;
            int naklid = Convert.ToInt32(currentListNaklRow.Cells[0].Value);

            //Возврат к начальной стадии
            dataGridViewListNakl.Enabled = true;
            infonaklbutton.Enabled = true;
            tabControl1.SelectedIndex = 0;
            tabPageNaklCart.Parent = null;

            //Обновление статуса накладной
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable finishnakltable = new DataTable();
            SqlCommand finishnaklcommand = new SqlCommand("UPDATE Накладные SET Состояние = N'Оплачено' WHERE idНакладная = @NI", db.getConnection());
            finishnaklcommand.Parameters.Add("@NI", SqlDbType.Int).Value = naklid;
            adapter.SelectCommand = finishnaklcommand;
            adapter.Fill(finishnakltable);

            //Подгрузка накладных в грид
            DataTable findfinishednaklstable = new DataTable();
            SqlCommand findfinishednaklscommand = new SqlCommand("SELECT Накладные.idНакладная  AS 'Номер накладной', Клиенты.Фамилия AS 'Фамилия клиента', Клиенты.Имя  AS 'Имя клиента', Клиенты.Отчество  AS 'Отчество клиента', Клиенты.Телефон  AS 'Номер телефона', Машины.марка  AS 'Марка машины', Машины.модель  AS 'Модель машины', Накладные.дата  AS 'Дата создания' FROM Накладные INNER JOIN Клиенты ON Накладные.idКлиента = Клиенты.idКлиента INNER JOIN Машины ON Накладные.idКлиента = Машины.idКлиента WHERE Состояние = N'Завершена'", db.getConnection());
            adapter.SelectCommand = findfinishednaklscommand;
            adapter.Fill(findfinishednaklstable);
            dataGridViewListNakl.DataSource = findfinishednaklstable;
        }
    }
}
