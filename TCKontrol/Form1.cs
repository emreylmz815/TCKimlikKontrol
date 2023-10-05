using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCKontrol
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			long kimlikNo=long.Parse(txtTC.Text);
			int yil=int.Parse(txtYIL.Text);
			bool durum;

			try
			{
				using(TcDogrula.KPSPublicSoapClient service =new TcDogrula.KPSPublicSoapClient { })
				{
					durum = service.TCKimlikNoDogrula(kimlikNo, txtAD.Text, txtSOYAD.Text, yil);
				}
			}
			catch (Exception)
			{

				throw;
			}
			MessageBox.Show(durum.ToString());
		}
	}
}
