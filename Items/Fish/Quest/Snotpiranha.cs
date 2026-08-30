using Avalon.Common;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Avalon.Items.Fish.Quest;

public class Snotpiranha : ModItem
{
	public override void SetStaticDefaults()
	{
		ItemID.Sets.IsQuestFish[Item.type] = true;
	}
	public override void SetDefaults()
	{
		Item.DefaultToQuestFish();
	}
	public override bool IsAnglerQuestAvailable()
	{
		return ModContent.GetInstance<AvalonWorld>().WorldEvil == WorldGeneration.Enums.WorldEvil.Contagion;
	}

	public override void AnglerQuestChat(ref string description, ref string catchLocation)
	{
		description = Language.GetTextValue("Mods.Avalon.QuestFish.Snotpiranha.Description");
		catchLocation = Language.GetTextValue("Mods.Avalon.QuestFish.Snotpiranha.CatchLocation");
	}
}
