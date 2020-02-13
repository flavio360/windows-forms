namespace Impacta.Alunos.UI
{
    partial class formCalculadoraTabuada
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
            this.textBoxTabuada = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxTabuada
            // 
            this.textBoxTabuada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTabuada.Location = new System.Drawing.Point(12, 12);
            this.textBoxTabuada.MaxLength = 5;
            this.textBoxTabuada.Name = "textBoxTabuada";
            this.textBoxTabuada.Size = new System.Drawing.Size(227, 20);
            this.textBoxTabuada.TabIndex = 0;
            this.textBoxTabuada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTabuada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTabuada_KeyPress);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(12, 47);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(227, 277);
            this.listBoxResultado.TabIndex = 1;
            this.listBoxResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxResultado_KeyPress);
            // 
            // formCalculadoraTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 333);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.textBoxTabuada);
            this.Name = "formCalculadoraTabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplicação";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculadoraTabuada_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTabuada;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}