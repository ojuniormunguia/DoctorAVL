namespace DoctorAVL
{
    partial class Pacientes
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUsuarios = new Button();
            label1 = new Label();
            btnRecomendaciones = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataUsers = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAgregarP = new Button();
            button3 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            txtBusqueda = new TextBox();
            button2 = new Button();
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsers).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(60, 60, 81);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(btnRecomendaciones);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 0, 20, 0);
            flowLayoutPanel1.Size = new Size(1063, 38);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(60, 60, 81);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = SystemColors.ButtonHighlight;
            btnUsuarios.Location = new Point(20, 0);
            btnUsuarios.Margin = new Padding(0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(94, 37);
            btnUsuarios.TabIndex = 8;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(33, 33, 61);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(117, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 9, 0, 0);
            label1.Size = new Size(89, 37);
            label1.TabIndex = 9;
            label1.Text = "Pacientes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRecomendaciones
            // 
            btnRecomendaciones.BackColor = Color.FromArgb(60, 60, 81);
            btnRecomendaciones.FlatAppearance.BorderSize = 0;
            btnRecomendaciones.FlatStyle = FlatStyle.Flat;
            btnRecomendaciones.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecomendaciones.ForeColor = SystemColors.ButtonHighlight;
            btnRecomendaciones.Location = new Point(209, 0);
            btnRecomendaciones.Margin = new Padding(0);
            btnRecomendaciones.Name = "btnRecomendaciones";
            btnRecomendaciones.Size = new Size(148, 37);
            btnRecomendaciones.TabIndex = 10;
            btnRecomendaciones.Text = "Recomendaciones";
            btnRecomendaciones.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataUsers, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(25, 20, 25, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1038, 631);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // dataUsers
            // 
            dataUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsers.Location = new Point(28, 257);
            dataUsers.Name = "dataUsers";
            dataUsers.ReadOnly = true;
            dataUsers.RowHeadersWidth = 51;
            dataUsers.Size = new Size(982, 371);
            dataUsers.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Location = new Point(28, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RightToLeft = RightToLeft.No;
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(982, 154);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 121);
            panel2.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(-3, 51);
            label3.Name = "label3";
            label3.Size = new Size(770, 60);
            label3.TabIndex = 1;
            label3.Text = "Desde aquí puede ver todos los usuarios dentro del sistema, los usuarios tienen un rol de edición dentro de la plataforma, para ver los pacientes dirigase a la pestaña de pacientes\r\n";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-11, 0);
            label2.Margin = new Padding(0, 0, 0, 5);
            label2.Name = "label2";
            label2.Size = new Size(289, 46);
            label2.TabIndex = 0;
            label2.Text = "Lista de Usuarios";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tableLayoutPanel3.Controls.Add(btnAgregarP, 1, 0);
            tableLayoutPanel3.Controls.Add(button3, 1, 1);
            tableLayoutPanel3.Location = new Point(494, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(485, 148);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // btnAgregarP
            // 
            btnAgregarP.BackColor = Color.FromArgb(0, 166, 204);
            btnAgregarP.FlatStyle = FlatStyle.Flat;
            btnAgregarP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarP.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarP.Location = new Point(260, 3);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(222, 43);
            btnAgregarP.TabIndex = 12;
            btnAgregarP.Text = "Agregar usuario";
            btnAgregarP.UseVisualStyleBackColor = false;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(229, 65, 65);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(260, 58);
            button3.Name = "button3";
            button3.Size = new Size(222, 40);
            button3.TabIndex = 13;
            button3.Text = "Borrar usuario";
            button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Controls.Add(button2, 1, 0);
            tableLayoutPanel4.Controls.Add(button4, 2, 0);
            tableLayoutPanel4.Location = new Point(28, 183);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RightToLeft = RightToLeft.No;
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(982, 68);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(197, 218, 221);
            panel1.Controls.Add(txtBusqueda);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 20, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 35);
            panel1.TabIndex = 13;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.BackColor = Color.FromArgb(197, 218, 221);
            txtBusqueda.BorderStyle = BorderStyle.None;
            txtBusqueda.Cursor = Cursors.IBeam;
            txtBusqueda.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(3, 6);
            txtBusqueda.Margin = new Padding(5);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar paciente por nombre...";
            txtBusqueda.Size = new Size(1059, 24);
            txtBusqueda.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.Image = Properties.Resources.Recurso_1;
            button2.Location = new Point(665, 0);
            button2.Margin = new Padding(3, 0, 3, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 20, 0);
            button2.Size = new Size(194, 35);
            button2.TabIndex = 14;
            button2.Text = "Buscar paciente";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(885, 0);
            button4.Margin = new Padding(3, 0, 3, 0);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 15;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = false;
            // 
            // Pacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Pacientes";
            Text = "Pacientes";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataUsers).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button btnUsuarios;
        private Button btnRecomendaciones;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataUsers;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnAgregarP;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private TextBox txtBusqueda;
        private Button button2;
        private Button button4;
    }
}