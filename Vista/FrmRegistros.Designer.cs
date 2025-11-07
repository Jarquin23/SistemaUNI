namespace SistemaUNI.Vista
{
    partial class FrmRegistros
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblFacultades = new System.Windows.Forms.Label();
            this.lbCarrera = new System.Windows.Forms.ListBox();
            this.lbCarreras = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(61, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Facultad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.tbCodigo);
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(40, 29);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(339, 234);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de facultad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(123, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(32, 129);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(271, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(29, 112);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(29, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(274, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carreras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.btnAgregarCarrera);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(26, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de facultad";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(29, 137);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(109, 20);
            this.tbPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 120);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Location = new System.Drawing.Point(60, 186);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(102, 42);
            this.btnAgregarCarrera.TabIndex = 4;
            this.btnAgregarCarrera.Text = "Agregar";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.btnAgregarCarrera_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(29, 85);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(166, 20);
            this.tbCode.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(26, 69);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Código";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(29, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(166, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnQuitar);
            this.tabPage3.Controls.Add(this.btnAsignar);
            this.tabPage3.Controls.Add(this.lbCarreras);
            this.tabPage3.Controls.Add(this.lbCarrera);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Controls.Add(this.lblFacultades);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(623, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asignar Carrera";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(53, 60);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 231);
            this.treeView1.TabIndex = 1;
            // 
            // lblFacultades
            // 
            this.lblFacultades.AutoSize = true;
            this.lblFacultades.Location = new System.Drawing.Point(50, 44);
            this.lblFacultades.Name = "lblFacultades";
            this.lblFacultades.Size = new System.Drawing.Size(62, 13);
            this.lblFacultades.TabIndex = 0;
            this.lblFacultades.Text = "Facultades:";
            // 
            // lbCarrera
            // 
            this.lbCarrera.FormattingEnabled = true;
            this.lbCarrera.Location = new System.Drawing.Point(423, 60);
            this.lbCarrera.Name = "lbCarrera";
            this.lbCarrera.Size = new System.Drawing.Size(120, 199);
            this.lbCarrera.TabIndex = 2;
            // 
            // lbCarreras
            // 
            this.lbCarreras.AutoSize = true;
            this.lbCarreras.Location = new System.Drawing.Point(278, 60);
            this.lbCarreras.Name = "lbCarreras";
            this.lbCarreras.Size = new System.Drawing.Size(46, 13);
            this.lbCarreras.TabIndex = 3;
            this.lbCarreras.Text = "Carreras";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(281, 112);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(281, 175);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // FrmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRegistros";
            this.Text = "FrmRegistros";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCarrera;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblFacultades;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lbCarreras;
        private System.Windows.Forms.ListBox lbCarrera;
    }
}