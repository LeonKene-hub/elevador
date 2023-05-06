using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elevador
{
    public abstract class Elevador
    {
        public int Pessoas { get; private set; } = 0;
        public int Andar { get; private set; } = 0;
        private int TotalAndares { get; set; } = 25;
        private int Capacidade { get; set; } = 7;

        //entrar
        public void Entrar(int pessoas)
        {
            if (pessoas <= this.Capacidade)
            {
                this.Pessoas += pessoas;
                Console.WriteLine($"Atualmente tem {this.Pessoas} pessoas no elevador");
            }
            else
            {
                Console.WriteLine($"Elevador cheio, sem espaço para mais pessoas");
            }
        }
        //sair
        public void Sair(int pessoas)
        {
            if (pessoas <= this.Pessoas)
            {
                this.Pessoas -= pessoas;
                Console.WriteLine($"Atualmente tem {this.Pessoas} no elevador");
            }
            else
            {
                Console.WriteLine($"O elevador já está vazio");
            }
        }
        //subir
        public void Subir(int Andar)
        {
            if (this.Pessoas > this.Capacidade)
            {
                Console.WriteLine($"Este elevador não pode operar com essa quantidade de pessoas");
            }
            else
            {
                if (Andar <= this.TotalAndares)
                {
                    this.Andar += Andar;
                    Console.WriteLine($"Subindo para o {Andar}º andar");
                }
                else
                {
                    Console.WriteLine($"Este andar não existe");
                }
            }
        }
        //descer
        public void Descer(int Andar)
        {
            if (this.Pessoas > this.Capacidade)
            {
                Console.WriteLine($"Este elevador não pode operar com essa quantidade de pessoas");
            }
            else
            {
                if (Andar <= this.TotalAndares)
                {
                    this.Andar -= Andar;
                    Console.WriteLine($"Descendo para o {Andar}º andar");
                }
                else
                {
                    Console.WriteLine($"Este andar não existe");
                }
            }
        }
    }
}