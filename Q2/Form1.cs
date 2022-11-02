using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			clear();
		}

		private void clear()
		{
			dice1Label.Text = String.Empty;
			dice2Label.Text = String.Empty;
			dice3Label.Text = String.Empty;
			dice4Label.Text = String.Empty;
			resultLabel.Text = String.Empty;
		}

		private void resultButton_Click(object sender, EventArgs e)
		{
			GetDice();
		}

		private void GetDice()
		{
			int seed = Guid.NewGuid().GetHashCode();
			var random = new Random(seed);
			int d1, d2, d3, d4, sum;

			int num = 7;
			while (num == 7)
			{
				d1 = random.Next(1, 7);
				d2 = random.Next(1, 7);
				d3 = random.Next(1, 7);
				d4 = random.Next(1, 7);
				int[] ints = { d1, d2, d3, d4 };
				for (int i = 0; i < ints.Length; i++)
				{
					for (int k = i + 1; k < ints.Length; k++)
					{
						if (ints[i] == ints[k])
						{
							if (ints[i] < num)
							{
								num = ints[i];
							}
						}
					}
				}
				sum = d1 + d2 + d3 + d4 - 2 * num;
				resultLabel.Text = $"您的點數是{sum}";
				dice1Label.Text = Convert.ToString(d1);
				dice2Label.Text = Convert.ToString(d2);
				dice3Label.Text = Convert.ToString(d3);
				dice4Label.Text = Convert.ToString(d4);
			}
			
		}

	}
}
