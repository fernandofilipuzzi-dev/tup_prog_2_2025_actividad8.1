namespace Ejercicio1
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
            btnConfirmar = new Button();
            btnActualizar = new Button();
            lsbVer = new ListBox();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            tbImporte = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(305, 64);
            btnConfirmar.Margin = new Padding(4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(96, 64);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(305, 210);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 68);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 21;
            lsbVer.Location = new Point(13, 172);
            lsbVer.Margin = new Padding(4);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(277, 193);
            lsbVer.TabIndex = 2;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(122, 29);
            tbNombre.Margin = new Padding(4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(127, 29);
            tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(122, 74);
            tbDNI.Margin = new Padding(4);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(127, 29);
            tbDNI.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(122, 121);
            tbImporte.Margin = new Padding(4);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(127, 29);
            tbImporte.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 7;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 8;
            label3.Text = "Importe";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 371);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbImporte);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(lsbVer);
            Controls.Add(btnActualizar);
            Controls.Add(btnConfirmar);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Button btnActualizar;
        private ListBox lsbVer;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private TextBox tbImporte;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
