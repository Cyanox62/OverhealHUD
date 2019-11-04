using Smod2.Attributes;

namespace OverhealHUD
{
	[PluginDetails(
	author = "Cyanox",
	name = "Overheal HUD",
	description = "Informs a user of how much health they have left if their health is over their maximum health when damaged.",
	id = "cyan.ohud",
	version = "1.0.0",
	SmodMajor = 3,
	SmodMinor = 0,
	SmodRevision = 0
	)]
	public class Plugin : Smod2.Plugin
	{
		public override void OnDisable() { }

		public override void OnEnable() { }

		public override void Register()
		{
			AddEventHandlers(new EventHandler(this));

			AddConfig(new Smod2.Config.ConfigSetting("ohud_broadcast_time", 2, true, "The amount of time for overheal indicators to display on a players screen."));
		}
	}
}
