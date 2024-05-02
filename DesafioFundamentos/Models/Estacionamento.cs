using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public bool Teste;

        public void Menu(List<string> lista, int tiquete, int custo)
        {

            Console.WriteLine("Digite a sua opção: ");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            Opcoes(lista, tiquete, custo);
        }

        public void Opcoes(List<string> veiculos, int tiquete, int custo)
        {

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: Cadastrar(veiculos, tiquete, custo); break;
                case 2: Remover(veiculos, tiquete, custo); break;
                case 3: Listar(veiculos, tiquete, custo); break;
                case 4: Environment.Exit(4); break;
                default: Menu(veiculos, tiquete, custo); break;
            }


        }
        public void Cadastrar(List<string> lista, int tiquete, int custo)
        {

            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            lista.Add(placa);

            Menu(lista, tiquete, custo);

        }

        public void Remover(List<string> lista, int tiquete, int custo)
        {


            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Veículo {i} = {lista[i]}");
            }
            Console.WriteLine("Digite a posição do veículo a ser removido: ");
            int posicao = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto tempo ficou estacionado");
            double tempo = double.Parse(Console.ReadLine());
            double valortotal = tiquete + (tempo * custo);

            if (lista.Contains(lista[posicao]))
            {
                Console.WriteLine("Carro da placa " + lista[posicao] + " e valor total: R$ " + valortotal);
                lista.Remove(lista[posicao]);

            }
            else
            {
                Console.WriteLine("Esse veículo não está no sistema. Insira novamente: ");
                Remover(lista, tiquete, custo);
            }


            Menu(lista, tiquete, custo);
        }

        public void Listar(List<string> lista, int tiquete, int custo)
        {
            Console.WriteLine("Lista de Veículos");
            Console.WriteLine(" ");
            int contador = 0;
            foreach (string i in lista)
            {
                Console.Write("Veiculo " + contador + ": ");
                Console.WriteLine(i);
                contador++;

            }
            Console.WriteLine(" ");

            Menu(lista, tiquete, custo);
        }
    }
}
