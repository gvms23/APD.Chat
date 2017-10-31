namespace APD.Chat.Cliente
{
    partial class FrmLogin
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.btnEntrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblDevel = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.txtIpServidor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblIpServidor = new MaterialSkin.Controls.MaterialLabel();
            this.lblPorta = new MaterialSkin.Controls.MaterialLabel();
            this.txtPorta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(59, 101);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(137, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(55, 79);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário Chat:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.btnEntrar.Icon = null;
            this.btnEntrar.Location = new System.Drawing.Point(121, 130);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = false;
            this.btnEntrar.Size = new System.Drawing.Size(73, 36);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // lblDevel
            // 
            this.lblDevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDevel.AutoSize = true;
            this.lblDevel.Depth = 0;
            this.lblDevel.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDevel.Location = new System.Drawing.Point(12, 264);
            this.lblDevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDevel.Name = "lblDevel";
            this.lblDevel.Size = new System.Drawing.Size(235, 19);
            this.lblDevel.TabIndex = 4;
            this.lblDevel.Text = "Desenvolvido por: Gabriel Vicente";
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpcoes.BackgroundImage = global::APD.Chat.Cliente.Properties.Resources.engrenagem;
            this.btnOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpcoes.Location = new System.Drawing.Point(232, 65);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(29, 29);
            this.btnOpcoes.TabIndex = 5;
            this.btnOpcoes.UseVisualStyleBackColor = false;
            this.btnOpcoes.Click += new System.EventHandler(this.BtnOpcoes_Click);
            this.btnOpcoes.MouseHover += new System.EventHandler(this.BtnOpcoes_MouseHover);
            // 
            // txtIpServidor
            // 
            this.txtIpServidor.Depth = 0;
            this.txtIpServidor.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.txtIpServidor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtIpServidor.Hint = "";
            this.txtIpServidor.Location = new System.Drawing.Point(27, 217);
            this.txtIpServidor.MaxLength = 32767;
            this.txtIpServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIpServidor.Name = "txtIpServidor";
            this.txtIpServidor.PasswordChar = '\0';
            this.txtIpServidor.SelectedText = "";
            this.txtIpServidor.SelectionLength = 0;
            this.txtIpServidor.SelectionStart = 0;
            this.txtIpServidor.Size = new System.Drawing.Size(137, 23);
            this.txtIpServidor.TabIndex = 7;
            this.txtIpServidor.TabStop = false;
            this.txtIpServidor.UseSystemPasswordChar = false;
            this.txtIpServidor.Visible = false;
            // 
            // lblIpServidor
            // 
            this.lblIpServidor.AutoSize = true;
            this.lblIpServidor.Depth = 0;
            this.lblIpServidor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIpServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIpServidor.Location = new System.Drawing.Point(23, 195);
            this.lblIpServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIpServidor.Name = "lblIpServidor";
            this.lblIpServidor.Size = new System.Drawing.Size(64, 19);
            this.lblIpServidor.TabIndex = 8;
            this.lblIpServidor.Text = "Servidor";
            this.lblIpServidor.Visible = false;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Depth = 0;
            this.lblPorta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPorta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPorta.Location = new System.Drawing.Point(165, 195);
            this.lblPorta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(49, 19);
            this.lblPorta.TabIndex = 9;
            this.lblPorta.Text = "Porta:";
            this.lblPorta.Visible = false;
            // 
            // txtPorta
            // 
            this.txtPorta.Depth = 0;
            this.txtPorta.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.txtPorta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPorta.Hint = "";
            this.txtPorta.Location = new System.Drawing.Point(169, 217);
            this.txtPorta.MaxLength = 32767;
            this.txtPorta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.PasswordChar = '\0';
            this.txtPorta.SelectedText = "";
            this.txtPorta.SelectionLength = 0;
            this.txtPorta.SelectionStart = 0;
            this.txtPorta.Size = new System.Drawing.Size(65, 23);
            this.txtPorta.TabIndex = 10;
            this.txtPorta.TabStop = false;
            this.txtPorta.UseSystemPasswordChar = false;
            this.txtPorta.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 292);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblIpServidor);
            this.Controls.Add(this.txtIpServidor);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.lblDevel);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(264, 205);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrar;
        private MaterialSkin.Controls.MaterialLabel lblDevel;
        private System.Windows.Forms.Button btnOpcoes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIpServidor;
        private MaterialSkin.Controls.MaterialLabel lblIpServidor;
        private MaterialSkin.Controls.MaterialLabel lblPorta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPorta;
    }
}
