using System;
using Server;

namespace Server.Items
{
	public class Artifact_ArmorOfFortune : GiftStuddedChest
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

		[Constructable]
		public Artifact_ArmorOfFortune()
		{
			Name = "Armor of Fortune";
			Hue = 0x501;
			Attributes.Luck = 200;
			Attributes.DefendChance = 15;
			Attributes.LowerRegCost = 40;
			ArmorAttributes.MageArmor = 1;
			Server.Misc.Arty.ArtySetup( this, 8, "" );
		}

		public Artifact_ArmorOfFortune( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}