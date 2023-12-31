using System;
using Server;

namespace Server.Items
{
	public class BeggarsRobe : Robe
	{
      [Constructable]
		public BeggarsRobe()
		{
			Name = "Beggar's Robe";
			Hue = 0x978;
			ItemID = 0x2687;
			Attributes.Luck = 100;
			SkillBonuses.SetValues( 0, SkillName.Begging, 30 );
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public BeggarsRobe( Serial serial ) : base( serial )
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