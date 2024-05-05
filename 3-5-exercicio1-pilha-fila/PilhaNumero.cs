
using System.Xml.Linq;

namespace _3_5_exercicio1_pilha_fila
{
    internal class PilhaNumero
    {
        Numero topo;
        public PilhaNumero()
        {
            topo = null;
        }
        public void push(Numero aux)
        {
            if (vazia() == true)
                topo = aux;
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }
        bool vazia()
        {
            if (topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void print()
        {
            Numero aux = topo;
            if (vazia())
            {
                Console.WriteLine("Pilha vazia!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);

                Console.WriteLine("Fim da impressão!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine("Pilha vazia! Impossível remover!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                topo = topo.getAnterior();
            }
        }

        public int quantidade()
        {
            Numero aux = topo;
            if (vazia())
            {
                return 0;
            }
            else
            {
                int cont = 0;
                do
                {
                    cont++;
                    aux = aux.getAnterior();
                } while (aux != null);
                return cont;
            }
        }

          public void Calcular()
        {
            Numero aux = topo;
            int size = this.quantidade();
            int indice = 0;
            int soma = 0;
            int maiorNumero = 0;
            int menorNumero = Int32.MaxValue;
            float media = 0;


            if (vazia())
            {
                Console.WriteLine("Pilha vazia!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {                 
                    // média
                    soma += aux.getValor();
                    indice++;

                    // menor número
                    if (menorNumero > aux.getValor())
                        menorNumero = aux.getValor();

                    // maior número
                    if (maiorNumero < aux.getValor())
                        maiorNumero = aux.getValor();

                    aux = aux.getAnterior();
                } while (aux != null);

                media = ((float)soma / (float)size);
                Console.WriteLine("\nMédia : " + media);
                Console.WriteLine("\nMenor número da pilha : " + menorNumero);
                Console.WriteLine("\nMaior número da pilha : " + maiorNumero);
            }
        }

        public void TransferirImprimir(PilhaNumero minhaPilhaAuxiliar)
        {
            Numero aux = topo;
            minhaPilhaAuxiliar.push(aux);
            if (vazia())
            {
                Console.WriteLine("Pilha vazia!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    pop();
                    aux = topo;
                } while (aux != null);
            }
        }
        public void Impares()
        {
            Numero aux = topo;
            int quantidadeImpares = 0;

            Console.WriteLine("Elementos ímpares:");

            while (aux != null)
            {
                int valor = aux.getValor();
                if (valor % 2 != 0) 
                {
                    quantidadeImpares++; 
                    Console.WriteLine(valor); 
                }
                aux = aux.getAnterior();
            }

            Console.WriteLine("Quantidade de números ímpares: " + quantidadeImpares); 
        }
        public void Pares()
        {
            Numero aux = topo;
            int quantidadePares = 0;

            Console.WriteLine("Elementos pares:");

            while (aux != null)
            {
                int valor = aux.getValor();
                if (valor % 2 == 0)
                {
                    quantidadePares++;
                    Console.WriteLine(valor);
                }
                aux = aux.getAnterior();
            }

            Console.WriteLine("Quantidade de números pares: " + quantidadePares);
        }

    }
}