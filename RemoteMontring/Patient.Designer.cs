namespace RemoteMontring
{
    partial class Patient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_doc = new System.Windows.Forms.Label();
            this.dataDataSet = new RemoteMontring.DataDataSet();
            this.temprtureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new RemoteMontring.DataDataSet1();
            this.temprtureTableAdapter = new RemoteMontring.DataDataSetTableAdapters.TemprtureTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temprtureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temp_pTableAdapter = new RemoteMontring.DataDataSet1TableAdapters.temp_pTableAdapter();
            this.temprtureTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet2 = new RemoteMontring.DataDataSet2();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new RemoteMontring.DataDataSet2TableAdapters.TableTableAdapter();
            this.name_txt = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.Label();
            this.age_txt = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.Label();
            this.diseas_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprtureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprtureTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diseas";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(39, 155);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 16;
            this.Address.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Patient of doctor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 19;
            // 
            // id_doc
            // 
            this.id_doc.AutoSize = true;
            this.id_doc.Location = new System.Drawing.Point(314, 27);
            this.id_doc.Name = "id_doc";
            this.id_doc.Size = new System.Drawing.Size(0, 13);
            this.id_doc.TabIndex = 20;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temprtureBindingSource
            // 
            this.temprtureBindingSource.DataSource = this.dataDataSet1;
            this.temprtureBindingSource.Position = 0;
            this.temprtureBindingSource.CurrentChanged += new System.EventHandler(this.temprtureBindingSource_CurrentChanged);
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "DataDataSet1";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temprtureTableAdapter
            // 
            this.temprtureTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPatientDataGridViewTextBoxColumn,
            this.temprtureDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.temppBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(262, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 195);
            this.dataGridView1.TabIndex = 21;
            // 
            // iDPatientDataGridViewTextBoxColumn
            // 
            this.iDPatientDataGridViewTextBoxColumn.DataPropertyName = "IDPatient";
            this.iDPatientDataGridViewTextBoxColumn.HeaderText = "IDPatient";
            this.iDPatientDataGridViewTextBoxColumn.Name = "iDPatientDataGridViewTextBoxColumn";
            // 
            // temprtureDataGridViewTextBoxColumn
            // 
            this.temprtureDataGridViewTextBoxColumn.DataPropertyName = "temprture";
            this.temprtureDataGridViewTextBoxColumn.HeaderText = "temprture";
            this.temprtureDataGridViewTextBoxColumn.Name = "temprtureDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // temppBindingSource
            // 
            this.temppBindingSource.DataMember = "temp_p";
            this.temppBindingSource.DataSource = this.dataDataSet1;
            // 
            // temp_pTableAdapter
            // 
            this.temp_pTableAdapter.ClearBeforeFill = true;
            // 
            // temprtureTableAdapterBindingSource
            // 
            this.temprtureTableAdapterBindingSource.DataSource = typeof(RemoteMontring.DataDataSetTableAdapters.TemprtureTableAdapter);
            // 
            // dataDataSet2
            // 
            this.dataDataSet2.DataSetName = "DataDataSet2";
            this.dataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataDataSet2;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Location = new System.Drawing.Point(91, 86);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(0, 13);
            this.name_txt.TabIndex = 22;
            // 
            // id_txt
            // 
            this.id_txt.AutoSize = true;
            this.id_txt.Location = new System.Drawing.Point(91, 122);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(0, 13);
            this.id_txt.TabIndex = 23;
            // 
            // address_txt
            // 
            this.address_txt.AutoSize = true;
            this.address_txt.Location = new System.Drawing.Point(91, 155);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(0, 13);
            this.address_txt.TabIndex = 24;
            // 
            // age_txt
            // 
            this.age_txt.AutoSize = true;
            this.age_txt.Location = new System.Drawing.Point(91, 183);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(0, 13);
            this.age_txt.TabIndex = 25;
            // 
            // phone_txt
            // 
            this.phone_txt.AutoSize = true;
            this.phone_txt.Location = new System.Drawing.Point(91, 217);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(0, 13);
            this.phone_txt.TabIndex = 26;
            // 
            // diseas_txt
            // 
            this.diseas_txt.AutoSize = true;
            this.diseas_txt.Location = new System.Drawing.Point(94, 251);
            this.diseas_txt.Name = "diseas_txt";
            this.diseas_txt.Size = new System.Drawing.Size(0, 13);
            this.diseas_txt.TabIndex = 27;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 286);
            this.Controls.Add(this.diseas_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id_doc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprtureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprtureTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label id_doc;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource temprtureBindingSource;
        private DataDataSetTableAdapters.TemprtureTableAdapter temprtureTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataDataSet1 dataDataSet1;
        private System.Windows.Forms.BindingSource temppBindingSource;
        private DataDataSet1TableAdapters.temp_pTableAdapter temp_pTableAdapter;
        private System.Windows.Forms.BindingSource temprtureTableAdapterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temprtureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataDataSet2 dataDataSet2;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataDataSet2TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.Label id_txt;
        private System.Windows.Forms.Label address_txt;
        private System.Windows.Forms.Label age_txt;
        private System.Windows.Forms.Label phone_txt;
        private System.Windows.Forms.Label diseas_txt;
    }
}