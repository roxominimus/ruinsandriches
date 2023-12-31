using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public abstract class BaseLeather : Item, ICommodity
	{
		private CraftResource m_Resource;

		[CommandProperty( AccessLevel.GameMaster )]
		public CraftResource Resource
		{
			get{ return m_Resource; }
			set{ m_Resource = value; InvalidateProperties(); }
		}
		
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
			writer.Write( (int) m_Resource );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			m_Resource = (CraftResource)reader.ReadInt();
			Name = Server.Misc.MaterialInfo.GetResourceName( m_Resource ) + "leather";
		}

		public BaseLeather( CraftResource resource ) : this( resource, 1 )
		{
		}

		public BaseLeather( CraftResource resource, int amount ) : base( 0x1081 )
		{
			Stackable = true;
			Weight = 1.0;
			Amount = amount;
			Hue = CraftResources.GetHue( resource );
			m_Resource = resource;
			Name = Server.Misc.MaterialInfo.GetResourceName( resource ) + "leather";
		}

		public BaseLeather( Serial serial ) : base( serial )
		{
		}

		public override int LabelNumber
		{
			get
			{
				if ( m_Resource >= CraftResource.SpinedLeather && m_Resource <= CraftResource.BarbedLeather )
					return 1049684 + (int)(m_Resource - CraftResource.SpinedLeather);

				if ( m_Resource == CraftResource.DinosaurLeather )
					return 1036113;

				return 1047022;
			}
		}
	}

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class Leather : BaseLeather
	{
		[Constructable]
		public Leather() : this( 1 )
		{
		}

		[Constructable]
		public Leather( int amount ) : base( CraftResource.RegularLeather, amount )
		{
		}

		public Leather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class SpinedLeather : BaseLeather
	{
		[Constructable]
		public SpinedLeather() : this( 1 )
		{
		}

		[Constructable]
		public SpinedLeather( int amount ) : base( CraftResource.SpinedLeather, amount )
		{
		}

		public SpinedLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class HornedLeather : BaseLeather
	{
		[Constructable]
		public HornedLeather() : this( 1 )
		{
		}

		[Constructable]
		public HornedLeather( int amount ) : base( CraftResource.HornedLeather, amount )
		{
		}

		public HornedLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class BarbedLeather : BaseLeather
	{
		[Constructable]
		public BarbedLeather() : this( 1 )
		{
		}

		[Constructable]
		public BarbedLeather( int amount ) : base( CraftResource.BarbedLeather, amount )
		{
		}

		public BarbedLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class NecroticLeather : BaseLeather
	{
		[Constructable]
		public NecroticLeather() : this( 1 )
		{
		}

		[Constructable]
		public NecroticLeather( int amount ) : base( CraftResource.NecroticLeather, amount )
		{
		}

		public NecroticLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class VolcanicLeather : BaseLeather
	{
		[Constructable]
		public VolcanicLeather() : this( 1 )
		{
		}

		[Constructable]
		public VolcanicLeather( int amount ) : base( CraftResource.VolcanicLeather, amount )
		{
		}

		public VolcanicLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class FrozenLeather : BaseLeather
	{
		[Constructable]
		public FrozenLeather() : this( 1 )
		{
		}

		[Constructable]
		public FrozenLeather( int amount ) : base( CraftResource.FrozenLeather, amount )
		{
		}

		public FrozenLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class GoliathLeather : BaseLeather
	{
		[Constructable]
		public GoliathLeather() : this( 1 )
		{
		}

		[Constructable]
		public GoliathLeather( int amount ) : base( CraftResource.GoliathLeather, amount )
		{
		}

		public GoliathLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class DraconicLeather : BaseLeather
	{
		[Constructable]
		public DraconicLeather() : this( 1 )
		{
		}

		[Constructable]
		public DraconicLeather( int amount ) : base( CraftResource.DraconicLeather, amount )
		{
		}

		public DraconicLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class HellishLeather : BaseLeather
	{
		[Constructable]
		public HellishLeather() : this( 1 )
		{
		}

		[Constructable]
		public HellishLeather( int amount ) : base( CraftResource.HellishLeather, amount )
		{
		}

		public HellishLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class DinosaurLeather : BaseLeather
	{
		[Constructable]
		public DinosaurLeather() : this( 1 )
		{
		}

		[Constructable]
		public DinosaurLeather( int amount ) : base( CraftResource.DinosaurLeather, amount )
		{
		}

		public DinosaurLeather( Serial serial ) : base( serial )
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

	[FlipableAttribute( 0x1081, 0x1082 )]
	public class AlienLeather : BaseLeather
	{
		[Constructable]
		public AlienLeather() : this( 1 )
		{
		}

		[Constructable]
		public AlienLeather( int amount ) : base( CraftResource.AlienLeather, amount )
		{
		}

		public AlienLeather( Serial serial ) : base( serial )
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