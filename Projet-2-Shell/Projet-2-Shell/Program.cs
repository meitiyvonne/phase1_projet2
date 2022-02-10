using System;

namespace Projet_2_Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        private void Start()
        {

        }

        private void Afficher()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Veuillez choisir le jeu à jouer:");
            Console.WriteLine("1- Roche/papier/ciseau   2- La devinette   3- Quitter");
            Console.WriteLine("----------------------------------------------------");
        }

        private void JouerARochePapierCiseau()
        {

        }

        private bool IsAnotherGame()
        {
            return false;
        }


        private string GetUserChoice()
        {
            return null;
        }
        private void ValidateWinner(string userChoice, string cpuChoice)
        {

        }

        private string GetComputerChoice()
        {
            return null;
        }

        private void JouerADevinette()
        {

        }

        private void AfficherResultatGame(bool isFound, string fruitToFind)
        {

        }

        private bool IsFruitPlayerGood(string fruitPlayer, string fruitToFind)
        {
            return false;
        }

        private string GetFruitWithout3Letters(string fruit)
        {
            return null;
        }

        private int[] GetThreeRandomNumber(string fruit)
        {
            return null;
        }

        private string GetFruit()
        {
            return null;
        }
    }
}
