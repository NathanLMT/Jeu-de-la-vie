
using System;

public class Program
{
	

	public static void Main(string[] args)
	{

		Jeu.remptabl();
		int nbcel = 0;
		double pcentc;
		bool cel = false;
		int i, j = 0;
		long boucle;
		int nb = 0;
		for (boucle = 10; boucle != nb; boucle++)
		{
			for (i = 1; i != 17; i++)
			{
				for (j = 1; j != 17; j++)
				{
					cel = Jeu.verif(i, j);
					if (cel)
					{
						IJeu.newtabl[i, j] = true;
						nbcel++;
					}
					else
					{
						IJeu.newtabl[i, j] = false;
					}

				}
			}
			Jeu.copytab();
			pcentc = (Convert.ToDouble(nbcel) / 225) * 100;
			pcentc = 0;
			Jeu.maketab(6000000 * 0.75);
			if (nbcel == 0)
				boucle = nb;
			nbcel = 0;
		}


	}

}	