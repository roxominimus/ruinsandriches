
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class TreasurePileAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6981, 3, 0, 1}, {6988, -2, 1, 1}, {6989, -2, 0, 1}// 1	2	3	
			, {6995, 1, 2, 1}, {7003, 1, 3, 1}, {7000, -1, 2, 1}// 4	5	6	
			, {7005, -1, 3, 1}, {7001, 0, 1, 1}, {6984, 2, 0, 1}// 7	8	9	
			, {6980, -1, 1, 1}, {6999, -2, 2, 1}, {7015, 0, 0, 1}// 10	11	12	
			, {6979, 0, 3, 1}, {7002, 1, 1, 1}, {6993, -1, 0, 1}// 13	14	15	
			, {6998, 0, 2, 1}, {7017, 1, 0, 1}, {7018, 1, -1, 1}// 16	17	18	
			, {7004, 2, 1, 3}, {7013, 0, -1, 1}, {7012, -2, 3, 1}// 19	20	21	
			, {7019, 1, -2, 1}, {7011, -2, 3, 1}, {7014, 0, -2, 1}// 22	23	24	
			, {6992, 1, -2, 1}, {6996, 0, -2, 0}// 25	26	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TreasurePileAddonDeed();
			}
		}

		[ Constructable ]
		public TreasurePileAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );

		}

		public TreasurePileAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class TreasurePileAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TreasurePileAddon();
			}
		}

		[Constructable]
		public TreasurePileAddonDeed()
		{
			ItemID = 0x0E41;
			Weight = 50.0;
			Name = "Chest of Decorative Treasure";
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
            list.Add( 1049644, "Double Click To Dump In Your Home");
        }

		public TreasurePileAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}