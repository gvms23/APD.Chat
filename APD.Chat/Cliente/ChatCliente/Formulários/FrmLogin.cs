using System;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Controls;
using MaterialSkin;

namespace APD.Chat.Cliente
{
    public partial class FrmLogin : MaterialForm
    {
        public static Usuario User = new Usuario();
        public static Configuracao ConfigServidor = new Configuracao() { Servidor = "127.0.0.1", Porta = 8888};
        bool OsControlesEstaoVisiveis = false;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnEntrar.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public bool PingConfigs()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingReply respostaPing;
                respostaPing = ping.Send(txtIpServidor.Text);

                if (respostaPing.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        public FrmLogin()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;

            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = User.Login ?? "@";
            ControleServidorVisivel(false);
            txtIpServidor.Text = ConfigServidor.Servidor;
            txtPorta.Text = ConfigServidor.Porta.ToString();
        }

        public void GerarUsuario()
        {
            string[] AlfabetoOtan = new[] {"alpha",
                        "bravo", "charlie", "delta",
                        "echo", "foxtrot", "golf", "hotel",
                        "india", "juliett", "kilo", "lima",
                        "mike", "november", "oscar", "papa",
                        "quebec", "romeo","sierra","tango",
                        "uniform","victor", "whiskey",
                        "xray","yankee", "zulu"};

            Random rand = new Random();

            int index = rand.Next(0, AlfabetoOtan.Length);
            txtUsuario.Text = $"@{AlfabetoOtan[index]}{rand.Next(1, 2000)}";
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            TentarPing();
        }

        public void TentarPing()
        {
            if (!PingConfigs())
            {
                DialogResult dr = MessageBox.Show($"O servidor apontado não está respondendo ao ping, utilize outro endereço.", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Retry)
                    TentarPing();
            }
            else { ValidarBotaoEntrar(); }
        }

        public void ValidarBotaoEntrar()
        {
            try
            {
                //caso esteja vazio, crie um usuário
                if (txtUsuario.Text == string.Empty || txtUsuario.Text == "@")
                {
                    GerarUsuario();
                    return;
                }

                //enviando para o objeto as informações de login
                if (txtUsuario.Text.Contains("@"))
                    User.Login = $"{txtUsuario.Text}";
                else
                    User.Login = $"@{txtUsuario.Text}";

                User.DataUltimoLogin = DateTime.Now;

                //recebendo novamente as informações, caso o user tenha mexido.
                ConfigServidor.Servidor = txtIpServidor.Text;
                ConfigServidor.Porta = Convert.ToInt16(txtPorta.Text);

                Thread d = new Thread(() => Application.Run(new FrmPrincipal()));
                d.Start();
                Close();
            }
            catch (Exception mm)
            {
                MessageBox.Show($"Erro: {mm.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                GerarUsuario();
            }
        }

        private void BtnOpcoes_MouseHover(object sender, EventArgs e)
        {
            //criando uma caixinha de informação para quando o usuário colocar o mouse em cima da engrenagem
            ToolTip tt = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 300,

                ShowAlways = true
            };
            tt.SetToolTip(btnOpcoes, "Modificar servidor");
           
        }

        private void BtnOpcoes_Click(object sender, EventArgs e)
        {
            AlterarLayout();
        }

        private void AlterarLayout()
        {
            //deixa o formulário maior ou menor, mostrando ou escondendo as opções de servidor.
            if (OsControlesEstaoVisiveis)
                ControleServidorVisivel(false);
            else
                ControleServidorVisivel(true);
        }

        public void ControleServidorVisivel(bool valor)
        {
            if (valor == false)
                Size = new System.Drawing.Size(264, 205);
            else if (valor == true)
                Size = new System.Drawing.Size(264, 292);

            lblIpServidor.Visible = valor;
            txtIpServidor.Visible = valor;

            lblPorta.Visible = valor;
            txtPorta.Visible = valor;

            OsControlesEstaoVisiveis = valor;
        }
    }
}
