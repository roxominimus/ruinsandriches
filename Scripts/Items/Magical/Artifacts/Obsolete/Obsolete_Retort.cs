using System;
using Server.Network;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
	public class Retort : WarFork, IIslesDreadDyable
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

      [Constructable]
		public Retort()
		{
          Name = "Retort";
          Hue = 910;
		  WeaponAttributes.HitLeechHits = 20;
		  WeaponAttributes.HitLeechStam = 35;
		  WeaponAttributes.HitLowerDefend = 30;
		  WeaponAttributes.SelfRepair = 3;
		  Attributes.BonusDex = 5;
		  Attributes.WeaponDamage = 50;
		  Attributes.WeaponSpeed = 25;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artefact");
        }

		public Retort( Serial serial ) : base( serial )
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
