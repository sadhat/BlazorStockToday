namespace StockToday
{
    public class CompanyInfo
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public string PrimaryExchange { get; set; }
        public string Sector { get; set; }
        public string CalculationPrice { get; set; }
        public double open { get; set; }
        public object openTime { get; set; }
        public double close { get; set; }
        public object closeTime { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public object latestUpdate { get; set; }
        public int latestVolume { get; set; }
        public double iexRealtimePrice { get; set; }
        public int iexRealtimeSize { get; set; }
        public object iexLastUpdated { get; set; }
        public double delayedPrice { get; set; }
        public object delayedPriceTime { get; set; }
        public double extendedPrice { get; set; }
        public double extendedChange { get; set; }
        public double extendedChangePercent { get; set; }
        public object extendedPriceTime { get; set; }
        public double previousClose { get; set; }
        public double change { get; set; }
        public double changePercent { get; set; }
        public double iexMarketPercent { get; set; }
        public int iexVolume { get; set; }
        public int avgTotalVolume { get; set; }
        public int iexBidPrice { get; set; }
        public int iexBidSize { get; set; }
        public int iexAskPrice { get; set; }
        public int iexAskSize { get; set; }
        public object marketCap { get; set; }
        public double? peRatio { get; set; }
        public double week52High { get; set; }
        public double week52Low { get; set; }
        public double ytdChange { get; set; }

        public double changePercentExtended=> changePercent * 100;
    }

    public class SPY
    {
        public CompanyInfo quote { get; set; }
    }

    public class DIA
    {
        public CompanyInfo quote { get; set; }
    }

    public class Market{
        public DIA DIA { get; set; }
        public SPY SPY { get; set; }
    }

    public class LatestCompanyStock
    {
        public string symbol { get; set; }
        public string sector { get; set; }
        public string securityType { get; set; }
        public double bidPrice { get; set; }
        public int bidSize { get; set; }
        public double askPrice { get; set; }
        public int askSize { get; set; }
        public long lastUpdated { get; set; }
        public double lastSalePrice { get; set; }
        public int lastSaleSize { get; set; }
        public long lastSaleTime { get; set; }
        public int volume { get; set; }
        public double marketPercent { get; set; }
        public int seq { get; set; }
    }
}
