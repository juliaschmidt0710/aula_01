using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Calcular IMC");
            Console.WriteLine("------------------------");

            Console.WriteLine("Informe o seu peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            calcularImc(peso, altura);

            static void calcularImc(float peso, float altura)
            {
                float imc = peso / (altura * altura);
  
                Console.WriteLine(@$"Seu imc é= {imc}");
          
                if (imc < 18)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                if (imc >= 18 && imc < 25)
                {
                    Console.WriteLine("Normal");
                }
                else if (imc >= 25 && imc < 30)
                {
                    Console.WriteLine("Obesidade");
                }
                else if (imc >= 30 && imc < 35)
                {
                    Console.WriteLine("Obesidade nível I");
                }
                else
                {
                    Console.WriteLine("Obesidade nível II");
                }

            }

        }


    }
}
