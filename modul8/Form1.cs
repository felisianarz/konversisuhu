using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod8_kel38
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			cbSuhu.SelectedIndex = 0;
			cbSuhu.DropDownStyle = ComboBoxStyle.DropDownList;
			txtHasil.ReadOnly = true;
		}

		private double knvrsi(double suhuawal, double suhukonversi, double inputsuhu)
		{
			if (suhuawal == 0 && suhukonversi == 2)
			{
				return (inputsuhu * 1.8) + 32;
			}
			else if (suhuawal == 1 && suhukonversi == 3)
			{
				return inputsuhu * 0.8;
			}
			else if (suhuawal == 1 && suhukonversi == 1)
			{
				return (inputsuhu - 32) / 1.8;
			}
			else if (suhuawal == 1 && suhukonversi == 3)
			{
				return (inputsuhu - 32) / 2.25;
			}
			else if (suhuawal == 2 && suhukonversi == 1)
			{
				return inputsuhu * 1.25;
			}
			else if (suhuawal == 2 && suhukonversi == 2)
			{
				return inputsuhu * 2.25 + 32;
			}
			else
			{
				return inputsuhu;
			}
		}

		private void btnKonversi_Click(object sender, EventArgs e)
		{
			int suhukonversi = 0,
				suhuawal = cbSuhu.SelectedIndex,
				inputsuhu = int.Parse(txtsuhu.Text);
			string hasil = "";
			if (rbCel.Checked)
			{
				suhuawal konversi = 1;
				hasil = Convert.ToString(Math.Round(knvrsi(suhuawal, suhukonversi, inputsuhu), 2)) + "\n " + "\n" + "Celcius";
			}
			if (rbFar.Checked)
			{
				suhuawal konversi = 2;
				hasil = Convert.ToString(Math.Round(knvrsi(suhuawal, suhukonversi, inputsuhu), 2)) + "\n " + "\n" + "Fahrenheit";
			}
			if (rbReamur.Checked)
			{
				suhuawal konversi = 2;
				hasil = Convert.ToString(Math.Round(knvrsi(suhuawal, suhukonversi, inputsuhu), 2)) + "\n " + "\n" + "Reamur";
			}
			txtHasil.Text = hasil;

		}

		private Label label1;
		private TextBox txtsuhu;
		private ComboBox cbSuhu;
		private Label label2;
		private Label label3;
		private Label label4;
		private RadioButton cbCel;
		private RadioButton cbFar;
		private RadioButton cbReamur;
		private Button btnKonversi;
		private TextBox txtHasil;
		private Label label5;
		private Label label6;
		private Label label8;
		private Label label9;
		private RadioButton rbkelvin;

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtsuhu = new System.Windows.Forms.TextBox();
			this.cbSuhu = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbCel = new System.Windows.Forms.RadioButton();
			this.cbFar = new System.Windows.Forms.RadioButton();
			this.cbReamur = new System.Windows.Forms.RadioButton();
			this.btnKonversi = new System.Windows.Forms.Button();
			this.txtHasil = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.rbkelvin = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(260, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Konversi Suhu";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtsuhu
			// 
			this.txtsuhu.Location = new System.Drawing.Point(260, 133);
			this.txtsuhu.Name = "txtsuhu";
			this.txtsuhu.Size = new System.Drawing.Size(150, 31);
			this.txtsuhu.TabIndex = 1;
			// 
			// cbSuhu
			// 
			this.cbSuhu.FormattingEnabled = true;
			this.cbSuhu.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur",
            "Kelvin"});
			this.cbSuhu.Location = new System.Drawing.Point(439, 131);
			this.cbSuhu.Name = "cbSuhu";
			this.cbSuhu.Size = new System.Drawing.Size(182, 33);
			this.cbSuhu.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(169, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 25);
			this.label2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(153, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Suhu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(153, 212);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Ke";
			// 
			// cbCel
			// 
			this.cbCel.AutoSize = true;
			this.cbCel.Location = new System.Drawing.Point(264, 217);
			this.cbCel.Name = "cbCel";
			this.cbCel.Size = new System.Drawing.Size(91, 29);
			this.cbCel.TabIndex = 6;
			this.cbCel.TabStop = true;
			this.cbCel.Text = "Celcius";
			this.cbCel.UseVisualStyleBackColor = true;
			// 
			// cbFar
			// 
			this.cbFar.AutoSize = true;
			this.cbFar.Location = new System.Drawing.Point(264, 252);
			this.cbFar.Name = "cbFar";
			this.cbFar.Size = new System.Drawing.Size(118, 29);
			this.cbFar.TabIndex = 7;
			this.cbFar.TabStop = true;
			this.cbFar.Text = "Fahrenheit";
			this.cbFar.UseVisualStyleBackColor = true;
			// 
			// cbReamur
			// 
			this.cbReamur.AutoSize = true;
			this.cbReamur.Location = new System.Drawing.Point(264, 287);
			this.cbReamur.Name = "cbReamur";
			this.cbReamur.Size = new System.Drawing.Size(97, 29);
			this.cbReamur.TabIndex = 8;
			this.cbReamur.TabStop = true;
			this.cbReamur.Text = "Reamur";
			this.cbReamur.UseVisualStyleBackColor = true;
			// 
			// btnKonversi
			// 
			this.btnKonversi.Location = new System.Drawing.Point(260, 374);
			this.btnKonversi.Name = "btnKonversi";
			this.btnKonversi.Size = new System.Drawing.Size(328, 39);
			this.btnKonversi.TabIndex = 9;
			this.btnKonversi.Text = "Konversi";
			this.btnKonversi.UseVisualStyleBackColor = true;
			// 
			// txtHasil
			// 
			this.txtHasil.Location = new System.Drawing.Point(260, 433);
			this.txtHasil.Name = "txtHasil";
			this.txtHasil.Size = new System.Drawing.Size(150, 31);
			this.txtHasil.TabIndex = 10;
			this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(149, 439);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 25);
			this.label5.TabIndex = 11;
			this.label5.Text = "Hasil";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(153, 488);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(220, 25);
			this.label6.TabIndex = 12;
			this.label6.Text = "Adel Nanda Abram Ruben";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(353, 488);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 25);
			this.label8.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(153, 526);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 25);
			this.label9.TabIndex = 15;
			this.label9.Text = "Kelompok 38";
			// 
			// rbkelvin
			// 
			this.rbkelvin.AutoSize = true;
			this.rbkelvin.Location = new System.Drawing.Point(264, 321);
			this.rbkelvin.Name = "rbkelvin";
			this.rbkelvin.Size = new System.Drawing.Size(83, 29);
			this.rbkelvin.TabIndex = 16;
			this.rbkelvin.TabStop = true;
			this.rbkelvin.Text = "Kelvin";
			this.rbkelvin.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 595);
			this.Controls.Add(this.rbkelvin);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtHasil);
			this.Controls.Add(this.btnKonversi);
			this.Controls.Add(this.cbReamur);
			this.Controls.Add(this.cbFar);
			this.Controls.Add(this.cbCel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbSuhu);
			this.Controls.Add(this.txtsuhu);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

	}
}