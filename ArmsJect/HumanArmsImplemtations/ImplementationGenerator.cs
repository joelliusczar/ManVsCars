
using System;
using System.Text;
using System.Collections.Generic;
using ArmsJect.HumanArms;


public partial class Knife: ISword
{
	public void Slash(string target)
	{
		string formatStr = String.Format("Knife -> {0}",target);
		Console.WriteLine(formatStr);
	}

	public void Guard()
	{	
		string formatStr = "Guarded with Knife";
		Console.WriteLine(formatStr);
	}
}

public partial class Broadsword: ISword
{
	public void Slash(string target)
	{
		string formatStr = String.Format("Broadsword -> {0}",target);
		Console.WriteLine(formatStr);
	}

	public void Guard()
	{	
		string formatStr = "Guarded with Broadsword";
		Console.WriteLine(formatStr);
	}
}

public partial class Katana: ISword
{
	public void Slash(string target)
	{
		string formatStr = String.Format("Katana -> {0}",target);
		Console.WriteLine(formatStr);
	}

	public void Guard()
	{	
		string formatStr = "Guarded with Katana";
		Console.WriteLine(formatStr);
	}
}

public partial class Cutlass: ISword
{
	public void Slash(string target)
	{
		string formatStr = String.Format("Cutlass -> {0}",target);
		Console.WriteLine(formatStr);
	}

	public void Guard()
	{	
		string formatStr = "Guarded with Cutlass";
		Console.WriteLine(formatStr);
	}
}

public partial class Firaga:ISpell
{
	public void Cast(string target)
	{
		string formatStr = String.Format("Cast Firaga on {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class Blizzaga:ISpell
{
	public void Cast(string target)
	{
		string formatStr = String.Format("Cast Blizzaga on {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class Thunderaga:ISpell
{
	public void Cast(string target)
	{
		string formatStr = String.Format("Cast Thunderaga on {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class Heal:ISpell
{
	public void Cast(string target)
	{
		string formatStr = String.Format("Cast Heal on {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class Slow:ISpell
{
	public void Cast(string target)
	{
		string formatStr = String.Format("Cast Slow on {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class Quicken:ISpell
{
	public void Cast(string target)
	{
		string formatStr = String.Format("Cast Quicken on {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class Kevlar:IAmor
{
	public int DefLvl {get; set;}
}

public partial class Bronze:IAmor
{
	public int DefLvl {get; set;}
}

public partial class Leather:IAmor
{
	public int DefLvl {get; set;}
}

public partial class Steel:IAmor
{
	public int DefLvl {get; set;}
}

public partial class Hound:IBeast
{
	public void Roar()
	{
		string formatStr = "The Hound roars";
		Console.WriteLine(formatStr);
	}
}

public partial class Tiger:IBeast
{
	public void Roar()
	{
		string formatStr = "The Tiger roars";
		Console.WriteLine(formatStr);
	}
}

public partial class Terrorsaur:IBeast
{
	public void Roar()
	{
		string formatStr = "The Terrorsaur roars";
		Console.WriteLine(formatStr);
	}
}

public partial class Malmere:IBeast
{
	public void Roar()
	{
		string formatStr = "The Malmere roars";
		Console.WriteLine(formatStr);
	}
}

public partial class ProximityBomb:IBomb
{
	public void Plant(string target)
	{
		string formatStr = String.Format("Planted ProximityBomb by {0}",target);
		Console.WriteLine(formatStr);
	}

	public void Lob(string target)
	{
		string formatStr = String.Format("Lobbed ProximityBomb at {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class TimedBomb:IBomb
{
	public void Plant(string target)
	{
		string formatStr = String.Format("Planted TimedBomb by {0}",target);
		Console.WriteLine(formatStr);
	}

	public void Lob(string target)
	{
		string formatStr = String.Format("Lobbed TimedBomb at {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class RemoteBomb:IBomb
{
	public void Plant(string target)
	{
		string formatStr = String.Format("Planted RemoteBomb by {0}",target);
		Console.WriteLine(formatStr);
	}

	public void Lob(string target)
	{
		string formatStr = String.Format("Lobbed RemoteBomb at {0}",target);
		Console.WriteLine(formatStr);
	}
}

public partial class Revolver:IGun
{
	private List<AmmoCache> Bullets;
	public AmmoCache CurrentBulletType {get; set; }

	public Revolver()
	{
		Console.WriteLine("No Ammo");
	}

	public Revolver(IBullet bulletA,int quantityA)
	{
		this.Bullets = new List<AmmoCache>();
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletA,Quantity = quantityA});
		this.CurrentBulletType = this.Bullets[0];
	}

	public Revolver(IBullet bulletA,int quantityA,IBullet bulletB,int quantityB)
		:this(bulletA,quantityA)
	{
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletB,Quantity = quantityB});
	}

	public void Shoot(string target)
	{
		string b = this.CurrentBulletType?.AmmoType?.BulletType??"No Ammo";
		string formatStr = String.Format("Revolver using {0}  -> {1}",b,target);
		Console.WriteLine(formatStr);
	}
}

public partial class Shotgun:IGun
{
	private List<AmmoCache> Bullets;
	public AmmoCache CurrentBulletType {get; set; }

	public Shotgun()
	{
		Console.WriteLine("No Ammo");
	}

	public Shotgun(IBullet bulletA,int quantityA)
	{
		this.Bullets = new List<AmmoCache>();
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletA,Quantity = quantityA});
		this.CurrentBulletType = this.Bullets[0];
	}

	public Shotgun(IBullet bulletA,int quantityA,IBullet bulletB,int quantityB)
		:this(bulletA,quantityA)
	{
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletB,Quantity = quantityB});
	}

	public void Shoot(string target)
	{
		string b = this.CurrentBulletType?.AmmoType?.BulletType??"No Ammo";
		string formatStr = String.Format("Shotgun using {0}  -> {1}",b,target);
		Console.WriteLine(formatStr);
	}
}

public partial class SniperRifle:IGun
{
	private List<AmmoCache> Bullets;
	public AmmoCache CurrentBulletType {get; set; }

	public SniperRifle()
	{
		Console.WriteLine("No Ammo");
	}

	public SniperRifle(IBullet bulletA,int quantityA)
	{
		this.Bullets = new List<AmmoCache>();
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletA,Quantity = quantityA});
		this.CurrentBulletType = this.Bullets[0];
	}

	public SniperRifle(IBullet bulletA,int quantityA,IBullet bulletB,int quantityB)
		:this(bulletA,quantityA)
	{
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletB,Quantity = quantityB});
	}

	public void Shoot(string target)
	{
		string b = this.CurrentBulletType?.AmmoType?.BulletType??"No Ammo";
		string formatStr = String.Format("SniperRifle using {0}  -> {1}",b,target);
		Console.WriteLine(formatStr);
	}
}

public partial class LaserBeam:IGun
{
	private List<AmmoCache> Bullets;
	public AmmoCache CurrentBulletType {get; set; }

	public LaserBeam()
	{
		Console.WriteLine("No Ammo");
	}

	public LaserBeam(IBullet bulletA,int quantityA)
	{
		this.Bullets = new List<AmmoCache>();
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletA,Quantity = quantityA});
		this.CurrentBulletType = this.Bullets[0];
	}

	public LaserBeam(IBullet bulletA,int quantityA,IBullet bulletB,int quantityB)
		:this(bulletA,quantityA)
	{
		this.Bullets.Add(new AmmoCache(){AmmoType = bulletB,Quantity = quantityB});
	}

	public void Shoot(string target)
	{
		string b = this.CurrentBulletType?.AmmoType?.BulletType??"No Ammo";
		string formatStr = String.Format("LaserBeam using {0}  -> {1}",b,target);
		Console.WriteLine(formatStr);
	}
}

public partial class LeadBullet:IBullet
{
	public string BulletType {get; set;}

	public LeadBullet()
	{
		this.BulletType = "Lead";
	}
}

public partial class FireBullet:IBullet
{
	public string BulletType {get; set;}

	public FireBullet()
	{
		this.BulletType = "Fire";
	}
}

public partial class PoisonBullet:IBullet
{
	public string BulletType {get; set;}

	public PoisonBullet()
	{
		this.BulletType = "Poison";
	}
}

public partial class SilverBullet:IBullet
{
	public string BulletType {get; set;}

	public SilverBullet()
	{
		this.BulletType = "Silver";
	}
}

public partial class ExplosiveBullet:IBullet
{
	public string BulletType {get; set;}

	public ExplosiveBullet()
	{
		this.BulletType = "Explosive";
	}
}

