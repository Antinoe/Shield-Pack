using System.Collections.Generic;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ShieldPack
{
    [Label("Server Config")]
    public class ShieldPackConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static ShieldPackConfig Instance;
		
	[Header("General")]
		
        [Label("[i:CobaltShield] Shield Weight")]
        [Tooltip("If false, shields will not slow Players down when equipped.\n[Default: On]")]
        [DefaultValue(true)]
        public bool shieldWeight {get; set;}
		
	[Header("Wooden")]
		
        [Label("[i:ShieldPack/WoodenBucklerShield] Wooden Buckler Defense")]
        [Tooltip("[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseWoodenBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenBucklerShield] Wooden Buckler Weight")]
        [Tooltip("[Default: 0.990]")]
        [Slider]
        [DefaultValue(0.990f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightWoodenBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenBucklerShield] Wooden Buckler Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeWoodenBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenParmaShield] Wooden Parma Shield Defense")]
        [Tooltip("[Default: 2]")]
        [Slider]
        [DefaultValue(2)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseWoodenParmaShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenParmaShield] Wooden Parma Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.980f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightWoodenParmaShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenParmaShield] Wooden Parma Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeWoodenParmaShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenTowerShield] Wooden Tower Shield Defense")]
        [Tooltip("[Default: 3]")]
        [Slider]
        [DefaultValue(3)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseWoodenTowerShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenTowerShield] Wooden Tower Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.970f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightWoodenTowerShield {get; set;}
		
        [Label("[i:ShieldPack/WoodenTowerShield] Wooden Tower Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeWoodenTowerShield {get; set;}
		
	[Header("Copper")]
		
        [Label("[i:ShieldPack/CopperBucklerShield] Copper Buckler Defense")]
        [Tooltip("[Default: 2]")]
        [Slider]
        [DefaultValue(2)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseCopperBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/CopperBucklerShield] Copper Buckler Weight")]
        [Tooltip("[Default: 0.990]")]
        [Slider]
        [DefaultValue(0.990f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightCopperBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/CopperBucklerShield] Copper Buckler Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeCopperBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/CopperParmaShield] Copper Parma Shield Defense")]
        [Tooltip("[Default: 3]")]
        [Slider]
        [DefaultValue(3)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseCopperParmaShield {get; set;}
		
        [Label("[i:ShieldPack/CopperParmaShield] Copper Parma Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.980f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightCopperParmaShield {get; set;}
		
        [Label("[i:ShieldPack/CopperParmaShield] Copper Parma Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeCopperParmaShield {get; set;}
		
        [Label("[i:ShieldPack/CopperTowerShield] Copper Tower Shield Defense")]
        [Tooltip("[Default: 4]")]
        [Slider]
        [DefaultValue(4)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseCopperTowerShield {get; set;}
		
        [Label("[i:ShieldPack/CopperTowerShield] Copper Tower Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.970f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightCopperTowerShield {get; set;}
		
        [Label("[i:ShieldPack/CopperTowerShield] Copper Tower Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeCopperTowerShield {get; set;}
		
	[Header("Iron")]
		
        [Label("[i:ShieldPack/IronBucklerShield] Iron Buckler Defense")]
        [Tooltip("[Default: 3]")]
        [Slider]
        [DefaultValue(3)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseIronBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/IronBucklerShield] Iron Buckler Weight")]
        [Tooltip("[Default: 0.990]")]
        [Slider]
        [DefaultValue(0.990f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightIronBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/IronBucklerShield] Iron Buckler Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeIronBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/IronParmaShield] Iron Parma Shield Defense")]
        [Tooltip("[Default: 4]")]
        [Slider]
        [DefaultValue(4)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseIronParmaShield {get; set;}
		
        [Label("[i:ShieldPack/IronParmaShield] Iron Parma Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.980f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightIronParmaShield {get; set;}
		
        [Label("[i:ShieldPack/IronParmaShield] Iron Parma Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeIronParmaShield {get; set;}
		
        [Label("[i:ShieldPack/IronTowerShield] Iron Tower Shield Defense")]
        [Tooltip("[Default: 5]")]
        [Slider]
        [DefaultValue(5)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseIronTowerShield {get; set;}
		
        [Label("[i:ShieldPack/IronTowerShield] Iron Tower Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.970f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightIronTowerShield {get; set;}
		
        [Label("[i:ShieldPack/IronTowerShield] Iron Tower Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeIronTowerShield {get; set;}
		
	[Header("Lead")]
		
        [Label("[i:ShieldPack/LeadBucklerShield] Lead Buckler Defense")]
        [Tooltip("[Default: 1]")]
        [Slider]
        [DefaultValue(3)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseLeadBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/LeadBucklerShield] Lead Buckler Weight")]
        [Tooltip("[Default: 0.990]")]
        [Slider]
        [DefaultValue(0.990f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightLeadBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/LeadBucklerShield] Lead Buckler Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeLeadBucklerShield {get; set;}
		
        [Label("[i:ShieldPack/LeadParmaShield] Lead Parma Shield Defense")]
        [Tooltip("[Default: 4]")]
        [Slider]
        [DefaultValue(4)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseLeadParmaShield {get; set;}
		
        [Label("[i:ShieldPack/LeadParmaShield] Lead Parma Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.980f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightLeadParmaShield {get; set;}
		
        [Label("[i:ShieldPack/LeadParmaShield] Lead Parma Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeLeadParmaShield {get; set;}
		
        [Label("[i:ShieldPack/LeadTowerShield] Lead Tower Shield Defense")]
        [Tooltip("[Default: 5]")]
        [Slider]
        [DefaultValue(5)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseLeadTowerShield {get; set;}
		
        [Label("[i:ShieldPack/LeadTowerShield] Lead Tower Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.970f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightLeadTowerShield {get; set;}
		
        [Label("[i:ShieldPack/LeadTowerShield] Lead Tower Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeLeadTowerShield {get; set;}
		
	[Header("Special")]
		
        [Label("[i:ShieldPack/TurtleShield] Turtle Shield Defense")]
        [Tooltip("[Default: 8]")]
        [Slider]
        [DefaultValue(8)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseTurtleShield {get; set;}
		
        [Label("[i:ShieldPack/TurtleShield] Turtle Shield Weight")]
        [Tooltip("[Default: 0.990]")]
        [Slider]
        [DefaultValue(0.990f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightTurtleShield {get; set;}
		
        [Label("[i:ShieldPack/TurtleShield] Turtle Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeTurtleShield {get; set;}
		
        [Label("[i:ShieldPack/BeetleShield] Beetle Shield Defense")]
        [Tooltip("[Default: 12]")]
        [Slider]
        [DefaultValue(12)]
        [Range(1, 20)]
        [Increment(1)]
        public int shieldDefenseBeetleShield {get; set;}
		
        [Label("[i:ShieldPack/BeetleShield] Beetle Shield Weight")]
        [Tooltip("[Default: 0.980]")]
        [Slider]
        [DefaultValue(0.980f)]
        [Range(0.90f, 1f)]
        [Increment(.01f)]
        public float shieldWeightBeetleShield {get; set;}
		
        [Label("[i:ShieldPack/BeetleShield] Beetle Shield Recipe")]
        [Tooltip("(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool recipeBeetleShield {get; set;}
		
    }
}