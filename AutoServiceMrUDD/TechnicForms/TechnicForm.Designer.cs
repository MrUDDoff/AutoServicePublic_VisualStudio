namespace AutoServiceMrUDD.TechnicForms
{
    partial class TechnicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNakList = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nextbutton = new System.Windows.Forms.Button();
            this.dataGridViewListNakl = new System.Windows.Forms.DataGridView();
            this.tabPageWorkWithNakl = new System.Windows.Forms.TabPage();
            this.tabControlNakl = new System.Windows.Forms.TabControl();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewListServices = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.createservicebutton = new System.Windows.Forms.Button();
            this.serviceaddtocartbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.NameServicetextBox = new System.Windows.Forms.TextBox();
            this.PriceServicenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VidscomboBox = new System.Windows.Forms.ComboBox();
            this.mrudd12DataSet = new AutoServiceMrUDD.mrudd12DataSet();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewListDetails = new System.Windows.Forms.DataGridView();
            this.idДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idУслугиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деталиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updatedetailsbutton = new System.Windows.Forms.Button();
            this.tabPageCart = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.backbutton = new System.Windows.Forms.Button();
            this.finishbutton = new System.Windows.Forms.Button();
            this.removepositionbutton = new System.Windows.Forms.Button();
            this.dataGridViewCartList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idВидУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деталиTableAdapter = new AutoServiceMrUDD.mrudd12DataSetTableAdapters.ДеталиTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageNakList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListNakl)).BeginInit();
            this.tabPageWorkWithNakl.SuspendLayout();
            this.tabControlNakl.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListServices)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceServicenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrudd12DataSet)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).BeginInit();
            this.tabPageCart.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNakList);
            this.tabControl1.Controls.Add(this.tabPageWorkWithNakl);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageNakList
            // 
            this.tabPageNakList.Controls.Add(this.tableLayoutPanel1);
            this.tabPageNakList.Location = new System.Drawing.Point(4, 22);
            this.tabPageNakList.Name = "tabPageNakList";
            this.tabPageNakList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNakList.Size = new System.Drawing.Size(792, 424);
            this.tabPageNakList.TabIndex = 0;
            this.tabPageNakList.Text = "Список активных накладных";
            this.tabPageNakList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.6056F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.3944F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewListNakl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.nextbutton, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(668, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.66019F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8932F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.29126F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.41748F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(115, 412);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nextbutton
            // 
            this.nextbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextbutton.Location = new System.Drawing.Point(3, 138);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(109, 75);
            this.nextbutton.TabIndex = 0;
            this.nextbutton.Text = "Далее >>";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // dataGridViewListNakl
            // 
            this.dataGridViewListNakl.AllowUserToAddRows = false;
            this.dataGridViewListNakl.AllowUserToDeleteRows = false;
            this.dataGridViewListNakl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListNakl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListNakl.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewListNakl.MultiSelect = false;
            this.dataGridViewListNakl.Name = "dataGridViewListNakl";
            this.dataGridViewListNakl.ReadOnly = true;
            this.dataGridViewListNakl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListNakl.Size = new System.Drawing.Size(659, 412);
            this.dataGridViewListNakl.TabIndex = 1;
            // 
            // tabPageWorkWithNakl
            // 
            this.tabPageWorkWithNakl.Controls.Add(this.tabControlNakl);
            this.tabPageWorkWithNakl.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkWithNakl.Name = "tabPageWorkWithNakl";
            this.tabPageWorkWithNakl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkWithNakl.Size = new System.Drawing.Size(792, 424);
            this.tabPageWorkWithNakl.TabIndex = 1;
            this.tabPageWorkWithNakl.Text = "Работа с накладной";
            this.tabPageWorkWithNakl.UseVisualStyleBackColor = true;
            // 
            // tabControlNakl
            // 
            this.tabControlNakl.Controls.Add(this.tabPageServices);
            this.tabControlNakl.Controls.Add(this.tabPageDetails);
            this.tabControlNakl.Controls.Add(this.tabPageCart);
            this.tabControlNakl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNakl.Location = new System.Drawing.Point(3, 3);
            this.tabControlNakl.Name = "tabControlNakl";
            this.tabControlNakl.SelectedIndex = 0;
            this.tabControlNakl.Size = new System.Drawing.Size(786, 418);
            this.tabControlNakl.TabIndex = 0;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Controls.Add(this.tableLayoutPanel3);
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(778, 392);
            this.tabPageServices.TabIndex = 0;
            this.tabPageServices.Text = "Услуги";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewListServices, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.53368F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46632F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 386);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridViewListServices
            // 
            this.dataGridViewListServices.AllowUserToAddRows = false;
            this.dataGridViewListServices.AllowUserToDeleteRows = false;
            this.dataGridViewListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListServices.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewListServices.MultiSelect = false;
            this.dataGridViewListServices.Name = "dataGridViewListServices";
            this.dataGridViewListServices.ReadOnly = true;
            this.dataGridViewListServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListServices.Size = new System.Drawing.Size(766, 301);
            this.dataGridViewListServices.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 310);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(766, 73);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.19889F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.80111F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tableLayoutPanel9.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.createservicebutton, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.serviceaddtocartbutton, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(760, 30);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 24);
            this.button5.TabIndex = 0;
            this.button5.Text = "Удалить услугу";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // createservicebutton
            // 
            this.createservicebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createservicebutton.Location = new System.Drawing.Point(162, 3);
            this.createservicebutton.Name = "createservicebutton";
            this.createservicebutton.Size = new System.Drawing.Size(195, 24);
            this.createservicebutton.TabIndex = 1;
            this.createservicebutton.Text = "Добавить услугу";
            this.createservicebutton.UseVisualStyleBackColor = true;
            this.createservicebutton.Click += new System.EventHandler(this.createservicebutton_Click);
            // 
            // serviceaddtocartbutton
            // 
            this.serviceaddtocartbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceaddtocartbutton.Location = new System.Drawing.Point(363, 3);
            this.serviceaddtocartbutton.Name = "serviceaddtocartbutton";
            this.serviceaddtocartbutton.Size = new System.Drawing.Size(394, 24);
            this.serviceaddtocartbutton.TabIndex = 2;
            this.serviceaddtocartbutton.Text = "Добавить в корзину >>";
            this.serviceaddtocartbutton.UseVisualStyleBackColor = true;
            this.serviceaddtocartbutton.Click += new System.EventHandler(this.serviceaddtocartbutton_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.NameServicetextBox, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.PriceServicenumericUpDown, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.VidscomboBox, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(760, 31);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // NameServicetextBox
            // 
            this.NameServicetextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameServicetextBox.Location = new System.Drawing.Point(3, 3);
            this.NameServicetextBox.Multiline = true;
            this.NameServicetextBox.Name = "NameServicetextBox";
            this.NameServicetextBox.Size = new System.Drawing.Size(247, 25);
            this.NameServicetextBox.TabIndex = 0;
            // 
            // PriceServicenumericUpDown
            // 
            this.PriceServicenumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceServicenumericUpDown.Location = new System.Drawing.Point(256, 3);
            this.PriceServicenumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PriceServicenumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceServicenumericUpDown.Name = "PriceServicenumericUpDown";
            this.PriceServicenumericUpDown.Size = new System.Drawing.Size(247, 20);
            this.PriceServicenumericUpDown.TabIndex = 1;
            this.PriceServicenumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // VidscomboBox
            // 
            this.VidscomboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VidscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VidscomboBox.FormattingEnabled = true;
            this.VidscomboBox.Location = new System.Drawing.Point(509, 3);
            this.VidscomboBox.Name = "VidscomboBox";
            this.VidscomboBox.Size = new System.Drawing.Size(248, 21);
            this.VidscomboBox.TabIndex = 2;
            this.VidscomboBox.ValueMember = "idВидУслуги";
            // 
            // mrudd12DataSet
            // 
            this.mrudd12DataSet.DataSetName = "mrudd12DataSet";
            this.mrudd12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.tableLayoutPanel4);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(778, 392);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Детали";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewListDetails, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.updatedetailsbutton, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.89637F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10363F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(772, 386);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridViewListDetails
            // 
            this.dataGridViewListDetails.AutoGenerateColumns = false;
            this.dataGridViewListDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idДеталиDataGridViewTextBoxColumn,
            this.idУслугиDataGridViewTextBoxColumn1,
            this.производительDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn1,
            this.ценаDataGridViewTextBoxColumn1});
            this.dataGridViewListDetails.DataSource = this.деталиBindingSource;
            this.dataGridViewListDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListDetails.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewListDetails.MultiSelect = false;
            this.dataGridViewListDetails.Name = "dataGridViewListDetails";
            this.dataGridViewListDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListDetails.Size = new System.Drawing.Size(766, 341);
            this.dataGridViewListDetails.TabIndex = 0;
            // 
            // idДеталиDataGridViewTextBoxColumn
            // 
            this.idДеталиDataGridViewTextBoxColumn.DataPropertyName = "idДетали";
            this.idДеталиDataGridViewTextBoxColumn.HeaderText = "Номер детали";
            this.idДеталиDataGridViewTextBoxColumn.Name = "idДеталиDataGridViewTextBoxColumn";
            this.idДеталиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idУслугиDataGridViewTextBoxColumn1
            // 
            this.idУслугиDataGridViewTextBoxColumn1.DataPropertyName = "idУслуги";
            this.idУслугиDataGridViewTextBoxColumn1.HeaderText = "Номер услуги";
            this.idУслугиDataGridViewTextBoxColumn1.Name = "idУслугиDataGridViewTextBoxColumn1";
            this.idУслугиDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            // 
            // ценаDataGridViewTextBoxColumn1
            // 
            this.ценаDataGridViewTextBoxColumn1.DataPropertyName = "цена";
            this.ценаDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn1.Name = "ценаDataGridViewTextBoxColumn1";
            // 
            // деталиBindingSource
            // 
            this.деталиBindingSource.DataMember = "Детали";
            this.деталиBindingSource.DataSource = this.mrudd12DataSet;
            // 
            // updatedetailsbutton
            // 
            this.updatedetailsbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatedetailsbutton.Location = new System.Drawing.Point(3, 350);
            this.updatedetailsbutton.Name = "updatedetailsbutton";
            this.updatedetailsbutton.Size = new System.Drawing.Size(766, 33);
            this.updatedetailsbutton.TabIndex = 1;
            this.updatedetailsbutton.Text = "Обновить детали";
            this.updatedetailsbutton.UseVisualStyleBackColor = true;
            this.updatedetailsbutton.Click += new System.EventHandler(this.updatedetailsbutton_Click);
            // 
            // tabPageCart
            // 
            this.tabPageCart.Controls.Add(this.tableLayoutPanel5);
            this.tabPageCart.Location = new System.Drawing.Point(4, 22);
            this.tabPageCart.Name = "tabPageCart";
            this.tabPageCart.Size = new System.Drawing.Size(778, 392);
            this.tabPageCart.TabIndex = 2;
            this.tabPageCart.Text = "Корзина";
            this.tabPageCart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dataGridViewCartList, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(778, 392);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.backbutton, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.finishbutton, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.removepositionbutton, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 353);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(772, 36);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // backbutton
            // 
            this.backbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backbutton.Location = new System.Drawing.Point(3, 3);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(251, 30);
            this.backbutton.TabIndex = 0;
            this.backbutton.Text = "<< Назад";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // finishbutton
            // 
            this.finishbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishbutton.Location = new System.Drawing.Point(517, 3);
            this.finishbutton.Name = "finishbutton";
            this.finishbutton.Size = new System.Drawing.Size(252, 30);
            this.finishbutton.TabIndex = 1;
            this.finishbutton.Text = "Завершить накладную >>";
            this.finishbutton.UseVisualStyleBackColor = true;
            this.finishbutton.Click += new System.EventHandler(this.finishbutton_Click);
            // 
            // removepositionbutton
            // 
            this.removepositionbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removepositionbutton.Location = new System.Drawing.Point(260, 3);
            this.removepositionbutton.Name = "removepositionbutton";
            this.removepositionbutton.Size = new System.Drawing.Size(251, 30);
            this.removepositionbutton.TabIndex = 2;
            this.removepositionbutton.Text = "Удалить позицию";
            this.removepositionbutton.UseVisualStyleBackColor = true;
            this.removepositionbutton.Click += new System.EventHandler(this.removepositionbutton_Click);
            // 
            // dataGridViewCartList
            // 
            this.dataGridViewCartList.AllowUserToAddRows = false;
            this.dataGridViewCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCartList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCartList.MultiSelect = false;
            this.dataGridViewCartList.Name = "dataGridViewCartList";
            this.dataGridViewCartList.ReadOnly = true;
            this.dataGridViewCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCartList.Size = new System.Drawing.Size(772, 344);
            this.dataGridViewCartList.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 340);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(772, 49);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(389, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(380, 43);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // idУслугиDataGridViewTextBoxColumn
            // 
            this.idУслугиDataGridViewTextBoxColumn.DataPropertyName = "idУслуги";
            this.idУслугиDataGridViewTextBoxColumn.HeaderText = "idУслуги";
            this.idУслугиDataGridViewTextBoxColumn.Name = "idУслугиDataGridViewTextBoxColumn";
            this.idУслугиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // idВидУслугиDataGridViewTextBoxColumn
            // 
            this.idВидУслугиDataGridViewTextBoxColumn.DataPropertyName = "idВидУслуги";
            this.idВидУслугиDataGridViewTextBoxColumn.HeaderText = "idВидУслуги";
            this.idВидУслугиDataGridViewTextBoxColumn.Name = "idВидУслугиDataGridViewTextBoxColumn";
            // 
            // видУслугиDataGridViewTextBoxColumn
            // 
            this.видУслугиDataGridViewTextBoxColumn.DataPropertyName = "Вид услуги";
            this.видУслугиDataGridViewTextBoxColumn.HeaderText = "Вид услуги";
            this.видУслугиDataGridViewTextBoxColumn.Name = "видУслугиDataGridViewTextBoxColumn";
            this.видУслугиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // деталиTableAdapter
            // 
            this.деталиTableAdapter.ClearBeforeFill = true;
            // 
            // TechnicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TechnicForm";
            this.Text = "TechnicForm";
            this.Activated += new System.EventHandler(this.TechnicForm_Activated);
            this.Load += new System.EventHandler(this.TechnicForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNakList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListNakl)).EndInit();
            this.tabPageWorkWithNakl.ResumeLayout(false);
            this.tabControlNakl.ResumeLayout(false);
            this.tabPageServices.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListServices)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceServicenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrudd12DataSet)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).EndInit();
            this.tabPageCart.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNakList;
        private System.Windows.Forms.TabPage tabPageWorkWithNakl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewListNakl;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.TabControl tabControlNakl;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridViewListDetails;
        private mrudd12DataSet mrudd12DataSet;
        private System.Windows.Forms.DataGridView dataGridViewListServices;
        private System.Windows.Forms.Button updatedetailsbutton;
        private System.Windows.Forms.TabPage tabPageCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button finishbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idВидУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource деталиBindingSource;
        private mrudd12DataSetTableAdapters.ДеталиTableAdapter деталиTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCartList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button createservicebutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox NameServicetextBox;
        private System.Windows.Forms.NumericUpDown PriceServicenumericUpDown;
        private System.Windows.Forms.ComboBox VidscomboBox;
        private System.Windows.Forms.Button serviceaddtocartbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idУслугиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button removepositionbutton;
    }
}