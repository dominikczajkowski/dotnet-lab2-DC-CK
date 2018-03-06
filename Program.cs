using System;

namespace game_of_life
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			game g = new game();
			while (true) {
				g.next_step ();
				g.print ();
				Console.ReadKey ();
				Console.Clear ();
			}

		}
	}

	class game
	{
		private bool[,] arr = new bool[10, 10];
		private bool[,] arr2 = new bool[10, 10];

		public game()
		{
			for (int i = 0; i < 10; i++)
				for (int j = 0; j < 10; j++)
					arr [i, j] = false;
			arr [0, 0] = true;
			arr [0, 1] = true;
			arr [0, 2] = true;
			arr [3, 0] = true;
			arr [3, 1] = true;
			arr [3, 2] = true;
		}

		public void print()
		{
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					if (arr [i, j] == true)
						Console.Write ("O");
					else
						Console.Write (" ");
					
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
					if( i+1 <= 9)
					if(arr[i+1,j] == true)
						cnt++;
					if( j-1 >= 0)
					if(arr[i,j-1] == true)
						cnt++;
					if( j+1 <= 9)
					if(arr[i,j+1] == true)
						cnt++;
			if((j+1 <=9) && (i-1 >=0))
				if(arr[i-1,j+1])
				cnt++;
			if((j+1 <=9) && (i+1 <=9))
			if(arr[i+1,j+1])
				cnt++;
			if((j-1 >=0) && (i-1 >=0))
			if(arr[i-1,j-1])
				cnt++;
					
			if((j-1 >=0) && (i+1 <=9))
			if(arr[i+1,j-1])
				cnt++;






			return cnt;

		}
		public void next_step()
		{
			for (int i = 0; i < 10; i++) 
				for (int j = 0; j < 10; j++) 
				{
					if (arr [i, j] == true) {
						if (this.count_neighb (i, j) < 2 || this.count_neighb (i, j) > 3)
							arr2 [i, j] = false;
						if (this.count_neighb (i, j) == 2 || this.count_neighb (i, j) == 3)
							arr2 [i, j] = true;
						
						}
					if (arr [i, j] == false)
					if (this.count_neighb (i, j) == 3)
						arr2 [i, j] = true;
				}
			arr = arr2;
		}

	
	}
}

