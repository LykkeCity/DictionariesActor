using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets;

namespace DictionaryService.DataAccess.Asset
{
    public class MarginalAssetRepository : IAssetRepository
    {
        public Task<IEnumerable<Lykke.Core.Domain.Assets.Models.Asset>> GetAllAsync()
        {
            IEnumerable<Lykke.Core.Domain.Assets.Models.Asset> assets = new List
                <Lykke.Core.Domain.Assets.Models.Asset>
                {
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "BTC",
                        Name = "BTC",
                        Symbol = "฿",
                        Accuracy = 8,
                        Multiplier = 0.00000001,
                        DustLimit = 0.0000273,
                        IdIssuer = "BTC"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "CHF",
                        Name = "CHF",
                        Symbol = "₣",
                        Accuracy = 2,
                        Multiplier = 0.01,
                        DustLimit = 0,
                        IdIssuer = "LKE"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "ETH",
                        Name = "ETH",
                        Symbol = "Ξ",
                        Accuracy = 6,
                        Multiplier = 0,
                        DustLimit = 0,
                        IdIssuer = "BTC"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "EUR",
                        Name = "EUR",
                        Symbol = "€",
                        Accuracy = 2,
                        Multiplier = 0.01,
                        DustLimit = 0,
                        IdIssuer = "LKE"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "GBP",
                        Name = "GBP",
                        Symbol = "£",
                        Accuracy = 2,
                        Multiplier = 0.01,
                        DustLimit = 0,
                        IdIssuer = "LKE"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "ICO",
                        Name = "IATA coin",
                        Symbol = "ICO",
                        Accuracy = 2,
                        Multiplier = 1,
                        DustLimit = 0,
                        IdIssuer = "LKE"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "JPY",
                        Name = "JPY",
                        Symbol = "¥",
                        Accuracy = 2,
                        Multiplier = 0.01,
                        DustLimit = 0,
                        IdIssuer = "LKE"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "LKK",
                        Name = "LYKKE",
                        Symbol = "LKK",
                        Accuracy = 0,
                        Multiplier = 0.000001,
                        DustLimit = 0,
                        IdIssuer = "LKE"
                    },
                    new Lykke.Core.Domain.Assets.Models.Asset
                    {
                        Id = "USD",
                        Name = "USD",
                        Symbol = "$",
                        Accuracy = 2,
                        Multiplier = 0.01,
                        DustLimit = 0,
                        IdIssuer = "LKE"
                    }
                };

            return Task.FromResult(assets);
        }
    }
}