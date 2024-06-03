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
            btnMostrar = new Button();
            btnAgregar = new Button();
            btnEvaluar = new Button();
            listBoxAlumnos = new ListBox();
            lblInfo = new Label();
            lblAlumnos = new Label();
            dataGridViewInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(319, 415);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
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
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(189, 415);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(75, 23);
            btnEvaluar.TabIndex = 2;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = true;
            btnEvaluar.Click += btnEvaluar_Click;
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
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(189, 21);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(104, 21);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Informacion";
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
            // dataGridViewInfo
            // 
            dataGridViewInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo.Location = new Point(189, 45);
            dataGridViewInfo.Name = "dataGridViewInfo";
            dataGridViewInfo.Size = new Size(899, 349);
            dataGridViewInfo.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1100, 450);
            Controls.Add(dataGridViewInfo);
            Controls.Add(lblAlumnos);
            Controls.Add(lblInfo);
            Controls.Add(listBoxAlumnos);
            Controls.Add(btnEvaluar);
            Controls.Add(btnAgregar);
            Controls.Add(btnMostrar);
            Name = "FormPrincipal";
            Text = "Alumnos";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Button btnAgregar;
        private Button btnEvaluar;
        private ListBox listBoxAlumnos;
        private Label lblInfo;
        private Label lblAlumnos;
        private DataGridView dataGridViewInfo;
    }
}
