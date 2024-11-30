namespace Proyecto
{
    partial class FormMemoriaVirtual
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstMemoriaFisica;
        private System.Windows.Forms.ListBox lstMemoriaVirtual;
        private System.Windows.Forms.Button btnSimularFalloPagina;
        private System.Windows.Forms.Label lblMemoriaFisica;
        private System.Windows.Forms.Label lblMemoriaVirtual;
        private System.Windows.Forms.TextBox txtPagina;

        private void InitializeComponent()
        {
            this.lstMemoriaFisica = new System.Windows.Forms.ListBox();
            this.lstMemoriaVirtual = new System.Windows.Forms.ListBox();
            this.btnSimularFalloPagina = new System.Windows.Forms.Button();
            this.lblMemoriaFisica = new System.Windows.Forms.Label();
            this.lblMemoriaVirtual = new System.Windows.Forms.Label();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMemoriaFisica
            // 
            this.lstMemoriaFisica.BackColor = System.Drawing.Color.LightCyan;
            this.lstMemoriaFisica.Font = new System.Drawing.Font("Arial", 10F);
            this.lstMemoriaFisica.FormattingEnabled = true;
            this.lstMemoriaFisica.ItemHeight = 15;
            this.lstMemoriaFisica.Location = new System.Drawing.Point(30, 60);
            this.lstMemoriaFisica.Name = "lstMemoriaFisica";
            this.lstMemoriaFisica.Size = new System.Drawing.Size(200, 94);
            this.lstMemoriaFisica.TabIndex = 0;
            // 
            // lstMemoriaVirtual
            // 
            this.lstMemoriaVirtual.BackColor = System.Drawing.Color.Lavender;
            this.lstMemoriaVirtual.Font = new System.Drawing.Font("Arial", 10F);
            this.lstMemoriaVirtual.FormattingEnabled = true;
            this.lstMemoriaVirtual.ItemHeight = 15;
            this.lstMemoriaVirtual.Location = new System.Drawing.Point(250, 60);
            this.lstMemoriaVirtual.Name = "lstMemoriaVirtual";
            this.lstMemoriaVirtual.Size = new System.Drawing.Size(200, 94);
            this.lstMemoriaVirtual.TabIndex = 1;
            // 
            // btnSimularFalloPagina
            // 
            this.btnSimularFalloPagina.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSimularFalloPagina.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimularFalloPagina.Location = new System.Drawing.Point(150, 190);
            this.btnSimularFalloPagina.Name = "btnSimularFalloPagina";
            this.btnSimularFalloPagina.Size = new System.Drawing.Size(180, 30);
            this.btnSimularFalloPagina.TabIndex = 2;
            this.btnSimularFalloPagina.Text = "Simular Fallo de Página";
            this.btnSimularFalloPagina.UseVisualStyleBackColor = false;
            this.btnSimularFalloPagina.Click += new System.EventHandler(this.btnSimularFalloPagina_Click);
            // 
            // lblMemoriaFisica
            // 
            this.lblMemoriaFisica.AutoSize = true;
            this.lblMemoriaFisica.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMemoriaFisica.Location = new System.Drawing.Point(30, 30);
            this.lblMemoriaFisica.Name = "lblMemoriaFisica";
            this.lblMemoriaFisica.Size = new System.Drawing.Size(116, 16);
            this.lblMemoriaFisica.TabIndex = 3;
            this.lblMemoriaFisica.Text = "Memoria Física:";
            // 
            // lblMemoriaVirtual
            // 
            this.lblMemoriaVirtual.AutoSize = true;
            this.lblMemoriaVirtual.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMemoriaVirtual.Location = new System.Drawing.Point(250, 30);
            this.lblMemoriaVirtual.Name = "lblMemoriaVirtual";
            this.lblMemoriaVirtual.Size = new System.Drawing.Size(117, 16);
            this.lblMemoriaVirtual.TabIndex = 4;
            this.lblMemoriaVirtual.Text = "Memoria Virtual:";
            // 
            // txtPagina
            // 
            this.txtPagina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPagina.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPagina.ForeColor = System.Drawing.Color.Gray;
            this.txtPagina.Location = new System.Drawing.Point(175, 160);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(130, 23);
            this.txtPagina.TabIndex = 5;
            this.txtPagina.Text = "Ingrese página...";
            this.txtPagina.Enter += (sender, e) =>
            {
                if (txtPagina.Text == "Ingrese página...")
                {
                    txtPagina.Text = "";
                    txtPagina.ForeColor = System.Drawing.Color.Black;
                }
            };
            this.txtPagina.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPagina.Text))
                {
                    txtPagina.Text = "Ingrese página...";
                    txtPagina.ForeColor = System.Drawing.Color.Gray;
                }
            };
            // 
            // FormMemoriaVirtual
            // 
            this.ClientSize = new System.Drawing.Size(480, 250);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.lblMemoriaVirtual);
            this.Controls.Add(this.lblMemoriaFisica);
            this.Controls.Add(this.btnSimularFalloPagina);
            this.Controls.Add(this.lstMemoriaVirtual);
            this.Controls.Add(this.lstMemoriaFisica);
            this.Name = "FormMemoriaVirtual";
            this.Text = "Simulación de Memoria Virtual";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
