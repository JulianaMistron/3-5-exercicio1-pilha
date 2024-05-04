/*1.dados duas pilhas p1 e p2 q armazenam numeros inteiros, faça um programa q contenha as seguintes funções:
a.uma fnçao para testar se as duas pilhas sao iguais(de tamanho), caso nao forem, informe qual é a maior.
b. uma funçao q forneça o maior , o menor e a media aritmetica dos elementos da pilha(troca a pilha por vetor)
c. uma funcao para transferir os elementos da pilha q eu informar para uma pilha auxiliar e mostrar
d. uma funçao para retornar a qtde de elementos impares da pilhas, informando quais sao.
e. uma funçao para retornar a qtde de elementos pares da pilhas, informando quais sao.*/

using _3_5_exercicio1_pilha_fila;

PilhaNumero minhaPilha1 = new PilhaNumero();
PilhaNumero minhaPilha2 = new PilhaNumero();
PilhaNumero minhaPilhaAuxiliar = new PilhaNumero();


int opc;
do
{
    Console.WriteLine("\n>>>MENU PRINCIPAL - PILHA DE NÚMEROS<<<");
    Console.WriteLine("Opções:");
    Console.WriteLine("1 - Inserir número na pilha 1");
    Console.WriteLine("2 - Inserir número na pilha 2");
    Console.WriteLine("3 - Remover número na pilha 1");
    Console.WriteLine("4 - Remover número na pilha 2");
    Console.WriteLine("5 - Imprimir pilha 1");
    Console.WriteLine("6 - Imprimir pilha 2");
    Console.WriteLine("7 - Comparar o tamanho das pilhas");
    Console.WriteLine("8 - Calcular para pilha 1: média, menor e maior número");
    Console.WriteLine("9 - Calcular para pilha 2: média, menor e maior número");
    Console.WriteLine("10 - Trocar elementos de pilha 1");
    Console.WriteLine("11 - Trocar elementos de pilha 2");
    Console.WriteLine("12 - Ímpares pilha 1");
    Console.WriteLine("13 - Ímpares pilha 2");
    Console.WriteLine("14 - Pares pilha 1");
    Console.WriteLine("15 - Pares pilha 2");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Informe a opção desejada: \b\b");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            minhaPilha1.push(cadastro_numero());
            break;
        case 2:
            minhaPilha2.push(cadastro_numero());
            break;
        case 3:
            minhaPilha1.pop();
            break;
        case 4:
            minhaPilha2.pop();
            break;
        case 5:
            minhaPilha1.print();
            break;
        case 6:
            minhaPilha2.print();
            break;
        case 7:
            CompararTamanhos(minhaPilha1, minhaPilha2);
            break;
        case 8:
            minhaPilha1.Calcular();
            break;
        case 9:
            minhaPilha2.Calcular();
            break;
        case 10:
            minhaPilha1.TransferirImprimir(minhaPilhaAuxiliar);
            Console.WriteLine("Início da impressão da pilha auxiliar: ");
            minhaPilhaAuxiliar.print();
            break;
        case 11:
            minhaPilha2.TransferirImprimir(minhaPilhaAuxiliar);
            Console.WriteLine("Início da impressão da pilha auxiliar: ");
            minhaPilhaAuxiliar.print();
            break;
        case 12:
            minhaPilha1.Impares();
            break;
        case 13:
            minhaPilha2.Impares();
            break;
        case 14:
            minhaPilha1.Pares();
            break;
        case 15:
            minhaPilha2.Pares();
            break;
        case 0:
            Console.WriteLine("Fim do programa :)");
            break;
        default:
            Console.WriteLine("Opção inexistente");
            break;
    }
} while (opc != 0);

static Numero cadastro_numero()
{
    int numero;
    Console.WriteLine("\nInforme o número");
    numero = int.Parse(Console.ReadLine());
    return new Numero(numero);
}
static void CompararTamanhos(PilhaNumero minhapilha1, PilhaNumero minhapilha2)
{
    int tamanhoPilha1 = minhapilha1.quantidade();
    int tamanhoPilha2 = minhapilha2.quantidade();

    if (tamanhoPilha1 == tamanhoPilha2)
    {
        Console.WriteLine("As pilhas têm o mesmo tamanho.");
    }
    else if (tamanhoPilha1 > tamanhoPilha2)
    {
        Console.WriteLine("A pilha 1 é maior que a pilha 2.");
    }
    else
    {
        Console.WriteLine("A pilha 2 é maior que a pilha 1.");
    }
}