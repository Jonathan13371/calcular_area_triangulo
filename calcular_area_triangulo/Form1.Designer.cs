
namespace ex01
{
    partial class frmTelaPrincipal
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
            this.lblBase = new System.Windows.Forms.Label();
            this.textBase = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(190, 87);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(48, 16);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base:";
            // 
            // textBase
            // 
            this.textBase.Location = new System.Drawing.Point(245, 87);
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(100, 22);
            this.textBase.TabIndex = 1;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(193, 131);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(52, 16);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(251, 131);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(100, 22);
            this.textAltura.TabIndex = 3;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(245, 186);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(106, 67);
            this.bntCalcular.TabIndex = 4;
            this.bntCalcular.Text = "Calcular Retangulo";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resposta:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(245, 288);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 16);
            this.lblSaida.TabIndex = 6;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 474);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.textBase);
            this.Controls.Add(this.lblBase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTelaPrincipal";
            this.Text = "Area Retanculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaida;
    }
}

