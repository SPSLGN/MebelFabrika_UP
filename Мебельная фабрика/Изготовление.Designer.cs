namespace Мебельная_фабрика
{
    partial class Изготовление
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodIzgotovleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodZakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusizgotovleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izgotovlenieMebeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet6 = new Мебельная_фабрика.Мебельная_фабрикаDataSet6();
            this.izgotovlenieMebeliTableAdapter = new Мебельная_фабрика.Мебельная_фабрикаDataSet6TableAdapters.IzgotovlenieMebeliTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izgotovlenieMebeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(755, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 46);
            this.button5.TabIndex = 15;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(633, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 46);
            this.button4.TabIndex = 14;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodIzgotovleniaDataGridViewTextBoxColumn,
            this.kodZakazaDataGridViewTextBoxColumn,
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn,
            this.statusizgotovleniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.izgotovlenieMebeliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(822, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // kodIzgotovleniaDataGridViewTextBoxColumn
            // 
            this.kodIzgotovleniaDataGridViewTextBoxColumn.DataPropertyName = "KodIzgotovlenia";
            this.kodIzgotovleniaDataGridViewTextBoxColumn.HeaderText = "KodIzgotovlenia";
            this.kodIzgotovleniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodIzgotovleniaDataGridViewTextBoxColumn.Name = "kodIzgotovleniaDataGridViewTextBoxColumn";
            this.kodIzgotovleniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodZakazaDataGridViewTextBoxColumn
            // 
            this.kodZakazaDataGridViewTextBoxColumn.DataPropertyName = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn.HeaderText = "KodZakaza";
            this.kodZakazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodZakazaDataGridViewTextBoxColumn.Name = "kodZakazaDataGridViewTextBoxColumn";
            this.kodZakazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datanachalaproizvodstvaDataGridViewTextBoxColumn
            // 
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.DataPropertyName = "Data_nachala_proizvodstva";
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.HeaderText = "Data_nachala_proizvodstva";
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.Name = "datanachalaproizvodstvaDataGridViewTextBoxColumn";
            this.datanachalaproizvodstvaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusizgotovleniaDataGridViewTextBoxColumn
            // 
            this.statusizgotovleniaDataGridViewTextBoxColumn.DataPropertyName = "Status_izgotovlenia";
            this.statusizgotovleniaDataGridViewTextBoxColumn.HeaderText = "Status_izgotovlenia";
            this.statusizgotovleniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusizgotovleniaDataGridViewTextBoxColumn.Name = "statusizgotovleniaDataGridViewTextBoxColumn";
            this.statusizgotovleniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // izgotovlenieMebeliBindingSource
            // 
            this.izgotovlenieMebeliBindingSource.DataMember = "IzgotovlenieMebeli";
            this.izgotovlenieMebeliBindingSource.DataSource = this.мебельная_фабрикаDataSet6;
            // 
            // мебельная_фабрикаDataSet6
            // 
            this.мебельная_фабрикаDataSet6.DataSetName = "Мебельная_фабрикаDataSet6";
            this.мебельная_фабрикаDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izgotovlenieMebeliTableAdapter
            // 
            this.izgotovlenieMebeliTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите код заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Введите дату начала производства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Введите статус готовности ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 53);
            this.button1.TabIndex = 23;
            this.button1.Text = "Внести изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "В процессе",
            "Готов"});
            this.comboBox1.Location = new System.Drawing.Point(269, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // Изготовление
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 560);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Name = "Изготовление";
            this.Text = "Изготовление";
            this.Load += new System.EventHandler(this.Изготовление_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izgotovlenieMebeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Мебельная_фабрикаDataSet6 мебельная_фабрикаDataSet6;
        private System.Windows.Forms.BindingSource izgotovlenieMebeliBindingSource;
        private Мебельная_фабрикаDataSet6TableAdapters.IzgotovlenieMebeliTableAdapter izgotovlenieMebeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodIzgotovleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodZakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanachalaproizvodstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusizgotovleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}