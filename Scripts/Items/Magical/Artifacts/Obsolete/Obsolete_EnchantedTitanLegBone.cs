using System;
using Server;

namespace Server.Items
{
	public class EnchantedTitanLegBone : ShortSpear
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

		[Constructable]
		public EnchantedTitanLegBone()
		{
			Hue = 0x8A5;
			WeaponAttributes.HitLowerDefend = 40;
			WeaponAttributes.HitLightning = 40;
			Attributes.AttackChance = 10;
			Attributes.WeaponDamage = 20;
			WeaponAttributes.ResistPhysicalBonus = 10;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public EnchantedTitanLegBone( Serial serial ) : base( serial )
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

			Name = "Enchanted Pirate Rapier";
		}
	}
}