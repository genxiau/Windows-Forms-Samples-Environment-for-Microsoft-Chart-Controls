﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsChartSamples
{
	/// <summary>
	/// Summary description for LegendCells.
	/// </summary>
	public class LegendCells : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;

		public LegendCells()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle1 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle2 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle3 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle4 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell1 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell2 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell3 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell4 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell5 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.375, 2410.8291015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.375, 2410.673095703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.375, 2413.3291015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.37890625, 2414.778076171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.37890625, 2411.59716796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.37890625, 2412.47900390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.37890625, 2410.249755859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.37890625, 2411.90576171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.37890625, 2415.433349609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3828125, 2411.48095703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3828125, 2413.19677734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3828125, 2411.896728515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3828125, 2408.0751953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3828125, 2406.742431640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3828125, 2403.135498046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.38671875, 2404.95166015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.38671875, 2406.21142578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.38671875, 2402.232177734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.38671875, 2404.173828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.38671875, 2404.4072265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.390625, 2407.52734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.390625, 2411.0947265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.390625, 2412.6083984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.390625, 2415.068603515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.390625, 2417.366943359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.390625, 2419.852783203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.39453125, 2419.675048828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.39453125, 2421.539306640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.39453125, 2422.873291015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.39453125, 2425.86328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.39453125, 2428.34228515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3984375, 2428.069580078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3984375, 2424.68212890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3984375, 2426.337890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3984375, 2423.540283203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3984375, 2422.253662109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.3984375, 2425.273193359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40234375, 2422.5595703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40234375, 2422.28369140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40234375, 2419.45556640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40234375, 2421.681884765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40234375, 2420.628173828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40234375, 2418.39306640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40625, 2421.05859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40625, 2420.064208984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40625, 2420.890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40625, 2423.586181640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.40625, 2427.564208984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint49 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41015625, 2428.7333984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint50 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41015625, 2432.54150390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint51 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41015625, 2432.024658203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint52 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41015625, 2430.294677734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint53 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41015625, 2433.6240234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint54 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41015625, 2435.79150390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint55 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4140625, 2435.985595703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint56 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4140625, 2433.24755859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint57 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4140625, 2435.57763671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint58 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4140625, 2431.7734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint59 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4140625, 2434.92431640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint60 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4140625, 2433.257568359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint61 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41796875, 2430.317138671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint62 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41796875, 2430.2236328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint63 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41796875, 2426.545654296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint64 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41796875, 2423.0830078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint65 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.41796875, 2420.65185546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint66 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.421875, 2418.64013671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint67 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.421875, 2416.7275390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint68 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.421875, 2415.25048828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint69 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.421875, 2412.71533203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint70 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.421875, 2414.39501953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint71 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.421875, 2417.191650390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint72 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.42578125, 2417.1650390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint73 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.42578125, 2417.461669921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint74 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.42578125, 2418.2314453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint75 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.42578125, 2420.238525390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint76 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.42578125, 2420.412109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint77 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4296875, 2422.214599609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint78 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4296875, 2425.06298828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint79 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4296875, 2424.517578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint80 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4296875, 2421.989501953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint81 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4296875, 2425.779541015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint82 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4296875, 2425.6240234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint83 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.43359375, 2422.31884765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint84 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.43359375, 2423.8447265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint85 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.43359375, 2423.351806640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint86 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.43359375, 2423.560546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint87 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.43359375, 2423.958740234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint88 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.43359375, 2422.40380859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint89 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4375, 2419.865234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint90 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4375, 2423.8056640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint91 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4375, 2424.189208984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint92 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4375, 2427.0126953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint93 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4375, 2425.1484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint94 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44140625, 2422.539306640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint95 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44140625, 2418.651611328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint96 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44140625, 2416.97119140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint97 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44140625, 2415.595703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint98 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44140625, 2412.8232421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint99 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44140625, 2413.919677734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint100 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4453125, 2410.93701171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint101 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4453125, 2409.676025390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint102 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4453125, 2409.848876953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint103 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4453125, 2412.36181640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint104 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4453125, 2415.8515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint105 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4453125, 2412.86279296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint106 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44921875, 2416.372802734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint107 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44921875, 2418.34619140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint108 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44921875, 2416.90576171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint109 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44921875, 2413.06591796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint110 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.44921875, 2409.086669921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint111 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.453125, 2408.546142578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint112 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.453125, 2412.027587890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint113 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.453125, 2412.768798828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint114 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.453125, 2414.447998046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint115 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.453125, 2412.990966796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint116 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.453125, 2414.2060546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint117 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.45703125, 2413.417724609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint118 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.45703125, 2412.2138671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint119 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.45703125, 2413.244384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint120 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.45703125, 2414.604248046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint121 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.45703125, 2416.194580078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint122 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4609375, 2419.8369140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint123 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4609375, 2416.8984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint124 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4609375, 2414.422607421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint125 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4609375, 2411.718994140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint126 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4609375, 2415.692138671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint127 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4609375, 2413.529541015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint128 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46484375, 2412.435546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint129 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46484375, 2413.0927734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint130 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46484375, 2412.7802734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint131 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46484375, 2410.32958984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint132 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46484375, 2410.904296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint133 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46484375, 2408.656494140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint134 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46875, 2407.093505859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint135 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46875, 2409.826416015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint136 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46875, 2409.44384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint137 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46875, 2410.775146484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint138 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.46875, 2407.980224609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint139 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.47265625, 2408.494873046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint140 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.47265625, 2408.4921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint141 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.47265625, 2410.7275390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint142 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.47265625, 2408.56591796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint143 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.47265625, 2406.850830078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint144 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.47265625, 2404.291748046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint145 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4765625, 2404.772705078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint146 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4765625, 2405.674560546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint147 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4765625, 2403.7568359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint148 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4765625, 2404.213623046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint149 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4765625, 2407.061279296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint150 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4765625, 2405.95849609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint151 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48046875, 2409.066650390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint152 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48046875, 2412.894775390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint153 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48046875, 2413.092041015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint154 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48046875, 2416.828369140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint155 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48046875, 2416.255615234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint156 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.484375, 2415.352294921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint157 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.484375, 2414.463623046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint158 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.484375, 2415.4521484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint159 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.484375, 2417.645751953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint160 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.484375, 2414.683837890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint161 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.484375, 2416.356201171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint162 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48828125, 2415.423828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint163 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48828125, 2417.326171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint164 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48828125, 2417.798828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint165 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48828125, 2420.27001953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint166 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.48828125, 2423.15478515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint167 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4921875, 2424.88427734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint168 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4921875, 2423.1884765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint169 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4921875, 2426.134521484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint170 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4921875, 2429.060302734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint171 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4921875, 2432.94384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint172 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.4921875, 2430.95068359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint173 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.49609375, 2433.23193359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint174 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.49609375, 2430.265380859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint175 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.49609375, 2433.389892578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint176 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.49609375, 2433.1416015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint177 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.49609375, 2434.499267578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint178 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.49609375, 2438.11962890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint179 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5, 2439.1630859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint180 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5, 2439.5576171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint181 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5, 2441.4482421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint182 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5, 2442.8291015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint183 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5, 2442.88720703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint184 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.50390625, 2440.647216796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint185 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.50390625, 2441.226806640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint186 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.50390625, 2438.94775390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint187 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.50390625, 2435.325439453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint188 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.50390625, 2433.341064453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint189 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.50390625, 2436.35107421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint190 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5078125, 2435.9873046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint191 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5078125, 2432.4931640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint192 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5078125, 2428.836181640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint193 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5078125, 2427.84765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint194 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5078125, 2427.32421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint195 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5078125, 2429.64892578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint196 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51171875, 2428.81689453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint197 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51171875, 2428.7529296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint198 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51171875, 2430.565185546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint199 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51171875, 2429.53466796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint200 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51171875, 2431.131103515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint201 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.515625, 2434.30322265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint202 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.515625, 2438.08154296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint203 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.515625, 2439.59228515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint204 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.515625, 2443.51416015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint205 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.515625, 2442.52783203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint206 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.515625, 2443.629150390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint207 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51953125, 2441.17578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint208 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51953125, 2440.33984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint209 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51953125, 2436.95166015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint210 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51953125, 2440.627197265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint211 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.51953125, 2442.3662109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint212 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5234375, 2441.85693359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint213 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5234375, 2445.80224609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint214 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5234375, 2443.601318359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint215 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5234375, 2442.748779296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint216 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5234375, 2439.040283203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint217 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5234375, 2442.049560546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint218 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.52734375, 2442.19189453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint219 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.52734375, 2446.0849609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint220 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.52734375, 2446.835205078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint221 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.52734375, 2449.34228515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint222 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.52734375, 2449.05615234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint223 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.52734375, 2448.350341796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint224 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53125, 2447.66015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint225 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53125, 2450.080078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint226 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53125, 2453.620849609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint227 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53125, 2456.615966796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint228 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53125, 2455.4208984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint229 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53515625, 2454.12939453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint230 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53515625, 2454.086181640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint231 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53515625, 2457.901611328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint232 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53515625, 2461.447021484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint233 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53515625, 2462.09814453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint234 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.53515625, 2465.544921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint235 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5390625, 2466.767333984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint236 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5390625, 2468.879638671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint237 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5390625, 2472.75);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint238 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5390625, 2472.88623046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint239 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5390625, 2475.632568359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint240 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5390625, 2479.11083984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint241 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.54296875, 2475.28515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint242 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.54296875, 2476.498779296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint243 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.54296875, 2473.902587890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint244 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.54296875, 2477.237060546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint245 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.54296875, 2479.13427734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint246 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.546875, 2480.1494140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint247 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.546875, 2476.546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint248 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.546875, 2473.759521484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint249 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.546875, 2470.08837890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint250 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.546875, 2472.121826171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint251 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.546875, 2472.2802734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint252 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55078125, 2476.07421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint253 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55078125, 2477.993408203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint254 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55078125, 2480.212646484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint255 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55078125, 2483.3017578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint256 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55078125, 2482.76025390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint257 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5546875, 2483.244384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint258 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5546875, 2481.445068359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint259 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5546875, 2478.947021484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint260 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5546875, 2478.419921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint261 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5546875, 2480.526123046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint262 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5546875, 2483.26806640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint263 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55859375, 2479.723388671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint264 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55859375, 2480.378662109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint265 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55859375, 2484.238525390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint266 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55859375, 2486.43212890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint267 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55859375, 2489.27197265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint268 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.55859375, 2485.770263671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint269 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5625, 2486.34716796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint270 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5625, 2487.38232421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint271 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5625, 2483.803466796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint272 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5625, 2482.67626953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint273 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5625, 2484.072265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint274 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.56640625, 2480.487060546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint275 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.56640625, 2481.063232421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint276 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.56640625, 2478.356689453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint277 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.56640625, 2476.666748046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint278 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.56640625, 2476.62646484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint279 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.56640625, 2478.0390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint280 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5703125, 2475.44384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint281 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5703125, 2478.587158203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint282 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5703125, 2480.369384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint283 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5703125, 2478.845703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint284 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5703125, 2479.520751953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint285 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5703125, 2483.31884765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint286 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.57421875, 2479.340576171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint287 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.57421875, 2476.966796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint288 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.57421875, 2479.398681640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint289 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.57421875, 2475.75634765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint290 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.57421875, 2473.52001953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint291 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.578125, 2471.1484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint292 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.578125, 2472.81787109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint293 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.578125, 2471.452392578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint294 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.578125, 2470.725830078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint295 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.578125, 2468.097900390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint296 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.578125, 2465.530029296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint297 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58203125, 2466.288330078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint298 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58203125, 2467.037109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint299 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58203125, 2470.51171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint300 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58203125, 2474.215087890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint301 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58203125, 2476.390380859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint302 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5859375, 2480.28955078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint303 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5859375, 2480.925537109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint304 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5859375, 2480.21923828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint305 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5859375, 2481.83154296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint306 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5859375, 2479.1171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint307 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.5859375, 2477.514892578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint308 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58984375, 2479.01953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint309 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58984375, 2476.662353515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint310 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58984375, 2478.458251953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint311 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58984375, 2475.606689453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint312 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58984375, 2472.130859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint313 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.58984375, 2472.919189453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint314 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59375, 2469.01611328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint315 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59375, 2469.345703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint316 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59375, 2465.669677734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint317 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59375, 2465.935302734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint318 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59375, 2465.7158203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint319 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59765625, 2466.57275390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint320 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59765625, 2470.410888671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint321 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59765625, 2470.978515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint322 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59765625, 2467.386474609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint323 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59765625, 2463.527099609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint324 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.59765625, 2462.340087890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint325 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6015625, 2461.7470703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint326 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6015625, 2460.49853515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint327 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6015625, 2456.737060546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint328 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6015625, 2454.859619140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint329 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6015625, 2457.90234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint330 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6015625, 2457.046142578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint331 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.60546875, 2457.58154296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint332 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.60546875, 2459.142578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint333 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.60546875, 2459.6279296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint334 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.60546875, 2461.3369140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint335 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.60546875, 2460.56640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint336 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.609375, 2463.810546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint337 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.609375, 2460.95703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint338 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.609375, 2464.139404296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint339 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.609375, 2467.202392578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint340 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.609375, 2469.71484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint341 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.609375, 2471.338623046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint342 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.61328125, 2471.460205078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint343 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.61328125, 2472.249267578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint344 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.61328125, 2470.811279296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint345 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.61328125, 2467.426513671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint346 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.61328125, 2464.530517578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint347 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6171875, 2461.411865234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint348 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6171875, 2459.94921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint349 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6171875, 2462.89306640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint350 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6171875, 2459.941162109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint351 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6171875, 2461.10791015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint352 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6171875, 2458.085693359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint353 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62109375, 2461.977294921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint354 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62109375, 2465.61376953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint355 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62109375, 2464.749755859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint356 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62109375, 2466.51708984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint357 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62109375, 2470.275390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint358 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62109375, 2468.0986328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint359 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.625, 2471.9853515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint360 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.625, 2470.845947265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint361 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.625, 2467.893310546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint362 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.625, 2464.16845703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint363 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.625, 2466.63037109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint364 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62890625, 2469.129150390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint365 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62890625, 2466.389892578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint366 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62890625, 2465.97705078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint367 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62890625, 2466.01611328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint368 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62890625, 2469.095458984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint369 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.62890625, 2469.962890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint370 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6328125, 2471.04833984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint371 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6328125, 2474.225830078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint372 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6328125, 2475.30908203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint373 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6328125, 2476.0263671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint374 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6328125, 2478.37109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint375 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6328125, 2476.58544921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint376 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.63671875, 2473.03125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint377 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.63671875, 2472.650146484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint378 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.63671875, 2474.22900390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint379 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.63671875, 2472.426513671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint380 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.63671875, 2470.7294921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint381 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.640625, 2468.599853515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint382 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.640625, 2470.30078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint383 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.640625, 2469.4794921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint384 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.640625, 2471.47412109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint385 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.640625, 2473.451416015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint386 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.640625, 2473.0087890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint387 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.64453125, 2474.67822265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint388 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.64453125, 2475.52734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint389 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.64453125, 2474.10009765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint390 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.64453125, 2475.5625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint391 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.64453125, 2479.048095703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint392 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6484375, 2482.37158203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint393 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6484375, 2485.667236328125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint394 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6484375, 2485.869384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint395 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6484375, 2487.334716796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint396 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6484375, 2488.683349609375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint397 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6484375, 2490.343017578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint398 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65234375, 2492.63330078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint399 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65234375, 2489.9345703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint400 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65234375, 2490.96240234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint401 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65234375, 2492.027587890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint402 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65234375, 2489.82958984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint403 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65234375, 2491.499755859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint404 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65625, 2489.35791015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint405 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65625, 2487.228271484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint406 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65625, 2483.31201171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint407 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65625, 2483.572509765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint408 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.65625, 2481.119384765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint409 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66015625, 2482.54150390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint410 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66015625, 2481.2314453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint411 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66015625, 2479.3798828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint412 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66015625, 2477.5595703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint413 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66015625, 2481.18505859375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint414 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66015625, 2482.76904296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint415 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6640625, 2479.75927734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint416 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6640625, 2479.10546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint417 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6640625, 2480.201904296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint418 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6640625, 2476.669189453125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint419 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6640625, 2473.190673828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint420 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6640625, 2474.89404296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint421 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66796875, 2476.81201171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint422 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66796875, 2480.001708984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint423 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66796875, 2480.50830078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint424 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66796875, 2483.913330078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint425 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.66796875, 2485.51318359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint426 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.671875, 2489.367431640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint427 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.671875, 2491.15478515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint428 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.671875, 2487.669921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint429 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.671875, 2484.549560546875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint430 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.671875, 2485.4150390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint431 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.671875, 2484.201171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint432 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.67578125, 2485.530029296875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint433 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.67578125, 2485.8076171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint434 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.67578125, 2486.977294921875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint435 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.67578125, 2488.21484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint436 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.67578125, 2484.283447265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint437 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6796875, 2480.314208984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint438 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6796875, 2477.634765625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint439 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6796875, 2477.759033203125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint440 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6796875, 2479.652587890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint441 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6796875, 2482.949462890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint442 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6796875, 2483.072021484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint443 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.68359375, 2486.4990234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint444 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.68359375, 2490.3818359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint445 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.68359375, 2489.695556640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint446 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.68359375, 2491.001708984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint447 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.68359375, 2494.69970703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint448 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.68359375, 2492.411376953125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint449 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6875, 2491.623046875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint450 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6875, 2489.7421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint451 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6875, 2485.99462890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint452 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6875, 2487.18701171875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint453 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6875, 2488.95556640625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint454 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69140625, 2488.553466796875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint455 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69140625, 2491.66357421875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint456 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69140625, 2493.5390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint457 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69140625, 2494.834228515625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint458 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69140625, 2497.099365234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint459 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69140625, 2497.35791015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint460 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6953125, 2495.3740234375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint461 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6953125, 2493.670166015625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint462 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6953125, 2493.41552734375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint463 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6953125, 2490.0830078125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint464 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6953125, 2486.6396484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint465 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.6953125, 2490.543212890625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint466 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69921875, 2491.363037109375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint467 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69921875, 2493.264892578125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint468 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69921875, 2491.720947265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint469 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69921875, 2488.067138671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint470 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.69921875, 2484.989013671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint471 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.703125, 2484.304443359375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint472 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.703125, 2484.080322265625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint473 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.703125, 2484.42333984375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint474 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.703125, 2483.051025390625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint475 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.703125, 2485.457763671875);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint476 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.703125, 2483.253173828125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint477 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.70703125, 2487.015869140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint478 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.70703125, 2487.6396484375);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint479 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.70703125, 2487.73095703125);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint480 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.70703125, 2484.0244140625);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint481 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38782.70703125, 2480.180908203125);
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.label9 = new System.Windows.Forms.Label();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 40);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates how to use individual cells to extend the features of a " +
				"custom legend item.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chart2
			// 
			this.chart2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			this.chart2.BackSecondaryColor = System.Drawing.Color.White;
			this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chart2.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chart2.BorderlineWidth = 2;
			this.chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 6.75F);
			chartArea1.AxisX.LabelStyle.Format = "t";
			chartArea1.AxisX.LabelStyle.Interval = 0;
			chartArea1.AxisX.LabelStyle.IntervalOffset = 0;
			chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.Interval = 0;
			chartArea1.AxisX.MajorGrid.IntervalOffset = 0;
			chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorTickMark.Enabled = false;
			chartArea1.AxisX.MajorTickMark.Interval = 0;
			chartArea1.AxisX.MajorTickMark.IntervalOffset = 0;
			chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsMarksNextToAxis = false;
			chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			axisScaleBreakStyle1.Enabled = false;
			chartArea1.AxisX.ScaleBreakStyle = axisScaleBreakStyle1;
			chartArea1.AxisX2.LabelStyle.Interval = 0;
			chartArea1.AxisX2.LabelStyle.IntervalOffset = 0;
			chartArea1.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX2.MajorGrid.Interval = 0;
			chartArea1.AxisX2.MajorGrid.IntervalOffset = 0;
			chartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX2.MajorTickMark.Interval = 0;
			chartArea1.AxisX2.MajorTickMark.IntervalOffset = 0;
			chartArea1.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			axisScaleBreakStyle2.Enabled = false;
			chartArea1.AxisX2.ScaleBreakStyle = axisScaleBreakStyle2;
			chartArea1.AxisY.Crossing = 2449.795166015625;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 6.75F);
			chartArea1.AxisY.LabelStyle.Format = "F0";
			chartArea1.AxisY.LabelStyle.Interval = 0;
			chartArea1.AxisY.LabelStyle.IntervalOffset = 0;
			chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.Interval = 0;
			chartArea1.AxisY.MajorGrid.IntervalOffset = 0;
			chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorTickMark.Enabled = false;
			chartArea1.AxisY.MajorTickMark.Interval = 0;
			chartArea1.AxisY.MajorTickMark.IntervalOffset = 0;
			chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.Maximum = 2498.35791015625;
			chartArea1.AxisY.Minimum = 2403.232177734375;
			chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			axisScaleBreakStyle3.Enabled = false;
			chartArea1.AxisY.ScaleBreakStyle = axisScaleBreakStyle3;
			chartArea1.AxisY2.LabelStyle.Interval = 0;
			chartArea1.AxisY2.LabelStyle.IntervalOffset = 0;
			chartArea1.AxisY2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY2.MajorGrid.Interval = 0;
			chartArea1.AxisY2.MajorGrid.IntervalOffset = 0;
			chartArea1.AxisY2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY2.MajorTickMark.Interval = 0;
			chartArea1.AxisY2.MajorTickMark.IntervalOffset = 0;
			chartArea1.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			chartArea1.AxisY2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
			axisScaleBreakStyle4.Enabled = false;
			chartArea1.AxisY2.ScaleBreakStyle = axisScaleBreakStyle4;
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "Default";
			this.chart2.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BorderColor = System.Drawing.Color.Black;
			legend1.BorderWidth = 0;
			legendCell1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell1.Name = "Cell1";
			legendCell1.Text = "Central";
			legendCell2.Alignment = System.Drawing.ContentAlignment.MiddleRight;
			legendCell2.Name = "Cell2";
			legendCell2.Text = "2480.18";
			legendCell3.Alignment = System.Drawing.ContentAlignment.MiddleRight;
			legendCell3.Name = "Cell3";
			legendCell3.Text = "69.35";
			legendCell3.ForeColor = System.Drawing.Color.LimeGreen;
			legendCell4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell4.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
			legendCell4.Name = "Cell4";
			legendCell5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell5.Name = "Cell5";
			legendCell5.Text = "2.88%";
			legendCell5.ForeColor = System.Drawing.Color.LimeGreen;
			legendItem1.Cells.Add(legendCell1);
			legendItem1.Cells.Add(legendCell2);
			legendItem1.Cells.Add(legendCell3);
			legendItem1.Cells.Add(legendCell4);
			legendItem1.Cells.Add(legendCell5);
			legendItem1.Color = System.Drawing.Color.Red;
			legendItem1.Name = "LegendItem";
			legend1.CustomItems.Add(legendItem1);
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
			legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.chart2.Legends.Add(legend1);
			this.chart2.Location = new System.Drawing.Point(16, 56);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.BorderWidth = 0;
			series1.ChartType = SeriesChartType.Area;
			series1.Name = "Central";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.Points.Add(dataPoint6);
			series1.Points.Add(dataPoint7);
			series1.Points.Add(dataPoint8);
			series1.Points.Add(dataPoint9);
			series1.Points.Add(dataPoint10);
			series1.Points.Add(dataPoint11);
			series1.Points.Add(dataPoint12);
			series1.Points.Add(dataPoint13);
			series1.Points.Add(dataPoint14);
			series1.Points.Add(dataPoint15);
			series1.Points.Add(dataPoint16);
			series1.Points.Add(dataPoint17);
			series1.Points.Add(dataPoint18);
			series1.Points.Add(dataPoint19);
			series1.Points.Add(dataPoint20);
			series1.Points.Add(dataPoint21);
			series1.Points.Add(dataPoint22);
			series1.Points.Add(dataPoint23);
			series1.Points.Add(dataPoint24);
			series1.Points.Add(dataPoint25);
			series1.Points.Add(dataPoint26);
			series1.Points.Add(dataPoint27);
			series1.Points.Add(dataPoint28);
			series1.Points.Add(dataPoint29);
			series1.Points.Add(dataPoint30);
			series1.Points.Add(dataPoint31);
			series1.Points.Add(dataPoint32);
			series1.Points.Add(dataPoint33);
			series1.Points.Add(dataPoint34);
			series1.Points.Add(dataPoint35);
			series1.Points.Add(dataPoint36);
			series1.Points.Add(dataPoint37);
			series1.Points.Add(dataPoint38);
			series1.Points.Add(dataPoint39);
			series1.Points.Add(dataPoint40);
			series1.Points.Add(dataPoint41);
			series1.Points.Add(dataPoint42);
			series1.Points.Add(dataPoint43);
			series1.Points.Add(dataPoint44);
			series1.Points.Add(dataPoint45);
			series1.Points.Add(dataPoint46);
			series1.Points.Add(dataPoint47);
			series1.Points.Add(dataPoint48);
			series1.Points.Add(dataPoint49);
			series1.Points.Add(dataPoint50);
			series1.Points.Add(dataPoint51);
			series1.Points.Add(dataPoint52);
			series1.Points.Add(dataPoint53);
			series1.Points.Add(dataPoint54);
			series1.Points.Add(dataPoint55);
			series1.Points.Add(dataPoint56);
			series1.Points.Add(dataPoint57);
			series1.Points.Add(dataPoint58);
			series1.Points.Add(dataPoint59);
			series1.Points.Add(dataPoint60);
			series1.Points.Add(dataPoint61);
			series1.Points.Add(dataPoint62);
			series1.Points.Add(dataPoint63);
			series1.Points.Add(dataPoint64);
			series1.Points.Add(dataPoint65);
			series1.Points.Add(dataPoint66);
			series1.Points.Add(dataPoint67);
			series1.Points.Add(dataPoint68);
			series1.Points.Add(dataPoint69);
			series1.Points.Add(dataPoint70);
			series1.Points.Add(dataPoint71);
			series1.Points.Add(dataPoint72);
			series1.Points.Add(dataPoint73);
			series1.Points.Add(dataPoint74);
			series1.Points.Add(dataPoint75);
			series1.Points.Add(dataPoint76);
			series1.Points.Add(dataPoint77);
			series1.Points.Add(dataPoint78);
			series1.Points.Add(dataPoint79);
			series1.Points.Add(dataPoint80);
			series1.Points.Add(dataPoint81);
			series1.Points.Add(dataPoint82);
			series1.Points.Add(dataPoint83);
			series1.Points.Add(dataPoint84);
			series1.Points.Add(dataPoint85);
			series1.Points.Add(dataPoint86);
			series1.Points.Add(dataPoint87);
			series1.Points.Add(dataPoint88);
			series1.Points.Add(dataPoint89);
			series1.Points.Add(dataPoint90);
			series1.Points.Add(dataPoint91);
			series1.Points.Add(dataPoint92);
			series1.Points.Add(dataPoint93);
			series1.Points.Add(dataPoint94);
			series1.Points.Add(dataPoint95);
			series1.Points.Add(dataPoint96);
			series1.Points.Add(dataPoint97);
			series1.Points.Add(dataPoint98);
			series1.Points.Add(dataPoint99);
			series1.Points.Add(dataPoint100);
			series1.Points.Add(dataPoint101);
			series1.Points.Add(dataPoint102);
			series1.Points.Add(dataPoint103);
			series1.Points.Add(dataPoint104);
			series1.Points.Add(dataPoint105);
			series1.Points.Add(dataPoint106);
			series1.Points.Add(dataPoint107);
			series1.Points.Add(dataPoint108);
			series1.Points.Add(dataPoint109);
			series1.Points.Add(dataPoint110);
			series1.Points.Add(dataPoint111);
			series1.Points.Add(dataPoint112);
			series1.Points.Add(dataPoint113);
			series1.Points.Add(dataPoint114);
			series1.Points.Add(dataPoint115);
			series1.Points.Add(dataPoint116);
			series1.Points.Add(dataPoint117);
			series1.Points.Add(dataPoint118);
			series1.Points.Add(dataPoint119);
			series1.Points.Add(dataPoint120);
			series1.Points.Add(dataPoint121);
			series1.Points.Add(dataPoint122);
			series1.Points.Add(dataPoint123);
			series1.Points.Add(dataPoint124);
			series1.Points.Add(dataPoint125);
			series1.Points.Add(dataPoint126);
			series1.Points.Add(dataPoint127);
			series1.Points.Add(dataPoint128);
			series1.Points.Add(dataPoint129);
			series1.Points.Add(dataPoint130);
			series1.Points.Add(dataPoint131);
			series1.Points.Add(dataPoint132);
			series1.Points.Add(dataPoint133);
			series1.Points.Add(dataPoint134);
			series1.Points.Add(dataPoint135);
			series1.Points.Add(dataPoint136);
			series1.Points.Add(dataPoint137);
			series1.Points.Add(dataPoint138);
			series1.Points.Add(dataPoint139);
			series1.Points.Add(dataPoint140);
			series1.Points.Add(dataPoint141);
			series1.Points.Add(dataPoint142);
			series1.Points.Add(dataPoint143);
			series1.Points.Add(dataPoint144);
			series1.Points.Add(dataPoint145);
			series1.Points.Add(dataPoint146);
			series1.Points.Add(dataPoint147);
			series1.Points.Add(dataPoint148);
			series1.Points.Add(dataPoint149);
			series1.Points.Add(dataPoint150);
			series1.Points.Add(dataPoint151);
			series1.Points.Add(dataPoint152);
			series1.Points.Add(dataPoint153);
			series1.Points.Add(dataPoint154);
			series1.Points.Add(dataPoint155);
			series1.Points.Add(dataPoint156);
			series1.Points.Add(dataPoint157);
			series1.Points.Add(dataPoint158);
			series1.Points.Add(dataPoint159);
			series1.Points.Add(dataPoint160);
			series1.Points.Add(dataPoint161);
			series1.Points.Add(dataPoint162);
			series1.Points.Add(dataPoint163);
			series1.Points.Add(dataPoint164);
			series1.Points.Add(dataPoint165);
			series1.Points.Add(dataPoint166);
			series1.Points.Add(dataPoint167);
			series1.Points.Add(dataPoint168);
			series1.Points.Add(dataPoint169);
			series1.Points.Add(dataPoint170);
			series1.Points.Add(dataPoint171);
			series1.Points.Add(dataPoint172);
			series1.Points.Add(dataPoint173);
			series1.Points.Add(dataPoint174);
			series1.Points.Add(dataPoint175);
			series1.Points.Add(dataPoint176);
			series1.Points.Add(dataPoint177);
			series1.Points.Add(dataPoint178);
			series1.Points.Add(dataPoint179);
			series1.Points.Add(dataPoint180);
			series1.Points.Add(dataPoint181);
			series1.Points.Add(dataPoint182);
			series1.Points.Add(dataPoint183);
			series1.Points.Add(dataPoint184);
			series1.Points.Add(dataPoint185);
			series1.Points.Add(dataPoint186);
			series1.Points.Add(dataPoint187);
			series1.Points.Add(dataPoint188);
			series1.Points.Add(dataPoint189);
			series1.Points.Add(dataPoint190);
			series1.Points.Add(dataPoint191);
			series1.Points.Add(dataPoint192);
			series1.Points.Add(dataPoint193);
			series1.Points.Add(dataPoint194);
			series1.Points.Add(dataPoint195);
			series1.Points.Add(dataPoint196);
			series1.Points.Add(dataPoint197);
			series1.Points.Add(dataPoint198);
			series1.Points.Add(dataPoint199);
			series1.Points.Add(dataPoint200);
			series1.Points.Add(dataPoint201);
			series1.Points.Add(dataPoint202);
			series1.Points.Add(dataPoint203);
			series1.Points.Add(dataPoint204);
			series1.Points.Add(dataPoint205);
			series1.Points.Add(dataPoint206);
			series1.Points.Add(dataPoint207);
			series1.Points.Add(dataPoint208);
			series1.Points.Add(dataPoint209);
			series1.Points.Add(dataPoint210);
			series1.Points.Add(dataPoint211);
			series1.Points.Add(dataPoint212);
			series1.Points.Add(dataPoint213);
			series1.Points.Add(dataPoint214);
			series1.Points.Add(dataPoint215);
			series1.Points.Add(dataPoint216);
			series1.Points.Add(dataPoint217);
			series1.Points.Add(dataPoint218);
			series1.Points.Add(dataPoint219);
			series1.Points.Add(dataPoint220);
			series1.Points.Add(dataPoint221);
			series1.Points.Add(dataPoint222);
			series1.Points.Add(dataPoint223);
			series1.Points.Add(dataPoint224);
			series1.Points.Add(dataPoint225);
			series1.Points.Add(dataPoint226);
			series1.Points.Add(dataPoint227);
			series1.Points.Add(dataPoint228);
			series1.Points.Add(dataPoint229);
			series1.Points.Add(dataPoint230);
			series1.Points.Add(dataPoint231);
			series1.Points.Add(dataPoint232);
			series1.Points.Add(dataPoint233);
			series1.Points.Add(dataPoint234);
			series1.Points.Add(dataPoint235);
			series1.Points.Add(dataPoint236);
			series1.Points.Add(dataPoint237);
			series1.Points.Add(dataPoint238);
			series1.Points.Add(dataPoint239);
			series1.Points.Add(dataPoint240);
			series1.Points.Add(dataPoint241);
			series1.Points.Add(dataPoint242);
			series1.Points.Add(dataPoint243);
			series1.Points.Add(dataPoint244);
			series1.Points.Add(dataPoint245);
			series1.Points.Add(dataPoint246);
			series1.Points.Add(dataPoint247);
			series1.Points.Add(dataPoint248);
			series1.Points.Add(dataPoint249);
			series1.Points.Add(dataPoint250);
			series1.Points.Add(dataPoint251);
			series1.Points.Add(dataPoint252);
			series1.Points.Add(dataPoint253);
			series1.Points.Add(dataPoint254);
			series1.Points.Add(dataPoint255);
			series1.Points.Add(dataPoint256);
			series1.Points.Add(dataPoint257);
			series1.Points.Add(dataPoint258);
			series1.Points.Add(dataPoint259);
			series1.Points.Add(dataPoint260);
			series1.Points.Add(dataPoint261);
			series1.Points.Add(dataPoint262);
			series1.Points.Add(dataPoint263);
			series1.Points.Add(dataPoint264);
			series1.Points.Add(dataPoint265);
			series1.Points.Add(dataPoint266);
			series1.Points.Add(dataPoint267);
			series1.Points.Add(dataPoint268);
			series1.Points.Add(dataPoint269);
			series1.Points.Add(dataPoint270);
			series1.Points.Add(dataPoint271);
			series1.Points.Add(dataPoint272);
			series1.Points.Add(dataPoint273);
			series1.Points.Add(dataPoint274);
			series1.Points.Add(dataPoint275);
			series1.Points.Add(dataPoint276);
			series1.Points.Add(dataPoint277);
			series1.Points.Add(dataPoint278);
			series1.Points.Add(dataPoint279);
			series1.Points.Add(dataPoint280);
			series1.Points.Add(dataPoint281);
			series1.Points.Add(dataPoint282);
			series1.Points.Add(dataPoint283);
			series1.Points.Add(dataPoint284);
			series1.Points.Add(dataPoint285);
			series1.Points.Add(dataPoint286);
			series1.Points.Add(dataPoint287);
			series1.Points.Add(dataPoint288);
			series1.Points.Add(dataPoint289);
			series1.Points.Add(dataPoint290);
			series1.Points.Add(dataPoint291);
			series1.Points.Add(dataPoint292);
			series1.Points.Add(dataPoint293);
			series1.Points.Add(dataPoint294);
			series1.Points.Add(dataPoint295);
			series1.Points.Add(dataPoint296);
			series1.Points.Add(dataPoint297);
			series1.Points.Add(dataPoint298);
			series1.Points.Add(dataPoint299);
			series1.Points.Add(dataPoint300);
			series1.Points.Add(dataPoint301);
			series1.Points.Add(dataPoint302);
			series1.Points.Add(dataPoint303);
			series1.Points.Add(dataPoint304);
			series1.Points.Add(dataPoint305);
			series1.Points.Add(dataPoint306);
			series1.Points.Add(dataPoint307);
			series1.Points.Add(dataPoint308);
			series1.Points.Add(dataPoint309);
			series1.Points.Add(dataPoint310);
			series1.Points.Add(dataPoint311);
			series1.Points.Add(dataPoint312);
			series1.Points.Add(dataPoint313);
			series1.Points.Add(dataPoint314);
			series1.Points.Add(dataPoint315);
			series1.Points.Add(dataPoint316);
			series1.Points.Add(dataPoint317);
			series1.Points.Add(dataPoint318);
			series1.Points.Add(dataPoint319);
			series1.Points.Add(dataPoint320);
			series1.Points.Add(dataPoint321);
			series1.Points.Add(dataPoint322);
			series1.Points.Add(dataPoint323);
			series1.Points.Add(dataPoint324);
			series1.Points.Add(dataPoint325);
			series1.Points.Add(dataPoint326);
			series1.Points.Add(dataPoint327);
			series1.Points.Add(dataPoint328);
			series1.Points.Add(dataPoint329);
			series1.Points.Add(dataPoint330);
			series1.Points.Add(dataPoint331);
			series1.Points.Add(dataPoint332);
			series1.Points.Add(dataPoint333);
			series1.Points.Add(dataPoint334);
			series1.Points.Add(dataPoint335);
			series1.Points.Add(dataPoint336);
			series1.Points.Add(dataPoint337);
			series1.Points.Add(dataPoint338);
			series1.Points.Add(dataPoint339);
			series1.Points.Add(dataPoint340);
			series1.Points.Add(dataPoint341);
			series1.Points.Add(dataPoint342);
			series1.Points.Add(dataPoint343);
			series1.Points.Add(dataPoint344);
			series1.Points.Add(dataPoint345);
			series1.Points.Add(dataPoint346);
			series1.Points.Add(dataPoint347);
			series1.Points.Add(dataPoint348);
			series1.Points.Add(dataPoint349);
			series1.Points.Add(dataPoint350);
			series1.Points.Add(dataPoint351);
			series1.Points.Add(dataPoint352);
			series1.Points.Add(dataPoint353);
			series1.Points.Add(dataPoint354);
			series1.Points.Add(dataPoint355);
			series1.Points.Add(dataPoint356);
			series1.Points.Add(dataPoint357);
			series1.Points.Add(dataPoint358);
			series1.Points.Add(dataPoint359);
			series1.Points.Add(dataPoint360);
			series1.Points.Add(dataPoint361);
			series1.Points.Add(dataPoint362);
			series1.Points.Add(dataPoint363);
			series1.Points.Add(dataPoint364);
			series1.Points.Add(dataPoint365);
			series1.Points.Add(dataPoint366);
			series1.Points.Add(dataPoint367);
			series1.Points.Add(dataPoint368);
			series1.Points.Add(dataPoint369);
			series1.Points.Add(dataPoint370);
			series1.Points.Add(dataPoint371);
			series1.Points.Add(dataPoint372);
			series1.Points.Add(dataPoint373);
			series1.Points.Add(dataPoint374);
			series1.Points.Add(dataPoint375);
			series1.Points.Add(dataPoint376);
			series1.Points.Add(dataPoint377);
			series1.Points.Add(dataPoint378);
			series1.Points.Add(dataPoint379);
			series1.Points.Add(dataPoint380);
			series1.Points.Add(dataPoint381);
			series1.Points.Add(dataPoint382);
			series1.Points.Add(dataPoint383);
			series1.Points.Add(dataPoint384);
			series1.Points.Add(dataPoint385);
			series1.Points.Add(dataPoint386);
			series1.Points.Add(dataPoint387);
			series1.Points.Add(dataPoint388);
			series1.Points.Add(dataPoint389);
			series1.Points.Add(dataPoint390);
			series1.Points.Add(dataPoint391);
			series1.Points.Add(dataPoint392);
			series1.Points.Add(dataPoint393);
			series1.Points.Add(dataPoint394);
			series1.Points.Add(dataPoint395);
			series1.Points.Add(dataPoint396);
			series1.Points.Add(dataPoint397);
			series1.Points.Add(dataPoint398);
			series1.Points.Add(dataPoint399);
			series1.Points.Add(dataPoint400);
			series1.Points.Add(dataPoint401);
			series1.Points.Add(dataPoint402);
			series1.Points.Add(dataPoint403);
			series1.Points.Add(dataPoint404);
			series1.Points.Add(dataPoint405);
			series1.Points.Add(dataPoint406);
			series1.Points.Add(dataPoint407);
			series1.Points.Add(dataPoint408);
			series1.Points.Add(dataPoint409);
			series1.Points.Add(dataPoint410);
			series1.Points.Add(dataPoint411);
			series1.Points.Add(dataPoint412);
			series1.Points.Add(dataPoint413);
			series1.Points.Add(dataPoint414);
			series1.Points.Add(dataPoint415);
			series1.Points.Add(dataPoint416);
			series1.Points.Add(dataPoint417);
			series1.Points.Add(dataPoint418);
			series1.Points.Add(dataPoint419);
			series1.Points.Add(dataPoint420);
			series1.Points.Add(dataPoint421);
			series1.Points.Add(dataPoint422);
			series1.Points.Add(dataPoint423);
			series1.Points.Add(dataPoint424);
			series1.Points.Add(dataPoint425);
			series1.Points.Add(dataPoint426);
			series1.Points.Add(dataPoint427);
			series1.Points.Add(dataPoint428);
			series1.Points.Add(dataPoint429);
			series1.Points.Add(dataPoint430);
			series1.Points.Add(dataPoint431);
			series1.Points.Add(dataPoint432);
			series1.Points.Add(dataPoint433);
			series1.Points.Add(dataPoint434);
			series1.Points.Add(dataPoint435);
			series1.Points.Add(dataPoint436);
			series1.Points.Add(dataPoint437);
			series1.Points.Add(dataPoint438);
			series1.Points.Add(dataPoint439);
			series1.Points.Add(dataPoint440);
			series1.Points.Add(dataPoint441);
			series1.Points.Add(dataPoint442);
			series1.Points.Add(dataPoint443);
			series1.Points.Add(dataPoint444);
			series1.Points.Add(dataPoint445);
			series1.Points.Add(dataPoint446);
			series1.Points.Add(dataPoint447);
			series1.Points.Add(dataPoint448);
			series1.Points.Add(dataPoint449);
			series1.Points.Add(dataPoint450);
			series1.Points.Add(dataPoint451);
			series1.Points.Add(dataPoint452);
			series1.Points.Add(dataPoint453);
			series1.Points.Add(dataPoint454);
			series1.Points.Add(dataPoint455);
			series1.Points.Add(dataPoint456);
			series1.Points.Add(dataPoint457);
			series1.Points.Add(dataPoint458);
			series1.Points.Add(dataPoint459);
			series1.Points.Add(dataPoint460);
			series1.Points.Add(dataPoint461);
			series1.Points.Add(dataPoint462);
			series1.Points.Add(dataPoint463);
			series1.Points.Add(dataPoint464);
			series1.Points.Add(dataPoint465);
			series1.Points.Add(dataPoint466);
			series1.Points.Add(dataPoint467);
			series1.Points.Add(dataPoint468);
			series1.Points.Add(dataPoint469);
			series1.Points.Add(dataPoint470);
			series1.Points.Add(dataPoint471);
			series1.Points.Add(dataPoint472);
			series1.Points.Add(dataPoint473);
			series1.Points.Add(dataPoint474);
			series1.Points.Add(dataPoint475);
			series1.Points.Add(dataPoint476);
			series1.Points.Add(dataPoint477);
			series1.Points.Add(dataPoint478);
			series1.Points.Add(dataPoint479);
			series1.Points.Add(dataPoint480);
			series1.Points.Add(dataPoint481);
			series1.ShadowColor = System.Drawing.Color.Black;
			series1.IsVisibleInLegend = false;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chart2.Series.Add(series1);
			this.chart2.Size = new System.Drawing.Size(412, 296);
			this.chart2.TabIndex = 1;
			title1.Alignment = System.Drawing.ContentAlignment.TopRight;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			title1.Name = "Title1";
			title1.Text = "The Central Stock Market";
			this.chart2.Titles.Add(title1);
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button1});
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 296);
			this.panel1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(56, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Generate Random Data";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LegendCells
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.chart2,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LegendCells";
			this.Size = new System.Drawing.Size(728, 480);
			this.Load += new System.EventHandler(this.LegendCustomPosition_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void LegendCustomPosition_Load(object sender, System.EventArgs e)
		{
			UpdateChart();
		}

		private void UpdateChart()
		{
			// Generate chart data
			this.GenerateData();

			// Set Y-axis minimum
			DataPoint minPoint = this.chart2.Series["Central"].Points.FindMinByValue();
			double min = minPoint.YValues[0];
			this.chart2.ChartAreas["Default"].AxisY.Minimum = min +1;

			// Set Y-axis maximum
			DataPoint maxPoint = this.chart2.Series["Central"].Points.FindMaxByValue();
			double max = maxPoint.YValues[0];
			this.chart2.ChartAreas["Default"].AxisY.Maximum = max +1;

			// Set crossing value
			double crossingValue = (max + min) / 2;
			this.chart2.ChartAreas["Default"].AxisY.Crossing = crossingValue;

			// Format axes
			this.chart2.ChartAreas["Default"].AxisY.LabelStyle.Format = "F0";
			this.chart2.ChartAreas["Default"].AxisX.LabelStyle.Format = "t";

			// Set axis marks to be on bottom
			this.chart2.ChartAreas["Default"].AxisX.IsMarksNextToAxis = false;

			// Show end labels for Y axis
			this.chart2.ChartAreas["Default"].AxisY.LabelStyle.IsEndLabelVisible = true;

			// Add custom legend item
			this.AddLegendItem();

			// Set custom legend item cell values
			this.SetLegendItemValues();
		}		
		
		// Generate data
		private void GenerateData()
		{
			this.chart2.Series["Central"].Points.Clear();

			Random random = new Random();
			double pointValue = random.Next(2389, 2451);

			DateTime date = DateTime.Parse("9:00AM");

			for (int pointIndex = 0; pointIndex < 481; pointIndex++)
			{
				pointValue = pointValue + random.NextDouble() * 8.0 - 4.0;
				chart2.Series["Central"].Points.AddXY(date.AddMinutes(pointIndex), pointValue);
			}
		}

		// Adds one custom legend item and its cells to the legend
		private void AddLegendItem()
		{
			chart2.Legends["Default"].CustomItems.Clear();

			// Add new custom legend item
			chart2.Legends["Default"].CustomItems.Add(new LegendItem("LegendItem", Color.Red, ""));
			
			// Add five new cells to the custom legend item
			chart2.Legends["Default"].CustomItems[0].Cells.Add(new LegendCell(LegendCellType.Text, "Central",ContentAlignment.MiddleLeft));
			chart2.Legends["Default"].CustomItems[0].Cells.Add(new LegendCell(LegendCellType.Text, "", ContentAlignment.MiddleRight));
			chart2.Legends["Default"].CustomItems[0].Cells.Add(new LegendCell(LegendCellType.Text, "", ContentAlignment.MiddleRight));
			chart2.Legends["Default"].CustomItems[0].Cells.Add(new LegendCell(LegendCellType.Image, "", ContentAlignment.MiddleLeft));
			chart2.Legends["Default"].CustomItems[0].Cells.Add(new LegendCell(LegendCellType.Text, "", ContentAlignment.MiddleLeft));
		}

		private void SetLegendItemValues()
		{
			int pointCount = this.chart2.Series["Central"].Points.Count;

			decimal firstPoint = (decimal)this.chart2.Series["Central"].Points[0].YValues[0];
			decimal lastPoint = decimal.Round((decimal)this.chart2.Series["Central"].Points[pointCount - 1].YValues[0], 2);
			decimal diff = decimal.Round((lastPoint - firstPoint), 2);
			decimal percentChange = decimal.Round(((diff / firstPoint) * (decimal)100.00), 2);

			System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain.MainForm mainForm = (System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain.MainForm)this.ParentForm;

			// Set appearance of cells based on percent change
			if (percentChange < 0)
			{
				chart2.Legends["Default"].CustomItems[0].Cells[2].ForeColor = Color.Red;
				chart2.Legends["Default"].CustomItems[0].Cells[3].Image = mainForm.CurrentSamplePath + @"\redsmallarrow.png";
				chart2.Legends["Default"].CustomItems[0].Cells[4].ForeColor = Color.Red;
			}

			else
			{
				chart2.Legends["Default"].CustomItems[0].Cells[2].ForeColor = Color.LimeGreen;
				chart2.Legends["Default"].CustomItems[0].Cells[3].Image = mainForm.CurrentSamplePath + @"\greensmallarrow.png";
				chart2.Legends["Default"].CustomItems[0].Cells[4].ForeColor = Color.LimeGreen;
			}
			
			chart2.Legends["Default"].CustomItems[0].Cells[0].Text = "Central";
			chart2.Legends["Default"].CustomItems[0].Cells[1].Text = lastPoint.ToString();
			chart2.Legends["Default"].CustomItems[0].Cells[2].Text = diff.ToString();
			chart2.Legends["Default"].CustomItems[0].Cells[4].Text = percentChange.ToString() + "%";
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Update chart settings
			UpdateChart();

			this.chart2.ResetAutoValues();
			this.chart2.Invalidate();
		}
	}
}
