namespace Proyecto
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnParticionFijo = new System.Windows.Forms.Button();
            this.btnParticionDinamico = new System.Windows.Forms.Button();
            this.btnPaginacion = new System.Windows.Forms.Button();
            this.btnSegmentacion = new System.Windows.Forms.Button();
            this.btnMemoriaVirtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParticionFijo
            // 
            this.btnParticionFijo.BackColor = System.Drawing.Color.LightBlue;
            this.btnParticionFijo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnParticionFijo.Location = new System.Drawing.Point(50, 60);
            this.btnParticionFijo.Name = "btnParticionFijo";
            this.btnParticionFijo.Size = new System.Drawing.Size(200, 50);
            this.btnParticionFijo.TabIndex = 0;
            this.btnParticionFijo.Text = "Particionamiento Fijo";
            this.btnParticionFijo.UseVisualStyleBackColor = false;
            this.btnParticionFijo.Click += new System.EventHandler(this.btnParticionFijo_Click);
            // 
            // btnParticionDinamico
            // 
            this.btnParticionDinamico.BackColor = System.Drawing.Color.LightCoral;
            this.btnParticionDinamico.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnParticionDinamico.Location = new System.Drawing.Point(300, 60);
            this.btnParticionDinamico.Name = "btnParticionDinamico";
            this.btnParticionDinamico.Size = new System.Drawing.Size(200, 50);
            this.btnParticionDinamico.TabIndex = 1;
            this.btnParticionDinamico.Text = "Particionamiento Dinámico";
            this.btnParticionDinamico.UseVisualStyleBackColor = false;
            this.btnParticionDinamico.Click += new System.EventHandler(this.btnParticionDinamico_Click);
            // 
            // btnPaginacion
            // 
            this.btnPaginacion.BackColor = System.Drawing.Color.LightGreen;
            this.btnPaginacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPaginacion.Location = new System.Drawing.Point(550, 60);
            this.btnPaginacion.Name = "btnPaginacion";
            this.btnPaginacion.Size = new System.Drawing.Size(200, 50);
            this.btnPaginacion.TabIndex = 2;
            this.btnPaginacion.Text = "Paginación";
            this.btnPaginacion.UseVisualStyleBackColor = false;
            this.btnPaginacion.Click += new System.EventHandler(this.btnPaginacion_Click);
            // 
            // btnSegmentacion
            // 
            this.btnSegmentacion.BackColor = System.Drawing.Color.LightYellow;
            this.btnSegmentacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSegmentacion.Location = new System.Drawing.Point(200, 150);
            this.btnSegmentacion.Name = "btnSegmentacion";
            this.btnSegmentacion.Size = new System.Drawing.Size(200, 50);
            this.btnSegmentacion.TabIndex = 3;
            this.btnSegmentacion.Text = "Segmentación";
            this.btnSegmentacion.UseVisualStyleBackColor = false;
            this.btnSegmentacion.Click += new System.EventHandler(this.btnSegmentacion_Click);
            // 
            // btnMemoriaVirtual
            // 
            this.btnMemoriaVirtual.BackColor = System.Drawing.Color.LightPink;
            this.btnMemoriaVirtual.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnMemoriaVirtual.Location = new System.Drawing.Point(450, 150);
            this.btnMemoriaVirtual.Name = "btnMemoriaVirtual";
            this.btnMemoriaVirtual.Size = new System.Drawing.Size(200, 50);
            this.btnMemoriaVirtual.TabIndex = 4;
            this.btnMemoriaVirtual.Text = "Memoria Virtual";
            this.btnMemoriaVirtual.UseVisualStyleBackColor = false;
            this.btnMemoriaVirtual.Click += new System.EventHandler(this.btnMemoriaVirtual_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.btnMemoriaVirtual);
            this.Controls.Add(this.btnSegmentacion);
            this.Controls.Add(this.btnPaginacion);
            this.Controls.Add(this.btnParticionDinamico);
            this.Controls.Add(this.btnParticionFijo);
            this.Name = "Form1";
            this.Text = "Gestión de Memoria - Opciones";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnParticionFijo;
        private System.Windows.Forms.Button btnParticionDinamico;
        private System.Windows.Forms.Button btnPaginacion;
        private System.Windows.Forms.Button btnSegmentacion;
        private System.Windows.Forms.Button btnMemoriaVirtual;
    }
}
