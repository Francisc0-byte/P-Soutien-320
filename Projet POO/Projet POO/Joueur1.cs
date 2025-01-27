using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO
{
    class Joueur

    {
		private string[] _representation;

		public string[] Representation
		{
			get { return _representation; }
			set { _representation = value; }
		}
		public Joueur()
		{
			//this.Representation = "";
			
		}
		public string affichageJoueur()
		{
            // Positionner le curseur tout en bas de la console
            Console.SetCursorPosition(Console.WindowWidth - 130, consoleHeight - 1);
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                    Console.WriteLine("  o  ");
				if (i == 1) Console.WriteLine(" / ¦ \ ");
            }
        }
    }
}
