using System;
using System.Linq;

namespace Betfair_Football_Markets
{
    internal class RatioData
    {
        private double rt1;
        private double rt2;
        private double rt3;
        private double rt4;
        private double rt5;
        private double rt6;
        private double rt7;
        private double rt8;
        private double rt9;
        private double rt10;
        private double rt11;
        private double rt12;
        private double rt13;
        private double rt14;
        private double rt15;
        private double rt16;
        private double rt17;
        private double rt18;
        private double rt19;
        private double rt20;

        private double opt1;
        private double opt2;
        private double opt3;
        private double opt4;
        private double opt5;
        private double opt6;
        private double opt7;
        private double opt8;
        private double opt9;
        private double opt10;
        private double opt11;
        private double opt12;
        private double opt13;
        private double opt14;
        private double opt15;
        private double opt16;
        private double opt17;
        private double opt18;
        private double opt19;
        private double opt20;

        private string rn1;
        private string rn2;
        private string rn3;
        private string rn4;
        private string rn5;
        private string rn6;
        private string rn7;
        private string rn8;
        private string rn9;
        private string rn10;
        private string rn11;
        private string rn12;
        private string rn13;
        private string rn14;
        private string rn15;
        private string rn16;
        private string rn17;
        private string rn18;
        private string rn19;
        private string rn20;

        private string mid;
		private string comment;
		public RatioData(double rt1, double rt2, double rt3, double rt4, double rt5, double rt6, double rt7, double rt8, double rt9, double rt10, double rt11, double rt12, double rt13, double rt14, double rt15, double rt16, double rt17, double rt18, double rt19, double rt20,
            string rn1, string rn2, string rn3, string rn4, string rn5, string rn6, string rn7, string rn8, string rn9, string rn10, string rn11, string rn12, string rn13, string rn14, string rn15, string rn16, string rn17, string rn18, string rn19, string rn20, string mid, 
            double opt1, double opt2, double opt3, double opt4, double opt5, double opt6, double opt7, double opt8, double opt9, double opt10, double opt11, double opt12, double opt13, double opt14,
            double opt15, double opt16, double opt17, double opt18, double opt19, double opt20, string comment)
        {
            this.rt1 = rt1;
            this.rt2 = rt2;
            this.rt3 = rt3;
            this.rt4 = rt4;
            this.rt5 = rt5;
            this.rt6 = rt6;
            this.rt7 = rt7;
            this.rt8 = rt8;
            this.rt9 = rt9;
            this.rt10 = rt10;
            this.rt11 = rt11;
            this.rt12 = rt12;
            this.rt13 = rt13;
            this.rt14 = rt14;
            this.rt15 = rt15;
            this.rt16 = rt16;
            this.rt17 = rt17;
            this.rt18 = rt18;
            this.rt19 = rt19;
            this.rt20 = rt20;

            this.opt1 = opt1;
            this.opt2 = opt2;
            this.opt3 = opt3;
            this.opt4 = opt4;
            this.opt5 = opt5;
            this.opt6 = opt6;
            this.opt7 = opt7;
            this.opt8 = opt8;
            this.opt9 = opt9;
            this.opt10 = opt10;
            this.opt11 = opt11;
            this.opt12 = opt12;
            this.opt13 = opt13;
            this.opt14 = opt14;
            this.opt15 = opt15;
            this.opt16 = opt16;
            this.opt17 = opt17;
            this.opt18 = opt18;
            this.opt19 = opt19;
            this.opt20 = opt20;

            this.rn1 = rn1;
            this.rn2 = rn2;
            this.rn3 = rn3;
            this.rn4 = rn4;
            this.rn5 = rn5;
            this.rn6 = rn6;
            this.rn7 = rn7;
            this.rn8 = rn8;
            this.rn9 = rn9;
            this.rn10 = rn10;
            this.rn11 = rn11;
            this.rn12 = rn12;
            this.rn13 = rn13;
            this.rn14 = rn14;
            this.rn15 = rn15;
            this.rn16 = rn16;
            this.rn17 = rn17;
            this.rn18 = rn18;
            this.rn19 = rn19;
            this.rn20 = rn20;
            this.mid = mid;
			this.comment = comment;
        }

        public string MarketID { get => mid; }
		public string Comment { get => comment; }

		public string Name_1 { get => rn1; }
        public string Perc_1 { get => (rt1 * 100).ToString(".00"); }

        public string Name_2 { get => rn2; }
        public string Perc_2 { get => (rt2 * 100).ToString(".00"); }

        public string Option2 { get => (opt2).ToString(".##"); }

        public string Name_3 { get => rn3; }
        public string Perc_3 { get => (rt3 * 100).ToString(".00"); }
        public string Option3 { get => (opt3).ToString(".##"); }

        public string Name_4 { get => rn4; }
        public string Perc_4 { get => (rt4 * 100).ToString(".00"); }
        public string Option4 { get => (opt4).ToString(".##"); }

        public string Name_5 { get => rn5; }
        public string Perc_5 { get => (rt5 * 100).ToString(".00"); }
        public string Option5 { get => (opt5).ToString(".##"); }

        public string Name_6 { get => rn6; }
        public string Perc_6 { get => (rt6 * 100).ToString(".00"); }
        public string Option6 { get => (opt6).ToString(".##"); }

        public string Name_7 { get => rn7; }
        public string Perc_7 { get => (rt7 * 100).ToString(".00"); }
        public string Option7 { get => (opt7).ToString(".##"); }

        public string Name_8 { get => rn8; }
        public string Perc_8 { get => (rt8 * 100).ToString(".00"); }
        public string Option8 { get => (opt8).ToString(".##"); }

        public string Name_9 { get => rn9; }
        public string Perc_9 { get => (rt9 * 100).ToString(".00"); }
        public string Option9 { get => (opt9).ToString(".##"); }

        public string Name_10 { get => rn10; }
        public string Perc_10 { get => (rt10 * 100).ToString(".00"); }
        public string Option10 { get => (opt10).ToString(".##"); }

        public string Name_11 { get => rn11; }
        public string Perc_11 { get => (rt11 * 100).ToString(".00"); }
        public string Option11 { get => (opt11).ToString(".##"); }

        public string Name_12 { get => rn12; }
        public string Perc_12 { get => (rt12 * 100).ToString(".00"); }
        public string Option12 { get => (opt12).ToString(".##"); }

        public string Name_13 { get => rn13; }
        public string Perc_13 { get => (rt13 * 100).ToString(".00"); }
        public string Option13 { get => (opt13).ToString(".##"); }

        public string Name_14 { get => rn14; }
        public string Perc_14 { get => (rt14 * 100).ToString(".00"); }
        public string Option14 { get => (opt14).ToString(".##"); }

        public string Name_15 { get => rn15; }
        public string Perc_15 { get => (rt15 * 100).ToString(".00"); }
        public string Option15 { get => (opt15).ToString(".##"); }

        public string Name_16 { get => rn16; }
        public string Perc_16 { get => (rt16 * 100).ToString(".00"); }
        public string Option16 { get => (opt16).ToString(".##"); }

        public string Name_17 { get => rn17; }
        public string Perc_17 { get => (rt17 * 100).ToString(".00"); }
        public string Option17 { get => (opt17).ToString(".##"); }

        public string Name_18 { get => rn18; }
        public string Perc_18 { get => (rt18 * 100).ToString(".00"); }
        public string Option18 { get => (opt18).ToString(".##"); }

        public string Name_19 { get => rn19; }
        public string Perc_19 { get => (rt19 * 100).ToString(".00"); }
        public string Option19 { get => (opt19).ToString(".##"); }

        public string Name_20 { get => rn20; }
        public string Perc_20 { get => (rt20 * 100).ToString(".00"); }
        public string Option20 { get => (opt20).ToString(".##"); }

        internal double GetRt1()
        {
            return rt1;
        }

        internal double GetRt2()
        {
            return rt2;
        }

        internal double GetRt3()
        {
            return rt3;
        }

        public double[] GetSortedData()
        {
            return (new double[] { rt1, rt2, rt3 }).OrderByDescending(x => x).ToArray();
        }

        internal object GetMarketID()
        {
            return mid;
        }
    }
}