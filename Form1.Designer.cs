namespace Text_Incripter1._1
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
            this.Incript = new System.Windows.Forms.Button();
            this.Decript = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.openCodedFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Incript
            // 
            this.Incript.Location = new System.Drawing.Point(72, 42);
            this.Incript.Name = "Incript";
            this.Incript.Size = new System.Drawing.Size(186, 72);
            this.Incript.TabIndex = 0;
            this.Incript.Text = "Read and Incript New File";
            this.Incript.UseVisualStyleBackColor = true;
            this.Incript.Click += new System.EventHandler(this.Incript_Click);
            // 
            // Decript
            // 
            this.Decript.Location = new System.Drawing.Point(356, 42);
            this.Decript.Name = "Decript";
            this.Decript.Size = new System.Drawing.Size(146, 68);
            this.Decript.TabIndex = 1;
            this.Decript.Text = "Read and Decript File";
            this.Decript.UseVisualStyleBackColor = true;
            this.Decript.Click += new System.EventHandler(this.Decript_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decript);
            this.Controls.Add(this.Incript);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incriptador de Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Incript;
        private System.Windows.Forms.Button Decript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.OpenFileDialog openCodedFile;
    }
}

