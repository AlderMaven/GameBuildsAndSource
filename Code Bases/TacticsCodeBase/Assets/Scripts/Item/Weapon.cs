using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ItemTemplate
{
    public Dictionary<string, int> statModifier = new Dictionary<string , int >();
    public Weapon(string Name, int id, int value, int rarity, string Description,
        Dictionary<string, int> statModifier)

    {
        this.Name = Name;
        this.Value = value;
        this.Rarity = rarity; 
        this.ID = id;
        this.Description = Description;
        this.statModifier = statModifier;
    }
    /*number type - weapon      material        enchantment
    0	    null		    null	        null
    1	    dagger          Bronze - 0      fire - 1
    2	    sword           Iron - 1        ice - 1
    3	    axe             Steel - 1       lightning - 1
    4	    spear           Orichalcum - 2  armor piercing - 2 
    5	    shield          Quicksilver - 3 monster slaying - 2
    6	    longsword       Darksteel   - 3 holy smite - 3
    7-----------------      Adamantite - 4
    sheild enchant damage is from defense of being attacked 
*/
}
