using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : ItemTemplate
{
    public Dictionary<string, int> statModifier = new Dictionary<string, int>();
    public Armor(string Name, int id, int value, int rarity, string Description, Dictionary<string, int> statModifier)

    {
        this.Name = Name;
        this.Value = value;
        this.Rarity = rarity;
        this.ID = id;
        this.Description = Description;
        this.statModifier = statModifier;
    }
    /*
    number	type - armour	material	    enchantment
    0	    null		    null		    null
    1	    head - light	Bronze-0	    absorb fire	-2	
    2	    head - medium	Iron-1		    absorb ice  -2
    3	    head - heavy	Steel-1		    absorb lightning-2
    4	    chest - light	Orichalcum-2    mana regen -3
    5	    chest - medium	Quicksilver-3   health regen -3
    6	    chest - heavy	Darksteel-3		
    7	    arms - light	Adamantite-4	
    8	    arms - medium						
    9	    arms - heavy				
    10	    legs - light				
    11	    legs - medium				
    12	    legs - heavy	 
    */

}
