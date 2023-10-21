namespace Broda.Escritorio
{
    partial class frmListado
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
            dataGridDocentes = new DataGridView();
            antiguedadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaIngresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docenteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docenteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridDocentes
            // 
            dataGridDocentes.AutoGenerateColumns = false;
            dataGridDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDocentes.Columns.AddRange(new DataGridViewColumn[] { antiguedadDataGridViewTextBoxColumn, apellidoNombreDataGridViewTextBoxColumn, cuilDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, fechaIngresoDataGridViewTextBoxColumn });
            dataGridDocentes.DataSource = docenteBindingSource;
            dataGridDocentes.Location = new Point(51, 91);
            dataGridDocentes.Name = "dataGridDocentes";
            dataGridDocentes.RowHeadersWidth = 51;
            dataGridDocentes.RowTemplate.Height = 29;
            dataGridDocentes.Size = new Size(930, 230);
            dataGridDocentes.TabIndex = 0;
            // 
            // antiguedadDataGridViewTextBoxColumn
            // 
            antiguedadDataGridViewTextBoxColumn.DataPropertyName = "Antiguedad";
            antiguedadDataGridViewTextBoxColumn.HeaderText = "Antiguedad";
            antiguedadDataGridViewTextBoxColumn.MinimumWidth = 6;
            antiguedadDataGridViewTextBoxColumn.Name = "antiguedadDataGridViewTextBoxColumn";
            antiguedadDataGridViewTextBoxColumn.ReadOnly = true;
            antiguedadDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoNombreDataGridViewTextBoxColumn
            // 
            apellidoNombreDataGridViewTextBoxColumn.DataPropertyName = "ApellidoNombre";
            apellidoNombreDataGridViewTextBoxColumn.HeaderText = "ApellidoNombre";
            apellidoNombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            apellidoNombreDataGridViewTextBoxColumn.Name = "apellidoNombreDataGridViewTextBoxColumn";
            apellidoNombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cuilDataGridViewTextBoxColumn
            // 
            cuilDataGridViewTextBoxColumn.DataPropertyName = "Cuil";
            cuilDataGridViewTextBoxColumn.HeaderText = "Cuil";
            cuilDataGridViewTextBoxColumn.MinimumWidth = 6;
            cuilDataGridViewTextBoxColumn.Name = "cuilDataGridViewTextBoxColumn";
            cuilDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            fechaIngresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // docenteBindingSource
            // 
            docenteBindingSource.DataSource = typeof(Entidades.Docente);
            // 
            // frmListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 450);
            Controls.Add(dataGridDocentes);
            Name = "frmListado";
            Text = "frmListado";
            Load += frmListado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)docenteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridDocentes;
        private DataGridViewTextBoxColumn antiguedadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cuilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private BindingSource docenteBindingSource;
    }
}