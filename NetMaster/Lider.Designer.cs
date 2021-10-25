namespace NetMaster
{
    partial class Lider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lider));
            System.Windows.Forms.Label w_idLabel;
            System.Windows.Forms.Label w_nameLabel;
            System.Windows.Forms.Label w_phone_numberLabel;
            System.Windows.Forms.Label skillLabel;
            this.database1DataSet = new NetMaster.Database1DataSet();
            this.worker_tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_tTableAdapter = new NetMaster.Database1DataSetTableAdapters.worker_tTableAdapter();
            this.tableAdapterManager = new NetMaster.Database1DataSetTableAdapters.TableAdapterManager();
            this.worker_tBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.worker_tBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.worker_tDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_idTextBox = new System.Windows.Forms.TextBox();
            this.w_nameTextBox = new System.Windows.Forms.TextBox();
            this.w_phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.skillTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            w_idLabel = new System.Windows.Forms.Label();
            w_nameLabel = new System.Windows.Forms.Label();
            w_phone_numberLabel = new System.Windows.Forms.Label();
            skillLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_tBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_tBindingNavigator)).BeginInit();
            this.worker_tBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_tDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worker_tBindingSource
            // 
            this.worker_tBindingSource.DataMember = "worker_t";
            this.worker_tBindingSource.DataSource = this.database1DataSet;
            // 
            // worker_tTableAdapter
            // 
            this.worker_tTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_tTableAdapter = null;
            this.tableAdapterManager.client_tTableAdapter = null;
            this.tableAdapterManager.garage_tTableAdapter = null;
            this.tableAdapterManager.ORDER_TTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NetMaster.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_tTableAdapter = null;
            this.tableAdapterManager.worker_tTableAdapter = this.worker_tTableAdapter;
            // 
            // worker_tBindingNavigator
            // 
            this.worker_tBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.worker_tBindingNavigator.BindingSource = this.worker_tBindingSource;
            this.worker_tBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.worker_tBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.worker_tBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.worker_tBindingNavigatorSaveItem});
            this.worker_tBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.worker_tBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.worker_tBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.worker_tBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.worker_tBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.worker_tBindingNavigator.Name = "worker_tBindingNavigator";
            this.worker_tBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.worker_tBindingNavigator.Size = new System.Drawing.Size(822, 25);
            this.worker_tBindingNavigator.TabIndex = 0;
            this.worker_tBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // worker_tBindingNavigatorSaveItem
            // 
            this.worker_tBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.worker_tBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("worker_tBindingNavigatorSaveItem.Image")));
            this.worker_tBindingNavigatorSaveItem.Name = "worker_tBindingNavigatorSaveItem";
            this.worker_tBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.worker_tBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.worker_tBindingNavigatorSaveItem.Click += new System.EventHandler(this.worker_tBindingNavigatorSaveItem_Click);
            // 
            // worker_tDataGridView
            // 
            this.worker_tDataGridView.AutoGenerateColumns = false;
            this.worker_tDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worker_tDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.worker_tDataGridView.DataSource = this.worker_tBindingSource;
            this.worker_tDataGridView.Location = new System.Drawing.Point(222, 55);
            this.worker_tDataGridView.Name = "worker_tDataGridView";
            this.worker_tDataGridView.Size = new System.Drawing.Size(580, 315);
            this.worker_tDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "w_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "w_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "w_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "w_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "w_phone_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "w_phone_number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "skill";
            this.dataGridViewTextBoxColumn4.HeaderText = "skill";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // w_idLabel
            // 
            w_idLabel.AutoSize = true;
            w_idLabel.Location = new System.Drawing.Point(12, 80);
            w_idLabel.Name = "w_idLabel";
            w_idLabel.Size = new System.Drawing.Size(29, 13);
            w_idLabel.TabIndex = 2;
            w_idLabel.Text = "w id:";
            // 
            // w_idTextBox
            // 
            this.w_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worker_tBindingSource, "w_id", true));
            this.w_idTextBox.Location = new System.Drawing.Point(107, 77);
            this.w_idTextBox.Name = "w_idTextBox";
            this.w_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.w_idTextBox.TabIndex = 3;
            // 
            // w_nameLabel
            // 
            w_nameLabel.AutoSize = true;
            w_nameLabel.Location = new System.Drawing.Point(12, 106);
            w_nameLabel.Name = "w_nameLabel";
            w_nameLabel.Size = new System.Drawing.Size(47, 13);
            w_nameLabel.TabIndex = 4;
            w_nameLabel.Text = "w name:";
            // 
            // w_nameTextBox
            // 
            this.w_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worker_tBindingSource, "w_name", true));
            this.w_nameTextBox.Location = new System.Drawing.Point(107, 103);
            this.w_nameTextBox.Name = "w_nameTextBox";
            this.w_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.w_nameTextBox.TabIndex = 5;
            // 
            // w_phone_numberLabel
            // 
            w_phone_numberLabel.AutoSize = true;
            w_phone_numberLabel.Location = new System.Drawing.Point(12, 132);
            w_phone_numberLabel.Name = "w_phone_numberLabel";
            w_phone_numberLabel.Size = new System.Drawing.Size(89, 13);
            w_phone_numberLabel.TabIndex = 6;
            w_phone_numberLabel.Text = "w phone number:";
            // 
            // w_phone_numberTextBox
            // 
            this.w_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worker_tBindingSource, "w_phone_number", true));
            this.w_phone_numberTextBox.Location = new System.Drawing.Point(107, 129);
            this.w_phone_numberTextBox.Name = "w_phone_numberTextBox";
            this.w_phone_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.w_phone_numberTextBox.TabIndex = 7;
            // 
            // skillLabel
            // 
            skillLabel.AutoSize = true;
            skillLabel.Location = new System.Drawing.Point(12, 158);
            skillLabel.Name = "skillLabel";
            skillLabel.Size = new System.Drawing.Size(27, 13);
            skillLabel.TabIndex = 8;
            skillLabel.Text = "skill:";
            // 
            // skillTextBox
            // 
            this.skillTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worker_tBindingSource, "skill", true));
            this.skillTextBox.Location = new System.Drawing.Point(107, 155);
            this.skillTextBox.Name = "skillTextBox";
            this.skillTextBox.Size = new System.Drawing.Size(100, 20);
            this.skillTextBox.TabIndex = 9;
            this.skillTextBox.TextChanged += new System.EventHandler(this.skillTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(w_idLabel);
            this.Controls.Add(this.w_idTextBox);
            this.Controls.Add(w_nameLabel);
            this.Controls.Add(this.w_nameTextBox);
            this.Controls.Add(w_phone_numberLabel);
            this.Controls.Add(this.w_phone_numberTextBox);
            this.Controls.Add(skillLabel);
            this.Controls.Add(this.skillTextBox);
            this.Controls.Add(this.worker_tDataGridView);
            this.Controls.Add(this.worker_tBindingNavigator);
            this.Name = "Lider";
            this.Text = "Lider";
            this.Load += new System.EventHandler(this.Lider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_tBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_tBindingNavigator)).EndInit();
            this.worker_tBindingNavigator.ResumeLayout(false);
            this.worker_tBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_tDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource worker_tBindingSource;
        private Database1DataSetTableAdapters.worker_tTableAdapter worker_tTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator worker_tBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton worker_tBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView worker_tDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox w_idTextBox;
        private System.Windows.Forms.TextBox w_nameTextBox;
        private System.Windows.Forms.TextBox w_phone_numberTextBox;
        private System.Windows.Forms.TextBox skillTextBox;
        private System.Windows.Forms.Button button1;
    }
}