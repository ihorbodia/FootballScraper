using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betfair_Football_Markets
{
    class ConstMarketWrapper : MarketWrapper
    {
        public ConstMarketWrapper(MarketNode n) : base(n)
        {
        }
        string id;
		string comment;
		double[] options;
        public ConstMarketWrapper(string[] values) : base(null)
        {
			comment = values[0];
			id = NormalizeMechantId(values[1]);
            options = Array.ConvertAll(values.Skip(2).ToArray(), x =>{
                double d;
                if (!double.TryParse(x, out d))
                    return double.NaN;
                return d;
            });
        }

		public string Comment { get => comment; }
		public override string MarketID { get => id; }
        public override double Option1 { get => options.Length < 1 ? double.NaN : options[0]; }
        public override double Option2 { get => options.Length < 2 ? double.NaN : options[1]; }
        public override double Option3 { get => options.Length < 3 ? double.NaN : options[2]; }
        public override double Option4 { get => options.Length < 4 ? double.NaN : options[2]; }
        public override double Option5 { get => options.Length < 5 ? double.NaN : options[2]; }
        public override double Option6 { get => options.Length < 6 ? double.NaN : options[2]; }
        public override double Option7 { get => options.Length < 7 ? double.NaN : options[2]; }
        public override double Option8 { get => options.Length < 8 ? double.NaN : options[2]; }
        public override double Option9 { get => options.Length < 9 ? double.NaN : options[2]; }
        public override double Option10 { get => options.Length < 10 ? double.NaN : options[2]; }
        public override double Option11 { get => options.Length < 11 ? double.NaN : options[2]; }
        public override double Option12 { get => options.Length < 12 ? double.NaN : options[2]; }
        public override double Option13 { get => options.Length < 13 ? double.NaN : options[2]; }
        public override double Option14 { get => options.Length < 14 ? double.NaN : options[2]; }
        public override double Option15 { get => options.Length < 15 ? double.NaN : options[2]; }
        public override double Option16 { get => options.Length < 16 ? double.NaN : options[2]; }
        public override double Option17 { get => options.Length < 17 ? double.NaN : options[2]; }
        public override double Option18 { get => options.Length < 18 ? double.NaN : options[2]; }
        public override double Option19 { get => options.Length < 19 ? double.NaN : options[2]; }
        public override double Option20 { get => options.Length < 20 ? double.NaN : options[2]; }



        private string NormalizeMechantId(string value)
        {
            string result = value;
            double res;


            if (!value.Contains("."))
            {
                result = value.Insert(1, ".");
            }
            if (double.TryParse(result, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
            {
                result = string.Format("{0:0.####00000}", res);
            }
            return result;
        }
    }
}
