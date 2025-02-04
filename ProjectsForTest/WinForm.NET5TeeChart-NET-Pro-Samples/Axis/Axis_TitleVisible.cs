﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Axis_TitleVisible : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Points pointSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Axis_TitleVisible()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			pointSeries1.FillSampleValues(20);
			textBox2.Text = tChart1.Axes.Left.Title.Caption;
			tChart1.Axes.Left.Title.Angle = 90;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pointSeries1 = new Steema.TeeChart.Styles.Points();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 40);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Chart Axis Title has a Visible property (defaults to true) and extended Font and " +
				"formatting properties.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			this.panel1.TabIndex = 1;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Visible = false;
			this.tChart1.Axes.Left.LogarithmicBase = 2;
			// 
			// tChart1.Axes.Left.Title
			// 
			this.tChart1.Axes.Left.Title.Caption = "Temperature [C]";
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Brush
			// 
			this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Axes.Left.Title.Font.Name = "Verdana";
			// 
			// tChart1.Axes.Left.Title.Font.Shadow
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Shadow.Brush
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Axes.Left.Title.Font.Shadow.Visible = true;
			this.tChart1.Axes.Left.Title.Lines = new string[] {
																  "Temperature [C]"};
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
														 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Legend.Shadow.Height = 2;
			this.tChart1.Legend.Shadow.Width = 2;
			this.tChart1.Location = new System.Drawing.Point(0, 73);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Panel.MarginTop = 10;
			this.tChart1.Series.Add(this.pointSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 213);
			this.tChart1.TabIndex = 2;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// pointSeries1
			// 
			// 
			// pointSeries1.LinePen
			// 
			this.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(61)), ((System.Byte)(92)), ((System.Byte)(153)));
			// 
			// pointSeries1.Pointer
			// 
			// 
			// pointSeries1.Pointer.Brush
			// 
			this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			// 
			// pointSeries1.Pointer.Pen
			// 
			this.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(61)), ((System.Byte)(92)), ((System.Byte)(153)));
			this.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries1.Title = "pointSeries1";
			// 
			// pointSeries1.XValues
			// 
			this.pointSeries1.XValues.DataMember = "X";
			this.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries1.YValues
			// 
			this.pointSeries1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(107, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Visible axis title";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(208, 6);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "textBox2";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(152, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Axis &title:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(344, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Edit Title...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Axis_TitleVisible
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Axis_TitleVisible";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Axes.Left.Title.Visible = checkBox1.Checked;
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			tChart1.Axes.Left.Title.Caption = textBox2.Text;
		}

    private void button1_Click(object sender, System.EventArgs e)
    {
      using (TeeChart.Editors.AxisEditor a=new TeeChart.Editors.AxisEditor(tChart1.Axes.Left,null, false))
      {
        a.SelectTab(3); // Title tab
        TeeChart.Editors.EditorUtils.ShowFormModal(a,this);
      }
    }
	}
}

