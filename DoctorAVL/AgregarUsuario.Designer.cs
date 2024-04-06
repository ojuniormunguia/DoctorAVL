namespace DoctorAVL
{
    partial class AgregarUsuario
    {
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
            panel1 = new Panel();
            txtContrasena = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmboxPermiso = new ComboBox();
            txtUsuario = new TextBox();
            btnAgregar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmboxPermiso);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(132, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 426);
            panel1.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContrasena.Location = new Point(3, 207);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(330, 27);
            txtContrasena.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 18);
            label4.Margin = new Padding(0, 0, 0, 5);
            label4.Name = "label4";
            label4.Size = new Size(330, 46);
            label4.TabIndex = 7;
            label4.Text = "Agregar usuario";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 251);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 6;
            label3.Text = "Elegir tipo de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 184);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 5;
            label2.Text = "Escribir contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 121);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 4;
            label1.Text = "Escribir nombre de usuario";
            // 
            // cmboxPermiso
            // 
            cmboxPermiso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmboxPermiso.FormattingEnabled = true;
            cmboxPermiso.Items.AddRange(new object[] { "administrador", "doctor", "digitador" });
            cmboxPermiso.Location = new Point(3, 274);
            cmboxPermiso.Name = "cmboxPermiso";
            cmboxPermiso.Size = new Size(330, 28);
            cmboxPermiso.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(3, 144);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(330, 27);
            txtUsuario.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Location = new Point(3, 338);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(330, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Usuario";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(panel1);
            Name = "AgregarUsuario";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnAgregar;
        private ComboBox cmboxPermiso;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtContrasena;
    }
}