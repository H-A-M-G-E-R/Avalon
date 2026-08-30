using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Avalon.ModSupport.MLL.Items;

public class ArmoredBonefish : ModItem
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
		return Main.hardMode && NPC.downedPlantBoss;
	}

	public override void AnglerQuestChat(ref string description, ref string catchLocation)
	{
		description = Language.GetTextValue("Mods.Avalon.QuestFish.ArmoredBonefish.Description");
		catchLocation = Language.GetTextValue("Mods.Avalon.QuestFish.ArmoredBonefish.CatchLocation");
	}
}
