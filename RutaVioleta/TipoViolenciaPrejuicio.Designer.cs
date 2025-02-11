﻿namespace RutaVioleta
{
    partial class TipoViolenciaPrejuicio
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
            this.lblTipoViolenciaPrejuicio = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblTipoViolenciaInstitucional = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.lblRemisionEspecialistas = new System.Windows.Forms.Label();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.bttCancelar4 = new System.Windows.Forms.Button();
            this.bttGuardar2 = new System.Windows.Forms.Button();
            this.bttAtras3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoViolenciaPrejuicio
            // 
            this.lblTipoViolenciaPrejuicio.AutoSize = true;
            this.lblTipoViolenciaPrejuicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoViolenciaPrejuicio.Location = new System.Drawing.Point(26, 28);
            this.lblTipoViolenciaPrejuicio.Name = "lblTipoViolenciaPrejuicio";
            this.lblTipoViolenciaPrejuicio.Size = new System.Drawing.Size(920, 32);
            this.lblTipoViolenciaPrejuicio.TabIndex = 12;
            this.lblTipoViolenciaPrejuicio.Text = "Tipo de Violencia por Prejuicio (Se pueden seleccionar varias opciones)";
            this.lblTipoViolenciaPrejuicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTipoViolenciaPrejuicio.UseMnemonic = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Discriminación por género u orientación sexual o identidad de género",
            "Hostigamiento",
            "Otra",
            "No aplica"});
            this.checkedListBox1.Location = new System.Drawing.Point(32, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(589, 92);
            this.checkedListBox1.TabIndex = 13;
            // 
            // lblTipoViolenciaInstitucional
            // 
            this.lblTipoViolenciaInstitucional.AutoSize = true;
            this.lblTipoViolenciaInstitucional.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoViolenciaInstitucional.Location = new System.Drawing.Point(26, 204);
            this.lblTipoViolenciaInstitucional.Name = "lblTipoViolenciaInstitucional";
            this.lblTipoViolenciaInstitucional.Size = new System.Drawing.Size(920, 32);
            this.lblTipoViolenciaInstitucional.TabIndex = 14;
            this.lblTipoViolenciaInstitucional.Text = "Tipo de Violencia institucional  (Se pueden seleccionar varias opciones)";
            this.lblTipoViolenciaInstitucional.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTipoViolenciaInstitucional.UseMnemonic = false;
            this.lblTipoViolenciaInstitucional.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Omisión del deber de denuncia",
            "Omisión al deber de debida diligencia",
            "Revictimización",
            "Otra",
            "No aplica"});
            this.checkedListBox2.Location = new System.Drawing.Point(32, 251);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(367, 114);
            this.checkedListBox2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Activación de Ruta Interna";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Dupla psico-jurídica",
            "Psicorientación con perspectiva de genero",
            "No acepta/No toma ninguna decisión en esta sesión.",
            "No aplica"});
            this.checkedListBox3.Location = new System.Drawing.Point(32, 432);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(445, 92);
            this.checkedListBox3.TabIndex = 17;
            this.checkedListBox3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            // 
            // lblRemisionEspecialistas
            // 
            this.lblRemisionEspecialistas.AutoSize = true;
            this.lblRemisionEspecialistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemisionEspecialistas.Location = new System.Drawing.Point(26, 549);
            this.lblRemisionEspecialistas.Name = "lblRemisionEspecialistas";
            this.lblRemisionEspecialistas.Size = new System.Drawing.Size(895, 32);
            this.lblRemisionEspecialistas.TabIndex = 18;
            this.lblRemisionEspecialistas.Text = "Remisión a especialistas en el Marco de los  Convenios con Bienestar";
            this.lblRemisionEspecialistas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRemisionEspecialistas.UseMnemonic = false;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "Psicorientación presencial",
            "Psicorientación Línea Bienestar Universitario",
            "Telepsiquiatría",
            "Remisión HAMA",
            "Carta del millón"});
            this.checkedListBox4.Location = new System.Drawing.Point(32, 606);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(395, 114);
            this.checkedListBox4.TabIndex = 19;
            // 
            // bttCancelar4
            // 
            this.bttCancelar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar4.Location = new System.Drawing.Point(379, 803);
            this.bttCancelar4.Name = "bttCancelar4";
            this.bttCancelar4.Size = new System.Drawing.Size(107, 31);
            this.bttCancelar4.TabIndex = 33;
            this.bttCancelar4.Text = "Cancelar";
            this.bttCancelar4.UseMnemonic = false;
            this.bttCancelar4.UseVisualStyleBackColor = true;
            this.bttCancelar4.Click += new System.EventHandler(this.bttCancelar4_Click);
            // 
            // bttGuardar2
            // 
            this.bttGuardar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar2.Location = new System.Drawing.Point(493, 751);
            this.bttGuardar2.Name = "bttGuardar2";
            this.bttGuardar2.Size = new System.Drawing.Size(107, 31);
            this.bttGuardar2.TabIndex = 34;
            this.bttGuardar2.Text = "Guardar";
            this.bttGuardar2.UseMnemonic = false;
            this.bttGuardar2.UseVisualStyleBackColor = true;
            this.bttGuardar2.Click += new System.EventHandler(this.bttGuardar2_Click);
            // 
            // bttAtras3
            // 
            this.bttAtras3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAtras3.Location = new System.Drawing.Point(265, 751);
            this.bttAtras3.Name = "bttAtras3";
            this.bttAtras3.Size = new System.Drawing.Size(107, 31);
            this.bttAtras3.TabIndex = 38;
            this.bttAtras3.Text = "Atras";
            this.bttAtras3.UseMnemonic = false;
            this.bttAtras3.UseVisualStyleBackColor = true;
            this.bttAtras3.Click += new System.EventHandler(this.bttAtras3_Click);
            // 
            // TipoViolenciaPrejuicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(964, 922);
            this.Controls.Add(this.bttAtras3);
            this.Controls.Add(this.bttGuardar2);
            this.Controls.Add(this.bttCancelar4);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.lblRemisionEspecialistas);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.lblTipoViolenciaInstitucional);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblTipoViolenciaPrejuicio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoViolenciaPrejuicio";
            this.Text = "TipoViolenciaPrejuicio";
            this.Load += new System.EventHandler(this.TipoViolenciaPrejuicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoViolenciaPrejuicio;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblTipoViolenciaInstitucional;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Label lblRemisionEspecialistas;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.Button bttCancelar4;
        private System.Windows.Forms.Button bttGuardar2;
        private System.Windows.Forms.Button bttAtras3;
    }
}