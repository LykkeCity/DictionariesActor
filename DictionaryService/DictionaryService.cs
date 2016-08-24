using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Assets;
using Core.Domain.Assets.Models;
using Core.Domain.Dictionary;
using DictionaryService.DataAccess.Asset;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace DictionaryService
{
    [StatePersistence(StatePersistence.Persisted)]
    internal class DictionaryService : Actor, IDictionaryService
    {
        private readonly IAssetPairRepository _assetPairRepository;

        public DictionaryService()
        {
            _assetPairRepository = new AssetPairRepository();
        }

        protected override async Task OnActivateAsync()
        {
            ActorEventSource.Current.ActorMessage(this, "Actor activated.");

            var assetPairs = await _assetPairRepository.GetAllAssetPairsAsync();

            await this.StateManager.TryAddStateAsync("AssetPairs", assetPairs);

            return;
        }

        public Task<IEnumerable<AssetPair>> GetAssetPairsAsync()
        {
            return this.StateManager.GetStateAsync<IEnumerable<AssetPair>>("AssetPairs");
        }
    }
}
