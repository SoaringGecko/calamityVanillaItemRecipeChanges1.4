using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class BeetleJuice : ModItem
    {
		public override void SetDefaults()
		{
            Item.maxStack = 999;
            Item.consumable = false;
            Item.value = 1600;
            Item.rare = ItemRarityID.Pink;
            Item.ResearchUnlockCount = 5;
        }


    }
}
