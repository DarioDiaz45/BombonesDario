namespace Bombones2025Semi.Windows
{
    partial class frmChocolateAE
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
            lblChocolate = new Label();
            txtChocolate = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblChocolate
            // 
            lblChocolate.AutoSize = true;
            lblChocolate.Location = new Point(40, 47);
            lblChocolate.Name = "lblChocolate";
            lblChocolate.Size = new Size(90, 15);
            lblChocolate.TabIndex = 0;
            lblChocolate.Text = "Tipo Chocolate:";
            // 
            // txtChocolate
            // 
            txtChocolate.Location = new Point(136, 47);
            txtChocolate.Name = "txtChocolate";
            txtChocolate.Size = new Size(578, 23);
            txtChocolate.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(136, 111);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(87, 62);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(627, 111);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 62);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChocolateAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 200);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtChocolate);
            Controls.Add(lblChocolate);
            Name = "frmChocolateAE";
            Text = "frmChocolateAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChocolate;
        private TextBox txtChocolate;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}