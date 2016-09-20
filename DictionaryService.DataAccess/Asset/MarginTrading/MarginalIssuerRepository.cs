using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets;
using Lykke.Core.Domain.Assets.Models;

namespace DictionaryService.DataAccess.Asset.MarginTrading
{
    public class MarginalIssuerRepository : IIssuerRepository
    {
        public Task<IEnumerable<Issuer>> GetAllAsync()
        {
            IEnumerable<Issuer> issuers = new List<Issuer>
            {
                new Issuer
                {
                    Id = "BTC",
                    Name = "BITCOIN"
                },
                new Issuer
                {
                    Id = "LKE",
                    Name = "LYKKE"
                }
            };

            return Task.FromResult(issuers);
        }
    }
}