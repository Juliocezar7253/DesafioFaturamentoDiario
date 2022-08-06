/*
Dado um vetor que guarda o valor de faturamento diário de uma distribuidora de todos os dias de um ano, faça um programa, na linguagem que desejar, que calcule e retorne:
•	O menor valor de faturamento ocorrido em um dia do ano;
•	O maior valor de faturamento ocorrido em um dia do ano;
•	Número de dias no ano em que o valor de faturamento diário foi superior à média anual.

a)	Considerar o vetor já carregado com as informações de valor de faturamento. 
b)	Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média.
c)	Utilize o algoritmo mais veloz que puder definir.
*/
using System;
namespace Faturamento { 
    public class Faturamento { 

        static List<FaturamentoDiario> fat = new List<FaturamentoDiario>();

        public static void Main(string[] args) => calculus();

        static void calculus() {
            var total = 0.0;
            var x = 0; // número de dias em que valor > média 
            
            var dias = 0; // total de dias

            var maior = fat.Max();
            var menor = fat.Min();
            
            // definindo dias e faturamento total
            fat.ForEach(f => {
                if (f.Valor != 0) {
                    total += f.Valor;
                    dias = fat.Count(); 
                }
            });
            
            var media =  total / dias; 
            
            // definindo o número de dias
            foreach (var aux in fat) {
                if (aux.Valor > media) 
                    x += 1;
            }

            global::System.Console.WriteLine(
                  $"Maior valor: $ {maior}" + "\n"
                + $"Menor valor: $ {menor}" + "\n"
                + $"Número de dias valor > Media: {x}"
            );
        }
    }

    public class FaturamentoDiario { 
        public int Dia { get; set; }
        public double Valor { get; set; }

        public FaturamentoDiario(double valor, int dia) {
            this.Valor = valor;
            this.Dia = dia;
        }
    }
}


