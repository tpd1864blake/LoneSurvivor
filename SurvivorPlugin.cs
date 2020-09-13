using System;
using Exiled.API.Features;
using Exiled.API.Enums;
using EPlayer = Exiled.API.Features.Player;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace LoneSurvivor
{
    internal class SurvivorPlugin : Plugin<Config>
    {
        public override string Name { get; } = "LoneSurvivor";
        public override string Author { get; } = "tpd1864blake";
        private static readonly Lazy<SurvivorPlugin> LazyInstance = new Lazy<SurvivorPlugin>(() => new SurvivorPlugin());
        public static SurvivorPlugin Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Highest;

        private Handlers.Player player;
        private Handlers.Server server;

        private SurvivorPlugin()
        {
        }

        public override void OnEnabled()
        {
            if (Config.IsEnabled == false)
            {
                return;
            }
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.WaitingForPlayers += server.OnWaitingForPlayers;

            Player.Left += player.OnDisconnect;
            Player.ChangingRole += player.OnChangingRole;
        }

        public void UnregisterEvents()
        {
            Server.WaitingForPlayers -= server.OnWaitingForPlayers;

            Player.Left -= player.OnDisconnect;
            Player.ChangingRole -= player.OnChangingRole;

            player = null;
            server = null;
        }
    }
}
