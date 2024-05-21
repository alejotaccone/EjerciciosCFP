namespace PrimerFormulario
{
    partial class Form1
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtContrasenia = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblContrasenia = new Label();
            btnIngresas = new Button();
            listBox1 = new ListBox();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(538, 23);
            txtNombre.TabIndex = 0;
            
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(173, 185);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(538, 23);
            txtApellido.TabIndex = 1;
            
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(173, 251);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(538, 23);
            txtContrasenia.TabIndex = 2;
            
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(173, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(173, 155);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(173, 221);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(70, 15);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contrasenia";
            // 
            // btnIngresas
            // 
            btnIngresas.Location = new Point(173, 295);
            btnIngresas.Name = "btnIngresas";
            btnIngresas.Size = new Size(75, 23);
            btnIngresas.TabIndex = 6;
            btnIngresas.Text = "Ingresar";
            btnIngresas.UseVisualStyleBackColor = true;
            btnIngresas.Click += btnIngresas_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(173, 353);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 94);
            listBox1.TabIndex = 7;
            
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(173, 462);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "button1";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1524, 769);
            Controls.Add(btnBorrar);
            Controls.Add(listBox1);
            Controls.Add(btnIngresas);
            Controls.Add(lblContrasenia);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtContrasenia);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtContrasenia;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblContrasenia;
        private Button btnIngresas;
        private ListBox listBox1;
        private Button btnBorrar;
    }
}
