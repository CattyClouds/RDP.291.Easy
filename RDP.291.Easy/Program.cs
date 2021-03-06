﻿using System;
using System.Collections.Generic;

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
			// Weight, Temp
			var tableFormal = new TupleList<int, int>
			{
				{ 100, 80 }, // Goldilocks
				{ 30, 50 }, { 130, 75 },{ 90, 60 },
				{ 150, 85 },{ 120, 70 },{ 200, 200 },{ 110, 100 },
			};

			// Weight, Temp
			var tableChallenge = new TupleList<int, int>
			{
				{ 100, 120 }, // Goldilocks
				{ 297, 90 }, { 66, 110 }, { 257, 113 },{ 276, 191 },{ 280, 129 },
				{ 219, 163 },{ 254, 193 },{ 86, 153 }, { 206, 147 },{ 71, 137 },
				{ 104, 40 }, { 238, 127 },{ 52, 146 }, { 129, 197 },{ 144, 59 },
				{ 157, 124 },{ 210, 59 }, { 11, 54 },  { 268, 119 },{ 261, 121 },
				{ 12, 189 }, { 186, 108 },{ 174, 21 }, { 77, 18 },  { 54, 90 },
				{ 174, 52 }, { 16, 129 }, { 59, 181 }, { 290, 123 },{ 248, 132 }
			};

			Console.WriteLine(String.Join(" ", CheckForSpots(tableChallenge)));
		}

		private static List<int> CheckForSpots(TupleList<int, int> table)
		{
			var availSpots = new List<int>();
			for (int i = 1; i < table.Count; i++)
			{
				if ((table[0].Item1 <= table[i].Item1) && // Weight
					(table[0].Item2 >= table[i].Item2))   // Temp
				{
					availSpots.Add(i);
				}
			}
			return availSpots;
		}
	}
}
