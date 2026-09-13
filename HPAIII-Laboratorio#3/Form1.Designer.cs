namespace HPAIII_Laboratorio_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIDemp = new System.Windows.Forms.Label();
            this.lblNomb = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechn = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtIDemp = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.dtpFechn = new System.Windows.Forms.DateTimePicker();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbIcono = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDemp
            // 
            this.lblIDemp.AutoSize = true;
            this.lblIDemp.Location = new System.Drawing.Point(55, 59);
            this.lblIDemp.Name = "lblIDemp";
            this.lblIDemp.Size = new System.Drawing.Size(66, 13);
            this.lblIDemp.TabIndex = 0;
            this.lblIDemp.Text = "Id Empleado";
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.Location = new System.Drawing.Point(55, 89);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(44, 13);
            this.lblNomb.TabIndex = 1;
            this.lblNomb.Text = "Nombre";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(55, 121);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(49, 13);
            this.lblApe.TabIndex = 2;
            this.lblApe.Text = "Apellidos";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblFechn
            // 
            this.lblFechn.AutoSize = true;
            this.lblFechn.Location = new System.Drawing.Point(55, 184);
            this.lblFechn.Name = "lblFechn";
            this.lblFechn.Size = new System.Drawing.Size(106, 13);
            this.lblFechn.TabIndex = 4;
            this.lblFechn.Text = "Fecha de nacimiento";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(55, 220);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salario";
            // 
            // txtIDemp
            // 
            this.txtIDemp.Location = new System.Drawing.Point(171, 56);
            this.txtIDemp.Name = "txtIDemp";
            this.txtIDemp.Size = new System.Drawing.Size(391, 20);
            this.txtIDemp.TabIndex = 6;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(171, 217);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(391, 20);
            this.txtSal.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(171, 118);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(391, 20);
            this.txtApe.TabIndex = 11;
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(171, 86);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(391, 20);
            this.txtNomb.TabIndex = 12;
            // 
            // dtpFechn
            // 
            this.dtpFechn.Location = new System.Drawing.Point(171, 184);
            this.dtpFechn.Name = "dtpFechn";
            this.dtpFechn.Size = new System.Drawing.Size(391, 20);
            this.dtpFechn.TabIndex = 13;
            // 
            // dgvdatos
            // 
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(31, 265);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.Size = new System.Drawing.Size(567, 150);
            this.dgvdatos.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIcono});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(626, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbIcono
            // 
            this.tsbIcono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIcono.Image = ((System.Drawing.Image)(resources.GetObject("tsbIcono.Image")));
            this.tsbIcono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIcono.Name = "tsbIcono";
            this.tsbIcono.Size = new System.Drawing.Size(23, 22);
            this.tsbIcono.Text = "toolStripButton1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 439);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.dtpFechn);
            this.Controls.Add(this.txtNomb);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtIDemp);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFechn);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNomb);
            this.Controls.Add(this.lblIDemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsbIcono.Click += new System.EventHandler(this.tsbNuevo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDemp;
        private System.Windows.Forms.Label lblNomb;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFechn;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtIDemp;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.DateTimePicker dtpFechn;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbIcono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

