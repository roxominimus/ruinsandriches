
using System;
using System.Collections.Generic;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	public class Monk : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }
		
		[Constructable]
		public Monk() : base( "the monk" )
		{
			SetSkill( SkillName.Psychology, 100.0 );
			SetSkill( SkillName.Tactics, 70.0, 90.0 );
			SetSkill( SkillName.FistFighting, 70.0, 90.0 );
			SetSkill( SkillName.MagicResist, 70.0, 90.0 );
			SetSkill( SkillName.Bludgeoning, 70.0, 90.0 );
		}
		
		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBMonk() );
		}

		public Monk( Serial serial ) : base( serial )
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
