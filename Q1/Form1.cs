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
			game.NewGame();
			resultTextBox.Text = String.Empty;
		}

		private void newButton_Click(object sender, EventArgs e)
		{
			game.NewGame();
			resultTextBox.Text = String.Empty;
		}

		private void ansButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"答案是{game.ans}");
		}

		private void inputButton_Click(object sender, EventArgs e)
		{
			string ints = GetNumber();
			if (string.IsNullOrEmpty(ints) == false)
			{
				string result = game.ConfirmAnswer(ints);
				resultTextBox.Text += result + "\r\n";
			}
		}

		private string GetNumber()
		{
			TextBox txt = this.inputTextbox;
			string input = txt.Text;

			bool isInt = int.TryParse(input, out int number);

			if (string.IsNullOrEmpty(input) || input.Length != 4 || !isInt)  
			{
				MessageBox.Show("請輸入正確的四個數字");
				return null;
			}

			int[] ints = new int[] { input[0], input[1], input[2], input[3] };
			for (int i = 0; i < ints.Length; i++)
			{
				for (int k = i + 1; k < ints.Length; k++)
				{
					if (ints[i] == ints[k])
					{
						MessageBox.Show("請勿輸入重複數字");
						return null;
					}
				}
			}
			return input;
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

		internal string ConfirmAnswer(string ints)
		{
			int a = 0;
			int b = 0;


			for (int i = 0; i < ints.Length; i++)
			{
				for (int k = 0; k < 4; k++)
				{
					if (ints[i] == ans[k])
					{
						if (i == k)
						{
							a++;
						}
						else
						{
							b++;
						}
					}
				}
			}
			if (a == 4) MessageBox.Show("您答對了");
			return $"{a} A {b} B";
		}
	}
}
