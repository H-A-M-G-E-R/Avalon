using Avalon.Common.Extensions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Avalon.Items.Other;

public class UnstableCatalyzer : ModItem
{
	public override void SetDefaults()
	{
		Item.DefaultToMisc(26, 26);
		Item.rare = ItemRarityID.LightRed;
		Item.value = Item.sellPrice(0, 1);
	}

	public override void AddRecipes()
	{
		Recipe.Create(Type)
			.AddRecipeGroup(RecipeGroups.Wood, 20)
			.AddRecipeGroup("DemoniteBar", 5)
			.AddRecipeGroup(RecipeGroups.IronBar, 15)
			.AddRecipeGroup("WorkBenches")
			.AddTile(TileID.Anvils)
			.DisableDecraft()
			.Register();
	}
}
