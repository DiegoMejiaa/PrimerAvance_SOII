namespace Proyecto
{
    partial class FormParticionFija
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSimularParticionFija;
        private System.Windows.Forms.Label lblEstadoMemoria;
        private System.Windows.Forms.Button btnAsignarProceso;
        private System.Windows.Forms.TextBox txtTamañoProceso;
        private System.Windows.Forms.ListBox lstEstadoMemoria;
        private System.Windows.Forms.Label lblTitulo;

        /// <summary>
        /// Liberar recursos utilizados.
        /// </summary>
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
            this.btnSimularParticionFija = new System.Windows.Forms.Button();
            this.lblEstadoMemoria = new System.Windows.Forms.Label();
            this.btnAsignarProceso = new System.Windows.Forms.Button();
            this.txtTamañoProceso = new System.Windows.Forms.TextBox();
            this.lstEstadoMemoria = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSimularParticionFija
            // 
            this.btnSimularParticionFija.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSimularParticionFija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimularParticionFija.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimularParticionFija.Location = new System.Drawing.Point(50, 80);
            this.btnSimularParticionFija.Name = "btnSimularParticionFija";
            this.btnSimularParticionFija.Size = new System.Drawing.Size(150, 40);
            this.btnSimularParticionFija.TabIndex = 0;
            this.btnSimularParticionFija.Text = "Simular";
            this.btnSimularParticionFija.UseVisualStyleBackColor = false;
            this.btnSimularParticionFija.Click += new System.EventHandler(this.btnSimularParticionFija_Click_1);
            // 
            // lblEstadoMemoria
            // 
            this.lblEstadoMemoria.AutoSize = true;
            this.lblEstadoMemoria.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lblEstadoMemoria.Location = new System.Drawing.Point(240, 125);
            this.lblEstadoMemoria.Name = "lblEstadoMemoria";
            this.lblEstadoMemoria.Size = new System.Drawing.Size(140, 16);
            this.lblEstadoMemoria.TabIndex = 3;
            this.lblEstadoMemoria.Text = "Tamaño del Proceso:";
            // 
            // btnAsignarProceso
            // 
            this.btnAsignarProceso.BackColor = System.Drawing.Color.LightGreen;
            this.btnAsignarProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarProceso.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAsignarProceso.Location = new System.Drawing.Point(50, 140);
            this.btnAsignarProceso.Name = "btnAsignarProceso";
            this.btnAsignarProceso.Size = new System.Drawing.Size(150, 40);
            this.btnAsignarProceso.TabIndex = 4;
            this.btnAsignarProceso.Text = "Asignar Proceso";
            this.btnAsignarProceso.UseVisualStyleBackColor = false;
            this.btnAsignarProceso.Click += new System.EventHandler(this.btnAsignarProceso_Click_1);
            // 
            // txtTamañoProceso
            // 
            this.txtTamañoProceso.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTamañoProceso.Location = new System.Drawing.Point(240, 145);
            this.txtTamañoProceso.Name = "txtTamañoProceso";
            this.txtTamañoProceso.Size = new System.Drawing.Size(120, 23);
            this.txtTamañoProceso.TabIndex = 5;
            // 
            // lstEstadoMemoria
            // 
            this.lstEstadoMemoria.BackColor = System.Drawing.Color.LightYellow;
            this.lstEstadoMemoria.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEstadoMemoria.FormattingEnabled = true;
            this.lstEstadoMemoria.ItemHeight = 16;
            this.lstEstadoMemoria.Location = new System.Drawing.Point(400, 80);
            this.lstEstadoMemoria.Name = "lstEstadoMemoria";
            this.lstEstadoMemoria.Size = new System.Drawing.Size(500, 100);
            this.lstEstadoMemoria.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(180, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 22);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Particionamiento Fijo";
            // 
            // FormParticionFija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstEstadoMemoria);
            this.Controls.Add(this.txtTamañoProceso);
            this.Controls.Add(this.btnAsignarProceso);
            this.Controls.Add(this.lblEstadoMemoria);
            this.Controls.Add(this.btnSimularParticionFija);
            this.Name = "FormParticionFija";
            this.Text = "Particionamiento Fijo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
