namespace practicaaaaaa
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
            button1 = new Button();
            txtTelegrama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbUrgente = new CheckBox();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(296, 203);
            button1.Name = "button1";
            button1.Size = new Size(87, 38);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(71, 36);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(274, 133);
            txtTelegrama.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 236);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Coste";
            // 
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.Location = new Point(53, 187);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(73, 19);
            cbUrgente.TabIndex = 5;
            cbUrgente.Text = "Urgente?";
            cbUrgente.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(110, 228);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 283);
            Controls.Add(txtPrecio);
            Controls.Add(cbUrgente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelegrama);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtTelegrama;
        private Label label1;
        private Label label2;
        private CheckBox cbUrgente;
        private TextBox txtPrecio;
    }
}
