using System;
using Server;

namespace Server.Items
{
	public class ShadowDancerArms : LeatherArms
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

		public override int LabelNumber{ get{ return 1061598; } } // Shadow Dancer Arms

		public override int BasePhysicalResistance{ get{ return 13; } }
		public override int BasePoisonResistance{ get{ return 15; } }
		public override int BaseEnergyResistance{ get{ return 15; } }
		[Constructable]
		public ShadowDancerArms()
		{
			Name = "Shadow Dancer Arms";
			Hue = 0x455;
			SkillBonuses.SetValues( 0, SkillName.Stealth, 10.0 );
			SkillBonuses.SetValues( 1, SkillName.Stealing, 10.0 );
			Attributes.BonusDex = 5;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public ShadowDancerArms( Serial serial ) : base( serial )
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
			{
				if ( ItemID == 0x13CB )
					ItemID = 0x13D2;

				PhysicalBonus = 0;
				PoisonBonus = 0;
				EnergyBonus = 0;
			}
		}
	}
}