

namespace WindowsFormsApp2
{
    partial class Form1
    {


        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uno = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.por = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.operaciones = new System.Windows.Forms.Label();
            this.masmenos = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.borrarNumeroCompleto = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uno
            // 
            this.uno.AccessibleName = "uno";
            this.uno.BackColor = System.Drawing.SystemColors.HighlightText;
            this.uno.FlatAppearance.BorderSize = 0;
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.Location = new System.Drawing.Point(8, 355);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(70, 70);
            this.uno.TabIndex = 0;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // sumar
            // 
            this.sumar.AccessibleName = "sumar";
            this.sumar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sumar.FlatAppearance.BorderSize = 0;
            this.sumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sumar.Location = new System.Drawing.Point(245, 356);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(70, 70);
            this.sumar.TabIndex = 1;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = false;
            this.sumar.Click += new System.EventHandler(this.suma_Click);
            // 
            // igual
            // 
            this.igual.AccessibleName = "igual";
            this.igual.BackColor = System.Drawing.SystemColors.HotTrack;
            this.igual.FlatAppearance.BorderSize = 0;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.Color.Transparent;
            this.igual.Location = new System.Drawing.Point(245, 431);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(69, 70);
            this.igual.TabIndex = 2;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // resultado
            // 
            this.resultado.AccessibleName = "resultado";
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultado.Location = new System.Drawing.Point(0, 20);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(325, 64);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "0";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // dos
            // 
            this.dos.AccessibleName = "dos";
            this.dos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dos.FlatAppearance.BorderSize = 0;
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(85, 355);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(70, 70);
            this.dos.TabIndex = 4;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // tres
            // 
            this.tres.AccessibleName = "tres";
            this.tres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tres.FlatAppearance.BorderSize = 0;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(162, 355);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(70, 70);
            this.tres.TabIndex = 5;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // cuatro
            // 
            this.cuatro.AccessibleName = "cuatro";
            this.cuatro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cuatro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cuatro.FlatAppearance.BorderSize = 0;
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(8, 280);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(70, 70);
            this.cuatro.TabIndex = 6;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // cinco
            // 
            this.cinco.AccessibleName = "cinco";
            this.cinco.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cinco.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cinco.FlatAppearance.BorderSize = 0;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(85, 280);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(70, 70);
            this.cinco.TabIndex = 7;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.AccessibleName = "seis";
            this.seis.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.seis.BackColor = System.Drawing.SystemColors.HighlightText;
            this.seis.FlatAppearance.BorderSize = 0;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(162, 280);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(70, 70);
            this.seis.TabIndex = 8;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // siete
            // 
            this.siete.AccessibleName = "siete";
            this.siete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.siete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.siete.FlatAppearance.BorderSize = 0;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(8, 204);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(70, 70);
            this.siete.TabIndex = 9;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // ocho
            // 
            this.ocho.AccessibleName = "ocho";
            this.ocho.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ocho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ocho.FlatAppearance.BorderSize = 0;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(85, 204);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(70, 70);
            this.ocho.TabIndex = 10;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // nueve
            // 
            this.nueve.AccessibleName = "nueve";
            this.nueve.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nueve.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nueve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nueve.FlatAppearance.BorderSize = 0;
            this.nueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(162, 204);
            this.nueve.Name = "nueve";
            this.nueve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nueve.Size = new System.Drawing.Size(70, 70);
            this.nueve.TabIndex = 11;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = false;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // cero
            // 
            this.cero.AccessibleName = "cero";
            this.cero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cero.FlatAppearance.BorderSize = 0;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.Location = new System.Drawing.Point(85, 431);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(70, 70);
            this.cero.TabIndex = 12;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // menos
            // 
            this.menos.AccessibleName = "menos";
            this.menos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menos.FlatAppearance.BorderSize = 0;
            this.menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menos.Location = new System.Drawing.Point(245, 280);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(70, 70);
            this.menos.TabIndex = 13;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // por
            // 
            this.por.AccessibleName = "por";
            this.por.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.por.FlatAppearance.BorderSize = 0;
            this.por.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.por.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.por.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.por.Location = new System.Drawing.Point(245, 204);
            this.por.Name = "por";
            this.por.Size = new System.Drawing.Size(70, 70);
            this.por.TabIndex = 14;
            this.por.Text = "x";
            this.por.UseVisualStyleBackColor = false;
            this.por.Click += new System.EventHandler(this.por_Click);
            // 
            // atras
            // 
            this.atras.AccessibleName = "atras";
            this.atras.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.atras.FlatAppearance.BorderSize = 0;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.atras.Location = new System.Drawing.Point(8, 128);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(70, 70);
            this.atras.TabIndex = 15;
            this.atras.Text = "←";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click_1);
            // 
            // division
            // 
            this.division.AccessibleName = "division";
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.division.FlatAppearance.BorderSize = 0;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.division.Location = new System.Drawing.Point(245, 128);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(70, 70);
            this.division.TabIndex = 16;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // operaciones
            // 
            this.operaciones.AccessibleName = "operaciones";
            this.operaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.operaciones.Location = new System.Drawing.Point(4, 83);
            this.operaciones.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.operaciones.Name = "operaciones";
            this.operaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.operaciones.Size = new System.Drawing.Size(308, 20);
            this.operaciones.TabIndex = 17;
            this.operaciones.Text = "0";
            this.operaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.operaciones.Click += new System.EventHandler(this.operaciones_Click);
            // 
            // masmenos
            // 
            this.masmenos.AccessibleName = "masmenos";
            this.masmenos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.masmenos.FlatAppearance.BorderSize = 0;
            this.masmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masmenos.Location = new System.Drawing.Point(8, 431);
            this.masmenos.Name = "masmenos";
            this.masmenos.Size = new System.Drawing.Size(70, 70);
            this.masmenos.TabIndex = 19;
            this.masmenos.Text = "±";
            this.masmenos.UseVisualStyleBackColor = false;
            this.masmenos.Click += new System.EventHandler(this.masmenos_Click);
            // 
            // borrar
            // 
            this.borrar.AccessibleName = "borrar";
            this.borrar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.borrar.FlatAppearance.BorderSize = 0;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrar.Location = new System.Drawing.Point(162, 128);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(70, 70);
            this.borrar.TabIndex = 20;
            this.borrar.Text = "c";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // borrarNumeroCompleto
            // 
            this.borrarNumeroCompleto.AccessibleName = "borrarNumeroCompleto";
            this.borrarNumeroCompleto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.borrarNumeroCompleto.FlatAppearance.BorderSize = 0;
            this.borrarNumeroCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarNumeroCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarNumeroCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrarNumeroCompleto.Location = new System.Drawing.Point(85, 128);
            this.borrarNumeroCompleto.Name = "borrarNumeroCompleto";
            this.borrarNumeroCompleto.Size = new System.Drawing.Size(70, 70);
            this.borrarNumeroCompleto.TabIndex = 21;
            this.borrarNumeroCompleto.Text = "ce";
            this.borrarNumeroCompleto.UseVisualStyleBackColor = false;
            this.borrarNumeroCompleto.Click += new System.EventHandler(this.borrarNum_Click);
            // 
            // coma
            // 
            this.coma.AccessibleName = "coma";
            this.coma.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.coma.FlatAppearance.BorderSize = 0;
            this.coma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coma.Location = new System.Drawing.Point(162, 431);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(70, 70);
            this.coma.TabIndex = 22;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = false;
            this.coma.Click += new System.EventHandler(this.coma_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 509);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.borrarNumeroCompleto);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.masmenos);
            this.Controls.Add(this.operaciones);
            this.Controls.Add(this.division);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.por);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.uno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.87D;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button por;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label operaciones;
        private System.Windows.Forms.Button masmenos;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button borrarNumeroCompleto;
        private System.Windows.Forms.Button coma;
    }
}

