using System;
using Server;
using Server.Spells.Fourth;
using Server.Targeting;

namespace Server.Items
{
	public class ArchProtectionMagicStaff : BaseMagicStaff
	{
		[Constructable]
		public ArchProtectionMagicStaff() : base( MagicStaffEffect.Charges, 1, 11 )
		{
			IntRequirement = 25;
			SkillBonuses.SetValues( 1, SkillName.Magery, 40 );
		}

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );
			list.Add( 1070722, "4th Circle of Power" );
		}

		public ArchProtectionMagicStaff( Serial serial ) : base( serial )
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

		public override void OnMagicStaffUse( Mobile from )
		{
			Cast( new ArchProtectionSpell( from, this ) );
		}
	}
}