
using System;

public class Jeu
{



	public static void copytab()
	{
		int i, j;
		for (i = 0; i != 17; i++)
		{
			for (j = 0; j != 17; j++)
			{
				IJeu.tabl[i, j] = IJeu.newtabl[i, j];
				IJeu.newtabl[i, j] = false;
			}
		}
	}

	public static bool verif(int x, int y)
	{
		bool cvie;
		int centourag = 0, i, j;
		cvie = IJeu.tabl[x, y];
		for (i = -1; i != 2; i++)
		{

			for (j = -1; j != 2; j++)
			{

				if ((i != 0) || (j != 0))
				{

					if (IJeu.tabl[x + i, y + j])
					{
						centourag++;
					}

				}
			}
		}

		if ((centourag == 3) || (centourag == 4) || (centourag == 4) && cvie)
		{
			return true;
		}
		if ((centourag == 3) && (!cvie))
		{
			return true;
		}
		return false;
	}
	public static void remptabl()
	{
		int rdm;
		Random rand = new Random();

		for (int i = 1; i != 17; i++)
		{

			for (int j = 1; j != 17; j++)
			{

				rdm = rand.Next(1, 3);

				if (rdm == 1)
				{
					IJeu.tabl[i, j] = true;
				}
			}
		}
	}
	public static void maketab(double speed)
	{

		long f = 0;
		string strctab = "";

		for (int h = 0; h != 31; h++)
		{
			strctab += "*";
			strctab += "\n";
		}

		for (int i = 1; i != 17; i++)
		{

			for (int j = 1; j != 17; j++)
			{

				if (IJeu.tabl[i, j])
				{
					strctab += "|O";
				}

				else
				{
					strctab += "| ";
				}
			}
			strctab += "\n";
		}
		strctab += "\n\n\n\n\n\n\n";
		Console.Write(strctab);

		for (int u = 0; u != speed; u++)
		{
			f--;
		}
	}
}