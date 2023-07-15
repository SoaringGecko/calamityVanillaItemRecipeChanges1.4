using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges
{
    public class calamityVanillaItemRecipeChanges : Mod
    {
        public override void PostSetupContent()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod) == true)
            {
                if (calamityMod != null)
                {
                    throw new System.Exception("You can not run this mod at the same time as Calamity as it makes some recipes easier.");
                }
            }
        }

    }
}