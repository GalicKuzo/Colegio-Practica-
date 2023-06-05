namespace Colegio
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
            this.btn_CrearColegio = new System.Windows.Forms.Button();
            this.lbl_Aula = new System.Windows.Forms.Label();
            this.cbox_Aulas = new System.Windows.Forms.ComboBox();
            this.btn_CrearRelacion = new System.Windows.Forms.Button();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lbl_Datos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_Alumnos = new System.Windows.Forms.ListBox();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.txtbox_Apellidos = new System.Windows.Forms.TextBox();
            this.txtbox_Nombres = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CrearColegio
            // 
            this.btn_CrearColegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearColegio.Location = new System.Drawing.Point(12, 12);
            this.btn_CrearColegio.Name = "btn_CrearColegio";
            this.btn_CrearColegio.Size = new System.Drawing.Size(778, 44);
            this.btn_CrearColegio.TabIndex = 0;
            this.btn_CrearColegio.Text = "Crear Colegio";
            this.btn_CrearColegio.UseVisualStyleBackColor = true;
            // 
            // lbl_Aula
            // 
            this.lbl_Aula.AutoSize = true;
            this.lbl_Aula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aula.Location = new System.Drawing.Point(12, 78);
            this.lbl_Aula.Name = "lbl_Aula";
            this.lbl_Aula.Size = new System.Drawing.Size(48, 24);
            this.lbl_Aula.TabIndex = 1;
            this.lbl_Aula.Text = "Aula";
            // 
            // cbox_Aulas
            // 
            this.cbox_Aulas.FormattingEnabled = true;
            this.cbox_Aulas.Location = new System.Drawing.Point(78, 78);
            this.cbox_Aulas.Name = "cbox_Aulas";
            this.cbox_Aulas.Size = new System.Drawing.Size(236, 24);
            this.cbox_Aulas.TabIndex = 2;
            // 
            // btn_CrearRelacion
            // 
            this.btn_CrearRelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearRelacion.Location = new System.Drawing.Point(340, 73);
            this.btn_CrearRelacion.Name = "btn_CrearRelacion";
            this.btn_CrearRelacion.Size = new System.Drawing.Size(450, 33);
            this.btn_CrearRelacion.TabIndex = 3;
            this.btn_CrearRelacion.Text = "Crear Relación de Alumnos del Aula";
            this.btn_CrearRelacion.UseVisualStyleBackColor = true;
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lista.Location = new System.Drawing.Point(12, 131);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(159, 24);
            this.lbl_Lista.TabIndex = 4;
            this.lbl_Lista.Text = "Lista de Alumnos:";
            // 
            // lbl_Datos
            // 
            this.lbl_Datos.AutoSize = true;
            this.lbl_Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Datos.Location = new System.Drawing.Point(336, 131);
            this.lbl_Datos.Name = "lbl_Datos";
            this.lbl_Datos.Size = new System.Drawing.Size(175, 24);
            this.lbl_Datos.TabIndex = 5;
            this.lbl_Datos.Text = "Datos del Alumno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_Nombres);
            this.groupBox1.Controls.Add(this.txtbox_Apellidos);
            this.groupBox1.Controls.Add(this.btn_Actualizar);
            this.groupBox1.Controls.Add(this.lbl_Nombres);
            this.groupBox1.Controls.Add(this.lbl_Apellidos);
            this.groupBox1.Location = new System.Drawing.Point(340, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // list_Alumnos
            // 
            this.list_Alumnos.FormattingEnabled = true;
            this.list_Alumnos.ItemHeight = 16;
            this.list_Alumnos.Location = new System.Drawing.Point(16, 169);
            this.list_Alumnos.Name = "list_Alumnos";
            this.list_Alumnos.Size = new System.Drawing.Size(298, 244);
            this.list_Alumnos.TabIndex = 7;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(30, 51);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(93, 24);
            this.lbl_Apellidos.TabIndex = 8;
            this.lbl_Apellidos.Text = "Apellidos:";
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.Location = new System.Drawing.Point(30, 108);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(93, 24);
            this.lbl_Nombres.TabIndex = 9;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(20, 156);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(408, 40);
            this.btn_Actualizar.TabIndex = 10;
            this.btn_Actualizar.Text = "Actualizar Alumno";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // txtbox_Apellidos
            // 
            this.txtbox_Apellidos.Location = new System.Drawing.Point(129, 53);
            this.txtbox_Apellidos.Name = "txtbox_Apellidos";
            this.txtbox_Apellidos.Size = new System.Drawing.Size(298, 22);
            this.txtbox_Apellidos.TabIndex = 11;
            // 
            // txtbox_Nombres
            // 
            this.txtbox_Nombres.Location = new System.Drawing.Point(129, 110);
            this.txtbox_Nombres.Name = "txtbox_Nombres";
            this.txtbox_Nombres.Size = new System.Drawing.Size(298, 22);
            this.txtbox_Nombres.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 433);
            this.Controls.Add(this.list_Alumnos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Datos);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.btn_CrearRelacion);
            this.Controls.Add(this.cbox_Aulas);
            this.Controls.Add(this.lbl_Aula);
            this.Controls.Add(this.btn_CrearColegio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Colegio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearColegio;
        private System.Windows.Forms.Label lbl_Aula;
        private System.Windows.Forms.ComboBox cbox_Aulas;
        private System.Windows.Forms.Button btn_CrearRelacion;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lbl_Datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_Alumnos;
        private System.Windows.Forms.TextBox txtbox_Nombres;
        private System.Windows.Forms.TextBox txtbox_Apellidos;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Apellidos;
    }
}

