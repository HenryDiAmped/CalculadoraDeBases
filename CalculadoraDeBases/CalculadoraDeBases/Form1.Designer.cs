
namespace CalculadoraDeBases
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.PnlHistorial = new System.Windows.Forms.Panel();
            this.rtbHistorial = new System.Windows.Forms.RichTextBox();
            this.btnVaciarHistorial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.cbxBaseNum = new System.Windows.Forms.ComboBox();
            this.lblConvertirNum = new System.Windows.Forms.Label();
            this.lblBaseNum = new System.Windows.Forms.Label();
            this.cbxConvertirNum = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.PnlTitulo.SuspendLayout();
            this.PnlHistorial.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.btnMinimizar);
            this.PnlTitulo.Controls.Add(this.btnMaximizar);
            this.PnlTitulo.Controls.Add(this.btnCerrar);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(350, 40);
            this.PnlTitulo.TabIndex = 0;
            this.PnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::CalculadoraDeBases.Properties.Resources.minimizarTransparente;
            this.btnMinimizar.Location = new System.Drawing.Point(200, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 40);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::CalculadoraDeBases.Properties.Resources.maximizarTransparente;
            this.btnMaximizar.Location = new System.Drawing.Point(250, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 40);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CalculadoraDeBases.Properties.Resources.cerrarTransparente1;
            this.btnCerrar.Location = new System.Drawing.Point(300, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PnlHistorial
            // 
            this.PnlHistorial.Controls.Add(this.rtbHistorial);
            this.PnlHistorial.Controls.Add(this.btnVaciarHistorial);
            this.PnlHistorial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistorial.Location = new System.Drawing.Point(0, 514);
            this.PnlHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistorial.Name = "PnlHistorial";
            this.PnlHistorial.Size = new System.Drawing.Size(350, 5);
            this.PnlHistorial.TabIndex = 1;
            // 
            // rtbHistorial
            // 
            this.rtbHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rtbHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHistorial.ForeColor = System.Drawing.Color.Silver;
            this.rtbHistorial.Location = new System.Drawing.Point(0, 0);
            this.rtbHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.rtbHistorial.Name = "rtbHistorial";
            this.rtbHistorial.ReadOnly = true;
            this.rtbHistorial.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbHistorial.Size = new System.Drawing.Size(350, 0);
            this.rtbHistorial.TabIndex = 2;
            this.rtbHistorial.Text = "";
            // 
            // btnVaciarHistorial
            // 
            this.btnVaciarHistorial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVaciarHistorial.FlatAppearance.BorderSize = 0;
            this.btnVaciarHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVaciarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarHistorial.Image = global::CalculadoraDeBases.Properties.Resources.tachoTransparente;
            this.btnVaciarHistorial.Location = new System.Drawing.Point(0, -35);
            this.btnVaciarHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.btnVaciarHistorial.Name = "btnVaciarHistorial";
            this.btnVaciarHistorial.Size = new System.Drawing.Size(350, 40);
            this.btnVaciarHistorial.TabIndex = 1;
            this.btnVaciarHistorial.UseVisualStyleBackColor = true;
            this.btnVaciarHistorial.Click += new System.EventHandler(this.btnVaciarHistorial_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHistorial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 54);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Calculadora de cambio de base";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Image = global::CalculadoraDeBases.Properties.Resources.historialTransparente;
            this.btnHistorial.Location = new System.Drawing.Point(300, 0);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(50, 54);
            this.btnHistorial.TabIndex = 0;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMostrar.Font = new System.Drawing.Font("Gadugi", 14F);
            this.txtMostrar.ForeColor = System.Drawing.Color.Silver;
            this.txtMostrar.Location = new System.Drawing.Point(0, 94);
            this.txtMostrar.Margin = new System.Windows.Forms.Padding(0);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.ReadOnly = true;
            this.txtMostrar.Size = new System.Drawing.Size(350, 25);
            this.txtMostrar.TabIndex = 3;
            this.txtMostrar.Text = "0";
            this.txtMostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResultado.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(0, 119);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(0);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(350, 50);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn7.Enabled = false;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(7, 247);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 50);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn8.Enabled = false;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(75, 247);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 50);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn9.Enabled = false;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(143, 247);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 50);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBorrarTodo.FlatAppearance.BorderSize = 0;
            this.btnBorrarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTodo.Location = new System.Drawing.Point(211, 247);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(63, 50);
            this.btnBorrarTodo.TabIndex = 15;
            this.btnBorrarTodo.Text = "AC";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnA.Enabled = false;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Location = new System.Drawing.Point(143, 424);
            this.btnA.Margin = new System.Windows.Forms.Padding(0);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(63, 50);
            this.btnA.TabIndex = 20;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn6.Enabled = false;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(143, 306);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 50);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnD.Enabled = false;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Location = new System.Drawing.Point(211, 424);
            this.btnD.Margin = new System.Windows.Forms.Padding(0);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(63, 50);
            this.btnD.TabIndex = 18;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn5.Enabled = false;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(75, 306);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 50);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn4.Enabled = false;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(7, 306);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 50);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnB.Enabled = false;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Location = new System.Drawing.Point(211, 306);
            this.btnB.Margin = new System.Windows.Forms.Padding(0);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(63, 50);
            this.btnB.TabIndex = 25;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn3.Enabled = false;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(143, 365);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 50);
            this.btn3.TabIndex = 24;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnE.Enabled = false;
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Location = new System.Drawing.Point(279, 306);
            this.btnE.Margin = new System.Windows.Forms.Padding(0);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(63, 50);
            this.btnE.TabIndex = 23;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn2.Enabled = false;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(75, 365);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 50);
            this.btn2.TabIndex = 22;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn1.Enabled = false;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(7, 365);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 50);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnC.Enabled = false;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(211, 365);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(63, 50);
            this.btnC.TabIndex = 30;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConvertir.Enabled = false;
            this.btnConvertir.FlatAppearance.BorderSize = 0;
            this.btnConvertir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Location = new System.Drawing.Point(279, 424);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(0);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(63, 50);
            this.btnConvertir.TabIndex = 29;
            this.btnConvertir.Text = "=";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnF.Enabled = false;
            this.btnF.FlatAppearance.BorderSize = 0;
            this.btnF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Location = new System.Drawing.Point(279, 365);
            this.btnF.Margin = new System.Windows.Forms.Padding(0);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(63, 50);
            this.btnF.TabIndex = 28;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn0.Enabled = false;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(75, 424);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(63, 50);
            this.btn0.TabIndex = 27;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPunto.Enabled = false;
            this.btnPunto.FlatAppearance.BorderSize = 0;
            this.btnPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunto.Location = new System.Drawing.Point(7, 424);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(0);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(63, 50);
            this.btnPunto.TabIndex = 26;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // cbxBaseNum
            // 
            this.cbxBaseNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cbxBaseNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBaseNum.ForeColor = System.Drawing.Color.White;
            this.cbxBaseNum.FormattingEnabled = true;
            this.cbxBaseNum.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cbxBaseNum.Location = new System.Drawing.Point(15, 202);
            this.cbxBaseNum.Margin = new System.Windows.Forms.Padding(0);
            this.cbxBaseNum.Name = "cbxBaseNum";
            this.cbxBaseNum.Size = new System.Drawing.Size(100, 27);
            this.cbxBaseNum.TabIndex = 33;
            // 
            // lblConvertirNum
            // 
            this.lblConvertirNum.AutoSize = true;
            this.lblConvertirNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertirNum.Location = new System.Drawing.Point(242, 180);
            this.lblConvertirNum.Name = "lblConvertirNum";
            this.lblConvertirNum.Size = new System.Drawing.Size(81, 13);
            this.lblConvertirNum.TabIndex = 32;
            this.lblConvertirNum.Text = "Pasar a base";
            // 
            // lblBaseNum
            // 
            this.lblBaseNum.AutoSize = true;
            this.lblBaseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseNum.Location = new System.Drawing.Point(14, 180);
            this.lblBaseNum.Name = "lblBaseNum";
            this.lblBaseNum.Size = new System.Drawing.Size(101, 13);
            this.lblBaseNum.TabIndex = 31;
            this.lblBaseNum.Text = "Base del número";
            // 
            // cbxConvertirNum
            // 
            this.cbxConvertirNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cbxConvertirNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxConvertirNum.ForeColor = System.Drawing.Color.White;
            this.cbxConvertirNum.FormattingEnabled = true;
            this.cbxConvertirNum.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cbxConvertirNum.Location = new System.Drawing.Point(234, 202);
            this.cbxConvertirNum.Margin = new System.Windows.Forms.Padding(0);
            this.cbxConvertirNum.Name = "cbxConvertirNum";
            this.cbxConvertirNum.Size = new System.Drawing.Size(100, 27);
            this.cbxConvertirNum.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::CalculadoraDeBases.Properties.Resources.cancelarTransparente2;
            this.btnCancelar.Location = new System.Drawing.Point(178, 198);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(41, 37);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Image = global::CalculadoraDeBases.Properties.Resources.borrarTransparente;
            this.btnQuitar.Location = new System.Drawing.Point(279, 247);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(63, 50);
            this.btnQuitar.TabIndex = 13;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Image = global::CalculadoraDeBases.Properties.Resources.iniciarTransparente;
            this.btnIniciar.Location = new System.Drawing.Point(132, 198);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(41, 37);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 519);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlHistorial);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.cbxConvertirNum);
            this.Controls.Add(this.cbxBaseNum);
            this.Controls.Add(this.lblConvertirNum);
            this.Controls.Add(this.lblBaseNum);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlHistorial.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel PnlHistorial;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button btnVaciarHistorial;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RichTextBox rtbHistorial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.ComboBox cbxBaseNum;
        private System.Windows.Forms.Label lblConvertirNum;
        private System.Windows.Forms.Label lblBaseNum;
        private System.Windows.Forms.ComboBox cbxConvertirNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

