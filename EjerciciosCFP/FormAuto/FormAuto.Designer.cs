namespace FormAuto
{
    partial class FormAuto
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
            comboBox1 = new ComboBox();
            labelColor = new Label();
            textBoxCombustible = new TextBox();
            textBoxMarca = new TextBox();
            labelMarca = new Label();
            labelComb = new Label();
            btnCrear = new Button();
            listBoxAuto = new ListBox();
            labelMostarAuto = new Label();
            btn_Limpiar = new Button();
            btn_Mostrar = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(218, 301);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 0;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Comic Sans MS", 12.75F);
            labelColor.Location = new Point(218, 273);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(53, 24);
            labelColor.TabIndex = 1;
            labelColor.Text = "Color";
            // 
            // textBoxCombustible
            // 
            textBoxCombustible.Location = new Point(218, 184);
            textBoxCombustible.Name = "textBoxCombustible";
            textBoxCombustible.Size = new Size(222, 23);
            textBoxCombustible.TabIndex = 2;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(218, 73);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(222, 23);
            textBoxMarca.TabIndex = 3;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Comic Sans MS", 12.75F);
            labelMarca.Location = new Point(218, 45);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(60, 24);
            labelMarca.TabIndex = 4;
            labelMarca.Text = "Marca";
            // 
            // labelComb
            // 
            labelComb.AutoSize = true;
            labelComb.Font = new Font("Comic Sans MS", 12.75F);
            labelComb.Location = new Point(218, 156);
            labelComb.Name = "labelComb";
            labelComb.Size = new Size(147, 24);
            labelComb.TabIndex = 5;
            labelComb.Text = "Cant combustible";
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 10F);
            btnCrear.Location = new Point(218, 352);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 40);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // listBoxAuto
            // 
            listBoxAuto.FormattingEnabled = true;
            listBoxAuto.ItemHeight = 15;
            listBoxAuto.Location = new Point(523, 73);
            listBoxAuto.Name = "listBoxAuto";
            listBoxAuto.Size = new Size(598, 319);
            listBoxAuto.TabIndex = 7;
            // 
            // labelMostarAuto
            // 
            labelMostarAuto.AutoSize = true;
            labelMostarAuto.Font = new Font("Comic Sans MS", 12.75F);
            labelMostarAuto.Location = new Point(523, 45);
            labelMostarAuto.Name = "labelMostarAuto";
            labelMostarAuto.Size = new Size(49, 24);
            labelMostarAuto.TabIndex = 8;
            labelMostarAuto.Text = "Auto";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.Red;
            btn_Limpiar.Font = new Font("Segoe UI", 10F);
            btn_Limpiar.Location = new Point(617, 398);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(75, 40);
            btn_Limpiar.TabIndex = 9;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = SystemColors.HotTrack;
            btn_Mostrar.Font = new Font("Segoe UI", 10F);
            btn_Mostrar.Location = new Point(523, 398);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(75, 40);
            btn_Mostrar.TabIndex = 10;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1267, 450);
            Controls.Add(btn_Mostrar);
            Controls.Add(btn_Limpiar);
            Controls.Add(labelMostarAuto);
            Controls.Add(listBoxAuto);
            Controls.Add(btnCrear);
            Controls.Add(labelComb);
            Controls.Add(labelMarca);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxCombustible);
            Controls.Add(labelColor);
            Controls.Add(comboBox1);
            Name = "FormAuto";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label labelColor;
        private TextBox textBoxCombustible;
        private TextBox textBoxMarca;
        private Label labelMarca;
        private Label labelComb;
        private Button btnCrear;
        private ListBox listBoxAuto;
        private Label labelMostarAuto;
        private Button btn_Limpiar;
        private Button btn_Mostrar;
    }
}
