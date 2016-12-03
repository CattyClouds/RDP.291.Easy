using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP._291.Easy
{
	class Program
	{
		// Class that defines a new type that allows a tuple in a list to make it act like a 2d array
		public class TupleList<T1, T2> : List<Tuple<T1, T2>>
		{
			public void Add(T1 item, T2 item2)
			{
				Add(new Tuple<T1, T2>(item, item2));
			}
		}

		static void Main(string[] args)
		{
			var availSpots = new List<int>();

			var tableSpotFormal = new TupleList<int, int>
			{
				{ 100, 80 },	//<-- Goldilocks
				{ 30, 50 },
				{ 130, 75 },
				{ 90, 60 },
				{ 150, 85 },
				{ 120, 70 },
				{ 200, 200 },
				{ 110, 100 },
			};

			// Weight, Temp
			var tableSpotChallenge = new TupleList<int, int>
			{
				{ 100, 80 },	//<--- Goldilocks
				{ 100, 120 },	//1 true
				{ 297, 90 },
				{ 66, 110 },	//3 true
				{ 257, 113 },
				{ 276, 191 },
				{ 280, 129 },
				{ 219, 163 },
				{ 254, 193 },
				{ 86, 153 },
				{ 206, 147 },
				{ 71, 137 },	//11 true
				{ 104, 40 },
				{ 238, 127 },
				{ 52, 146 },
				{ 129, 197 },	//15 true
				{ 144, 59 },
				{ 157, 124 },	//17 true
				{ 210, 59 },
				{ 11, 54 },		//19 true
				{ 268, 119 },
				{ 261, 121 },
				{ 12, 189 },	//22 true
				{ 186, 108 },	//23 true
				{ 174, 21 },
				{ 77, 18 },
				{ 54, 90 },		//26 true
				{ 174, 52 },
				{ 16, 129 },
				{ 59, 181 },
				{ 290, 123 },
				{ 248, 132 }
			};

			for (int i = 1; i < tableSpotChallenge.Count; i++)
			{
				if ((tableSpotChallenge[i].Item1 >= tableSpotChallenge[0].Item1) && // Weight
					(tableSpotChallenge[i].Item2 >= tableSpotChallenge[0].Item2))   // Temp
				{
					// Do nothing
				}
				else
				{
					availSpots.Add(i);
				}
			}

			Console.WriteLine("Expected: 1 3 11 15 17 19 22 23 26");
			Console.WriteLine("Results : " + String.Join(" ", availSpots));

			Console.WriteLine("-----------------------\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}
