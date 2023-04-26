namespace pryMenemSp1S2
{
    partial class frmConsulta
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbNacional2 = new System.Windows.Forms.RadioButton();
            this.rbImportado2 = new System.Windows.Forms.RadioButton();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboMarca2 = new System.Windows.Forms.ComboBox();
            this.mrcOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(18, 45);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(493, 43);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 21);
            this.Consultar.TabIndex = 2;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.rbAmbos);
            this.mrcOrigen.Controls.Add(this.rbNacional2);
            this.mrcOrigen.Controls.Add(this.rbImportado2);
            this.mrcOrigen.Location = new System.Drawing.Point(21, 96);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(298, 81);
            this.mrcOrigen.TabIndex = 3;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(197, 35);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbAmbos.TabIndex = 13;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbNacional2
            // 
            this.rbNacional2.AutoSize = true;
            this.rbNacional2.Location = new System.Drawing.Point(108, 35);
            this.rbNacional2.Name = "rbNacional2";
            this.rbNacional2.Size = new System.Drawing.Size(67, 17);
            this.rbNacional2.TabIndex = 12;
            this.rbNacional2.TabStop = true;
            this.rbNacional2.Text = "Nacional";
            this.rbNacional2.UseVisualStyleBackColor = true;
            // 
            // rbImportado2
            // 
            this.rbImportado2.AutoSize = true;
            this.rbImportado2.Location = new System.Drawing.Point(17, 35);
            this.rbImportado2.Name = "rbImportado2";
            this.rbImportado2.Size = new System.Drawing.Size(72, 17);
            this.rbImportado2.TabIndex = 11;
            this.rbImportado2.TabStop = true;
            this.rbImportado2.Text = "Importado";
            this.rbImportado2.UseVisualStyleBackColor = true;
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvRepuestos.Location = new System.Drawing.Point(21, 208);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.Size = new System.Drawing.Size(547, 208);
            this.dgvRepuestos.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Origen";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(493, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 21);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboMarca2
            // 
            this.cboMarca2.FormattingEnabled = true;
            this.cboMarca2.Items.AddRange(new object[] {
            "Renault",
            "Citroen",
            "Peugeot"});
            this.cboMarca2.Location = new System.Drawing.Point(75, 45);
            this.cboMarca2.Name = "cboMarca2";
            this.cboMarca2.Size = new System.Drawing.Size(244, 21);
            this.cboMarca2.TabIndex = 9;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 428);
            this.Controls.Add(this.cboMarca2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.mrcOrigen);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.lblMarca);
            this.Name = "frmConsulta";
            this.Text = "AutoCor - Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbNacional2;
        private System.Windows.Forms.RadioButton rbImportado2;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboMarca2;
    }
}