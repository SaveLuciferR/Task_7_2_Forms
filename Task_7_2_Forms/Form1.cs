using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7_2_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string beginStr = textBox1.Text;
			char[] del = new char[] { ' ', ',', '.', '?', ';', ':', '!' };
			var afterStr = String.Join(" ", beginStr.ToLower().Split(del).Distinct());

			for (int i = 0; i < afterStr.Length - 1; i++)
			{
				for (int j = 0; j < del.Length; j++)
				{
					if ((afterStr[i] == del[j] && afterStr[i] == ' ') && afterStr[i + 1] == del[j])
					{
						afterStr = afterStr.Remove(i, 1);

						if (i < 0)
						{
							i--;
						}
					}
				}
			}

			if (afterStr[0] == ' ')
			{
				afterStr = afterStr.Remove(0, 1);
			}

			textBox2.Text = ("Строка после удаления\r\n" + afterStr);
		}
	}
}
