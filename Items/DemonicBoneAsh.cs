using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class DemonicBoneAsh : ModItem
    {
        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = false;
            Item.value = 600;
            Item.rare = ItemRarityID.Orange;
            Item.ResearchUnlockCount = 5;
        }


    }
}
