using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
	public partial class Form1 : Form
	{
		int time = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] data = { "홍차", "녹차", "루이보스차", "국화차" };

			teaList.Items.AddRange(data);
			teaList.SelectedIndex = 0;
		}

		private void TeaList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.teaList.Text != "")
			{
				timeResult.Text = "";
				switch (teaList.Text)
				{
					case "홍차":
						time = 120;
						break;
					case "녹차":
						time = 180;
						break;
					case "루이보스차":
						time = 300;
						break;
					case "국화차":
						time = 120;
						break;
				}
				timeResult.Text = "결과: " + time / 60 + "분 " + time % 60 + "초 남았습니다!";
			}
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			this.Timer.Enabled = true;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (time == 0)
			{
				this.Timer.Enabled = false;
				MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.teaList.Focus();
			}
			else
			{
				time--;
				timeResult.Text = "";
				timeResult.Text = "결과: " + time / 60 + "분 " + time % 60 + "초 남았습니다!";
			}
		}
	}
}
