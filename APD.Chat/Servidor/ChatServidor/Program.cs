using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace APD.Chat.Servidor
{
    class Program
    {
        public static int requestCount = 0;
        private static void ThreadProc(object obj)
        {
            var clientSocket = (TcpClient)obj;
            requestCount = 0;
            try
            {
                requestCount++;
                /* GetStream retorna um NetworkStream que você pode usar para enviar e receber dados. A classe NetworkStream herda da classe Stream , que fornece uma rica coleção de métodos e propriedades 
                 usadas para facilitar as comunicações de rede.*/
                NetworkStream networkStream = clientSocket.GetStream();
                byte[] bytesFrom = new byte[65536];
                /* Um tamanho de buffer maior reduz potencialmente o número de confirmações vazias (pacotes TCP sem porção de dados), 
                 mas também pode atrasar o reconhecimento de dificuldades de conexão. Considere aumentar o tamanho do buffer se você 
                estiver transferindo arquivos grandes, ou estiver usando
                 uma conexão de alta largura de banda, alta latência (como um provedor de banda larga por satélite).*/
                networkStream.Read(bytesFrom, 0, clientSocket.ReceiveBufferSize);

                string mensagemCliente = Encoding.UTF8.GetString(bytesFrom);

                mensagemCliente = mensagemCliente.Substring(0, mensagemCliente.IndexOf("$"));

                string serverResponse = $"{DateTime.Now}: {mensagemCliente}";
             
                Byte[] sendBytes = Encoding.UTF8.GetBytes(serverResponse);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                /*Libera os dados do fluxo. Este método está reservado para uso futuro.*/
                networkStream.Flush();
                Console.WriteLine(" >> " + serverResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //finally
            //{
            //    clientSocket.Close();
            //}
        }

        public static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);//cria socket para gerenciar mensagens

            //Só declaro um socket
            TcpClient clientSocket = default(TcpClient);// fornece conexão de cliente de serviço TCP

            serverSocket.Start();

            Console.WriteLine(">> Servidor Ativo.");

            while (true) // Add your exit flag here
            {
                //Atribuo o socket para tantos que precisarem
                clientSocket = serverSocket.AcceptTcpClient();

                //Envio para a fila o cliente em questão
                ThreadPool.QueueUserWorkItem(ThreadProc, clientSocket);
            }

        }

    }
}