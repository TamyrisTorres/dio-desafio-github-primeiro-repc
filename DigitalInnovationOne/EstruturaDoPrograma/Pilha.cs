using System;

namespace DigitalInnovationOne
{
    public class Pilha
    {
        Posicao primeiro;

        public void Empilhar(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilhar()
        {
            if(primeiro == null)
            {
                throw new InvalidOperationException();
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao
        {
            public Posicao proximo;
            
            public object item;

            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}