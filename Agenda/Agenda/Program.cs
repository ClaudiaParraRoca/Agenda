namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            ValidarOpcio();
        }

        static void MenuPrincipal()
        {
            string opcio = "╔═══════════════════════════╗\n" +
                           "║           Agenda          ║\n" +
                           "╠═══════════════════════════╣\n" +
                           "║1. Donar d'alta a l'usuari ║\n" +
                           "║2. Recuperar usuari        ║\n" +
                           "║3. Modificar usuari        ║\n" +
                           "║4. Eliminar usuari         ║\n" +
                           "║5. Mostrar agenda          ║\n" +
                           "║6. ordenar agenda          ║\n" +
                           "║Q. Sortir de l'agenda      ║\n" +
                           "╚═══════════════════════════╝\n";
            Console.WriteLine(opcio);
        }
        static void ValidarOpcio()
        {
            Console.Write("Introdueix una opcio --> ");
        }
    }
}
