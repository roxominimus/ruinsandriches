using System;
using Server;

namespace Server.Items
{
	public class SpiritOfTheTotem : BearMask
	{
		public override int LabelNumber{ get{ return 1061599; } } // Spirit of the Totem

		public override int BasePhysicalResistance{ get{ return 20; } }

		[Constructable]
		public SpiritOfTheTotem()
		{
			Hue = 0x455;

			Attributes.BonusStr = 20;
			Attributes.ReflectPhysical = 15;
			Attributes.AttackChance = 15;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public SpiritOfTheTotem( Serial serial ) : base( serial )
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

			switch ( version )
			{
				case 0:
				{
					Resistances.Physical = 0;
					break;
				}
			}
		}
	}
}