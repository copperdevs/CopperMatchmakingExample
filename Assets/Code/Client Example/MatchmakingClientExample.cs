using System;
using CopperMatchmaking.Client;
using CopperMatchmaking.Info;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CopperMatchmaking.Example.Client
{
    public class MatchmakingClientExample : MonoBehaviour
    {
        private MatchmakerClient client;

        private void Start()
        {
            CopperLogger.Initialize(Debug.Log, Debug.LogWarning, Debug.LogError);
            client = new MatchmakerClient("127.0.0.1", new ClientHandler(), 1, (ulong)Random.Range(0, 1000000000000f));
        }

        private void Update()
        {
            // if (client.ShouldUpdate)
                client.Update();
        }
    }
}