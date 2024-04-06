namespace DoctorAVL
{
    partial class AgregarPaciente
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
            panel1 = new Panel();
            label6 = new Label();
            cmbDoctores = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            label5 = new Label();
            cmbGenero = new ComboBox();
            panel3 = new Panel();
            label2 = new Label();
            cmbPresion = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            cmbSangre = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbDoctores);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(32, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 426);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 239);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 12;
            label6.Text = "Doctor encargado";
            // 
            // cmbDoctores
            // 
            cmbDoctores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(0, 262);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(550, 28);
            cmbDoctores.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 158);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(544, 65);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(cmbGenero);
            panel4.Location = new Point(365, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 59);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Género";
            // 
            // cmbGenero
            // 
            cmbGenero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "hombre", "mujer" });
            cmbGenero.Location = new Point(0, 23);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(172, 28);
            cmbGenero.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cmbPresion);
            panel3.Location = new Point(184, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 59);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 9;
            label2.Text = "Presión cardiaca";
            // 
            // cmbPresion
            // 
            cmbPresion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPresion.FormattingEnabled = true;
            cmbPresion.Items.AddRange(new object[] { "baja", "media", "alta" });
            cmbPresion.Location = new Point(0, 23);
            cmbPresion.Name = "cmbPresion";
            cmbPresion.Size = new Size(172, 28);
            cmbPresion.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbSangre);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 59);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 9;
            label3.Text = "Tipo de sangre";
            // 
            // cmbSangre
            // 
            cmbSangre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSangre.FormattingEnabled = true;
            cmbSangre.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cmbSangre.Location = new Point(0, 23);
            cmbSangre.Name = "cmbSangre";
            cmbSangre.Size = new Size(172, 28);
            cmbSangre.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 18);
            label4.Margin = new Padding(0, 0, 0, 5);
            label4.Name = "label4";
            label4.Size = new Size(547, 46);
            label4.TabIndex = 7;
            label4.Text = "Agregar usuario";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 86);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 4;
            label1.Text = "Escribir nombre de usuario";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(0, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Usuario";
            txtNombre.Size = new Size(550, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Location = new Point(0, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(550, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Usuario";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(panel1);
            Name = "AgregarPaciente";
            Text = "AgregarPaciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private TextBox txtNombre;
        private Button btnAgregar;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Label label5;
        private ComboBox cmbGenero;
        private Panel panel3;
        private Label label2;
        private ComboBox cmbPresion;
        private Panel panel2;
        private Label label3;
        private ComboBox cmbSangre;
        private Label label6;
        private ComboBox cmbDoctores;
    }
}