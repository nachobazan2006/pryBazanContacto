namespace pryBazanContacto
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
            lblContacto = new Label();
            lblTelefono = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            lstResultado = new ListBox();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(184, 87);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(184, 139);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(265, 139);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(184, 265);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(120, 94);
            lstResultado.TabIndex = 4;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(290, 204);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 444);
            Controls.Add(btnGrabar);
            Controls.Add(lstResultado);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblTelefono;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private ListBox lstResultado;
        private Button btnGrabar;
    }
}
