namespace FormLapiceraDos
{
    partial class FormAltaDos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Precio = new TextBox();
            txt_Marca = new TextBox();
            btn_Confirmar = new Button();
            btn_Cancelar = new Button();
            lst_Colores = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 255);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 124);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Color";
            // 
            // txt_Precio
            // 
            txt_Precio.Location = new Point(118, 273);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(212, 23);
            txt_Precio.TabIndex = 3;
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(118, 81);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(212, 23);
            txt_Marca.TabIndex = 4;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Location = new Point(118, 323);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(75, 23);
            btn_Confirmar.TabIndex = 6;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(255, 323);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 7;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // lst_Colores
            // 
            lst_Colores.FormattingEnabled = true;
            lst_Colores.ItemHeight = 15;
            lst_Colores.Location = new Point(118, 158);
            lst_Colores.Name = "lst_Colores";
            lst_Colores.Size = new Size(212, 94);
            lst_Colores.TabIndex = 8;
            // 
            // FormAltaDos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_Colores);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Confirmar);
            Controls.Add(txt_Marca);
            Controls.Add(txt_Precio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAltaDos";
            Text = "FormAltaDos";
            Load += FormAltaDos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Precio;
        private TextBox txt_Marca;
        private Button btn_Confirmar;
        private Button btn_Cancelar;
        private ListBox lst_Colores;
    }
}