namespace FormIngresantes
{
    partial class FormAlta
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
            labelPais = new Label();
            btnCancelar = new Button();
            btnAgregar = new Button();
            lstPais = new ListBox();
            gpbGenero = new GroupBox();
            radioButtonM = new RadioButton();
            radioButtonF = new RadioButton();
            radioButtonX = new RadioButton();
            gpbDatosIngresante = new GroupBox();
            textBoxApellido = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            labelEdad = new Label();
            textBoxNombre = new TextBox();
            numEdad = new NumericUpDown();
            gpbCursos = new GroupBox();
            chkCSHARP = new CheckBox();
            CHKaNGULAR = new CheckBox();
            ckhPhyton = new CheckBox();
            chkNode = new CheckBox();
            chkJS = new CheckBox();
            gpbGenero.SuspendLayout();
            gpbDatosIngresante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            gpbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(67, 225);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(28, 15);
            labelPais.TabIndex = 22;
            labelPais.Text = "Pais";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(587, 410);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(67, 410);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstPais
            // 
            lstPais.FormattingEnabled = true;
            lstPais.ItemHeight = 15;
            lstPais.Location = new Point(67, 243);
            lstPais.Name = "lstPais";
            lstPais.Size = new Size(120, 139);
            lstPais.TabIndex = 16;
            // 
            // gpbGenero
            // 
            gpbGenero.Controls.Add(radioButtonM);
            gpbGenero.Controls.Add(radioButtonF);
            gpbGenero.Controls.Add(radioButtonX);
            gpbGenero.Location = new Point(533, 25);
            gpbGenero.Name = "gpbGenero";
            gpbGenero.Size = new Size(200, 100);
            gpbGenero.TabIndex = 17;
            gpbGenero.TabStop = false;
            gpbGenero.Text = "Genero";
            // 
            // radioButtonM
            // 
            radioButtonM.AutoSize = true;
            radioButtonM.Location = new Point(0, 25);
            radioButtonM.Name = "radioButtonM";
            radioButtonM.Size = new Size(80, 19);
            radioButtonM.TabIndex = 3;
            radioButtonM.TabStop = true;
            radioButtonM.Text = "Masculino";
            radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            radioButtonF.AutoSize = true;
            radioButtonF.Location = new Point(0, 50);
            radioButtonF.Name = "radioButtonF";
            radioButtonF.Size = new Size(78, 19);
            radioButtonF.TabIndex = 4;
            radioButtonF.TabStop = true;
            radioButtonF.Text = "Femenino";
            radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonX
            // 
            radioButtonX.AutoSize = true;
            radioButtonX.Location = new Point(0, 75);
            radioButtonX.Name = "radioButtonX";
            radioButtonX.Size = new Size(81, 19);
            radioButtonX.TabIndex = 5;
            radioButtonX.TabStop = true;
            radioButtonX.Text = "No Binario";
            radioButtonX.UseVisualStyleBackColor = true;
            // 
            // gpbDatosIngresante
            // 
            gpbDatosIngresante.Controls.Add(textBoxApellido);
            gpbDatosIngresante.Controls.Add(labelNombre);
            gpbDatosIngresante.Controls.Add(labelApellido);
            gpbDatosIngresante.Controls.Add(labelEdad);
            gpbDatosIngresante.Controls.Add(textBoxNombre);
            gpbDatosIngresante.Controls.Add(numEdad);
            gpbDatosIngresante.Location = new Point(67, 18);
            gpbDatosIngresante.Name = "gpbDatosIngresante";
            gpbDatosIngresante.Size = new Size(357, 184);
            gpbDatosIngresante.TabIndex = 18;
            gpbDatosIngresante.TabStop = false;
            gpbDatosIngresante.Text = "Datos del ingresante";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(97, 84);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(214, 23);
            textBoxApellido.TabIndex = 9;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(33, 37);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 12;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(33, 87);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 13;
            labelApellido.Text = "Apellido";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(33, 135);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(33, 15);
            labelEdad.TabIndex = 14;
            labelEdad.Text = "Edad";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(97, 37);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(214, 23);
            textBoxNombre.TabIndex = 8;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(97, 133);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(117, 23);
            numEdad.TabIndex = 11;
            // 
            // gpbCursos
            // 
            gpbCursos.Controls.Add(chkCSHARP);
            gpbCursos.Controls.Add(CHKaNGULAR);
            gpbCursos.Controls.Add(ckhPhyton);
            gpbCursos.Controls.Add(chkNode);
            gpbCursos.Controls.Add(chkJS);
            gpbCursos.Location = new Point(533, 228);
            gpbCursos.Name = "gpbCursos";
            gpbCursos.Size = new Size(200, 154);
            gpbCursos.TabIndex = 19;
            gpbCursos.TabStop = false;
            gpbCursos.Text = "Cursos";
            // 
            // chkCSHARP
            // 
            chkCSHARP.AutoSize = true;
            chkCSHARP.Location = new Point(111, 22);
            chkCSHARP.Name = "chkCSHARP";
            chkCSHARP.Size = new Size(41, 19);
            chkCSHARP.TabIndex = 3;
            chkCSHARP.Text = "C#";
            chkCSHARP.UseVisualStyleBackColor = true;
            // 
            // CHKaNGULAR
            // 
            CHKaNGULAR.AutoSize = true;
            CHKaNGULAR.Location = new Point(111, 47);
            CHKaNGULAR.Name = "CHKaNGULAR";
            CHKaNGULAR.Size = new Size(68, 19);
            CHKaNGULAR.TabIndex = 4;
            CHKaNGULAR.Text = "Angular";
            CHKaNGULAR.UseVisualStyleBackColor = true;
            // 
            // ckhPhyton
            // 
            ckhPhyton.AutoSize = true;
            ckhPhyton.Location = new Point(111, 75);
            ckhPhyton.Name = "ckhPhyton";
            ckhPhyton.Size = new Size(64, 19);
            ckhPhyton.TabIndex = 5;
            ckhPhyton.Text = "Phyton";
            ckhPhyton.UseVisualStyleBackColor = true;
            // 
            // chkNode
            // 
            chkNode.AutoSize = true;
            chkNode.Location = new Point(111, 100);
            chkNode.Name = "chkNode";
            chkNode.Size = new Size(66, 19);
            chkNode.TabIndex = 6;
            chkNode.Text = "Node.js";
            chkNode.UseVisualStyleBackColor = true;
            // 
            // chkJS
            // 
            chkJS.AutoSize = true;
            chkJS.Location = new Point(111, 125);
            chkJS.Name = "chkJS";
            chkJS.Size = new Size(81, 19);
            chkJS.TabIndex = 7;
            chkJS.Text = "Java Script";
            chkJS.UseVisualStyleBackColor = true;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPais);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lstPais);
            Controls.Add(gpbGenero);
            Controls.Add(gpbDatosIngresante);
            Controls.Add(gpbCursos);
            Name = "FormAlta";
            Text = "FormAlta";
            gpbGenero.ResumeLayout(false);
            gpbGenero.PerformLayout();
            gpbDatosIngresante.ResumeLayout(false);
            gpbDatosIngresante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            gpbCursos.ResumeLayout(false);
            gpbCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPais;
        private Button btnCancelar;
        private Button btnAgregar;
        private ListBox lstPais;
        private GroupBox gpbGenero;
        private RadioButton radioButtonM;
        private RadioButton radioButtonF;
        private RadioButton radioButtonX;
        private GroupBox gpbDatosIngresante;
        private TextBox textBoxApellido;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelEdad;
        private TextBox textBoxNombre;
        private NumericUpDown numEdad;
        private GroupBox gpbCursos;
        private CheckBox chkCSHARP;
        private CheckBox CHKaNGULAR;
        private CheckBox ckhPhyton;
        private CheckBox chkNode;
        private CheckBox chkJS;
    }
}