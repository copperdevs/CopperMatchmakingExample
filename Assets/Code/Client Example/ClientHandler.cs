using System;
using CopperMatchmaking.Client;
using CopperMatchmaking.Info;
using Riptide;
using Random = UnityEngine.Random;

namespace CopperMatchmaking.Example.Client
{
    public class ClientHandler : IClientHandler
    {
        public ulong ClientRequestedToHost()
        {
            var serverJoinCode = (ulong)Random.Range(0, 1000000000000f);
            Log.Info($"join code: {serverJoinCode}");
            return serverJoinCode;
        }

        public void JoinServer(ulong serverJoinCode)
        {
            Log.Info($"join code: {serverJoinCode}");
        }

        public void Disconnected(DisconnectReason reason)
        {
            Log.Info($"disconnect :(");
        }
    }
}