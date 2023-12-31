using System;
using Server;
using Server.Misc;
using Server.Mobiles;

namespace Server.Items
{
	public class GrimReapersLantern : MagicLantern
	{
		[Constructable]
		public GrimReapersLantern()
		{
			Name = "Grim Reaper's Lantern";
			Hue = 0x47E;
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;
			Attributes.SpellDamage = 10;
			SkillBonuses.SetValues( 0, SkillName.Necromancy, 10 );
			SkillBonuses.SetValues( 1, SkillName.Spiritualism, 10 );
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public GrimReapersLantern( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}