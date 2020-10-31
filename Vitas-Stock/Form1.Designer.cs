namespace Vitas_Stock
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.controlStockDataSet = new Vitas_Stock.ControlStockDataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new Vitas_Stock.ControlStockDataSetTableAdapters.ArticuloTableAdapter();
            this.fKLotesArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotesTableAdapter = new Vitas_Stock.ControlStockDataSetTableAdapters.LotesTableAdapter();
            this.articuloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idloteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codarticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLotesArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "cargar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idloteDataGridViewTextBoxColumn,
            this.codarticuloDataGridViewTextBoxColumn,
            this.fechaingresoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechavencDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKLotesArticuloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(568, 313);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cantidad";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(513, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "fecha de ingrso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "fecha de caducidad";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(586, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "despachar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "control de stock farmacia";
            // 
            // controlStockDataSet
            // 
            this.controlStockDataSet.DataSetName = "ControlStockDataSet";
            this.controlStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.controlStockDataSet;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // fKLotesArticuloBindingSource
            // 
            this.fKLotesArticuloBindingSource.DataMember = "FK_Lotes_Articulo";
            this.fKLotesArticuloBindingSource.DataSource = this.articuloBindingSource;
            // 
            // lotesTableAdapter
            // 
            this.lotesTableAdapter.ClearBeforeFill = true;
            // 
            // articuloBindingSource1
            // 
            this.articuloBindingSource1.DataMember = "Articulo";
            this.articuloBindingSource1.DataSource = this.controlStockDataSet;
            // 
            // idloteDataGridViewTextBoxColumn
            // 
            this.idloteDataGridViewTextBoxColumn.DataPropertyName = "id_lote";
            this.idloteDataGridViewTextBoxColumn.HeaderText = "id_lote";
            this.idloteDataGridViewTextBoxColumn.Name = "idloteDataGridViewTextBoxColumn";
            this.idloteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codarticuloDataGridViewTextBoxColumn
            // 
            this.codarticuloDataGridViewTextBoxColumn.DataPropertyName = "cod_articulo";
            this.codarticuloDataGridViewTextBoxColumn.HeaderText = "cod_articulo";
            this.codarticuloDataGridViewTextBoxColumn.Name = "codarticuloDataGridViewTextBoxColumn";
            this.codarticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaingresoDataGridViewTextBoxColumn
            // 
            this.fechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.HeaderText = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.Name = "fechaingresoDataGridViewTextBoxColumn";
            this.fechaingresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechavencDataGridViewTextBoxColumn
            // 
            this.fechavencDataGridViewTextBoxColumn.DataPropertyName = "fecha_venc";
            this.fechavencDataGridViewTextBoxColumn.HeaderText = "fecha_venc";
            this.fechavencDataGridViewTextBoxColumn.Name = "fechavencDataGridViewTextBoxColumn";
            this.fechavencDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLotesArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private ControlStockDataSet controlStockDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private ControlStockDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource fKLotesArticuloBindingSource;
        private ControlStockDataSetTableAdapters.LotesTableAdapter lotesTableAdapter;
        private System.Windows.Forms.BindingSource articuloBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idloteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codarticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencDataGridViewTextBoxColumn;
    }
}

