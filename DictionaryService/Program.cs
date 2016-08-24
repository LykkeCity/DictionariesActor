﻿using System;
using System.Threading;
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
                   (context, actorType) => new ActorService(context, actorType, () => new DictionaryService())).GetAwaiter().GetResult();

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
