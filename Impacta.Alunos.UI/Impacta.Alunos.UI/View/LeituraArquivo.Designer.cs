namespace Impacta.Alunos.UI.View
{
    partial class LeituraArquivo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLer = new System.Windows.Forms.Button();
            this.listBoxDadosLeitura = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonLer);
            this.groupBox1.Controls.Add(this.listBoxDadosLeitura);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leitura de dados";
            // 
            // buttonLer
            // 
            this.buttonLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLer.Location = new System.Drawing.Point(20, 25);
            this.buttonLer.Name = "buttonLer";
            this.buttonLer.Size = new System.Drawing.Size(147, 23);
            this.buttonLer.TabIndex = 3;
            this.buttonLer.Text = "Ler";
            this.buttonLer.UseVisualStyleBackColor = true;
            this.buttonLer.Click += new System.EventHandler(this.buttonLer_Click);
            // 
            // listBoxDadosLeitura
            // 
            this.listBoxDadosLeitura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDadosLeitura.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDadosLeitura.FormattingEnabled = true;
            this.listBoxDadosLeitura.HorizontalScrollbar = true;
            this.listBoxDadosLeitura.ItemHeight = 14;
            this.listBoxDadosLeitura.Location = new System.Drawing.Point(20, 54);
            this.listBoxDadosLeitura.Name = "listBoxDadosLeitura";
            this.listBoxDadosLeitura.ScrollAlwaysVisible = true;
            this.listBoxDadosLeitura.Size = new System.Drawing.Size(944, 284);
            this.listBoxDadosLeitura.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LeituraArquivo
            // 
            this.AcceptButton = this.buttonLer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 404);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "LeituraArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitura Arquivo Lab.8";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLer;
        private System.Windows.Forms.ListBox listBoxDadosLeitura;
        private System.Windows.Forms.Button button1;
    }
}