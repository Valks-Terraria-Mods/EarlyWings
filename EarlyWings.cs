using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EarlyWings;

public class EarlyWings : Mod
{
    public override void AddRecipes()
    {
        AddAngelWings();
        AddCenxsWings();
        AddJimsWings();
    }

    static void AddAngelWings() => _ = Recipe.Create(ItemID.AngelWings)
            .AddIngredient(ItemID.Feather, 25)
            .AddIngredient(ItemID.Cloud, 10)
            .AddIngredient(ItemID.SunplateBlock, 2)
            .AddIngredient(ItemID.FeatherfallPotion)
            .AddTile(TileID.WorkBenches)
            .Register();

    static void AddCenxsWings() => _ = Recipe.Create(ItemID.CenxsWings)
            .AddIngredient(ItemID.Feather, 25)
            .AddIngredient(ItemID.Obsidian, 10)
            .AddIngredient(ItemID.Hellstone, 2)
            .AddIngredient(ItemID.FeatherfallPotion)
            .AddTile(TileID.WorkBenches)
            .Register();

    static void AddJimsWings() => _ = Recipe.Create(ItemID.JimsWings)
            .AddIngredient(ItemID.Feather, 25)
            .AddIngredient(ItemID.MoonglowSeeds, 10)
            .AddIngredient(ItemID.DeathweedSeeds, 2)
            .AddIngredient(ItemID.GravitationPotion)
            .AddTile(TileID.WorkBenches)
            .Register();
}
