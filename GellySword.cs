using Terraria.ModLoader;

namespace GellySword
{
	class GellySword : Mod
	{
		public GellySword()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
