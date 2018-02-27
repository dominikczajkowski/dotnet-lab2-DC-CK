using System;

namespace game_of_life
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			game g = new game();
			g.print ();
		}
	}

	class game
	{
		private bool[,] arr = new bool[3, 3];
		private bool[,] arr2 = new bool[3, 3];

		public game()
		{
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					arr [i, j] = false;
			arr [0, 0] = true;
			arr [0, 1] = true;
			arr [0, 2] = true;
		}

		public void print()
		{
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					if (arr [i, j] == true)
						Console.Write ("O");
					else
						Console.Write ("X");
					
				}
				Console.WriteLine ("");
			}
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {

					Console.Write (this.count_neighb(i,j));


				}
				Console.WriteLine ("");
			}
		}

		private int count_neighb(int i, int j)
		{
			int cnt = 0;

					if( i-1 >=0)
					if(arr[i-1,j] == true)
						cnt++;
					if( i+1 <= 2)
					if(arr[i+1,j] == true)
						cnt++;
					if( j-1 >= 0)
					if(arr[i,j-1] == true)
						cnt++;
					if( j+1 <= 2)
					if(arr[i,j+1] == true)
						cnt++;
			if((j+1 <=2) && (i-1 >=0))
				if(arr[i-1,j+1])
				cnt++;
			if((j+1 <=2) && (i+1 <=2))
			if(arr[i+1,j+1])
				cnt++;
			if((j-1 >=0) && (i-1 >=0))
			if(arr[i-1,j-1])
				cnt++;
					
			if((j-1 >=0) && (i+1 <=2))
			if(arr[i+1,j-1])
				cnt++;






			return cnt;

		}
		private void next_step()
		{

		}

	
	}
}

