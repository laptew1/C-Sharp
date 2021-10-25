namespace NetMaster
{
    partial class Manager
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dESCRIPTLabel;
            System.Windows.Forms.Label pRICELabel;
            System.Windows.Forms.Label id_workerLabel;
            System.Windows.Forms.Label id_garageLabel;
            System.Windows.Forms.Label id_carLabel;
            System.Windows.Forms.Label id_clientLabel;
            System.Windows.Forms.Label dATATIME_fix_startLabel;
            System.Windows.Forms.Label dATATIME_fix_finishLabel;
            System.Windows.Forms.Label p_idLabel;
            System.Windows.Forms.Label p_nameLabel;
            System.Windows.Forms.Label p_adressLabel;
            System.Windows.Forms.Label p_phone_numberLabel;
            System.Windows.Forms.Label dRIVING_LICENSELabel;
            System.Windows.Forms.Label dop_phone_numberLabel;
            System.Windows.Forms.Label dop_DRIVING_LICENSELabel;
            System.Windows.Forms.Label c_idLabel;
            System.Windows.Forms.Label c_numberLabel;
            System.Windows.Forms.Label c_brandLabel;
            System.Windows.Forms.Label c_colorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.database1DataSet = new NetMaster.Database1DataSet();
            this.oRDER_TBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDER_TTableAdapter = new NetMaster.Database1DataSetTableAdapters.ORDER_TTableAdapter();
            this.tableAdapterManager = new NetMaster.Database1DataSetTableAdapters.TableAdapterManager();
            this.car_tTableAdapter = new NetMaster.Database1DataSetTableAdapters.car_tTableAdapter();
            this.client_tTableAdapter = new NetMaster.Database1DataSetTableAdapters.client_tTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.oRDER_TBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.oRDER_TBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTTextBox = new System.Windows.Forms.TextBox();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.id_workerTextBox = new System.Windows.Forms.TextBox();
            this.id_garageTextBox = new System.Windows.Forms.TextBox();
            this.id_carTextBox = new System.Windows.Forms.TextBox();
            this.id_clientTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.oRDER_TDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.car_tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.car_tDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_tDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_idTextBox = new System.Windows.Forms.TextBox();
            this.c_numberTextBox = new System.Windows.Forms.TextBox();
            this.c_brandTextBox = new System.Windows.Forms.TextBox();
            this.c_colorTextBox = new System.Windows.Forms.TextBox();
            this.p_idTextBox = new System.Windows.Forms.TextBox();
            this.p_nameTextBox = new System.Windows.Forms.TextBox();
            this.p_adressTextBox = new System.Windows.Forms.TextBox();
            this.p_phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.dRIVING_LICENSETextBox = new System.Windows.Forms.TextBox();
            this.dop_phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.dop_DRIVING_LICENSETextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.dATATIME_fix_startDateTimePicker = new System.Windows.Forms.TextBox();
            this.dATATIME_fix_finishDateTimePicker = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            dESCRIPTLabel = new System.Windows.Forms.Label();
            pRICELabel = new System.Windows.Forms.Label();
            id_workerLabel = new System.Windows.Forms.Label();
            id_garageLabel = new System.Windows.Forms.Label();
            id_carLabel = new System.Windows.Forms.Label();
            id_clientLabel = new System.Windows.Forms.Label();
            dATATIME_fix_startLabel = new System.Windows.Forms.Label();
            dATATIME_fix_finishLabel = new System.Windows.Forms.Label();
            p_idLabel = new System.Windows.Forms.Label();
            p_nameLabel = new System.Windows.Forms.Label();
            p_adressLabel = new System.Windows.Forms.Label();
            p_phone_numberLabel = new System.Windows.Forms.Label();
            dRIVING_LICENSELabel = new System.Windows.Forms.Label();
            dop_phone_numberLabel = new System.Windows.Forms.Label();
            dop_DRIVING_LICENSELabel = new System.Windows.Forms.Label();
            c_idLabel = new System.Windows.Forms.Label();
            c_numberLabel = new System.Windows.Forms.Label();
            c_brandLabel = new System.Windows.Forms.Label();
            c_colorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TBindingNavigator)).BeginInit();
            this.oRDER_TBindingNavigator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_tBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_tDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_tDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_tBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(36, 61);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // dESCRIPTLabel
            // 
            dESCRIPTLabel.AutoSize = true;
            dESCRIPTLabel.Location = new System.Drawing.Point(36, 87);
            dESCRIPTLabel.Name = "dESCRIPTLabel";
            dESCRIPTLabel.Size = new System.Drawing.Size(64, 13);
            dESCRIPTLabel.TabIndex = 3;
            dESCRIPTLabel.Text = "DESCRIPT:";
            // 
            // pRICELabel
            // 
            pRICELabel.AutoSize = true;
            pRICELabel.Location = new System.Drawing.Point(36, 113);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(42, 13);
            pRICELabel.TabIndex = 5;
            pRICELabel.Text = "PRICE:";
            // 
            // id_workerLabel
            // 
            id_workerLabel.AutoSize = true;
            id_workerLabel.Location = new System.Drawing.Point(36, 139);
            id_workerLabel.Name = "id_workerLabel";
            id_workerLabel.Size = new System.Drawing.Size(53, 13);
            id_workerLabel.TabIndex = 7;
            id_workerLabel.Text = "id worker:";
            // 
            // id_garageLabel
            // 
            id_garageLabel.AutoSize = true;
            id_garageLabel.Location = new System.Drawing.Point(36, 165);
            id_garageLabel.Name = "id_garageLabel";
            id_garageLabel.Size = new System.Drawing.Size(54, 13);
            id_garageLabel.TabIndex = 9;
            id_garageLabel.Text = "id garage:";
            // 
            // id_carLabel
            // 
            id_carLabel.AutoSize = true;
            id_carLabel.Location = new System.Drawing.Point(36, 191);
            id_carLabel.Name = "id_carLabel";
            id_carLabel.Size = new System.Drawing.Size(36, 13);
            id_carLabel.TabIndex = 11;
            id_carLabel.Text = "id car:";
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.Location = new System.Drawing.Point(36, 217);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(46, 13);
            id_clientLabel.TabIndex = 13;
            id_clientLabel.Text = "id client:";
            // 
            // dATATIME_fix_startLabel
            // 
            dATATIME_fix_startLabel.AutoSize = true;
            dATATIME_fix_startLabel.Location = new System.Drawing.Point(36, 244);
            dATATIME_fix_startLabel.Name = "dATATIME_fix_startLabel";
            dATATIME_fix_startLabel.Size = new System.Drawing.Size(101, 13);
            dATATIME_fix_startLabel.TabIndex = 15;
            dATATIME_fix_startLabel.Text = "DATATIME fix start:";
            // 
            // dATATIME_fix_finishLabel
            // 
            dATATIME_fix_finishLabel.AutoSize = true;
            dATATIME_fix_finishLabel.Location = new System.Drawing.Point(36, 270);
            dATATIME_fix_finishLabel.Name = "dATATIME_fix_finishLabel";
            dATATIME_fix_finishLabel.Size = new System.Drawing.Size(105, 13);
            dATATIME_fix_finishLabel.TabIndex = 17;
            dATATIME_fix_finishLabel.Text = "DATATIME fix finish:";
            // 
            // p_idLabel
            // 
            p_idLabel.AutoSize = true;
            p_idLabel.Location = new System.Drawing.Point(25, 40);
            p_idLabel.Name = "p_idLabel";
            p_idLabel.Size = new System.Drawing.Size(21, 13);
            p_idLabel.TabIndex = 0;
            p_idLabel.Text = " id:";
            // 
            // p_nameLabel
            // 
            p_nameLabel.AutoSize = true;
            p_nameLabel.Location = new System.Drawing.Point(25, 66);
            p_nameLabel.Name = "p_nameLabel";
            p_nameLabel.Size = new System.Drawing.Size(37, 13);
            p_nameLabel.TabIndex = 2;
            p_nameLabel.Text = "ИФО:";
            // 
            // p_adressLabel
            // 
            p_adressLabel.AutoSize = true;
            p_adressLabel.Location = new System.Drawing.Point(25, 92);
            p_adressLabel.Name = "p_adressLabel";
            p_adressLabel.Size = new System.Drawing.Size(38, 13);
            p_adressLabel.TabIndex = 4;
            p_adressLabel.Text = "Адрес";
            // 
            // p_phone_numberLabel
            // 
            p_phone_numberLabel.AutoSize = true;
            p_phone_numberLabel.Location = new System.Drawing.Point(25, 118);
            p_phone_numberLabel.Name = "p_phone_numberLabel";
            p_phone_numberLabel.Size = new System.Drawing.Size(55, 13);
            p_phone_numberLabel.TabIndex = 6;
            p_phone_numberLabel.Text = "Телефон:";
            // 
            // dRIVING_LICENSELabel
            // 
            dRIVING_LICENSELabel.AutoSize = true;
            dRIVING_LICENSELabel.Location = new System.Drawing.Point(25, 144);
            dRIVING_LICENSELabel.Name = "dRIVING_LICENSELabel";
            dRIVING_LICENSELabel.Size = new System.Drawing.Size(76, 13);
            dRIVING_LICENSELabel.TabIndex = 8;
            dRIVING_LICENSELabel.Text = "Водит. права:";
            // 
            // dop_phone_numberLabel
            // 
            dop_phone_numberLabel.AutoSize = true;
            dop_phone_numberLabel.Location = new System.Drawing.Point(25, 170);
            dop_phone_numberLabel.Name = "dop_phone_numberLabel";
            dop_phone_numberLabel.Size = new System.Drawing.Size(80, 13);
            dop_phone_numberLabel.TabIndex = 10;
            dop_phone_numberLabel.Text = "Доп. телефон:";
            // 
            // dop_DRIVING_LICENSELabel
            // 
            dop_DRIVING_LICENSELabel.AutoSize = true;
            dop_DRIVING_LICENSELabel.Location = new System.Drawing.Point(25, 196);
            dop_DRIVING_LICENSELabel.Name = "dop_DRIVING_LICENSELabel";
            dop_DRIVING_LICENSELabel.Size = new System.Drawing.Size(88, 13);
            dop_DRIVING_LICENSELabel.TabIndex = 12;
            dop_DRIVING_LICENSELabel.Text = "Доп. вод. права";
            // 
            // c_idLabel
            // 
            c_idLabel.AutoSize = true;
            c_idLabel.Location = new System.Drawing.Point(25, 269);
            c_idLabel.Name = "c_idLabel";
            c_idLabel.Size = new System.Drawing.Size(21, 13);
            c_idLabel.TabIndex = 14;
            c_idLabel.Text = " id:";
            // 
            // c_numberLabel
            // 
            c_numberLabel.AutoSize = true;
            c_numberLabel.Location = new System.Drawing.Point(22, 295);
            c_numberLabel.Name = "c_numberLabel";
            c_numberLabel.Size = new System.Drawing.Size(89, 13);
            c_numberLabel.TabIndex = 16;
            c_numberLabel.Text = "Номер машины:";
            // 
            // c_brandLabel
            // 
            c_brandLabel.AutoSize = true;
            c_brandLabel.Location = new System.Drawing.Point(25, 321);
            c_brandLabel.Name = "c_brandLabel";
            c_brandLabel.Size = new System.Drawing.Size(86, 13);
            c_brandLabel.TabIndex = 18;
            c_brandLabel.Text = "Марка машина:";
            // 
            // c_colorLabel
            // 
            c_colorLabel.AutoSize = true;
            c_colorLabel.Location = new System.Drawing.Point(25, 347);
            c_colorLabel.Name = "c_colorLabel";
            c_colorLabel.Size = new System.Drawing.Size(80, 13);
            c_colorLabel.TabIndex = 20;
            c_colorLabel.Text = "Цвет машины:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDER_TBindingSource
            // 
            this.oRDER_TBindingSource.DataMember = "ORDER_T";
            this.oRDER_TBindingSource.DataSource = this.database1DataSet;
            // 
            // oRDER_TTableAdapter
            // 
            this.oRDER_TTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_tTableAdapter = this.car_tTableAdapter;
            this.tableAdapterManager.client_tTableAdapter = this.client_tTableAdapter;
            this.tableAdapterManager.garage_tTableAdapter = null;
            this.tableAdapterManager.ORDER_TTableAdapter = this.oRDER_TTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NetMaster.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_tTableAdapter = null;
            this.tableAdapterManager.worker_tTableAdapter = null;
            // 
            // car_tTableAdapter
            // 
            this.car_tTableAdapter.ClearBeforeFill = true;
            // 
            // client_tTableAdapter
            // 
            this.client_tTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 453);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dATATIME_fix_finishDateTimePicker);
            this.tabPage1.Controls.Add(this.dATATIME_fix_startDateTimePicker);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.oRDER_TBindingNavigator);
            this.tabPage1.Controls.Add(idLabel);
            this.tabPage1.Controls.Add(this.idTextBox);
            this.tabPage1.Controls.Add(dESCRIPTLabel);
            this.tabPage1.Controls.Add(this.dESCRIPTTextBox);
            this.tabPage1.Controls.Add(pRICELabel);
            this.tabPage1.Controls.Add(this.pRICETextBox);
            this.tabPage1.Controls.Add(id_workerLabel);
            this.tabPage1.Controls.Add(this.id_workerTextBox);
            this.tabPage1.Controls.Add(id_garageLabel);
            this.tabPage1.Controls.Add(this.id_garageTextBox);
            this.tabPage1.Controls.Add(id_carLabel);
            this.tabPage1.Controls.Add(this.id_carTextBox);
            this.tabPage1.Controls.Add(id_clientLabel);
            this.tabPage1.Controls.Add(this.id_clientTextBox);
            this.tabPage1.Controls.Add(dATATIME_fix_startLabel);
            this.tabPage1.Controls.Add(dATATIME_fix_finishLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(426, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Завершить заказ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Принять заказ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Изменить заказ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // oRDER_TBindingNavigator
            // 
            this.oRDER_TBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oRDER_TBindingNavigator.BindingSource = this.oRDER_TBindingSource;
            this.oRDER_TBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oRDER_TBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oRDER_TBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.oRDER_TBindingNavigatorSaveItem});
            this.oRDER_TBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.oRDER_TBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oRDER_TBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oRDER_TBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oRDER_TBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oRDER_TBindingNavigator.Name = "oRDER_TBindingNavigator";
            this.oRDER_TBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oRDER_TBindingNavigator.Size = new System.Drawing.Size(791, 25);
            this.oRDER_TBindingNavigator.TabIndex = 19;
            this.oRDER_TBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // oRDER_TBindingNavigatorSaveItem
            // 
            this.oRDER_TBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oRDER_TBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oRDER_TBindingNavigatorSaveItem.Image")));
            this.oRDER_TBindingNavigatorSaveItem.Name = "oRDER_TBindingNavigatorSaveItem";
            this.oRDER_TBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oRDER_TBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.oRDER_TBindingNavigatorSaveItem.Click += new System.EventHandler(this.oRDER_TBindingNavigatorSaveItem_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(147, 58);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // dESCRIPTTextBox
            // 
            this.dESCRIPTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "DESCRIPT", true));
            this.dESCRIPTTextBox.Location = new System.Drawing.Point(147, 84);
            this.dESCRIPTTextBox.Name = "dESCRIPTTextBox";
            this.dESCRIPTTextBox.Size = new System.Drawing.Size(200, 20);
            this.dESCRIPTTextBox.TabIndex = 4;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(147, 110);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(200, 20);
            this.pRICETextBox.TabIndex = 6;
            // 
            // id_workerTextBox
            // 
            this.id_workerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "id_worker", true));
            this.id_workerTextBox.Location = new System.Drawing.Point(147, 136);
            this.id_workerTextBox.Name = "id_workerTextBox";
            this.id_workerTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_workerTextBox.TabIndex = 8;
            // 
            // id_garageTextBox
            // 
            this.id_garageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "id_garage", true));
            this.id_garageTextBox.Location = new System.Drawing.Point(147, 162);
            this.id_garageTextBox.Name = "id_garageTextBox";
            this.id_garageTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_garageTextBox.TabIndex = 10;
            // 
            // id_carTextBox
            // 
            this.id_carTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "id_car", true));
            this.id_carTextBox.Location = new System.Drawing.Point(147, 188);
            this.id_carTextBox.Name = "id_carTextBox";
            this.id_carTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_carTextBox.TabIndex = 12;
            // 
            // id_clientTextBox
            // 
            this.id_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "id_client", true));
            this.id_clientTextBox.Location = new System.Drawing.Point(147, 214);
            this.id_clientTextBox.Name = "id_clientTextBox";
            this.id_clientTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_clientTextBox.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(this.oRDER_TDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.oRDER_TBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(791, 25);
            this.bindingNavigator1.TabIndex = 20;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Сохранить данные";
            // 
            // oRDER_TDataGridView
            // 
            this.oRDER_TDataGridView.AutoGenerateColumns = false;
            this.oRDER_TDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oRDER_TDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.oRDER_TDataGridView.DataSource = this.oRDER_TBindingSource;
            this.oRDER_TDataGridView.Location = new System.Drawing.Point(3, 31);
            this.oRDER_TDataGridView.Name = "oRDER_TDataGridView";
            this.oRDER_TDataGridView.Size = new System.Drawing.Size(781, 274);
            this.oRDER_TDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPT";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRICE";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRICE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_worker";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_worker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_garage";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_garage";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_car";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_car";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_client";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_client";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DATATIME_fix_start";
            this.dataGridViewTextBoxColumn8.HeaderText = "DATATIME_fix_start";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DATATIME_fix_finish";
            this.dataGridViewTextBoxColumn9.HeaderText = "DATATIME_fix_finish";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.bindingNavigator2);
            this.tabPage3.Controls.Add(this.car_tDataGridView);
            this.tabPage3.Controls.Add(this.client_tDataGridView);
            this.tabPage3.Controls.Add(c_idLabel);
            this.tabPage3.Controls.Add(this.c_idTextBox);
            this.tabPage3.Controls.Add(c_numberLabel);
            this.tabPage3.Controls.Add(this.c_numberTextBox);
            this.tabPage3.Controls.Add(c_brandLabel);
            this.tabPage3.Controls.Add(this.c_brandTextBox);
            this.tabPage3.Controls.Add(c_colorLabel);
            this.tabPage3.Controls.Add(this.c_colorTextBox);
            this.tabPage3.Controls.Add(p_idLabel);
            this.tabPage3.Controls.Add(this.p_idTextBox);
            this.tabPage3.Controls.Add(p_nameLabel);
            this.tabPage3.Controls.Add(this.p_nameTextBox);
            this.tabPage3.Controls.Add(p_adressLabel);
            this.tabPage3.Controls.Add(this.p_adressTextBox);
            this.tabPage3.Controls.Add(p_phone_numberLabel);
            this.tabPage3.Controls.Add(this.p_phone_numberTextBox);
            this.tabPage3.Controls.Add(dRIVING_LICENSELabel);
            this.tabPage3.Controls.Add(this.dRIVING_LICENSETextBox);
            this.tabPage3.Controls.Add(dop_phone_numberLabel);
            this.tabPage3.Controls.Add(this.dop_phone_numberTextBox);
            this.tabPage3.Controls.Add(dop_DRIVING_LICENSELabel);
            this.tabPage3.Controls.Add(this.dop_DRIVING_LICENSETextBox);
            this.tabPage3.Controls.Add(this.bindingNavigator3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Изменить атвомобиль";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Изменить клиента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.BindingSource = this.car_tBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = this.toolStripButton9;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 399);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(791, 25);
            this.bindingNavigator2.TabIndex = 24;
            this.bindingNavigator2.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Добавить";
            // 
            // car_tBindingSource
            // 
            this.car_tBindingSource.DataMember = "car_t";
            this.car_tBindingSource.DataSource = this.database1DataSet;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "для {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Сохранить данные";
            // 
            // car_tDataGridView
            // 
            this.car_tDataGridView.AutoGenerateColumns = false;
            this.car_tDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_tDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.car_tDataGridView.DataSource = this.car_tBindingSource;
            this.car_tDataGridView.Location = new System.Drawing.Point(276, 254);
            this.car_tDataGridView.Name = "car_tDataGridView";
            this.car_tDataGridView.Size = new System.Drawing.Size(498, 139);
            this.car_tDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "c_id";
            this.dataGridViewTextBoxColumn17.HeaderText = "c_id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "c_number";
            this.dataGridViewTextBoxColumn18.HeaderText = "c_number";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "c_brand";
            this.dataGridViewTextBoxColumn19.HeaderText = "c_brand";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "c_color";
            this.dataGridViewTextBoxColumn20.HeaderText = "c_color";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // client_tDataGridView
            // 
            this.client_tDataGridView.AutoGenerateColumns = false;
            this.client_tDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_tDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.client_tDataGridView.DataSource = this.client_tBindingSource;
            this.client_tDataGridView.Location = new System.Drawing.Point(276, 31);
            this.client_tDataGridView.Name = "client_tDataGridView";
            this.client_tDataGridView.Size = new System.Drawing.Size(498, 196);
            this.client_tDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "p_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "p_id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "p_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "p_name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "p_adress";
            this.dataGridViewTextBoxColumn12.HeaderText = "p_adress";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "p_phone_number";
            this.dataGridViewTextBoxColumn13.HeaderText = "p_phone_number";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DRIVING_LICENSE";
            this.dataGridViewTextBoxColumn14.HeaderText = "DRIVING_LICENSE";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "dop_phone_number";
            this.dataGridViewTextBoxColumn15.HeaderText = "dop_phone_number";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "dop_DRIVING_LICENSE";
            this.dataGridViewTextBoxColumn16.HeaderText = "dop_DRIVING_LICENSE";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // client_tBindingSource
            // 
            this.client_tBindingSource.DataMember = "client_t";
            this.client_tBindingSource.DataSource = this.database1DataSet;
            // 
            // c_idTextBox
            // 
            this.c_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_tBindingSource, "c_id", true));
            this.c_idTextBox.Location = new System.Drawing.Point(111, 266);
            this.c_idTextBox.Name = "c_idTextBox";
            this.c_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_idTextBox.TabIndex = 15;
            // 
            // c_numberTextBox
            // 
            this.c_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_tBindingSource, "c_number", true));
            this.c_numberTextBox.Location = new System.Drawing.Point(111, 292);
            this.c_numberTextBox.Name = "c_numberTextBox";
            this.c_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_numberTextBox.TabIndex = 17;
            // 
            // c_brandTextBox
            // 
            this.c_brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_tBindingSource, "c_brand", true));
            this.c_brandTextBox.Location = new System.Drawing.Point(111, 318);
            this.c_brandTextBox.Name = "c_brandTextBox";
            this.c_brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_brandTextBox.TabIndex = 19;
            // 
            // c_colorTextBox
            // 
            this.c_colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_tBindingSource, "c_color", true));
            this.c_colorTextBox.Location = new System.Drawing.Point(111, 344);
            this.c_colorTextBox.Name = "c_colorTextBox";
            this.c_colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_colorTextBox.TabIndex = 21;
            // 
            // p_idTextBox
            // 
            this.p_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.client_tBindingSource, "p_id", true));
            this.p_idTextBox.Location = new System.Drawing.Point(111, 37);
            this.p_idTextBox.Name = "p_idTextBox";
            this.p_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_idTextBox.TabIndex = 1;
            // 
            // p_nameTextBox
            // 
            this.p_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.client_tBindingSource, "p_name", true));
            this.p_nameTextBox.Location = new System.Drawing.Point(111, 63);
            this.p_nameTextBox.Name = "p_nameTextBox";
            this.p_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_nameTextBox.TabIndex = 3;
            // 
            // p_adressTextBox
            // 
            this.p_adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.client_tBindingSource, "p_adress", true));
            this.p_adressTextBox.Location = new System.Drawing.Point(111, 89);
            this.p_adressTextBox.Name = "p_adressTextBox";
            this.p_adressTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_adressTextBox.TabIndex = 5;
            // 
            // p_phone_numberTextBox
            // 
            this.p_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.client_tBindingSource, "p_phone_number", true));
            this.p_phone_numberTextBox.Location = new System.Drawing.Point(111, 115);
            this.p_phone_numberTextBox.Name = "p_phone_numberTextBox";
            this.p_phone_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_phone_numberTextBox.TabIndex = 7;
            // 
            // dRIVING_LICENSETextBox
            // 
            this.dRIVING_LICENSETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.client_tBindingSource, "DRIVING_LICENSE", true));
            this.dRIVING_LICENSETextBox.Location = new System.Drawing.Point(111, 141);
            this.dRIVING_LICENSETextBox.Name = "dRIVING_LICENSETextBox";
            this.dRIVING_LICENSETextBox.Size = new System.Drawing.Size(100, 20);
            this.dRIVING_LICENSETextBox.TabIndex = 9;
            // 
            // dop_phone_numberTextBox
            // 
            this.dop_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.client_tBindingSource, "dop_phone_number", true));
            this.dop_phone_numberTextBox.Location = new System.Drawing.Point(111, 167);
            this.dop_phone_numberTextBox.Name = "dop_phone_numberTextBox";
            this.dop_phone_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.dop_phone_numberTextBox.TabIndex = 11;
            // 
            // dop_DRIVING_LICENSETextBox
            // 
            this.dop_DRIVING_LICENSETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.client_tBindingSource, "dop_DRIVING_LICENSE", true));
            this.dop_DRIVING_LICENSETextBox.Location = new System.Drawing.Point(111, 193);
            this.dop_DRIVING_LICENSETextBox.Name = "dop_DRIVING_LICENSETextBox";
            this.dop_DRIVING_LICENSETextBox.Size = new System.Drawing.Size(100, 20);
            this.dop_DRIVING_LICENSETextBox.TabIndex = 13;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.toolStripButton15;
            this.bindingNavigator3.BindingSource = this.client_tBindingSource;
            this.bindingNavigator3.CountItem = this.toolStripLabel3;
            this.bindingNavigator3.DeleteItem = this.toolStripButton16;
            this.bindingNavigator3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator9,
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripButton21});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton17;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton20;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton19;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton18;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator3.Size = new System.Drawing.Size(791, 25);
            this.bindingNavigator3.TabIndex = 25;
            this.bindingNavigator3.Text = "bindingNavigator1";
            this.bindingNavigator3.RefreshItems += new System.EventHandler(this.bindingNavigator3_RefreshItems);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Добавить";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel3.Text = "для {0}";
            this.toolStripLabel3.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Удалить";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "Переместить в начало";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "Переместить назад";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Положение";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton19.Text = "Переместить вперед";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "Переместить в конец";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton21.Text = "Сохранить данные";
            // 
            // dATATIME_fix_startDateTimePicker
            // 
            this.dATATIME_fix_startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "DATATIME_fix_start", true));
            this.dATATIME_fix_startDateTimePicker.Location = new System.Drawing.Point(147, 240);
            this.dATATIME_fix_startDateTimePicker.Name = "dATATIME_fix_startDateTimePicker";
            this.dATATIME_fix_startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATATIME_fix_startDateTimePicker.TabIndex = 24;
            // 
            // dATATIME_fix_finishDateTimePicker
            // 
            this.dATATIME_fix_finishDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDER_TBindingSource, "DATATIME_fix_finish", true));
            this.dATATIME_fix_finishDateTimePicker.Location = new System.Drawing.Point(147, 272);
            this.dATATIME_fix_finishDateTimePicker.Name = "dATATIME_fix_finishDateTimePicker";
            this.dATATIME_fix_finishDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATATIME_fix_finishDateTimePicker.TabIndex = 25;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TBindingNavigator)).EndInit();
            this.oRDER_TBindingNavigator.ResumeLayout(false);
            this.oRDER_TBindingNavigator.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_tBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_tDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_tDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_tBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource oRDER_TBindingSource;
        private Database1DataSetTableAdapters.ORDER_TTableAdapter oRDER_TTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.client_tTableAdapter client_tTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingNavigator oRDER_TBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton oRDER_TBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox dESCRIPTTextBox;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.TextBox id_workerTextBox;
        private System.Windows.Forms.TextBox id_garageTextBox;
        private System.Windows.Forms.TextBox id_carTextBox;
        private System.Windows.Forms.TextBox id_clientTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView oRDER_TDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource client_tBindingSource;
        private Database1DataSetTableAdapters.car_tTableAdapter car_tTableAdapter;
        private System.Windows.Forms.TextBox p_idTextBox;
        private System.Windows.Forms.TextBox p_nameTextBox;
        private System.Windows.Forms.TextBox p_adressTextBox;
        private System.Windows.Forms.TextBox p_phone_numberTextBox;
        private System.Windows.Forms.TextBox dRIVING_LICENSETextBox;
        private System.Windows.Forms.TextBox dop_phone_numberTextBox;
        private System.Windows.Forms.TextBox dop_DRIVING_LICENSETextBox;
        private System.Windows.Forms.BindingSource car_tBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.DataGridView car_tDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridView client_tDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.TextBox c_idTextBox;
        private System.Windows.Forms.TextBox c_numberTextBox;
        private System.Windows.Forms.TextBox c_brandTextBox;
        private System.Windows.Forms.TextBox c_colorTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox dATATIME_fix_finishDateTimePicker;
        private System.Windows.Forms.TextBox dATATIME_fix_startDateTimePicker;
    }
}