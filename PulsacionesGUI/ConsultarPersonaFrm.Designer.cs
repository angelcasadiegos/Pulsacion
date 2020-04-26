namespace PulsacionesGUI
{
    partial class ConsultarPersonaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPersonaFrm));
            this.PersonasDgw = new System.Windows.Forms.DataGridView();
            this.SexosCmb = new System.Windows.Forms.ComboBox();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.TotalHombresTxt = new System.Windows.Forms.TextBox();
            this.TotalMujeresTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonasDgw
            // 
            this.PersonasDgw.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PersonasDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasDgw.Location = new System.Drawing.Point(142, 33);
            this.PersonasDgw.Name = "PersonasDgw";
            this.PersonasDgw.Size = new System.Drawing.Size(525, 235);
            this.PersonasDgw.TabIndex = 0;
            // 
            // SexosCmb
            // 
            this.SexosCmb.FormattingEnabled = true;
            this.SexosCmb.Items.AddRange(new object[] {
            "Todos",
            "M",
            "F"});
            this.SexosCmb.Location = new System.Drawing.Point(12, 128);
            this.SexosCmb.Name = "SexosCmb";
            this.SexosCmb.Size = new System.Drawing.Size(101, 21);
            this.SexosCmb.TabIndex = 1;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConsultarBtn.CausesValidation = false;
            this.ConsultarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsultarBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarBtn.Image")));
            this.ConsultarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConsultarBtn.Location = new System.Drawing.Point(24, 155);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 52);
            this.ConsultarBtn.TabIndex = 2;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultarBtn.UseVisualStyleBackColor = false;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(178, 311);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(95, 20);
            this.TotalTxt.TabIndex = 3;
            // 
            // TotalHombresTxt
            // 
            this.TotalHombresTxt.Location = new System.Drawing.Point(348, 311);
            this.TotalHombresTxt.Name = "TotalHombresTxt";
            this.TotalHombresTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalHombresTxt.TabIndex = 4;
            // 
            // TotalMujeresTxt
            // 
            this.TotalMujeresTxt.Location = new System.Drawing.Point(507, 311);
            this.TotalMujeresTxt.Name = "TotalMujeresTxt";
            this.TotalMujeresTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalMujeresTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total De Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mujeres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tabla de Datos";
            // 
            // ConsultarPersonaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalMujeresTxt);
            this.Controls.Add(this.TotalHombresTxt);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.SexosCmb);
            this.Controls.Add(this.PersonasDgw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarPersonaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarPersonaFrm";
            this.Load += new System.EventHandler(this.ConsultarPersonaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonasDgw;
        private System.Windows.Forms.ComboBox SexosCmb;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.TextBox TotalHombresTxt;
        private System.Windows.Forms.TextBox TotalMujeresTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}