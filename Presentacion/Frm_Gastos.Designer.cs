
namespace Presentacion
{
    partial class Frm_Gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gastos));
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoGasto = new System.Windows.Forms.ComboBox();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "TIPO DE GASTO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.DimGray;
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(46, 175);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(237, 20);
            this.txtMonto.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "MONTO DEL GASTO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTipoGasto
            // 
            this.cbTipoGasto.BackColor = System.Drawing.SystemColors.Control;
            this.cbTipoGasto.FormattingEnabled = true;
            this.cbTipoGasto.Items.AddRange(new object[] {
            "Limpieza",
            "Mantenimiento",
            "Compra ",
            "Otros"});
            this.cbTipoGasto.Location = new System.Drawing.Point(46, 63);
            this.cbTipoGasto.Name = "cbTipoGasto";
            this.cbTipoGasto.Size = new System.Drawing.Size(237, 21);
            this.cbTipoGasto.TabIndex = 51;
            // 
            // pbAgregar
            // 
            this.pbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregar.Image")));
            this.pbAgregar.Location = new System.Drawing.Point(165, 220);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(32, 32);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAgregar.TabIndex = 60;
            this.pbAgregar.TabStop = false;
            this.pbAgregar.Click += new System.EventHandler(this.pbAgregar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(203, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 32);
            this.btnAgregar.TabIndex = 59;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(371, 220);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 65;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(409, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 64;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.BackColor = System.Drawing.Color.DimGray;
            this.txtNumFactura.ForeColor = System.Drawing.Color.White;
            this.txtNumFactura.Location = new System.Drawing.Point(46, 120);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(237, 20);
            this.txtNumFactura.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "NÚMERO DE FACTURA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 263);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbTipoGasto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoGasto;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Label label2;
    }
}