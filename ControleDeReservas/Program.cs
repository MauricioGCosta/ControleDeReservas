using System;
using ControleDeReservas.Entidades;
using ControleDeReservas.Excecoes;

namespace ControleDeReservas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data de entrada (DD/MM/AAAA): ");
                DateTime dataEntrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saída (DD/MM/AAAA): ");
                DateTime dataSaida = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numQuarto, dataEntrada, dataSaida);

                Console.WriteLine();
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com as datas para atualização da reserva: ");
                Console.Write("Data de entrada (DD/MM/AAAA): ");
                dataEntrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saída (DD/MM/AAAA): ");
                dataSaida = DateTime.Parse(Console.ReadLine());

                reserva.AtualizaReserva(dataEntrada, dataSaida);
                Console.WriteLine();
                Console.WriteLine("Reserva: " + reserva);
            }
            catch (DominioExcecoes e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro genérico na aplicação, favor entrar em contato com o responsável pelo sistema.");
            }
        }
    }
}
