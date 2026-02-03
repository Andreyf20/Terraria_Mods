using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace PabloBoza.Tiles.Paintings
{
    public class PabloPaintingTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileWaterDeath[Type] = false;
            TileID.Sets.FramesOnKillWall[Type] = true;
            
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Width = 3;  // Width of painting in tiles
            TileObjectData.newTile.Height = 3; // Height of painting in tiles
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.Origin = new Point16(2, 1);
            TileObjectData.addTile(Type);
            
            AddMapEntry(new Color(120, 85, 60), CreateMapEntryName());
            
            // Can be placed on walls
            TileID.Sets.DisableSmartCursor[Type] = true;
            // AdjTiles = new int[] { TileID.Paintings };
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 96, 64, ModContent.ItemType<Items.Paintings.PabloPainting>());
        }
    }
}
