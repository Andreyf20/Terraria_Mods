using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace PabloBoza.Tiles.Paintings
{
    public class PabloGatitoTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileWaterDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall); // Needs wall or anchor doesn't work lmao
            TileObjectData.newTile.Width = 4;  // 4: 64 pixels high, 3: 48 pixels high
            TileObjectData.newTile.Height = 6; // 6: 96 pixels wide, 3: 48 pixels wide
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 16, 16, 16 }; // 6 rows of 16 pixels high
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.Origin = new Point16(3, 5); // Anchor point
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(120, 85, 60), CreateMapEntryName());

            // Can be placed on walls
            TileID.Sets.DisableSmartCursor[Type] = true;
        }
    }
}
