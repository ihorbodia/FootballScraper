using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betfair_Football_Markets
{
    class Market
    {
        public string CurrencyCode { get; set; }
        public EventType[] EventTypes { get; set; }
        public string Indicative { get; set; }
    }

    public class EventType
    {
        public string EventTypeId { get; set; }
        public EventNode[] EventNodes { get; set; }
    }

    public class EventNode
    {
        public string EventId { get; set; }
        public MarketNode[] MarketNodes { get; set; }
    }

    public class MarketNode
    {
        public string MarketId { get; set; }
        public string IsMarketDataDelayed { get; set; }
        public Runner[] Runners { get; set; }
    }

    public class Runner
    {
        public string SelectionId { get; set; }
        public string Handicap { get; set; }
        public Description Description { get; set; }
        public Exchange Exchange;
    }

    public class Exchange
    {
        public PriceWrapper[] AvailableToBack { get; set; }
        public PriceWrapper[] AvailableToLay { get; set; }
    }

    public class PriceWrapper
    {
        public double Price { get; set; }
        public string Size { get; set; }
    }

    public class Description
    {
        public string RunnerName { get; set; }
    }

    public class RunnerWrapper
    {
        private Runner r;

        public RunnerWrapper(Runner r)
        {
            this.r = r;
        }

        public string RunnerName { get { return r.Description.RunnerName; } }
        public double LayAll
        {
            get => r.Exchange.AvailableToLay == null || r.Exchange.AvailableToLay.Length < 1 ? double.NaN : r.Exchange.AvailableToLay[0].Price;
        }
    }

    public class MarketWrapper
    {
        private MarketNode n;

        public MarketWrapper(MarketNode n)
        {
            this.n = n;
        }

        public virtual string MarketID { get => n.MarketId; }
        public virtual double Option1 { get => n.Runners.Length < 1 ? double.NaN : (new RunnerWrapper(n.Runners[0])).LayAll; }
        public virtual double Option2 { get => n.Runners.Length < 2 ? double.NaN : (new RunnerWrapper(n.Runners[1])).LayAll; }
        public virtual double Option3 { get => n.Runners.Length < 3 ? double.NaN : (new RunnerWrapper(n.Runners[2])).LayAll; }
        public virtual double Option4 { get => n.Runners.Length < 4 ? double.NaN : (new RunnerWrapper(n.Runners[3])).LayAll; }
        public virtual double Option5 { get => n.Runners.Length < 5 ? double.NaN : (new RunnerWrapper(n.Runners[4])).LayAll; }
        public virtual double Option6 { get => n.Runners.Length < 6 ? double.NaN : (new RunnerWrapper(n.Runners[5])).LayAll; }
        public virtual double Option7 { get => n.Runners.Length < 7 ? double.NaN : (new RunnerWrapper(n.Runners[6])).LayAll; }
        public virtual double Option8 { get => n.Runners.Length < 8 ? double.NaN : (new RunnerWrapper(n.Runners[7])).LayAll; }
        public virtual double Option9 { get => n.Runners.Length < 9 ? double.NaN : (new RunnerWrapper(n.Runners[8])).LayAll; }
        public virtual double Option10 { get => n.Runners.Length < 10 ? double.NaN : (new RunnerWrapper(n.Runners[9])).LayAll; }
        public virtual double Option11 { get => n.Runners.Length < 11 ? double.NaN : (new RunnerWrapper(n.Runners[10])).LayAll; }
        public virtual double Option12 { get => n.Runners.Length < 12 ? double.NaN : (new RunnerWrapper(n.Runners[11])).LayAll; }
        public virtual double Option13 { get => n.Runners.Length < 13 ? double.NaN : (new RunnerWrapper(n.Runners[12])).LayAll; }
        public virtual double Option14 { get => n.Runners.Length < 14 ? double.NaN : (new RunnerWrapper(n.Runners[13])).LayAll; }
        public virtual double Option15 { get => n.Runners.Length < 15 ? double.NaN : (new RunnerWrapper(n.Runners[14])).LayAll; }
        public virtual double Option16 { get => n.Runners.Length < 16 ? double.NaN : (new RunnerWrapper(n.Runners[15])).LayAll; }
        public virtual double Option17 { get => n.Runners.Length < 17 ? double.NaN : (new RunnerWrapper(n.Runners[16])).LayAll; }
        public virtual double Option18 { get => n.Runners.Length < 18 ? double.NaN : (new RunnerWrapper(n.Runners[17])).LayAll; }
        public virtual double Option19 { get => n.Runners.Length < 19 ? double.NaN : (new RunnerWrapper(n.Runners[18])).LayAll; }
        public virtual double Option20 { get => n.Runners.Length < 20 ? double.NaN : (new RunnerWrapper(n.Runners[19])).LayAll; }

        public MarketNode GetNode()
        {
            return n;
        }
    }
}
