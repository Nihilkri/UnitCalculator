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
		#region Variables
		static string[] cats = {
			//"Distance",			// 0
			//"Area",				// 1
			//"Volume",			// 2
			//"Mass",				// 3
			//"Temperature",		// 4
			//"Time",				// 5
			//"Angular Measure",	// 6
			//"Velocity",			// 7
			//"Energy",			// 8
			"Pressure"};		// 9
		static string[][] UnitNames = new string[cats.GetLength(0)][];
		static double[][,] Units = new double[cats.GetLength(0)][,];

		#endregion Variables
		#region Events
		public Form1() {InitializeComponent();}
		private void Form1_Load(object sender, EventArgs e) {
			for(int q = 0 ; q < cats.GetLength(0) ; q++) CatSel.Items.Add(cats[q]);
			UnitNames[0] = new string[] { // Distance
				"Silak", "Kelik", 
				"Millimeter", "Centimeter", "Meter", "Kilometer", 
				"Inch", "Foot", "Yard", "Mile"};
			Units[0] = new double[,] {
				// Silak, Kelik, mm, cm, Meter, km, Inch, Foot, Yard, Mile
				{1.0, 4294967296.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // Silak
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // Kelik
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // mm
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // cm
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // Meter
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // km
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // Inch
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // Foot
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}, // Yard
				{-1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0}};// Mile
			//UnitNames[1] = new string[] { // Area
			//	"Silak2", "Kelik2", 
			//	"Millimeter2", "Centimeter2", "Meter2", "Kilometer2", 
			//	"Inch2", "Foot2", "Yard2", "Mile2"};
			//UnitNames[2] = new string[] { // Volume
			//	"Silak3", "Kelik3", 
			//	"Millimeter3", "Centimeter3", "Meter3", "Kilometer3", 
			//	"Inch3", "Foot3", "Yard3", "Mile3"};


			//txL.Text = Double.MaxValue.ToString();
			CatSel.SelectedIndex = 0;
		}

		private void CatSel_SelectedIndexChanged(object sender, EventArgs e) {
			coL.Items.Clear(); coR.Items.Clear();
			for(int l = 0 ; l < UnitNames[CatSel.SelectedIndex].GetLength(0) ; l++) coL.Items.Add(UnitNames[l]);
			for(int r = 0 ; r < UnitNames[CatSel.SelectedIndex].GetLength(0) ; r++) coR.Items.Add(UnitNames[r]);
			coL.SelectedIndex = 0; coR.SelectedIndex = 0;
		}

		private void txL_TextChanged(object sender, EventArgs e) {

		}

		private void coL_SelectedIndexChanged(object sender, EventArgs e) {

		}
		private void coR_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void btSwap_Click(object sender, EventArgs e) {

		}
		#endregion Events
	}
}
