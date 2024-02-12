namespace Cars_Road
{
    partial class Form3
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
            this.номерДорогиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.протяженностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видПокрытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ограничениеСкоростиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.соединенныйГородИдентификаторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дорогиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cars_RoadDataSet = new Cars_Road.Cars_RoadDataSet();
            this.дорогиTableAdapter = new Cars_Road.Cars_RoadDataSetTableAdapters.ДорогиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дорогиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_RoadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДорогиDataGridViewTextBoxColumn,
            this.протяженностьDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.видПокрытияDataGridViewTextBoxColumn,
            this.ограничениеСкоростиDataGridViewTextBoxColumn,
            this.соединенныйГородИдентификаторDataGridViewTextBoxColumn,
            this.наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn,
            this.наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.дорогиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 79);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерДорогиDataGridViewTextBoxColumn
            // 
            this.номерДорогиDataGridViewTextBoxColumn.DataPropertyName = "НомерДороги";
            this.номерДорогиDataGridViewTextBoxColumn.HeaderText = "НомерДороги";
            this.номерДорогиDataGridViewTextBoxColumn.Name = "номерДорогиDataGridViewTextBoxColumn";
            this.номерДорогиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // протяженностьDataGridViewTextBoxColumn
            // 
            this.протяженностьDataGridViewTextBoxColumn.DataPropertyName = "Протяженность";
            this.протяженностьDataGridViewTextBoxColumn.HeaderText = "Протяженность";
            this.протяженностьDataGridViewTextBoxColumn.Name = "протяженностьDataGridViewTextBoxColumn";
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "ЕдиницаИзмерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "ЕдиницаИзмерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            // 
            // видПокрытияDataGridViewTextBoxColumn
            // 
            this.видПокрытияDataGridViewTextBoxColumn.DataPropertyName = "ВидПокрытия";
            this.видПокрытияDataGridViewTextBoxColumn.HeaderText = "ВидПокрытия";
            this.видПокрытияDataGridViewTextBoxColumn.Name = "видПокрытияDataGridViewTextBoxColumn";
            // 
            // ограничениеСкоростиDataGridViewTextBoxColumn
            // 
            this.ограничениеСкоростиDataGridViewTextBoxColumn.DataPropertyName = "ОграничениеСкорости";
            this.ограничениеСкоростиDataGridViewTextBoxColumn.HeaderText = "ОграничениеСкорости";
            this.ограничениеСкоростиDataGridViewTextBoxColumn.Name = "ограничениеСкоростиDataGridViewTextBoxColumn";
            // 
            // соединенныйГородИдентификаторDataGridViewTextBoxColumn
            // 
            this.соединенныйГородИдентификаторDataGridViewTextBoxColumn.DataPropertyName = "СоединенныйГородИдентификатор";
            this.соединенныйГородИдентификаторDataGridViewTextBoxColumn.HeaderText = "СоединенныйГородИдентификатор";
            this.соединенныйГородИдентификаторDataGridViewTextBoxColumn.Name = "соединенныйГородИдентификаторDataGridViewTextBoxColumn";
            // 
            // наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn
            // 
            this.наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn.DataPropertyName = "НаличиеАвторемонтныхПунктов";
            this.наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn.HeaderText = "НаличиеАвторемонтныхПунктов";
            this.наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn.Name = "наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn";
            // 
            // наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn
            // 
            this.наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn.DataPropertyName = "НаличиеАвтозаправочныхСтанций";
            this.наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn.HeaderText = "НаличиеАвтозаправочныхСтанций";
            this.наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn.Name = "наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn";
            // 
            // дорогиBindingSource
            // 
            this.дорогиBindingSource.DataMember = "Дороги";
            this.дорогиBindingSource.DataSource = this.cars_RoadDataSet;
            // 
            // cars_RoadDataSet
            // 
            this.cars_RoadDataSet.DataSetName = "Cars_RoadDataSet";
            this.cars_RoadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дорогиTableAdapter
            // 
            this.дорогиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Протяженность";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Единица Измерения";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Категория";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(507, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вид покрытия";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(649, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ограничение скорости";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(163, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(189, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Соединенный Город Идентификатор";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(360, 161);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(175, 20);
            this.textBox7.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Наличие Авторемонтных Пунктов";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(544, 161);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(184, 20);
            this.textBox8.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Наличие Автозаправочных Станций";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дорогиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars_RoadDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Cars_RoadDataSet cars_RoadDataSet;
        private System.Windows.Forms.BindingSource дорогиBindingSource;
        private Cars_RoadDataSetTableAdapters.ДорогиTableAdapter дорогиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДорогиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn протяженностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПокрытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ограничениеСкоростиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn соединенныйГородИдентификаторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеАвторемонтныхПунктовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеАвтозаправочныхСтанцийDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}