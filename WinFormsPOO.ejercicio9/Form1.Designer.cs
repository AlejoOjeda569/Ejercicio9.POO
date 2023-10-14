namespace WinFormsPOO.ejercicio9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tbsSalir = new ToolStripButton();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvDatos = new DataGridView();
            Colradio = new DataGridViewTextBoxColumn();
            ColArea = new DataGridViewTextBoxColumn();
            ColPerimetro = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCantidad = new TextBox();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltar, tsbActualizar, toolStripSeparator2, tbsSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 22);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 22);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 22);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbFiltar
            // 
            tsbFiltar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbFiltar.Image = (Image)resources.GetObject("tsbFiltar.Image");
            tsbFiltar.ImageTransparentColor = Color.Magenta;
            tsbFiltar.Name = "tsbFiltar";
            tsbFiltar.Size = new Size(41, 22);
            tsbFiltar.Text = "Filtrar";
            tsbFiltar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltar.Click += tsbFiltar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 22);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tbsSalir
            // 
            tbsSalir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsSalir.Image = (Image)resources.GetObject("tbsSalir.Image");
            tbsSalir.ImageTransparentColor = Color.Magenta;
            tbsSalir.Name = "tbsSalir";
            tbsSalir.Size = new Size(33, 22);
            tbsSalir.Text = "Salir";
            tbsSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tbsSalir.Click += tbsSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Enabled = false;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 311);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 139);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 286);
            panel2.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Colradio, ColArea, ColPerimetro });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 286);
            dgvDatos.TabIndex = 0;
            // 
            // Colradio
            // 
            Colradio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Colradio.HeaderText = "Radio";
            Colradio.Name = "Colradio";
            Colradio.ReadOnly = true;
            // 
            // ColArea
            // 
            ColArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColArea.HeaderText = "Área";
            ColArea.Name = "ColArea";
            ColArea.ReadOnly = true;
            // 
            // ColPerimetro
            // 
            ColPerimetro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPerimetro.HeaderText = "Perimetro";
            ColPerimetro.Name = "ColPerimetro";
            ColPerimetro.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 39);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de Registros";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(180, 36);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tbsSalir;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Colradio;
        private DataGridViewTextBoxColumn ColArea;
        private DataGridViewTextBoxColumn ColPerimetro;
        private TextBox txtCantidad;
        private Label label1;
    }
}