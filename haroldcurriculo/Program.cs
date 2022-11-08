using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haroldcurriculo
{
    class Program
    {
        static void Main(string[] args)
        {
           string idade;
            string nome;
            string sobrenome;
            string naturalidade;
            string emprego1;
            string cargo1;
            string tempo1;
            string emprego2;
            string tempo2;
            string cargo2;
            string endereco;
            string formacao;



            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("digite seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine("digite a cidade onde nasceu");
            naturalidade = Console.ReadLine();

            Console.WriteLine("digite seu endereço");
            endereco = Console.ReadLine();

            Console.WriteLine("digite sua idade");
            idade = Console.ReadLine();

            Console.WriteLine("digite o nome da ultima empresa que trabalhou");
            emprego1 = Console.ReadLine();

            Console.WriteLine("digite o cargo que ocupava na ultima empresa");
            cargo1 = Console.ReadLine();

            Console.WriteLine("digite a quantidade de meses que trabalhou na ultima empresa");
            tempo1 = Console.ReadLine();

            Console.WriteLine("digite o nome da penultima empresa que trabalhou");
            emprego2 = Console.ReadLine();

            Console.WriteLine("digite o cargo que ocupava na penultima empresa");
            cargo2 = Console.ReadLine();

            Console.WriteLine("digite a quantidade de meses que trabalhou na penultima empresa");
            tempo2 = Console.ReadLine();

            Console.WriteLine("digite a sua formação academica");
            formacao = Console.ReadLine();

            Console.WriteLine("\r\nNome:");
            Console.WriteLine(nome + " " + sobrenome);
            Console.WriteLine("\r\nNaturalidade:");
            Console.WriteLine(naturalidade);
            Console.WriteLine("\r\nEndereço:");
            Console.WriteLine(endereco);
            Console.WriteLine("\r\nIdade:");
            Console.WriteLine(idade);
            Console.WriteLine("\r\nFormação academica:");
            Console.WriteLine(formacao);
            Console.WriteLine("\r\nÚltimo emprego:");
            Console.WriteLine(emprego1 + " / " + cargo1 + " / " + tempo1 + "meses");
            Console.WriteLine("\r\nPenultimo emprego:");
            Console.WriteLine(emprego2 + " / " + cargo2 + " / " + tempo2 + "meses");
            Console.ReadKey();

        }
    }
}
