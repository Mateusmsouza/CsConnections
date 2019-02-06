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
            this.cbk_acumula = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparConnectionstxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(212, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CsConnections";
            // 
            // lstTime
            // 
            this.lstTime.FormattingEnabled = true;
            this.lstTime.Location = new System.Drawing.Point(136, 90);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(385, 95);
            this.lstTime.TabIndex = 1;
            this.lstTime.SelectedValueChanged += new System.EventHandler(this.lstTime_SelectedValueChanged);
            // 
            // btn_copy
            // 
            this.btn_copy.FlatAppearance.BorderSize = 5;
            this.btn_copy.Location = new System.Drawing.Point(379, 188);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(142, 47);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "Área de transferência";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // cbk_acumula
            // 
            this.cbk_acumula.AutoSize = true;
            this.cbk_acumula.Location = new System.Drawing.Point(136, 191);
            this.cbk_acumula.Name = "cbk_acumula";
            this.cbk_acumula.Size = new System.Drawing.Size(88, 17);
            this.cbk_acumula.TabIndex = 3;
            this.cbk_acumula.Text = "Multi-seleção";
            this.cbk_acumula.UseVisualStyleBackColor = true;
            this.cbk_acumula.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Window;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Location = new System.Drawing.Point(315, 191);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 23);
            this.lblTime.TabIndex = 4;
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparConnectionstxtToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // limparConnectionstxtToolStripMenuItem
            // 
            this.limparConnectionstxtToolStripMenuItem.Name = "limparConnectionstxtToolStripMenuItem";
            this.limparConnectionstxtToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.limparConnectionstxtToolStripMenuItem.Text = "Limpar Connections.txt";
            this.limparConnectionstxtToolStripMenuItem.Click += new System.EventHandler(this.limparConnectionstxtToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 260);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbk_acumula);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.lstTime);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "CsConnections";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstTime;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.CheckBox cbk_acumula;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparConnectionstxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

