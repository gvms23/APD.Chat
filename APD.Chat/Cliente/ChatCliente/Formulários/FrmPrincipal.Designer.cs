/*
 * Created by SharpDevelop.
 * User: Valeria
 * Date: 03/10/2017
 * Time: 09:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace APD.Chat.Cliente
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.txtMensagem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gpbRetorno = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new MaterialSkin.Controls.MaterialFlatButton();
            this.chkEnterEnviaMensagem = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblIpLocal = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.gpbRetorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Depth = 0;
            this.txtMensagem.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.txtMensagem.Hint = "";
            this.txtMensagem.Location = new System.Drawing.Point(40, 117);
            this.txtMensagem.MaxLength = 32767;
            this.txtMensagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.PasswordChar = '\0';
            this.txtMensagem.SelectedText = "";
            this.txtMensagem.SelectionLength = 0;
            this.txtMensagem.SelectionStart = 0;
            this.txtMensagem.Size = new System.Drawing.Size(389, 23);
            this.txtMensagem.TabIndex = 1;
            this.txtMensagem.TabStop = false;
            this.txtMensagem.UseSystemPasswordChar = false;
            this.txtMensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensagem_KeyDown);
            // 
            // gpbRetorno
            // 
            this.gpbRetorno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbRetorno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gpbRetorno.Controls.Add(this.txtInfo);
            this.gpbRetorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbRetorno.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.gpbRetorno.ForeColor = System.Drawing.Color.White;
            this.gpbRetorno.Location = new System.Drawing.Point(27, 270);
            this.gpbRetorno.Name = "gpbRetorno";
            this.gpbRetorno.Size = new System.Drawing.Size(402, 127);
            this.gpbRetorno.TabIndex = 3;
            this.gpbRetorno.TabStop = false;
            this.gpbRetorno.Text = "Histórico";
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.txtInfo.Location = new System.Drawing.Point(13, 22);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(377, 85);
            this.txtInfo.TabIndex = 4;
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviarMensagem.AutoSize = true;
            this.btnEnviarMensagem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarMensagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarMensagem.Depth = 0;
            this.btnEnviarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMensagem.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.btnEnviarMensagem.Icon = null;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(281, 179);
            this.btnEnviarMensagem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarMensagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Primary = false;
            this.btnEnviarMensagem.Size = new System.Drawing.Size(148, 36);
            this.btnEnviarMensagem.TabIndex = 6;
            this.btnEnviarMensagem.Text = "Enviar Mensagem";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.BtnEnviarMensagem_Click);
            // 
            // chkEnterEnviaMensagem
            // 
            this.chkEnterEnviaMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkEnterEnviaMensagem.AutoSize = true;
            this.chkEnterEnviaMensagem.BackColor = System.Drawing.SystemColors.Control;
            this.chkEnterEnviaMensagem.Checked = true;
            this.chkEnterEnviaMensagem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnterEnviaMensagem.Depth = 0;
            this.chkEnterEnviaMensagem.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEnterEnviaMensagem.ForeColor = System.Drawing.Color.Black;
            this.chkEnterEnviaMensagem.Location = new System.Drawing.Point(221, 143);
            this.chkEnterEnviaMensagem.Margin = new System.Windows.Forms.Padding(0);
            this.chkEnterEnviaMensagem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEnterEnviaMensagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEnterEnviaMensagem.Name = "chkEnterEnviaMensagem";
            this.chkEnterEnviaMensagem.Ripple = true;
            this.chkEnterEnviaMensagem.Size = new System.Drawing.Size(208, 30);
            this.chkEnterEnviaMensagem.TabIndex = 7;
            this.chkEnterEnviaMensagem.Text = "Tecla Enter envia mensagem";
            this.chkEnterEnviaMensagem.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(12, 436);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 19);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuário: ";
            // 
            // lblIpLocal
            // 
            this.lblIpLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIpLocal.AutoSize = true;
            this.lblIpLocal.Depth = 0;
            this.lblIpLocal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIpLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIpLocal.Location = new System.Drawing.Point(350, 437);
            this.lblIpLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIpLocal.Name = "lblIpLocal";
            this.lblIpLocal.Size = new System.Drawing.Size(30, 19);
            this.lblIpLocal.TabIndex = 8;
            this.lblIpLocal.Text = "IP: ";
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpcoes.BackgroundImage = global::APD.Chat.Cliente.Properties.Resources.engrenagem;
            this.btnOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpcoes.Location = new System.Drawing.Point(452, 66);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(29, 29);
            this.btnOpcoes.TabIndex = 9;
            this.btnOpcoes.UseVisualStyleBackColor = false;
            this.btnOpcoes.Click += new System.EventHandler(this.BtnOpcoes_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Mensagem:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(483, 460);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.chkEnterEnviaMensagem);
            this.Controls.Add(this.lblIpLocal);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.gpbRetorno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(483, 436);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat | GabrielVicente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gpbRetorno.ResumeLayout(false);
            this.gpbRetorno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private MaterialSkin.Controls.MaterialSingleLineTextField txtMensagem;
        private System.Windows.Forms.GroupBox gpbRetorno;
        private System.Windows.Forms.TextBox txtInfo;
        private MaterialSkin.Controls.MaterialFlatButton btnEnviarMensagem;
        private MaterialSkin.Controls.MaterialCheckBox chkEnterEnviaMensagem;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblIpLocal;
        private System.Windows.Forms.Button btnOpcoes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
