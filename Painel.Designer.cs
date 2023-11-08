namespace GerenciadorOVNI
{
    partial class Painel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnAddTripulante = new System.Windows.Forms.Button();
            this.btnRemoverTripulante = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnRetornarOrigem = new System.Windows.Forms.Button();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.lblPlaneta);
            this.grbDados.Controls.Add(this.lblTripulantes);
            this.grbDados.Controls.Add(this.lblAbduzidos);
            this.grbDados.Controls.Add(this.lblSituacao);
            this.grbDados.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(11, 11);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(175, 184);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(9, 39);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(72, 22);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(9, 72);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(87, 22);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(9, 104);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(90, 22);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLigar.Location = new System.Drawing.Point(11, 214);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(175, 36);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesligar.Location = new System.Drawing.Point(11, 256);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(175, 36);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnAddTripulante
            // 
            this.btnAddTripulante.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTripulante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTripulante.Location = new System.Drawing.Point(192, 23);
            this.btnAddTripulante.Name = "btnAddTripulante";
            this.btnAddTripulante.Size = new System.Drawing.Size(97, 64);
            this.btnAddTripulante.TabIndex = 3;
            this.btnAddTripulante.Text = "Adicionar Tripulante";
            this.btnAddTripulante.UseVisualStyleBackColor = true;
            // 
            // btnRemoverTripulante
            // 
            this.btnRemoverTripulante.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverTripulante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoverTripulante.Location = new System.Drawing.Point(295, 23);
            this.btnRemoverTripulante.Name = "btnRemoverTripulante";
            this.btnRemoverTripulante.Size = new System.Drawing.Size(97, 64);
            this.btnRemoverTripulante.TabIndex = 4;
            this.btnRemoverTripulante.Text = "Remover Tripulante";
            this.btnRemoverTripulante.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbduzir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbduzir.Location = new System.Drawing.Point(192, 95);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(97, 64);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesabduzir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesabduzir.Location = new System.Drawing.Point(295, 95);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(97, 64);
            this.btnDesabduzir.TabIndex = 6;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            // 
            // btnRetornarOrigem
            // 
            this.btnRetornarOrigem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarOrigem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRetornarOrigem.Location = new System.Drawing.Point(192, 181);
            this.btnRetornarOrigem.Name = "btnRetornarOrigem";
            this.btnRetornarOrigem.Size = new System.Drawing.Size(200, 64);
            this.btnRetornarOrigem.TabIndex = 7;
            this.btnRetornarOrigem.Text = "Retornar a Origem";
            this.btnRetornarOrigem.UseVisualStyleBackColor = true;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(13, 140);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(68, 22);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta: ";
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudarPlaneta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMudarPlaneta.Location = new System.Drawing.Point(319, 251);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(73, 41);
            this.btnMudarPlaneta.TabIndex = 8;
            this.btnMudarPlaneta.Text = "Mudar";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(192, 251);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(121, 41);
            this.cmbPlanetas.TabIndex = 9;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 299);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnMudarPlaneta);
            this.Controls.Add(this.btnRetornarOrigem);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnRemoverTripulante);
            this.Controls.Add(this.btnAddTripulante);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.grbDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnAddTripulante;
        private System.Windows.Forms.Button btnRemoverTripulante;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnRetornarOrigem;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
    }
}