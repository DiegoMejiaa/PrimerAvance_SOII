namespace Proyecto
{
    partial class FormSegmentacion
    {
        private System.ComponentModel.IContainer components = null;

        // Controles de la interfaz de usuario
        private System.Windows.Forms.ListBox lstEstadoMemoriaSegmentacion;
        private System.Windows.Forms.Button btnAsignarSegmento;
        private System.Windows.Forms.Button btnSimularSegmentacion;
        private System.Windows.Forms.TextBox txtTamañoSegmento;
        private System.Windows.Forms.Label lblSegmentos;
        private System.Windows.Forms.Label lblTitulo;

        // Método Dispose para liberar recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Inicialización de los componentes
        private void InitializeComponent()
        {
            this.lstEstadoMemoriaSegmentacion = new System.Windows.Forms.ListBox();
            this.btnAsignarSegmento = new System.Windows.Forms.Button();
            this.btnSimularSegmentacion = new System.Windows.Forms.Button();
            this.txtTamañoSegmento = new System.Windows.Forms.TextBox();
            this.lblSegmentos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEstadoMemoriaSegmentacion
            // 
            this.lstEstadoMemoriaSegmentacion.BackColor = System.Drawing.Color.LightYellow;
            this.lstEstadoMemoriaSegmentacion.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEstadoMemoriaSegmentacion.FormattingEnabled = true;
            this.lstEstadoMemoriaSegmentacion.ItemHeight = 16;
            this.lstEstadoMemoriaSegmentacion.Location = new System.Drawing.Point(300, 100);
            this.lstEstadoMemoriaSegmentacion.Name = "lstEstadoMemoriaSegmentacion";
            this.lstEstadoMemoriaSegmentacion.Size = new System.Drawing.Size(300, 100);
            this.lstEstadoMemoriaSegmentacion.TabIndex = 0;
            // 
            // btnAsignarSegmento
            // 
            this.btnAsignarSegmento.BackColor = System.Drawing.Color.LightGreen;
            this.btnAsignarSegmento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarSegmento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAsignarSegmento.Location = new System.Drawing.Point(40, 160);
            this.btnAsignarSegmento.Name = "btnAsignarSegmento";
            this.btnAsignarSegmento.Size = new System.Drawing.Size(150, 40);
            this.btnAsignarSegmento.TabIndex = 1;
            this.btnAsignarSegmento.Text = "Asignar Segmento";
            this.btnAsignarSegmento.UseVisualStyleBackColor = false;
            this.btnAsignarSegmento.Click += new System.EventHandler(this.btnAsignarSegmento_Click);
            // 
            // btnSimularSegmentacion
            // 
            this.btnSimularSegmentacion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSimularSegmentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimularSegmentacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimularSegmentacion.Location = new System.Drawing.Point(40, 110);
            this.btnSimularSegmentacion.Name = "btnSimularSegmentacion";
            this.btnSimularSegmentacion.Size = new System.Drawing.Size(150, 40);
            this.btnSimularSegmentacion.TabIndex = 2;
            this.btnSimularSegmentacion.Text = "Simular Segmentación";
            this.btnSimularSegmentacion.UseVisualStyleBackColor = false;
            this.btnSimularSegmentacion.Click += new System.EventHandler(this.btnSimularSegmentacion_Click);
            // 
            // txtTamañoSegmento
            // 
            this.txtTamañoSegmento.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTamañoSegmento.Location = new System.Drawing.Point(40, 80);
            this.txtTamañoSegmento.Name = "txtTamañoSegmento";
            this.txtTamañoSegmento.Size = new System.Drawing.Size(150, 23);
            this.txtTamañoSegmento.TabIndex = 3;
            // 
            // lblSegmentos
            // 
            this.lblSegmentos.AutoSize = true;
            this.lblSegmentos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lblSegmentos.Location = new System.Drawing.Point(40, 60);
            this.lblSegmentos.Name = "lblSegmentos";
            this.lblSegmentos.Size = new System.Drawing.Size(141, 16);
            this.lblSegmentos.TabIndex = 4;
            this.lblSegmentos.Text = "Tamaño del Segmento:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(120, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 22);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Simulación Segmentación";
            // 
            // FormSegmentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSegmentos);
            this.Controls.Add(this.txtTamañoSegmento);
            this.Controls.Add(this.btnSimularSegmentacion);
            this.Controls.Add(this.btnAsignarSegmento);
            this.Controls.Add(this.lstEstadoMemoriaSegmentacion);
            this.Name = "FormSegmentacion";
            this.Text = "Simulación de Segmentación";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
