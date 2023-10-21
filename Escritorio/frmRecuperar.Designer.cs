namespace Broda.Escritorio
{
    partial class frmRecuperar
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
            txtCuil = new TextBox();
            lblCuil = new Label();
            btnRecuperar = new Button();
            lblNombre = new Label();
            lblEmail = new Label();
            lblId = new Label();
            lblFecha = new Label();
            lblSalario = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(256, 63);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(125, 27);
            txtCuil.TabIndex = 0;
            // 
            // lblCuil
            // 
            lblCuil.AutoSize = true;
            lblCuil.Location = new Point(195, 70);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(34, 20);
            lblCuil.TabIndex = 1;
            lblCuil.Text = "Cuil";
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(418, 66);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(94, 29);
            btnRecuperar.TabIndex = 2;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = true;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(195, 121);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(195, 154);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(194, 186);
            lblId.Name = "lblId";
            lblId.Size = new Size(82, 20);
            lblId.TabIndex = 5;
            lblId.Text = "Id Docente";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(194, 227);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 20);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha Ingreso";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(195, 259);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(55, 20);
            lblSalario.TabIndex = 7;
            lblSalario.Text = "Salario";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(200, 295);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 8;
            // 
            // frmRecuperar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(lblSalario);
            Controls.Add(lblFecha);
            Controls.Add(lblId);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(btnRecuperar);
            Controls.Add(lblCuil);
            Controls.Add(txtCuil);
            Name = "frmRecuperar";
            Text = "frmRecuperar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuil;
        private Label lblCuil;
        private Button btnRecuperar;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblId;
        private Label lblFecha;
        private Label lblSalario;
        private Label lblError;
    }
}