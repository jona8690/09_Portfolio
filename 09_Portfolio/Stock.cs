﻿using System;

namespace _09_Portfolio {
	internal class Stock {
		private string symbol;
		private double pricePerShare;
		private int numShares;

		public string Symbol { get { return this.symbol; } set { this.symbol = value; } }
		public double PricePerShare { get { return this.pricePerShare; } set { this.pricePerShare = value; } }
		public int NumShares { get { return this.numShares; } set { this.numShares = value; } }

		public Stock(string Sym, double Pps, int Ns) {
			this.symbol = Sym;
			this.pricePerShare = Pps;
			this.numShares = Ns;
		}

		public Stock() {}

		internal double GetValue() {
			return this.numShares * this.pricePerShare;
		}

		internal static double TotalValue(Stock[] stocks) {
			double sum = 0;

			foreach(Stock stock in stocks) {
				sum += stock.GetValue();
			}

			return sum;
		}
	}
}