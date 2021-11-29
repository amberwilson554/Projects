using System;

public class Art
{
	public void ConeArt(int numofstars)
    {
		string spaces = " ";

		for(int i = numofstars; i != 0; i--)
        {
			spaces += " ";
			Console.Write(spaces);
				for (int j = 0; j < numofstars; j++)
				{
				    Console.Write("");
				    Console.Write("*");    
				}
			Console.WriteLine("");
			numofstars = numofstars - 2;
			
			if(numofstars < 0)
            {
				break;
            }
		}
    }


	public void HourglassArt(int totalnumstars)
    {
		string spaces = " ";
		int checkodd = 0;
		int numofstarsbottom = 0;
		int numofstarstop = totalnumstars;
	
		while (numofstarstop > 0)
		{
			Console.WriteLine("");
			spaces += " ";
			Console.Write(spaces);

				for (int j = 0; j < numofstarstop; j++)
				{
					Console.Write("*");
				}

				if(numofstarstop >= 2)
				{
					numofstarstop = numofstarstop - 2;
				}
				else
				{
					numofstarsbottom = numofstarstop;
					numofstarstop = 0;
				}
		}
		checkodd = totalnumstars % 2;
		while (numofstarsbottom <= totalnumstars)
		{

			if (checkodd != 0)
			{
				Console.WriteLine("");
				Console.Write(spaces);

				spaces += " ";
				for (int k = 1; k <= numofstarsbottom; k++)
				{
					Console.Write("*");
				}
				if (spaces.Length > 1)
				{
					spaces = spaces.Remove(0, 2);
				}
				numofstarsbottom = numofstarsbottom + 2;
			}
			else
            {
				spaces += " ";
				Console.Write(spaces);
				
				for (int k = 1; k <= numofstarsbottom; k++)
				{
					Console.Write("*");
				}
				if (spaces.Length > 1)
				{
					Console.WriteLine("");
					spaces = spaces.Remove(0, 2);
				}
				numofstarsbottom = numofstarsbottom + 2;
			}

		}

	}

}
