namespace FormEstudiantes
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            listBoxAlumnos = new ListBox();
            lblAlumnos = new Label();
            btnMaterias = new Button();
            labelMaterias = new Label();
            listBoxMaterias = new ListBox();
            btnEstadoAcademico = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.Location = new Point(38, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listBoxAlumnos
            // 
            listBoxAlumnos.FormattingEnabled = true;
            listBoxAlumnos.ItemHeight = 15;
            listBoxAlumnos.Location = new Point(12, 45);
            listBoxAlumnos.Name = "listBoxAlumnos";
            listBoxAlumnos.Size = new Size(150, 349);
            listBoxAlumnos.TabIndex = 4;
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumnos.Location = new Point(12, 21);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(78, 21);
            lblAlumnos.TabIndex = 6;
            lblAlumnos.Text = "Alumnos";
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(281, 415);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(75, 23);
            btnMaterias.TabIndex = 8;
            btnMaterias.Text = "Agregar Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // labelMaterias
            // 
            labelMaterias.AutoSize = true;
            labelMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaterias.Location = new Point(280, 21);
            labelMaterias.Name = "labelMaterias";
            labelMaterias.Size = new Size(76, 21);
            labelMaterias.TabIndex = 10;
            labelMaterias.Text = "Materias";
            // 
            // listBoxMaterias
            // 
            listBoxMaterias.FormattingEnabled = true;
            listBoxMaterias.ItemHeight = 15;
            listBoxMaterias.Location = new Point(280, 45);
            listBoxMaterias.Name = "listBoxMaterias";
            listBoxMaterias.Size = new Size(150, 349);
            listBoxMaterias.TabIndex = 9;
            // 
            // btnEstadoAcademico
            // 
            btnEstadoAcademico.Location = new Point(504, 415);
            btnEstadoAcademico.Name = "btnEstadoAcademico";
            btnEstadoAcademico.Size = new Size(146, 23);
            btnEstadoAcademico.TabIndex = 11;
            btnEstadoAcademico.Text = "Crear Estado Academico";
            btnEstadoAcademico.UseVisualStyleBackColor = true;
            btnEstadoAcademico.Click += btnEstadoAcademico_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1100, 450);
            Controls.Add(btnEstadoAcademico);
            Controls.Add(labelMaterias);
            Controls.Add(listBoxMaterias);
            Controls.Add(btnMaterias);
            Controls.Add(lblAlumnos);
            Controls.Add(listBoxAlumnos);
            Controls.Add(btnAgregar);
            Name = "FormPrincipal";
            Text = "Alumnos";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private ListBox listBoxAlumnos;
        private Label lblAlumnos;
        private Button btnMaterias;
        private Label labelMaterias;
        private ListBox listBoxMaterias;
        private Button btnEstadoAcademico;
    }
}
