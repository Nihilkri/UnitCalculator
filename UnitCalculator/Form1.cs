using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitCalculator {
	public partial class Form1 : Form {
		public Form1() {InitializeComponent();}
		private void Form1_Load(object sender, EventArgs e) {
			txL.Text = Double.MaxValue.ToString();
		}

		private void CatSel_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void txL_TextChanged(object sender, EventArgs e) {

		}

		private void coL_SelectedIndexChanged(object sender, EventArgs e) {

		}
		private void coR_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void btSwap_Click(object sender, EventArgs e) {

		}
	}
}
