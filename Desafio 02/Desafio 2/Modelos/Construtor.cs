using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2.Modelos
{
    public interface IConstructors
    {
        void ExibirConstrutor();
    }
    public class Constructors : IConstructors
    {
        public Uri? url { get; set; }
        public string? name { get; set; }
        public string? nationality { get; set; }

        public void ExibirConstrutor(){
            System.Console.WriteLine($"Nome da equipe: {name}");
            System.Console.WriteLine($"Nacionalidade: {nationality}");
            System.Console.WriteLine($"Biografia no Wikipedia: {url}");
        }
    }
}