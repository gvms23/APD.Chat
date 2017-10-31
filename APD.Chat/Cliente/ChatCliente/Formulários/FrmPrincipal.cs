using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;
using System.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;

namespace APD.Chat.Cliente
{
    /// <summary>
    /// Formulário Principal
    /// </summary>
    public partial class FrmPrincipal : MaterialForm
    {

        TcpClient clientSocket;
        public FrmPrincipal()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            //skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey300, 
            //    Primary.LightBlue500, Primary.LightBlue400, 
            //    Accent.LightGreen400, TextShade.WHITE);

            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    switch (keyData)
        //    {
        //        case Keys.Enter:
        //            if (chkEnterEnviaMensagem.Checked)
        //            {
        //                btnEnviarMensagem.PerformClick();
        //                break;
        //            }
        //            break;
        //    }

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        public static string GetIpLocal()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Não há adaptadores de rede que utilizem IPv4.");
        }

        void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text += FrmLogin.User.Login ?? "Indefinido";
            lblIpLocal.Text += GetIpLocal();
            MensagemParaCliente("Cliente iniciado");
        }

        void BtnEnviarMensagem_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket = new TcpClient();
                clientSocket.Connect(FrmLogin.ConfigServidor.Servidor, FrmLogin.ConfigServidor.Porta);

                if (clientSocket.Connected == false)
                    throw new Exception("Não foi possível enviar a mensagem: Cliente desconectado.");

                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = Encoding.UTF8.GetBytes($"{FrmLogin.User.Login}: {txtMensagem.Text}$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[65536];
                serverStream.Read(inStream, 0, clientSocket.ReceiveBufferSize);
                string returndata = Encoding.UTF8.GetString(inStream);
                MensagemParaCliente(returndata);
                txtMensagem.Text = "";
                txtMensagem.Focus();
            }
            catch (Exception mm)
            {
                MessageBox.Show($"Erro: {mm.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MensagemParaCliente(string mensagem)
        {
            if (txtInfo.Text != string.Empty)
                txtInfo.Text += $@"{Environment.NewLine}{mensagem}";

            else
                txtInfo.Text = ">> " + mensagem;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void BtnOpcoes_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Para configurar o servidor você sairá desse formulário e irá para a tela de login.\nDeseja realmente proesseguir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Thread d = new Thread(() => Application.Run(new FrmLogin()));
                d.Start();
                Close();
            }
        }

        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkEnterEnviaMensagem.Checked)
                    btnEnviarMensagem.PerformClick();

                e.SuppressKeyPress = true;
            }
        }
    }
}

