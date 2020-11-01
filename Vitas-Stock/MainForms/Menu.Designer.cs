namespace FE
{
    partial class frmMenu
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPrecio = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pnlCantidad = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlVto = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.pnlTroquel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPrecio.SuspendLayout();
            this.pnlCantidad.SuspendLayout();
            this.pnlVto.SuspendLayout();
            this.panelFecha.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlTroquel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(89, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnDespachar
            // 
            this.btnDespachar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(124)))));
            this.btnDespachar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespachar.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDespachar.ForeColor = System.Drawing.Color.White;
            this.btnDespachar.Location = new System.Drawing.Point(33, 481);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(162, 33);
            this.btnDespachar.TabIndex = 12;
            this.btnDespachar.Text = "Despechar";
            this.btnDespachar.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(60, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 37);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Stock Farmacia";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(124)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(33, 431);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(162, 33);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(188)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 56);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vitas_Stock.Properties.Resources.icoFarmacia;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::Vitas_Stock.Properties.Resources.minimize_button;
            this.btnMinimizar.Location = new System.Drawing.Point(915, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 19);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Vitas_Stock.Properties.Resources.close_button;
            this.btnCerrar.Location = new System.Drawing.Point(943, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 19);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(248)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.pnlPrecio);
            this.panel2.Controls.Add(this.pnlCantidad);
            this.panel2.Controls.Add(this.pnlVto);
            this.panel2.Controls.Add(this.panelFecha);
            this.panel2.Controls.Add(this.btnDespachar);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnCargar);
            this.panel2.Controls.Add(this.pnlProducto);
            this.panel2.Controls.Add(this.pnlTroquel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 580);
            this.panel2.TabIndex = 15;
            // 
            // pnlPrecio
            // 
            this.pnlPrecio.Controls.Add(this.label6);
            this.pnlPrecio.Controls.Add(this.textBox4);
            this.pnlPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrecio.Location = new System.Drawing.Point(0, 156);
            this.pnlPrecio.Name = "pnlPrecio";
            this.pnlPrecio.Size = new System.Drawing.Size(243, 52);
            this.pnlPrecio.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "| Precio";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(89, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // pnlCantidad
            // 
            this.pnlCantidad.Controls.Add(this.label4);
            this.pnlCantidad.Controls.Add(this.textBox3);
            this.pnlCantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCantidad.Location = new System.Drawing.Point(0, 104);
            this.pnlCantidad.Name = "pnlCantidad";
            this.pnlCantidad.Size = new System.Drawing.Size(243, 52);
            this.pnlCantidad.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "| Cantidad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // pnlVto
            // 
            this.pnlVto.Controls.Add(this.label3);
            this.pnlVto.Controls.Add(this.dateTimePicker2);
            this.pnlVto.Location = new System.Drawing.Point(0, 259);
            this.pnlVto.Name = "pnlVto";
            this.pnlVto.Size = new System.Drawing.Size(243, 52);
            this.pnlVto.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "| Vto";
            // 
            // panelFecha
            // 
            this.panelFecha.Controls.Add(this.label5);
            this.panelFecha.Controls.Add(this.dateTimePicker1);
            this.panelFecha.Location = new System.Drawing.Point(0, 208);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(243, 52);
            this.panelFecha.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "| Fecha";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(12, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 0);
            this.panel5.TabIndex = 25;
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.label2);
            this.pnlProducto.Controls.Add(this.txtnombre);
            this.pnlProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProducto.Location = new System.Drawing.Point(0, 52);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(243, 52);
            this.pnlProducto.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "| Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(89, 16);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 20;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pnlTroquel
            // 
            this.pnlTroquel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTroquel.Controls.Add(this.label1);
            this.pnlTroquel.Controls.Add(this.textBox1);
            this.pnlTroquel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTroquel.Location = new System.Drawing.Point(0, 0);
            this.pnlTroquel.Name = "pnlTroquel";
            this.pnlTroquel.Size = new System.Drawing.Size(243, 52);
            this.pnlTroquel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "| Troquel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 317);
            this.dataGridView1.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(124)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(243, 590);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(728, 46);
            this.panel9.TabIndex = 26;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(252)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(971, 636);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlPrecio.ResumeLayout(false);
            this.pnlPrecio.PerformLayout();
            this.pnlCantidad.ResumeLayout(false);
            this.pnlCantidad.PerformLayout();
            this.pnlVto.ResumeLayout(false);
            this.pnlVto.PerformLayout();
            this.panelFecha.ResumeLayout(false);
            this.panelFecha.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlTroquel.ResumeLayout(false);
            this.pnlTroquel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlVto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Panel pnlTroquel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnlPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel pnlCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox txtnombre;
    }
}

