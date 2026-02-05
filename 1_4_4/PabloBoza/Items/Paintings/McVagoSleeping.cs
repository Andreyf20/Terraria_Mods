using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PabloBoza.Items.Paintings
{
    public class McVagoSleeping : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.maxStack = 99;
            Item.value = Item.buyPrice(0, 0, 0, 1); // 1 copper 
            Item.rare = ItemRarityID.LightRed;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Paintings.McVagoSleepingTile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 1)
                .AddTile(TileID.Sawmill)
                .Register();
        }
    }
}
