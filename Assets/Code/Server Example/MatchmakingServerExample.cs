using CopperMatchmaking.Data;
using CopperMatchmaking.Info;
using UnityEngine;
using CopperMatchmaking.Server;

namespace CopperMatchmaking.Example.Server
{
    public class MatchmakingServerExample : MonoBehaviour
    {
        [SerializeField] private Rank[] ranks;
        private MatchmakerServer server;
        
        private void Start()
        {
            CopperLogger.Initialize(Debug.Log, Debug.LogWarning, Debug.LogError);

            server = new MatchmakerServer(new ServerHandler(), 4);
            server.RegisterRanks(ranks);
        }

        private void Update()
        {
            server.Update();
        }
    }
}