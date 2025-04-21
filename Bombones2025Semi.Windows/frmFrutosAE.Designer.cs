namespace Bombones2025Semi.Windows
{
    partial class frmFrutosAE
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
            components = new System.ComponentModel.Container();
            lblFrutos = new Label();
            txtFruto = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblFrutos
            // 
            lblFrutos.AutoSize = true;
            lblFrutos.Location = new Point(50, 32);
            lblFrutos.Name = "lblFrutos";
            lblFrutos.Size = new Size(43, 15);
            lblFrutos.TabIndex = 0;
            lblFrutos.Text = "Frutos:";
            // 
            // txtFruto
            // 
            txtFruto.Location = new Point(99, 29);
            txtFruto.Name = "txtFruto";
            txtFruto.Size = new Size(518, 23);
            txtFruto.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(99, 129);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 72);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(430, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 72);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmFrutosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 213);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtFruto);
            Controls.Add(lblFrutos);
            Name = "frmFrutosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrutos;
        private TextBox txtFruto;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}