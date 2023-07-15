﻿using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class BloodOrb : ModItem
    {
		public override void SetDefaults()
		{
            Item.maxStack = 999;
            Item.consumable = false;
            Item.value = 120;
            Item.rare = ItemRarityID.Blue;
            Item.ResearchUnlockCount = 100;
        }


    }
}
