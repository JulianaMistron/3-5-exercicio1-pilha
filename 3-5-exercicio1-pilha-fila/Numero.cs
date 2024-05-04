

namespace _3_5_exercicio1_pilha_fila
{
    internal class Numero
    {
        int numero;
        int valor;
        Numero anterior;

        public Numero(int numero)
        {
            this.numero = numero;
            this.anterior = null;
        }
        public override string? ToString()
        {
            return "\n\n>>>>NÚMERO: " + numero;
        }
        public void setAnterior(Numero numero)
        {
            anterior = numero;
        }
        public Numero getAnterior()
        {
            return anterior;
        }
        public int getValor()
        {
            return numero;
        }

    }
}