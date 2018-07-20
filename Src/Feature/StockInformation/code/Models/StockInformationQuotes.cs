using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace M1CP.Feature.StockInformation.Models
{
    [XmlRoot(ElementName = "header")]
    public class Header
    {
        [XmlElement(ElementName = "dataDateTime")]
        public string DataDateTime { get; set; }
        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
    }

    [XmlRoot(ElementName = "instrumentIdentifier")]
    public class InstrumentIdentifier
    {
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "nameFull")]
        public string NameFull { get; set; }
    }

    [XmlRoot(ElementName = "currency")]
    public class Currency
    {
        [XmlElement(ElementName = "currencyCode")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "currencyDesc")]
        public string CurrencyDesc { get; set; }
    }

    [XmlRoot(ElementName = "market")]
    public class Market
    {
        [XmlElement(ElementName = "marketCode")]
        public string MarketCode { get; set; }
        [XmlElement(ElementName = "marketShortDesc")]
        public string MarketShortDesc { get; set; }
        [XmlElement(ElementName = "marketFullDesc")]
        public string MarketFullDesc { get; set; }
    }

    [XmlRoot(ElementName = "sector")]
    public class Sector
    {
        [XmlElement(ElementName = "sectorCode")]
        public string SectorCode { get; set; }
        [XmlElement(ElementName = "sectorShortDesc")]
        public string SectorShortDesc { get; set; }
        [XmlElement(ElementName = "sectorFullDesc")]
        public string SectorFullDesc { get; set; }
    }

    [XmlRoot(ElementName = "status")]
    public class Status
    {
        [XmlElement(ElementName = "statusShortDesc")]
        public string StatusShortDesc { get; set; }
        [XmlElement(ElementName = "statusFullDesc")]
        public string StatusFullDesc { get; set; }
    }

    [XmlRoot(ElementName = "tradePrice")]
    public class TradePrice
    {
        [XmlElement(ElementName = "previousClose")]
        public string PreviousClose { get; set; }
        [XmlElement(ElementName = "open")]
        public string Open { get; set; }
        [XmlElement(ElementName = "last")]
        public string Last { get; set; }
        [XmlElement(ElementName = "bid")]
        public string Bid { get; set; }
        [XmlElement(ElementName = "offer")]
        public string Offer { get; set; }
        [XmlElement(ElementName = "high")]
        public string High { get; set; }
        [XmlElement(ElementName = "low")]
        public string Low { get; set; }
        [XmlElement(ElementName = "change")]
        public string Change { get; set; }
        [XmlElement(ElementName = "percentChange")]
        public string PercentChange { get; set; }
        [XmlElement(ElementName = "tickDirection")]
        public string TickDirection { get; set; }
        [XmlElement(ElementName = "totalValue")]
        public string TotalValue { get; set; }
        [XmlElement(ElementName = "boardLotSize")]
        public string BoardLotSize { get; set; }
        [XmlElement(ElementName = "etfClose")]
        public string EtfClose { get; set; }
    }

    [XmlRoot(ElementName = "tradeVolume")]
    public class TradeVolume
    {
        [XmlElement(ElementName = "bidVolume")]
        public string BidVolume { get; set; }
        [XmlElement(ElementName = "offerVolume")]
        public string OfferVolume { get; set; }
        [XmlElement(ElementName = "totalVolume")]
        public string TotalVolume { get; set; }
    }

    [XmlRoot(ElementName = "equityDomain")]
    public class EquityDomain
    {
        [XmlElement(ElementName = "instrumentIdentifier")]
        public InstrumentIdentifier InstrumentIdentifier { get; set; }
        [XmlElement(ElementName = "currency")]
        public Currency Currency { get; set; }
        [XmlElement(ElementName = "market")]
        public Market Market { get; set; }
        [XmlElement(ElementName = "sector")]
        public Sector Sector { get; set; }
        [XmlElement(ElementName = "status")]
        public Status Status { get; set; }
        [XmlElement(ElementName = "tradePrice")]
        public TradePrice TradePrice { get; set; }
        [XmlElement(ElementName = "tradeVolume")]
        public TradeVolume TradeVolume { get; set; }
    }

    [XmlRoot(ElementName = "equityDomainGroup")]
    public class EquityDomainGroup
    {
        [XmlElement(ElementName = "equityDomain")]
        public EquityDomain EquityDomain { get; set; }
    }

    [XmlRoot(ElementName = "snap")]
    public class Snap
    {
        [XmlElement(ElementName = "indexDomainGroup")]
        public string IndexDomainGroup { get; set; }
        [XmlElement(ElementName = "equityDomainGroup")]
        public EquityDomainGroup EquityDomainGroup { get; set; }
    }

    [XmlRoot(ElementName = "pricefeed")]
    public class Pricefeed
    {
        [XmlElement(ElementName = "header")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "snap")]
        public Snap Snap { get; set; }
    }
}