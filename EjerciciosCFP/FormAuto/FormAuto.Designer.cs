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
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(274, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 0;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI", 13F);
            labelColor.Location = new Point(274, 277);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(55, 25);
            labelColor.TabIndex = 1;
            labelColor.Text = "Color";
            // 
            // textBoxCombustible
            // 
            textBoxCombustible.Location = new Point(274, 188);
            textBoxCombustible.Name = "textBoxCombustible";
            textBoxCombustible.Size = new Size(222, 23);
            textBoxCombustible.TabIndex = 2;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(274, 77);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(222, 23);
            textBoxMarca.TabIndex = 3;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Segoe UI", 13F);
            labelMarca.Location = new Point(274, 49);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(60, 25);
            labelMarca.TabIndex = 4;
            labelMarca.Text = "Marca";
            // 
            // labelComb
            // 
            labelComb.AutoSize = true;
            labelComb.Font = new Font("Segoe UI", 13F);
            labelComb.Location = new Point(274, 160);
            labelComb.Name = "labelComb";
            labelComb.Size = new Size(151, 25);
            labelComb.TabIndex = 5;
            labelComb.Text = "Cant combustible";
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 10F);
            btnCrear.Location = new Point(274, 354);
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
            listBoxAuto.Location = new Point(608, 77);
            listBoxAuto.Name = "listBoxAuto";
            listBoxAuto.Size = new Size(367, 319);
            listBoxAuto.TabIndex = 7;
            // 
            // labelMostarAuto
            // 
            labelMostarAuto.AutoSize = true;
            labelMostarAuto.Font = new Font("Segoe UI", 13F);
            labelMostarAuto.Location = new Point(608, 49);
            labelMostarAuto.Name = "labelMostarAuto";
            labelMostarAuto.Size = new Size(51, 25);
            labelMostarAuto.TabIndex = 8;
            labelMostarAuto.Text = "Auto";
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 450);
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
    }
}
