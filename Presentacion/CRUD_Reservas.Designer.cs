
namespace Presentacion
{
    partial class CRUD_Reservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Reservas));
            this.label7 = new System.Windows.Forms.Label();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.pbLimpiar = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.DateTimePicker();
            this.salida = new System.Windows.Forms.DateTimePicker();
            this.cbPropiedad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadPersonas = new System.Windows.Forms.DomainUpDown();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.booking = new System.Windows.Forms.RadioButton();
            this.expedia = new System.Windows.Forms.RadioButton();
            this.airbnb = new System.Windows.Forms.RadioButton();
            this.directa = new System.Windows.Forms.RadioButton();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 93;
            this.label7.Text = "PROPIEDAD:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRegresar
            // 
            this.pbRegresar.Image = ((System.Drawing.Image)(resources.GetObject("pbRegresar.Image")));
            this.pbRegresar.Location = new System.Drawing.Point(908, 27);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(32, 31);
            this.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegresar.TabIndex = 89;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pbLimpiar
            // 
            this.pbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pbLimpiar.Image")));
            this.pbLimpiar.Location = new System.Drawing.Point(684, 27);
            this.pbLimpiar.Name = "pbLimpiar";
            this.pbLimpiar.Size = new System.Drawing.Size(32, 32);
            this.pbLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLimpiar.TabIndex = 88;
            this.pbLimpiar.TabStop = false;
            this.pbLimpiar.Click += new System.EventHandler(this.pbLimpiar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(722, 27);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 32);
            this.btnLimpiar.TabIndex = 87;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(469, 26);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(23, 32);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEliminar.TabIndex = 86;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(248, 27);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(32, 32);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEditar.TabIndex = 85;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(692, 557);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Black;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(946, 27);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(136, 32);
            this.btnRegresar.TabIndex = 82;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(498, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 32);
            this.btnEliminar.TabIndex = 81;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(286, 26);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 32);
            this.btnEditar.TabIndex = 80;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(66, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 32);
            this.btnAgregar.TabIndex = 79;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "CHECK - OUT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "CHECK - IN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "CLIENTE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entrada
            // 
            this.entrada.CalendarForeColor = System.Drawing.Color.White;
            this.entrada.CalendarMonthBackground = System.Drawing.Color.Black;
            this.entrada.Location = new System.Drawing.Point(58, 167);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(222, 20);
            this.entrada.TabIndex = 94;
            this.entrada.ValueChanged += new System.EventHandler(this.entrada_ValueChanged);
            // 
            // salida
            // 
            this.salida.CalendarForeColor = System.Drawing.Color.White;
            this.salida.CalendarMonthBackground = System.Drawing.Color.Black;
            this.salida.Location = new System.Drawing.Point(58, 233);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(222, 20);
            this.salida.TabIndex = 95;
            // 
            // cbPropiedad
            // 
            this.cbPropiedad.FormattingEnabled = true;
            this.cbPropiedad.Location = new System.Drawing.Point(58, 298);
            this.cbPropiedad.Name = "cbPropiedad";
            this.cbPropiedad.Size = new System.Drawing.Size(222, 21);
            this.cbPropiedad.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "CANTIDAD DE PERSONAS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Items.Add("1");
            this.txtCantidadPersonas.Items.Add("2");
            this.txtCantidadPersonas.Items.Add("3");
            this.txtCantidadPersonas.Items.Add("4");
            this.txtCantidadPersonas.Items.Add("5");
            this.txtCantidadPersonas.Items.Add("6");
            this.txtCantidadPersonas.Items.Add("7");
            this.txtCantidadPersonas.Items.Add("8");
            this.txtCantidadPersonas.Items.Add("9");
            this.txtCantidadPersonas.Items.Add("10");
            this.txtCantidadPersonas.Items.Add("11");
            this.txtCantidadPersonas.Items.Add("12");
            this.txtCantidadPersonas.Items.Add("13");
            this.txtCantidadPersonas.Items.Add("14");
            this.txtCantidadPersonas.Items.Add("15");
            this.txtCantidadPersonas.Items.Add("16");
            this.txtCantidadPersonas.Items.Add("17");
            this.txtCantidadPersonas.Items.Add("18");
            this.txtCantidadPersonas.Items.Add("19");
            this.txtCantidadPersonas.Items.Add("20");
            this.txtCantidadPersonas.Location = new System.Drawing.Point(58, 371);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.Size = new System.Drawing.Size(222, 20);
            this.txtCantidadPersonas.TabIndex = 98;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.DimGray;
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(58, 438);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(222, 20);
            this.txtPrecio.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 102;
            this.label5.Text = "PRECIO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 108;
            this.label6.Text = "PLATAFORMA:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booking
            // 
            this.booking.AutoSize = true;
            this.booking.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F);
            this.booking.Location = new System.Drawing.Point(58, 524);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(108, 23);
            this.booking.TabIndex = 110;
            this.booking.TabStop = true;
            this.booking.Text = "Booking.com";
            this.booking.UseVisualStyleBackColor = true;
            // 
            // expedia
            // 
            this.expedia.AutoSize = true;
            this.expedia.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F);
            this.expedia.Location = new System.Drawing.Point(58, 559);
            this.expedia.Name = "expedia";
            this.expedia.Size = new System.Drawing.Size(107, 23);
            this.expedia.TabIndex = 111;
            this.expedia.TabStop = true;
            this.expedia.Text = "Expedia.com";
            this.expedia.UseVisualStyleBackColor = true;
            // 
            // airbnb
            // 
            this.airbnb.AutoSize = true;
            this.airbnb.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F);
            this.airbnb.Location = new System.Drawing.Point(178, 524);
            this.airbnb.Name = "airbnb";
            this.airbnb.Size = new System.Drawing.Size(68, 23);
            this.airbnb.TabIndex = 112;
            this.airbnb.TabStop = true;
            this.airbnb.Text = "Airbnb";
            this.airbnb.UseVisualStyleBackColor = true;
            // 
            // directa
            // 
            this.directa.AutoSize = true;
            this.directa.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F);
            this.directa.Location = new System.Drawing.Point(177, 559);
            this.directa.Name = "directa";
            this.directa.Size = new System.Drawing.Size(130, 23);
            this.directa.TabIndex = 113;
            this.directa.TabStop = true;
            this.directa.Text = "Reserva Directa";
            this.directa.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(58, 108);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(222, 21);
            this.cbCliente.TabIndex = 114;
            // 
            // CRUD_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 670);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.directa);
            this.Controls.Add(this.airbnb);
            this.Controls.Add(this.expedia);
            this.Controls.Add(this.booking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidadPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPropiedad);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbRegresar);
            this.Controls.Add(this.pbLimpiar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUD_Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar";
            this.Load += new System.EventHandler(this.CRUD_Reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.PictureBox pbLimpiar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker entrada;
        private System.Windows.Forms.DateTimePicker salida;
        private System.Windows.Forms.ComboBox cbPropiedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown txtCantidadPersonas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton booking;
        private System.Windows.Forms.RadioButton expedia;
        private System.Windows.Forms.RadioButton airbnb;
        private System.Windows.Forms.RadioButton directa;
        private System.Windows.Forms.ComboBox cbCliente;
    }
}