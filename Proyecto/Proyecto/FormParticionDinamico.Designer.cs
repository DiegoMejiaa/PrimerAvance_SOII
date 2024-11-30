namespace Proyecto
{
    partial class FormParticionDinamica
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstEstadoMemoriaDinamica;
        private System.Windows.Forms.Button btnSimularDinamico;
        private System.Windows.Forms.Button btnAsignarProcesoDinamico;
        private System.Windows.Forms.TextBox txtTamañoProcesoDinamico;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTamañoProceso;
        private System.Windows.Forms.TextBox txtBloqueLiberar;
        // Método para limpiar recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstEstadoMemoriaDinamica = new System.Windows.Forms.ListBox();
            this.btnSimularDinamico = new System.Windows.Forms.Button();
            this.btnAsignarProcesoDinamico = new System.Windows.Forms.Button();
            this.txtTamañoProcesoDinamico = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTamañoProceso = new System.Windows.Forms.Label();
            this.txtBloqueLiberar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstEstadoMemoriaDinamica
            // 
            this.lstEstadoMemoriaDinamica.BackColor = System.Drawing.Color.LightYellow;
            this.lstEstadoMemoriaDinamica.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEstadoMemoriaDinamica.FormattingEnabled = true;
            this.lstEstadoMemoriaDinamica.FormattingEnabled = true;
            this.lstEstadoMemoriaDinamica.ItemHeight = 16;
            this.lstEstadoMemoriaDinamica.Location = new System.Drawing.Point(380, 80);
            this.lstEstadoMemoriaDinamica.Name = "lstEstadoMemoriaDinamica";
            this.lstEstadoMemoriaDinamica.Size = new System.Drawing.Size(500, 132);
            this.lstEstadoMemoriaDinamica.TabIndex = 0;
            // 
            // btnSimularDinamico
            // 
            this.btnSimularDinamico.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSimularDinamico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimularDinamico.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimularDinamico.Location = new System.Drawing.Point(50, 80);
            this.btnSimularDinamico.Name = "btnSimularDinamico";
            this.btnSimularDinamico.Size = new System.Drawing.Size(150, 30);
            this.btnSimularDinamico.TabIndex = 1;
            this.btnSimularDinamico.Text = "Simular";
            this.btnSimularDinamico.UseVisualStyleBackColor = false;
            this.btnSimularDinamico.Click += new System.EventHandler(this.btnSimularDinamico_Click);
            // 
            // btnAsignarProcesoDinamico
            // 
            this.btnAsignarProcesoDinamico.BackColor = System.Drawing.Color.LightGreen;
            this.btnAsignarProcesoDinamico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarProcesoDinamico.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAsignarProcesoDinamico.Location = new System.Drawing.Point(50, 180);
            this.btnAsignarProcesoDinamico.Name = "btnAsignarProcesoDinamico";
            this.btnAsignarProcesoDinamico.Size = new System.Drawing.Size(150, 30);
            this.btnAsignarProcesoDinamico.TabIndex = 2;
            this.btnAsignarProcesoDinamico.Text = "Asignar Proceso";
            this.btnAsignarProcesoDinamico.UseVisualStyleBackColor = false;
            this.btnAsignarProcesoDinamico.Click += new System.EventHandler(this.btnAsignarProcesoDinamico_Click);
            // 
            // txtTamañoProcesoDinamico
            // 
            this.txtTamañoProcesoDinamico.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTamañoProcesoDinamico.Location = new System.Drawing.Point(240, 135);
            this.txtTamañoProcesoDinamico.Name = "txtTamañoProcesoDinamico";
            this.txtTamañoProcesoDinamico.Size = new System.Drawing.Size(100, 23);
            this.txtTamañoProcesoDinamico.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(200, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 22);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Particionamiento Dinámico";
            // 
            // lblTamañoProceso
            // 
            this.lblTamañoProceso.AutoSize = true;
            this.lblTamañoProceso.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTamañoProceso.Location = new System.Drawing.Point(240, 115);
            this.lblTamañoProceso.Name = "lblTamañoProceso";
            this.lblTamañoProceso.Size = new System.Drawing.Size(121, 16);
            this.lblTamañoProceso.TabIndex = 5;
            this.lblTamañoProceso.Text = "Tamaño Proceso:";
            // 
            // FormParticionDinamica
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 280);
            this.Controls.Add(this.lblTamañoProceso);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTamañoProcesoDinamico);
            this.Controls.Add(this.btnAsignarProcesoDinamico);
            this.Controls.Add(this.btnSimularDinamico);
            this.Controls.Add(this.lstEstadoMemoriaDinamica);
            this.Name = "FormParticionDinamica";
            this.Text = "Particionamiento Dinámico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
