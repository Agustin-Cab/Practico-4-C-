namespace Practico_4__C__
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
            LTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            TDesde = new TextBox();
            THasta = new TextBox();
            BGenerar = new Button();
            BPares = new Button();
            BImpares = new Button();
            BPrimos = new Button();
            LB_ListaNros = new ListBox();
            SuspendLayout();
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.ForeColor = Color.Red;
            LTitulo.Location = new Point(526, 52);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(132, 20);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "Lista de Numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 141);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 212);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasta";
            // 
            // TDesde
            // 
            TDesde.Location = new Point(127, 141);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(104, 27);
            TDesde.TabIndex = 4;
            TDesde.TextChanged += TDesde_TextChanged;
            // 
            // THasta
            // 
            THasta.Location = new Point(127, 212);
            THasta.Name = "THasta";
            THasta.Size = new Size(104, 27);
            THasta.TabIndex = 5;
            // 
            // BGenerar
            // 
            BGenerar.Location = new Point(271, 99);
            BGenerar.Name = "BGenerar";
            BGenerar.Size = new Size(154, 29);
            BGenerar.TabIndex = 6;
            BGenerar.Text = "Generar Numeros";
            BGenerar.UseVisualStyleBackColor = true;
            BGenerar.Click += BGenerar_Click;
            // 
            // BPares
            // 
            BPares.Location = new Point(288, 178);
            BPares.Name = "BPares";
            BPares.Size = new Size(120, 28);
            BPares.TabIndex = 7;
            BPares.Text = "Nros Pares";
            BPares.UseVisualStyleBackColor = true;
            BPares.Click += BPares_Click;
            // 
            // BImpares
            // 
            BImpares.Location = new Point(288, 212);
            BImpares.Name = "BImpares";
            BImpares.Size = new Size(120, 28);
            BImpares.TabIndex = 8;
            BImpares.Text = "Nros Impares";
            BImpares.UseVisualStyleBackColor = true;
            BImpares.Click += BImpares_Click;
            // 
            // BPrimos
            // 
            BPrimos.Location = new Point(288, 246);
            BPrimos.Name = "BPrimos";
            BPrimos.Size = new Size(120, 28);
            BPrimos.TabIndex = 9;
            BPrimos.Text = "Nros Primos";
            BPrimos.UseVisualStyleBackColor = false;
            BPrimos.Click += BPrimos_Click;
            // 
            // LB_ListaNros
            // 
            LB_ListaNros.FormattingEnabled = true;
            LB_ListaNros.Location = new Point(466, 101);
            LB_ListaNros.Name = "LB_ListaNros";
            LB_ListaNros.Size = new Size(261, 284);
            LB_ListaNros.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 495);
            Controls.Add(LB_ListaNros);
            Controls.Add(BPrimos);
            Controls.Add(BImpares);
            Controls.Add(BPares);
            Controls.Add(BGenerar);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LTitulo;
        private Label label2;
        private Label label3;
        private TextBox TListaNumeros;
        private TextBox TDesde;
        private TextBox THasta;
        private Button BGenerar;
        private Button BPares;
        private Button BImpares;
        private Button BPrimos;
        private ListBox LB_ListaNros;
    }
}
