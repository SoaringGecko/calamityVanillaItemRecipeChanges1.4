﻿using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class MurkyPaste : ModItem
    {
		public override void SetDefaults()
		{
            Item.maxStack = 999;
            Item.consumable = false;
            Item.value = 200;
            Item.rare = ItemRarityID.Blue;
            Item.ResearchUnlockCount = 5;
        }


    }
}
