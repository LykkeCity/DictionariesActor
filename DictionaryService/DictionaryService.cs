using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets;
using Lykke.Core.Domain.Assets.Models;
using Lykke.Core.Domain.Country;
using Lykke.Core.Domain.Country.Models;
using Lykke.Core.Domain.Dictionary;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace DictionaryService
{
    [StatePersistence(StatePersistence.Persisted)]
    internal class DictionaryService : Actor, IDictionaryService
    {
        private readonly IAssetPairRepository _assetPairRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IAssetPairRepository _marginalAssetPairRepository;
        private readonly IAssetRepository _marginalAssetRepository;
        private readonly IIssuerRepository _marginalIssuerRepository;

        public DictionaryService(IAssetPairRepository assetPairRepository, ICountryRepository countryRepository,
            IAssetPairRepository marginalAssetPairRepository, IIssuerRepository marginalIssuerRepository,
            IAssetRepository marginalAssetRepository)
        {
            _assetPairRepository = assetPairRepository;
            _countryRepository = countryRepository;
            _marginalAssetPairRepository = marginalAssetPairRepository;
            _marginalIssuerRepository = marginalIssuerRepository;
            _marginalAssetRepository = marginalAssetRepository;
        }

        public Task<IEnumerable<AssetPair>> GetAssetPairsAsync()
        {
            return StateManager.GetStateAsync<IEnumerable<AssetPair>>("AssetPairs");
        }

        public async Task<IEnumerable<CountryItem>> GetCountriesAsync(string language)
        {
            return await _countryRepository.GetAllAsync(language);
        }

        public Task<IEnumerable<AssetPair>> GetMarginalAssetPairsAsync()
        {
            return StateManager.GetStateAsync<IEnumerable<AssetPair>>("MarginalAssetPairs");
        }

        public Task<IEnumerable<Issuer>> GetMarginalIssuersAsync()
        {
            return StateManager.GetStateAsync<IEnumerable<Issuer>>("MarginalIssuers");
        }

        public Task<IEnumerable<Asset>> GetMarginalAssetsAsync()
        {
            return StateManager.GetStateAsync<IEnumerable<Asset>>("MarginalAssets");
        }

        protected override async Task OnActivateAsync()
        {
            ActorEventSource.Current.ActorMessage(this, "Actor activated.");

            var assetPairs = await _assetPairRepository.GetAllAsync();
            var marginalAssetPairs = await _marginalAssetPairRepository.GetAllAsync();
            var marginalIssuers = await _marginalIssuerRepository.GetAllAsync();
            var marginalAssets = await _marginalAssetRepository.GetAllAsync();

            await StateManager.TryAddStateAsync("AssetPairs", assetPairs);
            await StateManager.TryAddStateAsync("MarginalAssetPairs", marginalAssetPairs);
            await StateManager.TryAddStateAsync("MarginalIssuers", marginalIssuers);
            await StateManager.TryAddStateAsync("MarginalAssets", marginalAssets);
        }
    }
}