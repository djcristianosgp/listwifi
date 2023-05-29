namespace WifiView
{
    partial class Principal
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
            pnProgresso = new Panel();
            pbProgress = new ProgressBar();
            ssStatus = new StatusStrip();
            lblDesenvolvedor = new ToolStripStatusLabel();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnFechar = new Button();
            btnExportarLista = new Button();
            btnGerarQrcode = new Button();
            btnExecutar = new Button();
            lsRedes = new ListBox();
            pnProgresso.SuspendLayout();
            ssStatus.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnProgresso
            // 
            pnProgresso.Controls.Add(pbProgress);
            pnProgresso.Dock = DockStyle.Bottom;
            pnProgresso.Location = new Point(0, 354);
            pnProgresso.Name = "pnProgresso";
            pnProgresso.Size = new Size(671, 74);
            pnProgresso.TabIndex = 0;
            // 
            // pbProgress
            // 
            pbProgress.Location = new Point(24, 3);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(275, 50);
            pbProgress.TabIndex = 0;
            // 
            // ssStatus
            // 
            ssStatus.BackColor = Color.Transparent;
            ssStatus.Items.AddRange(new ToolStripItem[] { lblDesenvolvedor });
            ssStatus.Location = new Point(0, 428);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(671, 22);
            ssStatus.TabIndex = 1;
            ssStatus.Text = "statusStrip1";
            // 
            // lblDesenvolvedor
            // 
            lblDesenvolvedor.Name = "lblDesenvolvedor";
            lblDesenvolvedor.Size = new Size(201, 17);
            lblDesenvolvedor.Text = "Desenvolvido por: Cristiano Grobério";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 70);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(671, 70);
            label1.TabIndex = 0;
            label1.Text = "Redes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFechar);
            groupBox1.Controls.Add(btnExportarLista);
            groupBox1.Controls.Add(btnGerarQrcode);
            groupBox1.Controls.Add(btnExecutar);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(471, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 284);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // btnFechar
            // 
            btnFechar.Dock = DockStyle.Top;
            btnFechar.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.Transparent;
            btnFechar.Location = new Point(3, 184);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(194, 55);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnExportarLista
            // 
            btnExportarLista.Dock = DockStyle.Top;
            btnExportarLista.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnExportarLista.FlatAppearance.BorderSize = 0;
            btnExportarLista.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnExportarLista.FlatStyle = FlatStyle.Flat;
            btnExportarLista.ForeColor = Color.Transparent;
            btnExportarLista.Location = new Point(3, 129);
            btnExportarLista.Name = "btnExportarLista";
            btnExportarLista.Size = new Size(194, 55);
            btnExportarLista.TabIndex = 7;
            btnExportarLista.Text = "Exportar Lista";
            btnExportarLista.UseVisualStyleBackColor = true;
            btnExportarLista.Click += btnExportarLista_Click;
            // 
            // btnGerarQrcode
            // 
            btnGerarQrcode.Dock = DockStyle.Top;
            btnGerarQrcode.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnGerarQrcode.FlatAppearance.BorderSize = 0;
            btnGerarQrcode.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnGerarQrcode.FlatStyle = FlatStyle.Flat;
            btnGerarQrcode.ForeColor = Color.Transparent;
            btnGerarQrcode.Location = new Point(3, 74);
            btnGerarQrcode.Name = "btnGerarQrcode";
            btnGerarQrcode.Size = new Size(194, 55);
            btnGerarQrcode.TabIndex = 6;
            btnGerarQrcode.Text = "Gerar QR Code";
            btnGerarQrcode.UseVisualStyleBackColor = true;
            btnGerarQrcode.Click += btnGerarQrcode_Click;
            // 
            // btnExecutar
            // 
            btnExecutar.Dock = DockStyle.Top;
            btnExecutar.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnExecutar.FlatAppearance.BorderSize = 0;
            btnExecutar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnExecutar.FlatStyle = FlatStyle.Flat;
            btnExecutar.ForeColor = Color.Transparent;
            btnExecutar.Location = new Point(3, 19);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(194, 55);
            btnExecutar.TabIndex = 5;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // lsRedes
            // 
            lsRedes.BackColor = Color.DimGray;
            lsRedes.BorderStyle = BorderStyle.None;
            lsRedes.Dock = DockStyle.Fill;
            lsRedes.FormattingEnabled = true;
            lsRedes.ItemHeight = 15;
            lsRedes.Location = new Point(0, 70);
            lsRedes.Name = "lsRedes";
            lsRedes.Size = new Size(471, 284);
            lsRedes.TabIndex = 6;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(671, 450);
            Controls.Add(lsRedes);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pnProgresso);
            Controls.Add(ssStatus);
            ForeColor = Color.White;
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            pnProgresso.ResumeLayout(false);
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnProgresso;
        private StatusStrip ssStatus;
        private ToolStripStatusLabel lblDesenvolvedor;
        private ProgressBar pbProgress;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnExecutar;
        private Button btnGerarQrcode;
        private Label label1;
        private Button btnFechar;
        private Button btnExportarLista;
        private ListBox lsRedes;
    }
}