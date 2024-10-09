namespace RenomeiaPDF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEscolhePasta = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRodar = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnEscolhePasta
            // 
            this.btnEscolhePasta.Location = new System.Drawing.Point(13, 50);
            this.btnEscolhePasta.Name = "btnEscolhePasta";
            this.btnEscolhePasta.Size = new System.Drawing.Size(371, 29);
            this.btnEscolhePasta.TabIndex = 0;
            this.btnEscolhePasta.Text = "Escolher Pasta";
            this.btnEscolhePasta.UseVisualStyleBackColor = true;
            this.btnEscolhePasta.Click += new System.EventHandler(this.btnEscolhePasta_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiretorio.Location = new System.Drawing.Point(13, 13);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(371, 24);
            this.txtDiretorio.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRodar);
            this.panel1.Controls.Add(this.txtDiretorio);
            this.panel1.Controls.Add(this.btnEscolhePasta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 127);
            this.panel1.TabIndex = 2;
            // 
            // btnRodar
            // 
            this.btnRodar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRodar.Location = new System.Drawing.Point(13, 87);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(371, 29);
            this.btnRodar.TabIndex = 2;
            this.btnRodar.Text = "Rodar";
            this.btnRodar.UseVisualStyleBackColor = false;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 145);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(404, 290);
            this.lstLog.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RenomeiaPDF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnEscolhePasta;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRodar;
        private System.Windows.Forms.ListBox lstLog;
    }
}

