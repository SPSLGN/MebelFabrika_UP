namespace Мебельная_фабрика
{
    partial class Продажи
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.мебельная_фабрикаDataSet7 = new Мебельная_фабрика.Мебельная_фабрикаDataSet7();
            this.prodazhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodazhiTableAdapter = new Мебельная_фабрика.Мебельная_фабрикаDataSet7TableAdapters.ProdazhiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodProdazhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodZakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProdazhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodazhiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet8 = new Мебельная_фабрика.Мебельная_фабрикаDataSet8();
            this.prodazhiTableAdapter1 = new Мебельная_фабрика.Мебельная_фабрикаDataSet8TableAdapters.ProdazhiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(751, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 46);
            this.button5.TabIndex = 15;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 46);
            this.button4.TabIndex = 14;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 53);
            this.button1.TabIndex = 30;
            this.button1.Text = "Внести изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Введите код заказа";
            // 
            // мебельная_фабрикаDataSet7
            // 
            this.мебельная_фабрикаDataSet7.DataSetName = "Мебельная_фабрикаDataSet7";
            this.мебельная_фабрикаDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodazhiBindingSource
            // 
            this.prodazhiBindingSource.DataMember = "Prodazhi";
            this.prodazhiBindingSource.DataSource = this.мебельная_фабрикаDataSet7;
            // 
            // prodazhiTableAdapter
            // 
            this.prodazhiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodProdazhiDataGridViewTextBoxColumn,
            this.kodZakazaDataGridViewTextBoxColumn,
            this.dataProdazhiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodazhiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(117, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 228);
            this.dataGridView1.TabIndex = 31;
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
            // kodZakazaDataGridViewTextBoxColumn
            // 
            this.kodZakazaDataGridViewTextBoxColumn.DataPropertyName = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn.HeaderText = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodZakazaDataGridViewTextBoxColumn.Name = "kodZakazaDataGridViewTextBoxColumn";
            this.kodZakazaDataGridViewTextBoxColumn.Width = 125;
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
            this.prodazhiBindingSource1.DataSource = this.мебельная_фабрикаDataSet8;
            // 
            // мебельная_фабрикаDataSet8
            // 
            this.мебельная_фабрикаDataSet8.DataSetName = "Мебельная_фабрикаDataSet8";
            this.мебельная_фабрикаDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodazhiTableAdapter1
            // 
            this.prodazhiTableAdapter1.ClearBeforeFill = true;
            // 
            // Продажи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.MinimumSize = new System.Drawing.Size(891, 590);
            this.Name = "Продажи";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.Продажи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Мебельная_фабрикаDataSet7 мебельная_фабрикаDataSet7;
        private System.Windows.Forms.BindingSource prodazhiBindingSource;
        private Мебельная_фабрикаDataSet7TableAdapters.ProdazhiTableAdapter prodazhiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Мебельная_фабрикаDataSet8 мебельная_фабрикаDataSet8;
        private System.Windows.Forms.BindingSource prodazhiBindingSource1;
        private Мебельная_фабрикаDataSet8TableAdapters.ProdazhiTableAdapter prodazhiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodProdazhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodZakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataProdazhiDataGridViewTextBoxColumn;
    }
}