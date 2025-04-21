namespace Bombones2025Semi.Windows
{
    partial class frmPrincipal
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
            btnPaises = new Button();
            btnFrutos = new Button();
            btnRelleno = new Button();
            btnChocolate = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnPaises
            // 
            btnPaises.Location = new Point(70, 26);
            btnPaises.Name = "btnPaises";
            btnPaises.Size = new Size(80, 72);
            btnPaises.TabIndex = 0;
            btnPaises.Text = "Paises";
            btnPaises.UseVisualStyleBackColor = true;
            btnPaises.Click += btnPaises_Click;
            // 
            // btnFrutos
            // 
            btnFrutos.Location = new Point(203, 26);
            btnFrutos.Name = "btnFrutos";
            btnFrutos.Size = new Size(75, 72);
            btnFrutos.TabIndex = 1;
            btnFrutos.Text = "Frutos";
            btnFrutos.UseVisualStyleBackColor = true;
            btnFrutos.Click += btnFrutos_Click;
            // 
            // btnRelleno
            // 
            btnRelleno.Location = new Point(333, 26);
            btnRelleno.Name = "btnRelleno";
            btnRelleno.Size = new Size(75, 72);
            btnRelleno.TabIndex = 2;
            btnRelleno.Text = "Relleno";
            btnRelleno.UseVisualStyleBackColor = true;
            btnRelleno.Click += btnRelleno_Click;
            // 
            // btnChocolate
            // 
            btnChocolate.Location = new Point(459, 26);
            btnChocolate.Name = "btnChocolate";
            btnChocolate.Size = new Size(75, 72);
            btnChocolate.TabIndex = 2;
            btnChocolate.Text = "Chocolate";
            btnChocolate.UseVisualStyleBackColor = true;
            btnChocolate.Click += btnChocolate_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(459, 357);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 45);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnChocolate);
            Controls.Add(btnRelleno);
            Controls.Add(btnFrutos);
            Controls.Add(btnPaises);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPaises;
        private Button btnFrutos;
        private Button btnRelleno;
        private Button btnChocolate;
        private Button btnSalir;
    }
}