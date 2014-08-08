namespace UnitCalculator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.CatSel = new System.Windows.Forms.ComboBox();
			this.txL = new System.Windows.Forms.TextBox();
			this.coL = new System.Windows.Forms.ComboBox();
			this.coR = new System.Windows.Forms.ComboBox();
			this.btSwap = new System.Windows.Forms.Button();
			this.lbR = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CatSel
			// 
			this.CatSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CatSel.FormattingEnabled = true;
			this.CatSel.Items.AddRange(new object[] {
            "Distance",
            "Area",
            "Volume",
            "Mass",
            "Temperature",
            "Time",
            "Angular Measure",
            "Velocity",
            "Energy",
            "Pressure"});
			this.CatSel.Location = new System.Drawing.Point(12, 12);
			this.CatSel.Name = "CatSel";
			this.CatSel.Size = new System.Drawing.Size(136, 21);
			this.CatSel.TabIndex = 0;
			this.CatSel.SelectedIndexChanged += new System.EventHandler(this.CatSel_SelectedIndexChanged);
			// 
			// txL
			// 
			this.txL.Location = new System.Drawing.Point(12, 39);
			this.txL.Name = "txL";
			this.txL.Size = new System.Drawing.Size(136, 20);
			this.txL.TabIndex = 2;
			this.txL.Text = "0";
			this.txL.TextChanged += new System.EventHandler(this.txL_TextChanged);
			// 
			// coL
			// 
			this.coL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coL.FormattingEnabled = true;
			this.coL.Location = new System.Drawing.Point(12, 65);
			this.coL.Name = "coL";
			this.coL.Size = new System.Drawing.Size(136, 21);
			this.coL.TabIndex = 3;
			this.coL.SelectedIndexChanged += new System.EventHandler(this.coL_SelectedIndexChanged);
			// 
			// coR
			// 
			this.coR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coR.FormattingEnabled = true;
			this.coR.Location = new System.Drawing.Point(154, 65);
			this.coR.Name = "coR";
			this.coR.Size = new System.Drawing.Size(136, 21);
			this.coR.TabIndex = 4;
			this.coR.SelectedIndexChanged += new System.EventHandler(this.coR_SelectedIndexChanged);
			// 
			// btSwap
			// 
			this.btSwap.Location = new System.Drawing.Point(154, 12);
			this.btSwap.Name = "btSwap";
			this.btSwap.Size = new System.Drawing.Size(136, 21);
			this.btSwap.TabIndex = 1;
			this.btSwap.Text = "Swap Values";
			this.btSwap.UseVisualStyleBackColor = true;
			this.btSwap.Click += new System.EventHandler(this.btSwap_Click);
			// 
			// lbR
			// 
			this.lbR.AutoSize = true;
			this.lbR.Location = new System.Drawing.Point(154, 42);
			this.lbR.Name = "lbR";
			this.lbR.Size = new System.Drawing.Size(13, 13);
			this.lbR.TabIndex = 6;
			this.lbR.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 98);
			this.Controls.Add(this.lbR);
			this.Controls.Add(this.btSwap);
			this.Controls.Add(this.coR);
			this.Controls.Add(this.coL);
			this.Controls.Add(this.txL);
			this.Controls.Add(this.CatSel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox CatSel;
		private System.Windows.Forms.TextBox txL;
		private System.Windows.Forms.ComboBox coL;
		private System.Windows.Forms.ComboBox coR;
		private System.Windows.Forms.Button btSwap;
		private System.Windows.Forms.Label lbR;
	}
}

