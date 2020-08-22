namespace FormatTextForJasomn
{
    partial class FrmPrincipal
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
            this.txtTextInput = new System.Windows.Forms.TextBox();
            this.btnFormatText = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Informações = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lbxType = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.Informações.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTextInput
            // 
            this.txtTextInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTextInput.Location = new System.Drawing.Point(0, 0);
            this.txtTextInput.Multiline = true;
            this.txtTextInput.Name = "txtTextInput";
            this.txtTextInput.Size = new System.Drawing.Size(800, 288);
            this.txtTextInput.TabIndex = 0;
            // 
            // btnFormatText
            // 
            this.btnFormatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormatText.Location = new System.Drawing.Point(646, 325);
            this.btnFormatText.Name = "btnFormatText";
            this.btnFormatText.Size = new System.Drawing.Size(142, 89);
            this.btnFormatText.TabIndex = 1;
            this.btnFormatText.Text = "Formatar";
            this.btnFormatText.UseVisualStyleBackColor = true;
            this.btnFormatText.Click += new System.EventHandler(this.btnFormatText_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(311, 121);
            this.txtLog.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Location = new System.Drawing.Point(2, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // Informações
            // 
            this.Informações.Controls.Add(this.lbxType);
            this.Informações.Controls.Add(this.label4);
            this.Informações.Controls.Add(this.txtUrl);
            this.Informações.Controls.Add(this.label3);
            this.Informações.Controls.Add(this.label2);
            this.Informações.Controls.Add(this.txtAuthor);
            this.Informações.Controls.Add(this.label1);
            this.Informações.Controls.Add(this.txtTitle);
            this.Informações.Location = new System.Drawing.Point(335, 298);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(282, 137);
            this.Informações.TabIndex = 4;
            this.Informações.TabStop = false;
            this.Informações.Text = "Informações";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(57, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(204, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Atuhor:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(57, 58);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(204, 20);
            this.txtAuthor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Url:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(57, 110);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(204, 20);
            this.txtUrl.TabIndex = 6;
            // 
            // lbxType
            // 
            this.lbxType.FormattingEnabled = true;
            this.lbxType.Location = new System.Drawing.Point(57, 84);
            this.lbxType.Name = "lbxType";
            this.lbxType.Size = new System.Drawing.Size(204, 17);
            this.lbxType.TabIndex = 8;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Informações);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFormatText);
            this.Controls.Add(this.txtTextInput);
            this.Name = "FrmPrincipal";
            this.Text = "FormatTextEbs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Informações.ResumeLayout(false);
            this.Informações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextInput;
        private System.Windows.Forms.Button btnFormatText;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Informações;
        private System.Windows.Forms.ListBox lbxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
    }
}

