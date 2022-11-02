using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		private Game1A2B game;
		public Form1()
		{
			InitializeComponent();

			game = new Game1A2B();
			resultTextBox.Text = String.Empty;
		}

		private void newButton_Click(object sender, EventArgs e)
		{
			game.NewGame();
		}

		private void ansButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"答案是{game.ans}");
		}

		private void inputButton_Click(object sender, EventArgs e)
		{
			string input = GetNumber();
		}

		private string GetNumber()
		{
			TextBox txt = this.inputTextbox;
			string input = txt.Text;
			if (string.IsNullOrEmpty(input)) return null;

			bool isInt = int.TryParse(input, out int number);
			return isInt ? input : null;
		}
	}
	public class Game1A2B
	{
		public string ans;
		int[] ints = new int[] {0,1,2,3,4,5,6,7,8,9};
		public void NewGame()
		{
			ans = string.Empty;
			int seed = Guid.NewGuid().GetHashCode();
			var random = new Random(seed);
			for(int i = 0; i < ints.Length; i++)
			{
				int int2 = random.Next(0, 10);
				int temp = ints[i];
				ints[i] = ints[int2];
				ints[int2] = temp;
			}
			for (int k = 0; k < 4; k++)
			{
				ans = ans + ints[k];
			}
		}
	}
}
