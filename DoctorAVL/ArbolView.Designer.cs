namespace DoctorAVL
{
    partial class ArbolView
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
            btnPacientes = new Button();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            treePacientes = new TreeView();
            tableLayoutPanel1 = new TableLayoutPanel();
            listView1 = new ListView();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(60, 60, 81);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(btnPacientes);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel5);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 0, 0, 0);
            flowLayoutPanel1.Size = new Size(1063, 38);
            flowLayoutPanel1.TabIndex = 9;
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
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.FromArgb(60, 60, 81);
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientes.ForeColor = SystemColors.ButtonHighlight;
            btnPacientes.Location = new Point(114, 0);
            btnPacientes.Margin = new Padding(0);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(94, 37);
            btnPacientes.TabIndex = 10;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(33, 33, 61);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(211, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 9, 0, 0);
            label1.Size = new Size(89, 40);
            label1.TabIndex = 9;
            label1.Text = "Árbol";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel5.Controls.Add(button1, 1, 0);
            tableLayoutPanel5.Location = new Point(306, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(244, 34);
            tableLayoutPanel5.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(97, 3);
            button1.Name = "button1";
            button1.Size = new Size(144, 28);
            button1.TabIndex = 0;
            button1.Text = "Cerrar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // treePacientes
            // 
            treePacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treePacientes.Location = new Point(12, 44);
            treePacientes.Name = "treePacientes";
            treePacientes.Size = new Size(288, 617);
            treePacientes.TabIndex = 10;
            treePacientes.AfterSelect += treePacientes_AfterSelect_1;
            treePacientes.Click += treePacientes_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(listView1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(306, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(744, 617);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(738, 551);
            listView1.TabIndex = 13;
            listView1.TileSize = new Size(700, 100);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(406, 46);
            label2.TabIndex = 12;
            label2.Text = "Recomendaciones seleccionadas:";
            // 
            // ArbolView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(treePacientes);
            Controls.Add(flowLayoutPanel1);
            Name = "ArbolView";
            Text = "ArbolView";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnUsuarios;
        private Label label1;
        private Button btnPacientes;
        private TreeView treePacientes;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private ListView listView1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
    }
}