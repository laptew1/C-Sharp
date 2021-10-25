namespace NetMaster
{
    partial class Пользователь
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Пользователь));
            this.oRDER_TBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new NetMaster.Database1DataSet();
            this.client_tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDER_TTableAdapter = new NetMaster.Database1DataSetTableAdapters.ORDER_TTableAdapter();
            this.tableAdapterManager = new NetMaster.Database1DataSetTableAdapters.TableAdapterManager();
            this.client_tTableAdapter = new NetMaster.Database1DataSetTableAdapters.client_tTableAdapter();
            this.datDisplayClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textSumZak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_tBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDisplayClient)).BeginInit();
            this.SuspendLayout();
            // 
            // oRDER_TBindingSource
            // 
            this.oRDER_TBindingSource.DataMember = "ORDER_T";
            this.oRDER_TBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_tBindingSource
            // 
            this.client_tBindingSource.DataMember = "client_t";
            this.client_tBindingSource.DataSource = this.database1DataSet;
            // 
            // oRDER_TTableAdapter
            // 
            this.oRDER_TTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_tTableAdapter = null;
            this.tableAdapterManager.client_tTableAdapter = null;
            this.tableAdapterManager.garage_tTableAdapter = null;
            this.tableAdapterManager.ORDER_TTableAdapter = this.oRDER_TTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NetMaster.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_tTableAdapter = null;
            this.tableAdapterManager.worker_tTableAdapter = null;
            // 
            // client_tTableAdapter
            // 
            this.client_tTableAdapter.ClearBeforeFill = true;
            // 
            // datDisplayClient
            // 
            this.datDisplayClient.AllowUserToOrderColumns = true;
            this.datDisplayClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datDisplayClient.Location = new System.Drawing.Point(12, 68);
            this.datDisplayClient.Name = "datDisplayClient";
            this.datDisplayClient.Size = new System.Drawing.Size(861, 295);
            this.datDisplayClient.TabIndex = 0;
            this.datDisplayClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datDisplayClient_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(75, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // textSumZak
            // 
            this.textSumZak.Cursor = System.Windows.Forms.Cursors.Default;
            this.textSumZak.Location = new System.Drawing.Point(681, 393);
            this.textSumZak.Name = "textSumZak";
            this.textSumZak.ReadOnly = true;
            this.textSumZak.Size = new System.Drawing.Size(114, 20);
            this.textSumZak.TabIndex = 2;
            this.textSumZak.Text = "0";
            this.textSumZak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Общая сумма потраченая на ремонт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вы вошли под номером :";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(238, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Пользователь
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSumZak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datDisplayClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Пользователь";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.Пользователь_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_TBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_tBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDisplayClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource oRDER_TBindingSource;
        private Database1DataSetTableAdapters.ORDER_TTableAdapter oRDER_TTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource client_tBindingSource;
        private Database1DataSetTableAdapters.client_tTableAdapter client_tTableAdapter;
        private System.Windows.Forms.DataGridView datDisplayClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSumZak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}