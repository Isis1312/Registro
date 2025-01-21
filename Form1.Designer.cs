namespace Resgistra
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
            this.bienvenida = new System.Windows.Forms.Label();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbdatos = new System.Windows.Forms.Label();
            this.lbfechain = new System.Windows.Forms.Label();
            this.lbfechafin = new System.Windows.Forms.Label();
            this.lbmodalidad = new System.Windows.Forms.Label();
            this.lbhoras = new System.Windows.Forms.Label();
            this.lbestudiantes = new System.Windows.Forms.Label();
            this.kbactivo = new System.Windows.Forms.Label();
            this.fechain = new System.Windows.Forms.DateTimePicker();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.txnombrecurso = new System.Windows.Forms.TextBox();
            this.txdatos = new System.Windows.Forms.TextBox();
            this.lbej1 = new System.Windows.Forms.Label();
            this.lbej2 = new System.Windows.Forms.Label();
            this.cbmodalidad = new System.Windows.Forms.ComboBox();
            this.nunhoras = new System.Windows.Forms.NumericUpDown();
            this.nunestudiantes = new System.Windows.Forms.NumericUpDown();
            this.si = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.guardar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.txcodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nunhoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunestudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // bienvenida
            // 
            this.bienvenida.AutoSize = true;
            this.bienvenida.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(375, 9);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(402, 33);
            this.bienvenida.TabIndex = 0;
            this.bienvenida.Text = "Bienvedios a CursoResgistra";
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.Location = new System.Drawing.Point(44, 58);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(149, 26);
            this.lbcodigo.TabIndex = 2;
            this.lbcodigo.Text = "Codigo curso";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(12, 118);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(200, 26);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "Nombre del curso:";
            // 
            // lbdatos
            // 
            this.lbdatos.AutoSize = true;
            this.lbdatos.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatos.Location = new System.Drawing.Point(544, 58);
            this.lbdatos.Name = "lbdatos";
            this.lbdatos.Size = new System.Drawing.Size(231, 26);
            this.lbdatos.TabIndex = 4;
            this.lbdatos.Text = "Datos del instrucctor:";
            // 
            // lbfechain
            // 
            this.lbfechain.AutoSize = true;
            this.lbfechain.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechain.Location = new System.Drawing.Point(601, 118);
            this.lbfechain.Name = "lbfechain";
            this.lbfechain.Size = new System.Drawing.Size(164, 26);
            this.lbfechain.TabIndex = 5;
            this.lbfechain.Text = "Fecha de inicio";
            // 
            // lbfechafin
            // 
            this.lbfechafin.AutoSize = true;
            this.lbfechafin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechafin.Location = new System.Drawing.Point(544, 166);
            this.lbfechafin.Name = "lbfechafin";
            this.lbfechafin.Size = new System.Drawing.Size(233, 26);
            this.lbfechafin.TabIndex = 6;
            this.lbfechafin.Text = "Fecha de culminacion";
            // 
            // lbmodalidad
            // 
            this.lbmodalidad.AutoSize = true;
            this.lbmodalidad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmodalidad.Location = new System.Drawing.Point(97, 166);
            this.lbmodalidad.Name = "lbmodalidad";
            this.lbmodalidad.Size = new System.Drawing.Size(115, 26);
            this.lbmodalidad.TabIndex = 7;
            this.lbmodalidad.Text = "Modalidad";
            // 
            // lbhoras
            // 
            this.lbhoras.AutoSize = true;
            this.lbhoras.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhoras.Location = new System.Drawing.Point(544, 218);
            this.lbhoras.Name = "lbhoras";
            this.lbhoras.Size = new System.Drawing.Size(162, 26);
            this.lbhoras.TabIndex = 8;
            this.lbhoras.Text = "Horas a cursar";
            // 
            // lbestudiantes
            // 
            this.lbestudiantes.AutoSize = true;
            this.lbestudiantes.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestudiantes.Location = new System.Drawing.Point(817, 219);
            this.lbestudiantes.Name = "lbestudiantes";
            this.lbestudiantes.Size = new System.Drawing.Size(248, 26);
            this.lbestudiantes.TabIndex = 9;
            this.lbestudiantes.Text = "Número de estudiantes";
            // 
            // kbactivo
            // 
            this.kbactivo.AutoSize = true;
            this.kbactivo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbactivo.Location = new System.Drawing.Point(44, 218);
            this.kbactivo.Name = "kbactivo";
            this.kbactivo.Size = new System.Drawing.Size(168, 26);
            this.kbactivo.TabIndex = 10;
            this.kbactivo.Text = "¿Curso activo?";
            // 
            // fechain
            // 
            this.fechain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechain.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechain.Location = new System.Drawing.Point(780, 118);
            this.fechain.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.fechain.MinDate = new System.DateTime(2025, 1, 25, 0, 0, 0, 0);
            this.fechain.Name = "fechain";
            this.fechain.Size = new System.Drawing.Size(170, 26);
            this.fechain.TabIndex = 11;
            this.fechain.Value = new System.DateTime(2025, 1, 25, 0, 0, 0, 0);
            // 
            // fechafin
            // 
            this.fechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechafin.Location = new System.Drawing.Point(783, 166);
            this.fechafin.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.fechafin.MinDate = new System.DateTime(2025, 1, 25, 0, 0, 0, 0);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(170, 26);
            this.fechafin.TabIndex = 12;
            this.fechafin.Value = new System.DateTime(2025, 1, 25, 0, 0, 0, 0);
            // 
            // txnombrecurso
            // 
            this.txnombrecurso.Location = new System.Drawing.Point(218, 118);
            this.txnombrecurso.MaxLength = 100;
            this.txnombrecurso.Name = "txnombrecurso";
            this.txnombrecurso.Size = new System.Drawing.Size(276, 26);
            this.txnombrecurso.TabIndex = 14;
            // 
            // txdatos
            // 
            this.txdatos.Location = new System.Drawing.Point(783, 60);
            this.txdatos.MaxLength = 100;
            this.txdatos.Name = "txdatos";
            this.txdatos.Size = new System.Drawing.Size(316, 26);
            this.txdatos.TabIndex = 15;
            // 
            // lbej1
            // 
            this.lbej1.AutoSize = true;
            this.lbej1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbej1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbej1.Location = new System.Drawing.Point(214, 89);
            this.lbej1.Name = "lbej1";
            this.lbej1.Size = new System.Drawing.Size(72, 19);
            this.lbej1.TabIndex = 16;
            this.lbej1.Text = "Ej AA-12";
            // 
            // lbej2
            // 
            this.lbej2.AutoSize = true;
            this.lbej2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbej2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbej2.Location = new System.Drawing.Point(779, 89);
            this.lbej2.Name = "lbej2";
            this.lbej2.Size = new System.Drawing.Size(147, 19);
            this.lbej2.TabIndex = 17;
            this.lbej2.Text = "Nombre y apellido";
            // 
            // cbmodalidad
            // 
            this.cbmodalidad.BackColor = System.Drawing.Color.MediumVioletRed;
            this.cbmodalidad.FormattingEnabled = true;
            this.cbmodalidad.Items.AddRange(new object[] {
            "Prencial",
            "Semipresencial",
            "Virtual"});
            this.cbmodalidad.Location = new System.Drawing.Point(228, 164);
            this.cbmodalidad.Name = "cbmodalidad";
            this.cbmodalidad.Size = new System.Drawing.Size(243, 28);
            this.cbmodalidad.TabIndex = 18;
            // 
            // nunhoras
            // 
            this.nunhoras.BackColor = System.Drawing.Color.LavenderBlush;
            this.nunhoras.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nunhoras.Location = new System.Drawing.Point(712, 218);
            this.nunhoras.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nunhoras.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nunhoras.Name = "nunhoras";
            this.nunhoras.Size = new System.Drawing.Size(83, 26);
            this.nunhoras.TabIndex = 19;
            this.nunhoras.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nunestudiantes
            // 
            this.nunestudiantes.BackColor = System.Drawing.Color.LavenderBlush;
            this.nunestudiantes.Location = new System.Drawing.Point(1071, 218);
            this.nunestudiantes.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nunestudiantes.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nunestudiantes.Name = "nunestudiantes";
            this.nunestudiantes.Size = new System.Drawing.Size(94, 26);
            this.nunestudiantes.TabIndex = 20;
            this.nunestudiantes.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // si
            // 
            this.si.AutoSize = true;
            this.si.Checked = true;
            this.si.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.si.Location = new System.Drawing.Point(259, 219);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(58, 29);
            this.si.TabIndex = 21;
            this.si.TabStop = true;
            this.si.Text = "SI";
            this.si.UseVisualStyleBackColor = true;
            this.si.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(378, 220);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(69, 29);
            this.no.TabIndex = 22;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(141, 305);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(160, 36);
            this.guardar.TabIndex = 23;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // eliminar
            // 
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(722, 305);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(160, 36);
            this.eliminar.TabIndex = 24;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // limpiar
            // 
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(908, 305);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(160, 36);
            this.limpiar.TabIndex = 25;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // buscar
            // 
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(337, 305);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(160, 36);
            this.buscar.TabIndex = 26;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // modificar
            // 
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(530, 305);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(160, 36);
            this.modificar.TabIndex = 27;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // txcodigo
            // 
            this.txcodigo.Location = new System.Drawing.Point(218, 60);
            this.txcodigo.MaxLength = 5;
            this.txcodigo.Name = "txcodigo";
            this.txcodigo.Size = new System.Drawing.Size(253, 26);
            this.txcodigo.TabIndex = 13;
            this.txcodigo.Text = "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1196, 376);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.no);
            this.Controls.Add(this.si);
            this.Controls.Add(this.nunestudiantes);
            this.Controls.Add(this.nunhoras);
            this.Controls.Add(this.cbmodalidad);
            this.Controls.Add(this.lbej2);
            this.Controls.Add(this.lbej1);
            this.Controls.Add(this.txdatos);
            this.Controls.Add(this.txnombrecurso);
            this.Controls.Add(this.txcodigo);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.fechain);
            this.Controls.Add(this.kbactivo);
            this.Controls.Add(this.lbestudiantes);
            this.Controls.Add(this.lbhoras);
            this.Controls.Add(this.lbmodalidad);
            this.Controls.Add(this.lbfechafin);
            this.Controls.Add(this.lbfechain);
            this.Controls.Add(this.lbdatos);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.bienvenida);
            this.Name = "Form1";
            this.Text = "CursoRegistra.com";
            ((System.ComponentModel.ISupportInitialize)(this.nunhoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunestudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbdatos;
        private System.Windows.Forms.Label lbfechain;
        private System.Windows.Forms.Label lbfechafin;
        private System.Windows.Forms.Label lbmodalidad;
        private System.Windows.Forms.Label lbhoras;
        private System.Windows.Forms.Label lbestudiantes;
        private System.Windows.Forms.Label kbactivo;
        private System.Windows.Forms.DateTimePicker fechain;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.TextBox txnombrecurso;
        private System.Windows.Forms.TextBox txdatos;
        private System.Windows.Forms.Label lbej1;
        private System.Windows.Forms.Label lbej2;
        private System.Windows.Forms.ComboBox cbmodalidad;
        private System.Windows.Forms.NumericUpDown nunhoras;
        private System.Windows.Forms.NumericUpDown nunestudiantes;
        private System.Windows.Forms.RadioButton si;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.TextBox txcodigo;
    }
}

