namespace GerenciadorOVNI
{
    partial class Inicializador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicializador));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.nudAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.nudTripulantes = new System.Windows.Forms.NumericUpDown();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(76, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "OVNI MENAGER";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(9, 55);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(121, 22);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Max Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(9, 77);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(125, 22);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Max Tripulantes:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneta.Location = new System.Drawing.Point(9, 102);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(141, 22);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta de Origem:";
            // 
            // nudAbduzidos
            // 
            this.nudAbduzidos.Location = new System.Drawing.Point(146, 53);
            this.nudAbduzidos.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudAbduzidos.Name = "nudAbduzidos";
            this.nudAbduzidos.Size = new System.Drawing.Size(120, 20);
            this.nudAbduzidos.TabIndex = 4;
            // 
            // nudTripulantes
            // 
            this.nudTripulantes.Location = new System.Drawing.Point(146, 79);
            this.nudTripulantes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTripulantes.Name = "nudTripulantes";
            this.nudTripulantes.Size = new System.Drawing.Size(120, 20);
            this.nudTripulantes.TabIndex = 5;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(146, 105);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(120, 21);
            this.cmbPlaneta.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Location = new System.Drawing.Point(34, 132);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(203, 34);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(395, 181);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.nudTripulantes);
            this.Controls.Add(this.nudAbduzidos);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.NumericUpDown nudAbduzidos;
        private System.Windows.Forms.NumericUpDown nudTripulantes;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnIniciar;
    }
}