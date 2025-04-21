namespace Bombones2025Semi.Windows
{
    partial class frmRellenoAE
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
            lblRelleno = new Label();
            txtRelleno = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblRelleno
            // 
            lblRelleno.AutoSize = true;
            lblRelleno.Location = new Point(61, 35);
            lblRelleno.Name = "lblRelleno";
            lblRelleno.Size = new Size(49, 15);
            lblRelleno.TabIndex = 0;
            lblRelleno.Text = "Relleno:";
            // 
            // txtRelleno
            // 
            txtRelleno.Location = new Point(116, 32);
            txtRelleno.Name = "txtRelleno";
            txtRelleno.Size = new Size(579, 23);
            txtRelleno.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(116, 81);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 66);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(613, 81);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 66);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRellenoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 159);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtRelleno);
            Controls.Add(lblRelleno);
            Name = "frmRellenoAE";
            Text = "frmRellenoAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRelleno;
        private TextBox txtRelleno;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}