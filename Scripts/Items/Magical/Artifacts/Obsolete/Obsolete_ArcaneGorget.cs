using System;
using Server;

namespace Server.Items
{
	public class ArcaneGorget : LeatherGorget
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

		public override int LabelNumber{ get{ return 1061101; } } // Arcane Gorget 

		[Constructable]
		public ArcaneGorget()
		{
			Name = "Arcane Gorget";
			Hue = 0x556;
			Attributes.NightSight = 1;
			Attributes.DefendChance = 8;
			Attributes.CastSpeed = 1;
			Attributes.LowerManaCost = 2;
			Attributes.LowerRegCost = 2;
			Attributes.SpellDamage = 2;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public ArcaneGorget( Serial serial ) : base( serial )
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

			if ( Attributes.NightSight == 0 )
				Attributes.NightSight = 1;
		}
	}
}