namespace Vitas_Stock.MainForms
{
    partial class Articulos
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(347, 57);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(163, 57);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(100, 20);
            this.txtarticulo.TabIndex = 2;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.btnagregar);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtarticulo;
    }
}