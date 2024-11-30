namespace Proyecto
{
    partial class FormPaginacion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstEstadoMemoriaPaginacion;
        private System.Windows.Forms.Button btnPaginaAnterior;
        private System.Windows.Forms.Button btnPaginaSiguiente;
        private System.Windows.Forms.Label lblPaginaActual;

        private void InitializeComponent()
        {
            this.lstEstadoMemoriaPaginacion = new System.Windows.Forms.ListBox();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPaginaSiguiente = new System.Windows.Forms.Button();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEstadoMemoriaPaginacion
            // 
            this.lstEstadoMemoriaPaginacion.BackColor = System.Drawing.Color.LightCyan;
            this.lstEstadoMemoriaPaginacion.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEstadoMemoriaPaginacion.FormattingEnabled = true;
            this.lstEstadoMemoriaPaginacion.ItemHeight = 16;
            this.lstEstadoMemoriaPaginacion.Location = new System.Drawing.Point(80, 40);
            this.lstEstadoMemoriaPaginacion.Name = "lstEstadoMemoriaPaginacion";
            this.lstEstadoMemoriaPaginacion.Size = new System.Drawing.Size(320, 164);
            this.lstEstadoMemoriaPaginacion.TabIndex = 0;
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.BackColor = System.Drawing.Color.LightCoral;
            this.btnPaginaAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaAnterior.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPaginaAnterior.Location = new System.Drawing.Point(80, 220);
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(100, 30);
            this.btnPaginaAnterior.TabIndex = 1;
            this.btnPaginaAnterior.Text = "Anterior";
            this.btnPaginaAnterior.UseVisualStyleBackColor = false;
            this.btnPaginaAnterior.Click += new System.EventHandler(this.btnPaginaAnterior_Click);
            // 
            // btnPaginaSiguiente
            // 
            this.btnPaginaSiguiente.BackColor = System.Drawing.Color.LightGreen;
            this.btnPaginaSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaSiguiente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPaginaSiguiente.Location = new System.Drawing.Point(300, 220);
            this.btnPaginaSiguiente.Name = "btnPaginaSiguiente";
            this.btnPaginaSiguiente.Size = new System.Drawing.Size(100, 30);
            this.btnPaginaSiguiente.TabIndex = 2;
            this.btnPaginaSiguiente.Text = "Siguiente";
            this.btnPaginaSiguiente.UseVisualStyleBackColor = false;
            this.btnPaginaSiguiente.Click += new System.EventHandler(this.btnPaginaSiguiente_Click);
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaginaActual.Location = new System.Drawing.Point(200, 260);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(89, 16);
            this.lblPaginaActual.TabIndex = 3;
            this.lblPaginaActual.Text = "Página 1 de 4";
            this.lblPaginaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPaginacion
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.btnPaginaSiguiente);
            this.Controls.Add(this.btnPaginaAnterior);
            this.Controls.Add(this.lstEstadoMemoriaPaginacion);
            this.Name = "FormPaginacion";
            this.Text = "Simulador de Paginación";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
