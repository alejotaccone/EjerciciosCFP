namespace FormLapiceraDos
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
            lst_Mostrar = new ListBox();
            btn_Agregar = new Button();
            btn_Escribir = new Button();
            SuspendLayout();
            // 
            // lst_Mostrar
            // 
            lst_Mostrar.FormattingEnabled = true;
            lst_Mostrar.ItemHeight = 15;
            lst_Mostrar.Location = new Point(0, 0);
            lst_Mostrar.Name = "lst_Mostrar";
            lst_Mostrar.Size = new Size(803, 214);
            lst_Mostrar.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(359, 265);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Escribir
            // 
            btn_Escribir.Location = new Point(542, 265);
            btn_Escribir.Name = "btn_Escribir";
            btn_Escribir.Size = new Size(75, 23);
            btn_Escribir.TabIndex = 2;
            btn_Escribir.Text = "Escribir";
            btn_Escribir.UseVisualStyleBackColor = true;
            btn_Escribir.Click += btn_Escribir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Escribir);
            Controls.Add(btn_Agregar);
            Controls.Add(lst_Mostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_Mostrar;
        private Button btn_Agregar;
        private Button btn_Escribir;
    }
}
