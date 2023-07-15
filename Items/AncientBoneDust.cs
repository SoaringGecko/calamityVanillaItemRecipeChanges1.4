using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class AncientBoneDust : ModItem
    {
		public override void SetDefaults()
		{
            Item.maxStack = 999;
            Item.consumable = false;
            Item.value = 100;
            Item.rare = ItemRarityID.Blue;
            Item.ResearchUnlockCount = 5;
        }


    }
}
