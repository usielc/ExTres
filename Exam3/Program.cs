using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exam3
{
    public class Contador
    {
        public char Letra { get; set; }
        public int Repeticiones { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cadena= new string("iamastriiiiiingwaitwaaaaaaaaaaaaaatttt");
            var lista = new List<Contador>();
            foreach (var caracter in cadena)
            {
                if(lista.Count==0)
                {
                    lista.Add(new Contador(){Letra=caracter, Repeticiones=1});
                }
                else
                {
                    var elemento = lista.Where(p => p.Letra == caracter);
                    var selected = elemento.FirstOrDefault();
                    if (selected != null)
                    {
                        selected.Repeticiones++;
                    }
                    else
                    {
                        lista.Add(new Contador() {Letra = caracter, Repeticiones = 1});
                    }
                }
            }

            foreach (var contador in lista)
            {
                Console.WriteLine("Letra: {0} Repeticiones:{1}",contador.Letra, contador.Repeticiones);
            }

            var repsMax = lista.Select(x => x.Repeticiones).Max();
            var letra = lista.FirstOrDefault(x => x.Repeticiones == repsMax);

            Console.WriteLine("Maximo: {0} Repeticiones: {1}",letra?.Letra, repsMax);
            Console.Read();
        }
    }
}
