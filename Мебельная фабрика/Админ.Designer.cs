namespace Мебельная_фабрика
{
    partial class Админ
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodKomplektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoKomplektovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet3 = new Мебельная_фабрика.Мебельная_фабрикаDataSet3();
            this.skladTableAdapter = new Мебельная_фабрика.Мебельная_фабрикаDataSet3TableAdapters.SkladTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodIzgotovleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodZakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusizgotovleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izgotovlenieMebeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet4 = new Мебельная_фабрика.Мебельная_фабрикаDataSet4();
            this.izgotovlenieMebeliTableAdapter = new Мебельная_фабрика.Мебельная_фабрикаDataSet4TableAdapters.IzgotovlenieMebeliTableAdapter();
            this.prodazhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet5 = new Мебельная_фабрика.Мебельная_фабрикаDataSet5();
            this.prodazhiTableAdapter = new Мебельная_фабрика.Мебельная_фабрикаDataSet5TableAdapters.ProdazhiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.kodProdazhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodZakazaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProdazhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodazhiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet9 = new Мебельная_фабрика.Мебельная_фабрикаDataSet9();
            this.prodazhiTableAdapter1 = new Мебельная_фабрика.Мебельная_фабрикаDataSet9TableAdapters.ProdazhiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izgotovlenieMebeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodKomplektDataGridViewTextBoxColumn,
            this.kolichestvoKomplektovDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.skladBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // kodKomplektDataGridViewTextBoxColumn
            // 
            this.kodKomplektDataGridViewTextBoxColumn.DataPropertyName = "KodKomplekt";
            this.kodKomplektDataGridViewTextBoxColumn.HeaderText = "KodKomplekt";
            this.kodKomplektDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodKomplektDataGridViewTextBoxColumn.Name = "kodKomplektDataGridViewTextBoxColumn";
            this.kodKomplektDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodKomplektDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolichestvoKomplektovDataGridViewTextBoxColumn
            // 
            this.kolichestvoKomplektovDataGridViewTextBoxColumn.DataPropertyName = "KolichestvoKomplektov";
            this.kolichestvoKomplektovDataGridViewTextBoxColumn.HeaderText = "KolichestvoKomplektov";
            this.kolichestvoKomplektovDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolichestvoKomplektovDataGridViewTextBoxColumn.Name = "kolichestvoKomplektovDataGridViewTextBoxColumn";
            this.kolichestvoKomplektovDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolichestvoKomplektovDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.мебельная_фабрикаDataSet3;
            // 
            // мебельная_фабрикаDataSet3
            // 
            this.мебельная_фабрикаDataSet3.DataSetName = "Мебельная_фабрикаDataSet3";
            this.мебельная_фабрикаDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodIzgotovleniaDataGridViewTextBoxColumn,
            this.kodZakazaDataGridViewTextBoxColumn,
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn,
            this.statusizgotovleniaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.izgotovlenieMebeliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(733, 253);
            this.dataGridView2.TabIndex = 1;
            // 
            // kodIzgotovleniaDataGridViewTextBoxColumn
            // 
            this.kodIzgotovleniaDataGridViewTextBoxColumn.DataPropertyName = "KodIzgotovlenia";
            this.kodIzgotovleniaDataGridViewTextBoxColumn.HeaderText = "KodIzgotovlenia";
            this.kodIzgotovleniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodIzgotovleniaDataGridViewTextBoxColumn.Name = "kodIzgotovleniaDataGridViewTextBoxColumn";
            this.kodIzgotovleniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodIzgotovleniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodZakazaDataGridViewTextBoxColumn
            // 
            this.kodZakazaDataGridViewTextBoxColumn.DataPropertyName = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn.HeaderText = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodZakazaDataGridViewTextBoxColumn.Name = "kodZakazaDataGridViewTextBoxColumn";
            this.kodZakazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodZakazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datanachalaproizvodstvaDataGridViewTextBoxColumn
            // 
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.DataPropertyName = "Data_nachala_proizvodstva";
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.HeaderText = "Data_nachala_proizvodstva";
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.Name = "datanachalaproizvodstvaDataGridViewTextBoxColumn";
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusizgotovleniaDataGridViewTextBoxColumn
            // 
            this.statusizgotovleniaDataGridViewTextBoxColumn.DataPropertyName = "Status_izgotovlenia";
            this.statusizgotovleniaDataGridViewTextBoxColumn.HeaderText = "Status_izgotovlenia";
            this.statusizgotovleniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusizgotovleniaDataGridViewTextBoxColumn.Name = "statusizgotovleniaDataGridViewTextBoxColumn";
            this.statusizgotovleniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusizgotovleniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // izgotovlenieMebeliBindingSource
            // 
            this.izgotovlenieMebeliBindingSource.DataMember = "IzgotovlenieMebeli";
            this.izgotovlenieMebeliBindingSource.DataSource = this.мебельная_фабрикаDataSet4;
            // 
            // мебельная_фабрикаDataSet4
            // 
            this.мебельная_фабрикаDataSet4.DataSetName = "Мебельная_фабрикаDataSet4";
            this.мебельная_фабрикаDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izgotovlenieMebeliTableAdapter
            // 
            this.izgotovlenieMebeliTableAdapter.ClearBeforeFill = true;
            // 
            // prodazhiBindingSource
            // 
            this.prodazhiBindingSource.DataMember = "Prodazhi";
            this.prodazhiBindingSource.DataSource = this.мебельная_фабрикаDataSet5;
            // 
            // мебельная_фабрикаDataSet5
            // 
            this.мебельная_фабрикаDataSet5.DataSetName = "Мебельная_фабрикаDataSet5";
            this.мебельная_фабрикаDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodazhiTableAdapter
            // 
            this.prodazhiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Информация о поступлении комплектующих на склад";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(761, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Информация о продажах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Информация об изготовлении мебели";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(766, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1252, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "Выйти из системы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1374, 564);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 46);
            this.button5.TabIndex = 13;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodProdazhiDataGridViewTextBoxColumn,
            this.kodZakazaDataGridViewTextBoxColumn1,
            this.dataProdazhiDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.prodazhiBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(766, 40);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(724, 253);
            this.dataGridView3.TabIndex = 14;
            // 
            // kodProdazhiDataGridViewTextBoxColumn
            // 
            this.kodProdazhiDataGridViewTextBoxColumn.DataPropertyName = "KodProdazhi";
            this.kodProdazhiDataGridViewTextBoxColumn.HeaderText = "KodProdazhi";
            this.kodProdazhiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodProdazhiDataGridViewTextBoxColumn.Name = "kodProdazhiDataGridViewTextBoxColumn";
            this.kodProdazhiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodProdazhiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodZakazaDataGridViewTextBoxColumn1
            // 
            this.kodZakazaDataGridViewTextBoxColumn1.DataPropertyName = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn1.HeaderText = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kodZakazaDataGridViewTextBoxColumn1.Name = "kodZakazaDataGridViewTextBoxColumn1";
            this.kodZakazaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataProdazhiDataGridViewTextBoxColumn
            // 
            this.dataProdazhiDataGridViewTextBoxColumn.DataPropertyName = "DataProdazhi";
            this.dataProdazhiDataGridViewTextBoxColumn.HeaderText = "DataProdazhi";
            this.dataProdazhiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataProdazhiDataGridViewTextBoxColumn.Name = "dataProdazhiDataGridViewTextBoxColumn";
            this.dataProdazhiDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodazhiBindingSource1
            // 
            this.prodazhiBindingSource1.DataMember = "Prodazhi";
            this.prodazhiBindingSource1.DataSource = this.мебельная_фабрикаDataSet9;
            // 
            // мебельная_фабрикаDataSet9
            // 
            this.мебельная_фабрикаDataSet9.DataSetName = "Мебельная_фабрикаDataSet9";
            this.мебельная_фабрикаDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodazhiTableAdapter1
            // 
            this.prodazhiTableAdapter1.ClearBeforeFill = true;
            // 
            // Админ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 651);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1520, 698);
            this.Name = "Админ";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Админ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izgotovlenieMebeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Мебельная_фабрикаDataSet3 мебельная_фабрикаDataSet3;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private Мебельная_фабрикаDataSet3TableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodKomplektDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoKomplektovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Мебельная_фабрикаDataSet4 мебельная_фабрикаDataSet4;
        private System.Windows.Forms.BindingSource izgotovlenieMebeliBindingSource;
        private Мебельная_фабрикаDataSet4TableAdapters.IzgotovlenieMebeliTableAdapter izgotovlenieMebeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodIzgotovleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodZakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanachalaproizvodstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusizgotovleniaDataGridViewTextBoxColumn;
        private Мебельная_фабрикаDataSet5 мебельная_фабрикаDataSet5;
        private System.Windows.Forms.BindingSource prodazhiBindingSource;
        private Мебельная_фабрикаDataSet5TableAdapters.ProdazhiTableAdapter prodazhiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Мебельная_фабрикаDataSet9 мебельная_фабрикаDataSet9;
        private System.Windows.Forms.BindingSource prodazhiBindingSource1;
        private Мебельная_фабрикаDataSet9TableAdapters.ProdazhiTableAdapter prodazhiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodProdazhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodZakazaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataProdazhiDataGridViewTextBoxColumn;
    }
}