namespace FormPrincipal
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
            btn_Confirmar = new Button();
            btn_Cancelar = new Button();
            txt_Marca = new TextBox();
            txt_Precio = new TextBox();
            txt_Color = new TextBox();
            lbl_Marca = new Label();
            lbl_Color = new Label();
            lbl_Precio = new Label();
            SuspendLayout();
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Location = new Point(254, 293);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(75, 23);
            btn_Confirmar.TabIndex = 0;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            btn_Confirmar.Click += button1_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(439, 293);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(254, 85);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(260, 23);
            txt_Marca.TabIndex = 2;
            // 
            // txt_Precio
            // 
            txt_Precio.Location = new Point(254, 229);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(260, 23);
            txt_Precio.TabIndex = 3;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(254, 157);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(260, 23);
            txt_Color.TabIndex = 4;
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Location = new Point(254, 67);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(40, 15);
            lbl_Marca.TabIndex = 5;
            lbl_Marca.Text = "Marca";
            // 
            // lbl_Color
            // 
            lbl_Color.AutoSize = true;
            lbl_Color.Location = new Point(254, 139);
            lbl_Color.Name = "lbl_Color";
            lbl_Color.Size = new Size(36, 15);
            lbl_Color.TabIndex = 6;
            lbl_Color.Text = "Color";
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Location = new Point(254, 211);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(40, 15);
            lbl_Precio.TabIndex = 7;
            lbl_Precio.Text = "Precio";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Precio);
            Controls.Add(lbl_Color);
            Controls.Add(lbl_Marca);
            Controls.Add(txt_Color);
            Controls.Add(txt_Precio);
            Controls.Add(txt_Marca);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Confirmar);
            Name = "FormAlta";
            Text = "FormAlta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Confirmar;
        private Button btn_Cancelar;
        private TextBox txt_Marca;
        private TextBox txt_Precio;
        private TextBox txt_Color;
        private Label lbl_Marca;
        private Label lbl_Color;
        private Label lbl_Precio;
    }
}