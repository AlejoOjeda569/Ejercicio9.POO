namespace WinFormsPOO.ejercicio9
{
    partial class frmCirculoAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtRadio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 50);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el Radio del Circulo";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(240, 47);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(113, 142);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 58);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(392, 142);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 58);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCirculoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 277);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtRadio);
            Controls.Add(label1);
            MaximumSize = new Size(816, 316);
            MinimumSize = new Size(816, 316);
            Name = "frmCirculoAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCirculoAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadio;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}