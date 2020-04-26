namespace PulsacionesGUI
{
    partial class RegistrarPersonaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPersonaFrm));
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.EdadTxt = new System.Windows.Forms.TextBox();
            this.PulsacionesTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SexoCmb = new System.Windows.Forms.ComboBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(243, 29);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(100, 20);
            this.IdentificacionTxt.TabIndex = 0;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(243, 69);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreTxt.TabIndex = 1;
            // 
            // EdadTxt
            // 
            this.EdadTxt.Location = new System.Drawing.Point(243, 109);
            this.EdadTxt.Name = "EdadTxt";
            this.EdadTxt.Size = new System.Drawing.Size(100, 20);
            this.EdadTxt.TabIndex = 2;
            // 
            // PulsacionesTxt
            // 
            this.PulsacionesTxt.AllowDrop = true;
            this.PulsacionesTxt.Enabled = false;
            this.PulsacionesTxt.Location = new System.Drawing.Point(243, 189);
            this.PulsacionesTxt.Name = "PulsacionesTxt";
            this.PulsacionesTxt.Size = new System.Drawing.Size(100, 20);
            this.PulsacionesTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identificacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pulsaciones";
            // 
            // SexoCmb
            // 
            this.SexoCmb.FormattingEnabled = true;
            this.SexoCmb.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SexoCmb.Location = new System.Drawing.Point(243, 147);
            this.SexoCmb.Name = "SexoCmb";
            this.SexoCmb.Size = new System.Drawing.Size(121, 21);
            this.SexoCmb.TabIndex = 10;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GuardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBtn.Image")));
            this.GuardarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarBtn.Location = new System.Drawing.Point(49, 270);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 55);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBtn.UseVisualStyleBackColor = false;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarBtn.Image")));
            this.BuscarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarBtn.Location = new System.Drawing.Point(130, 271);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 54);
            this.BuscarBtn.TabIndex = 12;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarBtn.UseVisualStyleBackColor = false;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBtn.Image")));
            this.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarBtn.Location = new System.Drawing.Point(211, 271);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 53);
            this.EliminarBtn.TabIndex = 13;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // EditarBtn
            // 
            this.EditarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditarBtn.Image")));
            this.EditarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditarBtn.Location = new System.Drawing.Point(292, 271);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(75, 53);
            this.EditarBtn.TabIndex = 14;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarBtn.UseVisualStyleBackColor = false;
            this.EditarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LimpiarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBtn.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarBtn.Image")));
            this.LimpiarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LimpiarBtn.Location = new System.Drawing.Point(373, 270);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(75, 53);
            this.LimpiarBtn.TabIndex = 15;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LimpiarBtn.UseVisualStyleBackColor = false;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // RegistrarPersonaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(496, 355);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.SexoCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PulsacionesTxt);
            this.Controls.Add(this.EdadTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.IdentificacionTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarPersonaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registror";
            this.Load += new System.EventHandler(this.RegistrarPersonaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox EdadTxt;
        private System.Windows.Forms.TextBox PulsacionesTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SexoCmb;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button LimpiarBtn;
    }
}