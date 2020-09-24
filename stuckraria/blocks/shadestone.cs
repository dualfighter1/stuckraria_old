using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace stuckraria.blocks
 {
     public class shadestone : ModTile
     {
         public override void SetDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileMergeDirt[Type] = true;

             drop = mod.ItemType("shadestone");

             ModTranslation name = CreateMapEntryName();
             name.SetDefault("shadestone");
             AddMapEntry(Color.Gray);

             minPick = 20;
         }
     }
 }