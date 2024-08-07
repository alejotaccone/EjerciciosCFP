namespace FormComputadora
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
            groupBoxHadware = new GroupBox();
            comboBox1 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBoxProgramas = new GroupBox();
            cBAvast = new CheckBox();
            cBDropBox = new CheckBox();
            cBOWinrar = new CheckBox();
            cBAdobe = new CheckBox();
            cBOffice = new CheckBox();
            groupBoxSistOperativo = new GroupBox();
            radioBtnWindows = new RadioButton();
            radioBtnLinux = new RadioButton();
            radioBtnMacOs = new RadioButton();
            btnAgregar = new Button();
            btnCancelar = new Button();
            groupBoxHadware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBoxProgramas.SuspendLayout();
            groupBoxSistOperativo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxHadware
            // 
            groupBoxHadware.Controls.Add(comboBox1);
            groupBoxHadware.Controls.Add(numericUpDown2);
            groupBoxHadware.Controls.Add(numericUpDown1);
            groupBoxHadware.Controls.Add(label1);
            groupBoxHadware.Controls.Add(label2);
            groupBoxHadware.Controls.Add(label3);
            groupBoxHadware.Location = new Point(109, 44);
            groupBoxHadware.Name = "groupBoxHadware";
            groupBoxHadware.Size = new Size(233, 299);
            groupBoxHadware.TabIndex = 0;
            groupBoxHadware.TabStop = false;
            groupBoxHadware.Text = "Hadware";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(94, 154);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(94, 117);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 8;
            label1.Text = "Procesadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 119);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 9;
            label2.Text = "Memoria Ram";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 156);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Disco";
            // 
            // groupBoxProgramas
            // 
            groupBoxProgramas.Controls.Add(cBAvast);
            groupBoxProgramas.Controls.Add(cBDropBox);
            groupBoxProgramas.Controls.Add(cBOWinrar);
            groupBoxProgramas.Controls.Add(cBAdobe);
            groupBoxProgramas.Controls.Add(cBOffice);
            groupBoxProgramas.Location = new Point(460, 189);
            groupBoxProgramas.Name = "groupBoxProgramas";
            groupBoxProgramas.Size = new Size(200, 166);
            groupBoxProgramas.TabIndex = 0;
            groupBoxProgramas.TabStop = false;
            groupBoxProgramas.Text = "Programas";
            // 
            // cBAvast
            // 
            cBAvast.AutoSize = true;
            cBAvast.Location = new Point(6, 125);
            cBAvast.Name = "cBAvast";
            cBAvast.Size = new Size(55, 19);
            cBAvast.TabIndex = 4;
            cBAvast.Text = "Avast";
            cBAvast.UseVisualStyleBackColor = true;
            // 
            // cBDropBox
            // 
            cBDropBox.AutoSize = true;
            cBDropBox.Location = new Point(6, 100);
            cBDropBox.Name = "cBDropBox";
            cBDropBox.Size = new Size(72, 19);
            cBDropBox.TabIndex = 3;
            cBDropBox.Text = "DropBox";
            cBDropBox.UseVisualStyleBackColor = true;
            // 
            // cBOWinrar
            // 
            cBOWinrar.AutoSize = true;
            cBOWinrar.Location = new Point(6, 75);
            cBOWinrar.Name = "cBOWinrar";
            cBOWinrar.Size = new Size(61, 19);
            cBOWinrar.TabIndex = 2;
            cBOWinrar.Text = "Winrar";
            cBOWinrar.UseVisualStyleBackColor = true;
            // 
            // cBAdobe
            // 
            cBAdobe.AutoSize = true;
            cBAdobe.Location = new Point(6, 50);
            cBAdobe.Name = "cBAdobe";
            cBAdobe.Size = new Size(61, 19);
            cBAdobe.TabIndex = 1;
            cBAdobe.Text = "Adobe";
            cBAdobe.UseVisualStyleBackColor = true;
            // 
            // cBOffice
            // 
            cBOffice.AutoSize = true;
            cBOffice.Location = new Point(6, 25);
            cBOffice.Name = "cBOffice";
            cBOffice.Size = new Size(58, 19);
            cBOffice.TabIndex = 0;
            cBOffice.Text = "Office";
            cBOffice.UseVisualStyleBackColor = true;
            // 
            // groupBoxSistOperativo
            // 
            groupBoxSistOperativo.Controls.Add(radioBtnWindows);
            groupBoxSistOperativo.Controls.Add(radioBtnLinux);
            groupBoxSistOperativo.Controls.Add(radioBtnMacOs);
            groupBoxSistOperativo.Location = new Point(460, 49);
            groupBoxSistOperativo.Name = "groupBoxSistOperativo";
            groupBoxSistOperativo.Size = new Size(200, 100);
            groupBoxSistOperativo.TabIndex = 0;
            groupBoxSistOperativo.TabStop = false;
            groupBoxSistOperativo.Text = "Sistema Operativo";
            // 
            // radioBtnWindows
            // 
            radioBtnWindows.AutoSize = true;
            radioBtnWindows.Location = new Point(6, 25);
            radioBtnWindows.Name = "radioBtnWindows";
            radioBtnWindows.Size = new Size(74, 19);
            radioBtnWindows.TabIndex = 5;
            radioBtnWindows.TabStop = true;
            radioBtnWindows.Text = "Windows";
            radioBtnWindows.UseVisualStyleBackColor = true;
            // 
            // radioBtnLinux
            // 
            radioBtnLinux.AutoSize = true;
            radioBtnLinux.Location = new Point(6, 50);
            radioBtnLinux.Name = "radioBtnLinux";
            radioBtnLinux.Size = new Size(54, 19);
            radioBtnLinux.TabIndex = 6;
            radioBtnLinux.TabStop = true;
            radioBtnLinux.Text = "Lunix";
            radioBtnLinux.UseVisualStyleBackColor = true;
            // 
            // radioBtnMacOs
            // 
            radioBtnMacOs.AutoSize = true;
            radioBtnMacOs.Location = new Point(6, 75);
            radioBtnMacOs.Name = "radioBtnMacOs";
            radioBtnMacOs.Size = new Size(62, 19);
            radioBtnMacOs.TabIndex = 7;
            radioBtnMacOs.TabStop = true;
            radioBtnMacOs.Text = "MacOs";
            radioBtnMacOs.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(267, 382);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(460, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBoxProgramas);
            Controls.Add(groupBoxSistOperativo);
            Controls.Add(groupBoxHadware);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            groupBoxHadware.ResumeLayout(false);
            groupBoxHadware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBoxProgramas.ResumeLayout(false);
            groupBoxProgramas.PerformLayout();
            groupBoxSistOperativo.ResumeLayout(false);
            groupBoxSistOperativo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHadware;
        private GroupBox groupBoxProgramas;
        private GroupBox groupBoxSistOperativo;
        private CheckBox cBDropBox;
        private CheckBox cBOWinrar;
        private CheckBox cBAdobe;
        private CheckBox cBOffice;
        private CheckBox cBAvast;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioBtnWindows;
        private RadioButton radioBtnLinux;
        private RadioButton radioBtnMacOs;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}