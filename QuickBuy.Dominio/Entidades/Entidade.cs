using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            // se _mensagensValidacao for nula, ele retorna uma instância vazia
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validade();
        

    }
}
