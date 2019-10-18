using System;

namespace ControleDeReservas.Excecoes
{
    class DominioExcecoes : ApplicationException
    {
        public DominioExcecoes(string mensagem) : base(mensagem)
        {

        }
    }
}
