using MEC;
using Smod2.API;
using System.Collections.Generic;

namespace OverhealHUD
{
	partial class EventHandler
	{
		private void LoadConfigs()
		{
			broadcastTime = instance.GetConfigInt("ohud_broadcast_time");
		}

		private IEnumerator<float> TestOverheal(Player player)
		{
			yield return Timing.WaitForSeconds(0.2f);
			int curHealth = player.GetHealth();
			if (curHealth > player.TeamRole.MaxHP)
			{
				player.PersonalClearBroadcasts();
				player.PersonalBroadcast((uint)broadcastTime, $"<i><color=#FFFF00>Health:</color> {curHealth}hp</i>", false);
			}
		}
	}
}
