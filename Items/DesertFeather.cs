using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class DesertFeather : ModItem
    {
		public override void SetDefaults()
		{
            Item.maxStack = 999;
            Item.consumable = false;
            Item.value = 20;
            Item.rare = ItemRarityID.Blue;
            Item.ResearchUnlockCount = 5;
        }


    }
}
