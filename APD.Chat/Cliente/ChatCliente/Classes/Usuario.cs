using System;
namespace APD.Chat.Cliente
{
    /// <summary>
    /// Classe de Usuário que envia a mensagem.
    /// </summary>
    public class Usuario
	{
        /// <summary>
        /// Login do Usuário.
        /// </summary>
        public string Login { get; set; }
        public DateTime DataUltimoLogin { get; set; }
    }
}
