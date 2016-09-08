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

        public DictionaryService(IAssetPairRepository assetPairRepository, ICountryRepository countryRepository)
        {
            _assetPairRepository = assetPairRepository;
            _countryRepository = countryRepository;
        }

        public Task<IEnumerable<AssetPair>> GetAssetPairsAsync()
        {
            return StateManager.GetStateAsync<IEnumerable<AssetPair>>("AssetPairs");
        }

        public async Task<IEnumerable<CountryItem>> GetCountriesAsync(string language)
        {
            return await _countryRepository.GetAllAsync(language);
        }

        protected override async Task OnActivateAsync()
        {
            ActorEventSource.Current.ActorMessage(this, "Actor activated.");

            var assetPairs = await _assetPairRepository.GetAllAssetPairsAsync();

            await StateManager.TryAddStateAsync("AssetPairs", assetPairs);
        }
    }
}