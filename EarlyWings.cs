using Terraria.ID;
using Terraria.ModLoader;

namespace EarlyWings
{
	class EarlyWings : Mod
	{
		public EarlyWings()
		{
		}

        public override void AddRecipes()
        {
            addAngelWings();
            addCenxsWings();
            addJimsWings();
        }

        private void addAngelWings()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Feather, 25);
            recipe.AddIngredient(ItemID.Cloud, 10);
            recipe.AddIngredient(ItemID.SunplateBlock, 2);
            recipe.AddIngredient(ItemID.FeatherfallPotion);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.AngelWings);
            recipe.AddRecipe();
        }

        private void addCenxsWings() {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Feather, 25);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddIngredient(ItemID.Hellstone, 2);
            recipe.AddIngredient(ItemID.FeatherfallPotion);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CenxsWings);
            recipe.AddRecipe();
        }

        private void addJimsWings() {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Feather, 25);
            recipe.AddIngredient(ItemID.MoonglowSeeds, 10);
            recipe.AddIngredient(ItemID.DeathweedSeeds, 2);
            recipe.AddIngredient(ItemID.GravitationPotion);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.JimsWings);
            recipe.AddRecipe();
        }
    }
}
