namespace Bombones2025Semi.Windows
{
    partial class frmPaisesAE
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
            lblPais = new Label();
            txtPais = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(38, 26);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(31, 15);
            lblPais.TabIndex = 0;
            lblPais.Text = "Pais:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(75, 23);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(477, 23);
            txtPais.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(75, 95);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 60);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(477, 95);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 60);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPaisesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 178);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtPais);
            Controls.Add(lblPais);
            Name = "frmPaisesAE";
            Text = "frmPaisesAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPais;
        private TextBox txtPais;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}