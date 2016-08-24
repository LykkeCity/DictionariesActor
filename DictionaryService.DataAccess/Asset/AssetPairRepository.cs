using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Assets;
using Core.Domain.Assets.Models;

namespace DictionaryService.DataAccess.Asset
{
    public class AssetPairRepository : IAssetPairRepository
    {
        public Task<IEnumerable<AssetPair>> GetAllAssetPairsAsync()
        {
            IEnumerable<AssetPair> assetPairs = new List<AssetPair>
            {
                new AssetPair
                {
                    Id = "BTCCHF",
                    Name = "BTC/CHF",
                    BaseAssetId = "BTC",
                    QuotingAssetId = "CHF",
                    Accuracy = 3,
                    InvertedAccuracy = 7
                },
                new AssetPair
                {
                    Id = "BTCEUR",
                    Name = "BTC/EUR",
                    BaseAssetId = "BTC",
                    QuotingAssetId = "EUR",
                    Accuracy = 3,
                    InvertedAccuracy = 7
                },
                new AssetPair
                {
                    Id = "BTCGBP",
                    Name = "BTC/GBP",
                    BaseAssetId = "BTC",
                    QuotingAssetId = "GBP",
                    Accuracy = 3,
                    InvertedAccuracy = 7
                },
                new AssetPair
                {
                    Id = "BTCJPY",
                    Name = "BTC/JPY",
                    BaseAssetId = "BTC",
                    QuotingAssetId = "JPY",
                    Accuracy = 2,
                    InvertedAccuracy = 7
                },
                new AssetPair
                {
                    Id = "BTCLKK",
                    Name = "BTC/LYKKE",
                    BaseAssetId = "BTC",
                    QuotingAssetId = "LKK",
                    Accuracy = 2,
                    InvertedAccuracy = 7
                },
                new AssetPair
                {
                    Id = "BTCUSD",
                    Name = "BTC/ddd",
                    BaseAssetId = "BTC",
                    QuotingAssetId = "USD",
                    Accuracy = 3,
                    InvertedAccuracy = 7
                },
                new AssetPair
                {
                    Id = "CHFJPY",
                    Name = "CHF/JPY",
                    BaseAssetId = "CHF",
                    QuotingAssetId = "JPY",
                    Accuracy = 3,
                    InvertedAccuracy = 3
                },
                new AssetPair
                {
                    Id = "ETHBTC",
                    Name = "ETH/BTC",
                    BaseAssetId = "ETH",
                    QuotingAssetId = "BTC",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "ETHUSD",
                    Name = "ETH/USD",
                    BaseAssetId = "ETH",
                    QuotingAssetId = "USD",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "EURCHF",
                    Name = "EUR/CHF",
                    BaseAssetId = "EUR",
                    QuotingAssetId = "CHF",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "EURGBP",
                    Name = "EUR/GBP",
                    BaseAssetId = "EUR",
                    QuotingAssetId = "GBP",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "EURJPY",
                    Name = "EUR/JPY",
                    BaseAssetId = "EUR",
                    QuotingAssetId = "JPY",
                    Accuracy = 3,
                    InvertedAccuracy = 3
                },
                new AssetPair
                {
                    Id = "EURUSD",
                    Name = "EUR/USD",
                    BaseAssetId = "EUR",
                    QuotingAssetId = "USD",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "GBPCHF",
                    Name = "GBP/CHF",
                    BaseAssetId = "GBP",
                    QuotingAssetId = "CHF",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "GBPJPY",
                    Name = "GBP/JPY",
                    BaseAssetId = "GBP",
                    QuotingAssetId = "JPY",
                    Accuracy = 3,
                    InvertedAccuracy = 3
                },
                new AssetPair
                {
                    Id = "GBPUSD",
                    Name = "GBP/USD",
                    BaseAssetId = "GBP",
                    QuotingAssetId = "USD",
                    Accuracy = 5,
                    InvertedAccuracy = 3
                },
                new AssetPair
                {
                    Id = "ICOCHF",
                    Name = "ICO/CHF",
                    BaseAssetId = "ICO",
                    QuotingAssetId = "CHF",
                    Accuracy = 2,
                    InvertedAccuracy = 2
                },
                new AssetPair
                {
                    Id = "ICOEUR",
                    Name = "ICO/EUR",
                    BaseAssetId = "ICO",
                    QuotingAssetId = "EUR",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "ICOGBP",
                    Name = "ICO/GBP",
                    BaseAssetId = "ICO",
                    QuotingAssetId = "GBP",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "ICOUSD",
                    Name = "ICO/USD",
                    BaseAssetId = "ICO",
                    QuotingAssetId = "USD",
                    Accuracy = 3,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "LKKCHF",
                    Name = "LYKKE/CHF",
                    BaseAssetId = "LKK",
                    QuotingAssetId = "CHF",
                    Accuracy = 5,
                    InvertedAccuracy = 2
                },
                new AssetPair
                {
                    Id = "LKKEUR",
                    Name = "LYKKE/EUR",
                    BaseAssetId = "LKK",
                    QuotingAssetId = "EUR",
                    Accuracy = 5,
                    InvertedAccuracy = 2
                },
                new AssetPair
                {
                    Id = "LKKGBP",
                    Name = "LYKKE/GBP",
                    BaseAssetId = "LKK",
                    QuotingAssetId = "GBP",
                    Accuracy = 5,
                    InvertedAccuracy = 2
                },
                new AssetPair
                {
                    Id = "LKKJPY",
                    Name = "LYKKE/JPY",
                    BaseAssetId = "LKK",
                    QuotingAssetId = "JPY",
                    Accuracy = 3,
                    InvertedAccuracy = 2
                },
                new AssetPair
                {
                    Id = "LKKUSD",
                    Name = "LYKKE/USD",
                    BaseAssetId = "LKK",
                    QuotingAssetId = "USD",
                    Accuracy = 5,
                    InvertedAccuracy = 2
                },
                new AssetPair
                {
                    Id = "USDCHF",
                    Name = "USD/CHF",
                    BaseAssetId = "USD",
                    QuotingAssetId = "CHF",
                    Accuracy = 5,
                    InvertedAccuracy = 5
                },
                new AssetPair
                {
                    Id = "USDJPY",
                    Name = "USD/JPY",
                    BaseAssetId = "USD",
                    QuotingAssetId = "JPY",
                    Accuracy = 3,
                    InvertedAccuracy = 5
                }
            };

            return Task.FromResult(assetPairs);
        }
    }
}