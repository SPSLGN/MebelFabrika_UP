namespace Мебельная_фабрика
{
    partial class Покупатель
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodMebelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalichieDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mebeliBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet2 = new Мебельная_фабрика.Мебельная_фабрикаDataSet2();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mebeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебельная_фабрикаDataSet = new Мебельная_фабрика.Мебельная_фабрикаDataSet();
            this.mebeliTableAdapter = new Мебельная_фабрика.Мебельная_фабрикаDataSetTableAdapters.MebeliTableAdapter();
            this.мебельная_фабрикаDataSet1 = new Мебельная_фабрика.Мебельная_фабрикаDataSet1();
            this.mebeliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mebeliTableAdapter1 = new Мебельная_фабрика.Мебельная_фабрикаDataSet1TableAdapters.MebeliTableAdapter();
            this.мебельная_фабрикаDataSet11 = new Мебельная_фабрика.Мебельная_фабрикаDataSet1();
            this.mebeliTableAdapter2 = new Мебельная_фабрика.Мебельная_фабрикаDataSet2TableAdapters.MebeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebeliBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebeliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(667, 409);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 28);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Закрыть";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(532, 409);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(120, 28);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Выход";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Поиск";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(500, 224);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 20);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "В наличии";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(442, 224);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 20);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Все";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodMebelyaDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.senaDataGridViewTextBoxColumn,
            this.nalichieDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.mebeliBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 203);
            this.dataGridView1.TabIndex = 21;
            // 
            // kodMebelyaDataGridViewTextBoxColumn
            // 
            this.kodMebelyaDataGridViewTextBoxColumn.DataPropertyName = "KodMebelya";
            this.kodMebelyaDataGridViewTextBoxColumn.HeaderText = "KodMebelya";
            this.kodMebelyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodMebelyaDataGridViewTextBoxColumn.Name = "kodMebelyaDataGridViewTextBoxColumn";
            this.kodMebelyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodMebelyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            this.naimenovanieDataGridViewTextBoxColumn.ReadOnly = true;
            this.naimenovanieDataGridViewTextBoxColumn.Width = 125;
            // 
            // senaDataGridViewTextBoxColumn
            // 
            this.senaDataGridViewTextBoxColumn.DataPropertyName = "Sena";
            this.senaDataGridViewTextBoxColumn.HeaderText = "Sena";
            this.senaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senaDataGridViewTextBoxColumn.Name = "senaDataGridViewTextBoxColumn";
            this.senaDataGridViewTextBoxColumn.ReadOnly = true;
            this.senaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nalichieDataGridViewCheckBoxColumn
            // 
            this.nalichieDataGridViewCheckBoxColumn.DataPropertyName = "Nalichie";
            this.nalichieDataGridViewCheckBoxColumn.HeaderText = "Nalichie";
            this.nalichieDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.nalichieDataGridViewCheckBoxColumn.Name = "nalichieDataGridViewCheckBoxColumn";
            this.nalichieDataGridViewCheckBoxColumn.ReadOnly = true;
            this.nalichieDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mebeliBindingSource2
            // 
            this.mebeliBindingSource2.DataMember = "Mebeli";
            this.mebeliBindingSource2.DataSource = this.мебельная_фабрикаDataSet2;
            // 
            // мебельная_фабрикаDataSet2
            // 
            this.мебельная_фабрикаDataSet2.DataSetName = "Мебельная_фабрикаDataSet2";
            this.мебельная_фабрикаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 22);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Введите код мебели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Введите количество";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(475, 300);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 22);
            this.textBox3.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "Сделать заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mebeliBindingSource
            // 
            this.mebeliBindingSource.DataMember = "Mebeli";
            this.mebeliBindingSource.DataSource = this.мебельная_фабрикаDataSet;
            // 
            // мебельная_фабрикаDataSet
            // 
            this.мебельная_фабрикаDataSet.DataSetName = "Мебельная_фабрикаDataSet";
            this.мебельная_фабрикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mebeliTableAdapter
            // 
            this.mebeliTableAdapter.ClearBeforeFill = true;
            // 
            // мебельная_фабрикаDataSet1
            // 
            this.мебельная_фабрикаDataSet1.DataSetName = "Мебельная_фабрикаDataSet1";
            this.мебельная_фабрикаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mebeliBindingSource1
            // 
            this.mebeliBindingSource1.DataMember = "Mebeli";
            this.mebeliBindingSource1.DataSource = this.мебельная_фабрикаDataSet1;
            // 
            // mebeliTableAdapter1
            // 
            this.mebeliTableAdapter1.ClearBeforeFill = true;
            // 
            // мебельная_фабрикаDataSet11
            // 
            this.мебельная_фабрикаDataSet11.DataSetName = "Мебельная_фабрикаDataSet1";
            this.мебельная_фабрикаDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mebeliTableAdapter2
            // 
            this.mebeliTableAdapter2.ClearBeforeFill = true;
            // 
            // Покупатель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Покупатель";
            this.Text = "Покупатель";
            this.Load += new System.EventHandler(this.Покупатель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebeliBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebeliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельная_фабрикаDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Мебельная_фабрикаDataSet мебельная_фабрикаDataSet;
        private System.Windows.Forms.BindingSource mebeliBindingSource;
        private Мебельная_фабрикаDataSetTableAdapters.MebeliTableAdapter mebeliTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Мебельная_фабрикаDataSet1 мебельная_фабрикаDataSet1;
        private System.Windows.Forms.BindingSource mebeliBindingSource1;
        private Мебельная_фабрикаDataSet1TableAdapters.MebeliTableAdapter mebeliTableAdapter1;
        private Мебельная_фабрикаDataSet1 мебельная_фабрикаDataSet11;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Мебельная_фабрикаDataSet2 мебельная_фабрикаDataSet2;
        private System.Windows.Forms.BindingSource mebeliBindingSource2;
        private Мебельная_фабрикаDataSet2TableAdapters.MebeliTableAdapter mebeliTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodMebelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nalichieDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}