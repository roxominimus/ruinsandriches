using System;
using Server;

namespace Server.Items
{
	public class LegsOfInsight : PlateLegs
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

		public override int LabelNumber{ get{ return 1061096; } } // Legs of Insight

		public override int BaseEnergyResistance{ get{ return 19; } }

		[Constructable]
		public LegsOfInsight()
		{
			Name = "Legging of Insight";
			Hue = 0x554;
			ItemID = 0x46AA;
			Attributes.BonusInt = 8;
			Attributes.BonusMana = 15;
			Attributes.RegenMana = 2;
			Attributes.LowerManaCost = 8;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public LegsOfInsight( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
				EnergyBonus = 0;
		}
	}
}