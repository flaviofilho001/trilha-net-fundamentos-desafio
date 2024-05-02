using DesafioFundamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


Console.OutputEncoding = System.Text.Encoding.UTF8;



Estacionamento es = new Estacionamento();

//Abre a lista de veiculos
List<string> veiculos = new List<string>();

Console.WriteLine("Seja bem-vindo ao estacionamento do Flávio: ");
Console.WriteLine("Tiquete custa: ");
int tiquete = int.Parse(Console.ReadLine());
Console.WriteLine("Cada hora estacionado custa: ");
int custo = int.Parse(Console.ReadLine());
while (true)
{
    es.Menu(veiculos, tiquete, custo);
}