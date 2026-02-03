using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ReLogic.Content;

namespace PabloBoza.Items.Paintings
{
    public class PabloPainting : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Pablo Painting");
            // Tooltip.SetDefault("A beautiful painting");
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.maxStack = 99;
            Item.value = Item.buyPrice(0, 1, 0, 0); // 1 gold
            Item.rare = ItemRarityID.White;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Paintings.PabloPaintingTile>();
        }

        public override void AddRecipes()
        {
            // Optional: Add a recipe for your painting
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 1)
                // .AddIngredient(ItemID.Silk, 5)
                // .AddTile(TileID.Sawmill)
                // .AddTile(TileID.Workbench)
                .Register();
        }
    }
}
