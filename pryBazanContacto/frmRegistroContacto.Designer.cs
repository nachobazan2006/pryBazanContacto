namespace pryBazanContacto
{
    partial class frmRegistroContacto
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
            lblContacto = new Label();
            lblTelefono = new Label();
            txtContacto = new TextBox();
            txtTelefono = new MaskedTextBox();
            lstResultado = new ListBox();
            btnGrabar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(27, 84);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(67, 19);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(29, 139);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(65, 19);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(149, 84);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 2;
            txtContacto.TextChanged += textBox1_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(149, 135);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(29, 254);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(220, 94);
            lstResultado.TabIndex = 4;
            // 
            // btnGrabar
            // 
            btnGrabar.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrabar.Location = new Point(174, 194);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.TextAlign = ContentAlignment.TopCenter;
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-3, 9);
            label1.Name = "label1";
            label1.Size = new Size(476, 35);
            label1.TabIndex = 6;
            label1.Text = "¡Bienvenido al programa de registro!";
            // 
            // frmRegistroContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(309, 378);
            Controls.Add(label1);
            Controls.Add(btnGrabar);
            Controls.Add(lstResultado);
            Controls.Add(txtTelefono);
            Controls.Add(txtContacto);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Name = "frmRegistroContacto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmRegistroContacto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblTelefono;
        private TextBox txtContacto;
        private MaskedTextBox txtTelefono;
        private ListBox lstResultado;
        private Button btnGrabar;
        private Label label1;
    }
}
