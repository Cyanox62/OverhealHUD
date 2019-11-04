using Smod2.Events;
using Smod2.EventHandlers;
using System.Collections.Generic;
using MEC;

namespace OverhealHUD
{
	partial class EventHandler : IEventHandlerWaitingForPlayers, IEventHandlerPlayerHurt
	{
		private readonly Plugin instance;

		// Configs
		private int broadcastTime;

		public EventHandler(Plugin plugin) => instance = plugin;

		public void OnWaitingForPlayers(WaitingForPlayersEvent ev)
		{
			LoadConfigs();
		}

		public void OnPlayerHurt(PlayerHurtEvent ev)
		{
			Timing.RunCoroutine(TestOverheal(ev.Player));
		}
	}
}
