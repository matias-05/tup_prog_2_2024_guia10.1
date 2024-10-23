namespace Ejercicio1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmpleados = new System.Windows.Forms.ListBox();
            this.btVer = new System.Windows.Forms.Button();
            this.btImportar = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            this.btGenerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de empleados";
            // 
            // lbEmpleados
            // 
            this.lbEmpleados.FormattingEnabled = true;
            this.lbEmpleados.Location = new System.Drawing.Point(6, 19);
            this.lbEmpleados.Name = "lbEmpleados";
            this.lbEmpleados.Size = new System.Drawing.Size(191, 264);
            this.lbEmpleados.TabIndex = 0;
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(221, 31);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(110, 45);
            this.btVer.TabIndex = 1;
            this.btVer.Text = "(1) Ver Listado";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(221, 103);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(110, 45);
            this.btImportar.TabIndex = 2;
            this.btImportar.Text = "(2) Importar Empleados";
            this.btImportar.UseVisualStyleBackColor = true;
            this.btImportar.Click += new System.EventHandler(this.btImportar_Click);
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(221, 179);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(110, 45);
            this.btExportar.TabIndex = 3;
            this.btExportar.Text = "(3) Exportar Empleados";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(221, 250);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(110, 45);
            this.btGenerar.TabIndex = 4;
            this.btGenerar.Text = "(4) Generar Recibos";
            this.btGenerar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 312);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btImportar);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbEmpleados;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.Button btImportar;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Button btGenerar;
    }
}

