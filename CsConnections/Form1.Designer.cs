namespace CsConnections
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstTime = new System.Windows.Forms.ListBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(306, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CsConnections";
            // 
            // lstTime
            // 
            this.lstTime.FormattingEnabled = true;
            this.lstTime.Location = new System.Drawing.Point(172, 60);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(558, 95);
            this.lstTime.TabIndex = 1;
            this.lstTime.SelectedValueChanged += new System.EventHandler(this.lstTime_SelectedValueChanged);
            // 
            // btn_copy
            // 
            this.btn_copy.FlatAppearance.BorderSize = 5;
            this.btn_copy.Location = new System.Drawing.Point(587, 162);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(142, 47);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "Área de transferência";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Location = new System.Drawing.Point(523, 163);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 23);
            this.lblTime.TabIndex = 4;
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(847, 231);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.lstTime);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "CsConnections";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstTime;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblTime;
    }
}

