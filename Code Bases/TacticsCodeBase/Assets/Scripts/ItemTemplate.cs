using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTemplate 
{
    public string Name { get; set; }
    // the worth of the item in gold
    public int Value { get; set; }
    // stores rarity as a number to make it easy to compare 
    //when item creation happens
    // --idea-- the rarity will be based on the highest raity 
    // -- ie sword Rarity = 0 , fire enchant  rarity = 1 , silver = 2
    // -- rarity will equal 2 or "rare"
    public int Rarity { get; set; }//can only be 0-4
    // So it can macth with the array easily
    public string[] RarityName = new string[5] {"Common","Uncommon","Rare","Unique","Mythic" };
    // to correspond to an image
    public Sprite Icon { get; set; }
    // the number id
    // --idea-- have the id be a construct of what the item is 
    // --based on type, enchantments,creation material, and other mods; 
    // --ie sword = 123 , fire enchant = 456, silver = 789
    // --ID will equal 123456789
    public int ID { get; set; }

    public string Description { get; set; }

}