using System;

namespace Server.Items
{
	public class WhiteFurBoots : Boots
	{
		[Constructable]
		public WhiteFurBoots() : base( 0x2307 )
		{
			Name = "fur boots";
			Hue = 0x481;
			Weight = 3.0;
			Resistances.Cold = 5;
			ItemID = 0x2307;
		}

		public WhiteFurBoots( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
