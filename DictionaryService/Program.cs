using System;
using System.Threading;
using DictionaryService.DataAccess.Asset;
using DictionaryService.DataAccess.Country;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace DictionaryService
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                ActorRuntime.RegisterActorAsync<DictionaryService>(
                        (context, actorType) =>
                            new ActorService(context, actorType,
                                () => new DictionaryService(new AssetPairRepository(), new CountryRepository())))
                    .GetAwaiter()
                    .GetResult();

                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                ActorEventSource.Current.ActorHostInitializationFailed(e.ToString());
                throw;
            }
        }
    }
}