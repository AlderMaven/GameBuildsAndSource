using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*number type - weapon      material        enchantment
    0	    null		    null	        null
    1	    dagger          Bronze - 0      fire - 1
    2	    sword           Iron - 1        ice - 1
    3	    axe             Steel - 1       lightning - 1
    4	    spear           Orichalcum - 2  armor piercing - 2 
    5	    shield          Quicksilver - 3 monster slaying - 2
    6	    longsword       Darksteel   - 3 holy smite - 3
    7       bow             Adamantite - 4
    8       gun
*/
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
public class InventoryDatabase : MonoBehaviour
{
    public List<Weapon> weapons = new List<Weapon>();
    public List<Armor> armors = new List<Armor>();

    private void Awake()
    {
        WeaponDatabase();
        ArmorDatabase();
    }
    public Weapon GetWeapon(int id)
    {
        return weapons.Find(weapons => weapons.ID == id);
    }
    public Weapon GetWeapon(string weaponName)
    {
        return weapons.Find(weapons => weapons.Name == weaponName);
    }
    public Armor GetArmor(int id)
    {
        return armors.Find(armors => armors.ID == id);
    }
    public Armor GetArmor(string armorName)
    {
        return armors.Find(armors => armors.Name == armorName);
    }

    //public Weapon(string Name, int id, int value, int rarity, 
    //string Description, Dictionary<string, int> statModifier)
    void WeaponDatabase()
    {
        weapons = new List<Weapon>(){
            new Weapon("Bronze Dagger", 110, 2, 0, "A simple Bronze dagger",
            new Dictionary<string, int>
            {
                { "weaponDamage", 3 }
            }),
            new Weapon("Iron Dagger", 120, 5, 1, "A simple Iron dagger",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 }
            }),
            new Weapon("Steel Dagger", 130, 10, 1, "A simple Steel dagger",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 }
            }),
            new Weapon("Orichalcum Dagger", 140, 20, 2, "A simple Orichalcum dagger",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 }
            }),
            new Weapon("Quicksilver Dagger", 150, 50, 3, "A simple Quicksilver dagger",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 }
            }),
            new Weapon("Darksteel Dagger", 160, 100, 3, "A simple Darksteel dagger",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 }
            }),
            new Weapon("Adamantite Dagger", 170, 175, 4, "A simple Adamantite dagger",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 }
            }),
            // echantment 1
            new Weapon("Bronze Dagger of Fire", 111, 12, 1, "A Bronze dagger with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 3 },
                { "fire", 1 }
            }),
            new Weapon("Iron Dagger of Fire", 121, 15, 1, "An Iron dagger with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "fire", 2 }
            }),
            new Weapon("Steel Dagger of Fire", 131, 20, 1, "A Steel dagger with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "fire", 3 }
            }),
            new Weapon("Orichalcum Dagger of Fire", 141, 40, 2, "An Orichalcum dagger with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "fire", 4 }
            }),
            new Weapon("Quicksilver Dagger of Fire", 151, 70, 3, "A Quicksilver dagger with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "fire", 5 }
            }),
            new Weapon("Darksteel Dagger of Fire", 161, 140, 3, "A Darksteel dagger with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "fire", 6 }
            }),
            new Weapon("Adamantite Dagger of Fire", 171, 200, 4, "An Adamantite dagger with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "fire", 7 }
            }),
            // echantment 2
            new Weapon("Bronze Dagger of Ice", 112, 12, 1, "A Bronze dagger with an ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 3 },
                { "ice", 1 }
            }),
            new Weapon("Iron Dagger of Ice", 122, 15, 1, "An Iron dagger with an ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "ice", 2 }
            }),
            new Weapon("Steel Dagger of Ice", 132, 20, 1, "A Steel dagger with an ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "ice", 3 }
            }),
            new Weapon("Orichalcum Dagger of Ice", 142, 40, 2, "An Orichalcum dagger with an ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "ice", 4 }
            }),
            new Weapon("Quicksilver Dagger of Ice", 152, 70, 3, "A Quicksilver dagger with an ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "ice", 5 }
            }),
            new Weapon("Darksteel Dagger of Ice", 162, 140, 3, "A Darksteel dagger with an ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "ice", 6 }
            }),
            new Weapon("Adamantite Dagger of Ice", 172, 200, 4, "An Adamantite dagger with an ice enchantment",
            new Dictionary<string, int>
            {
               { "weaponDamage", 15 },
               { "ice", 7 }
            }),
            // echantment 3
            new Weapon("Bronze Dagger of Lightning", 113, 12, 1, "A Bronze dagger with a lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 3 },
                { "lightning", 1 }
            }),
            new Weapon("Iron Dagger of Lightning", 123, 15, 1, "An Iron dagger with a lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "lightning", 2 }
            }),
            new Weapon("Steel Dagger of Lightning", 133, 20, 1, "A Steel dagger with a lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "lightning", 3 }
            }),
            new Weapon("Orichalcum Dagger of Lightning", 143, 40, 2, "An Orichalcum dagger with a lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "lightning", 4 }
            }),
            new Weapon("Quicksilver Dagger of Lightning", 153, 70, 3, "A Quicksilver dagger with a lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "lightning", 5 }
            }),
            new Weapon("Darksteel Dagger of Lightning", 163, 140, 3, "A Darksteel dagger with a lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "lightning", 6 }
            }),
            new Weapon("Adamantite Dagger of Lightning", 173, 200, 4, "An Adamantite dagger with a lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "lightning", 7 }
            }),
            // echantment 4
            new Weapon("Bronze Dagger of Armor Piercing", 114, 22, 2, "A Bronze dagger with an armor piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 3 },
                { "armor piercing", 1 }
            }),
            new Weapon("Iron Dagger of Armor Piercing", 124, 30, 2, "An Iron dagger with an armor piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "armor piercing", 2 }
            }),
            new Weapon("Steel Dagger of Armor Piercing", 134, 40, 2, "A Steel dagger with an armor piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "armor piercing", 3 }
            }),
            new Weapon("Orichalcum Dagger of Armor Piercing", 144, 65, 2, "An Orichalcum dagger with an armor piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "armor piercing", 4 }
            }),
            new Weapon("Quicksilver Dagger of Armor Piercing", 154, 110, 3, "A Quicksilver dagger with an armor piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "armor piercing", 5 }
            }),
            new Weapon("Darksteel Dagger of Armor Piercing", 164, 180, 3, "A Darksteel dagger with an armor piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "armor piercing", 6 }
            }),
            new Weapon("Adamantite Dagger of Armor Piercing", 174, 250, 4, "An Adamantite dagger with an armor piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "armor piercing", 7 }
            }),
            // echantment 5
            new Weapon("Bronze Dagger of Monster Slaying", 115, 22, 2, "A Bronze dagger with a monster slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 3 },
                { "monster slaying", 1 }
            }),
            new Weapon("Iron Dagger of Monster Slaying", 125, 30, 2, "An Iron dagger with a monster slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "monster slaying", 2 }
            }),
            new Weapon("Steel Dagger of Monster Slaying", 135, 40, 2, "A Steel dagger with a monster slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "monster slaying", 3 }
            }),
            new Weapon("Orichalcum Dagger of Monster Slaying", 145, 65, 2, "An Orichalcum dagger with a monster slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "monster slaying", 4 }
            }),
            new Weapon("Quicksilver Dagger of Monster Slaying", 155, 110, 3, "A Quicksilver dagger with a monster slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "monster slaying", 5 }
            }),
            new Weapon("Darksteel Dagger of Monster Slaying", 165, 180, 3, "A Darksteel dagger with a monster slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "monster slaying", 6 }
            }),
            new Weapon("Adamantite Dagger of Monster Slaying", 175, 250, 4, "An Adamantite dagger with a monster slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "monster slaying", 7 }
            }),
            // echantment 6
            new Weapon("Bronze Dagger of Holy Smite", 116, 32, 3, "A Bronze dagger with a holy smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 3 },
                { "holy smite", 1 }
            }),
            new Weapon("Iron Dagger of Holy Smite", 126, 40, 3, "An Iron dagger with a holy smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "holy smite", 2 }
            }),
            new Weapon("Steel Dagger of Holy Smite", 136, 55, 3, "A Steel dagger with a holy smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "holy smite", 3 }
            }),
            new Weapon("Orichalcum Dagger of Holy Smite", 146, 105, 3, "An Orichalcum dagger with a holy smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "holy smite", 4 }
            }),
            new Weapon("Quicksilver Dagger of Holy Smite", 156, 140, 3, "A Quicksilver dagger with a holy smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "holy smite", 5 }
            }),
            new Weapon("Darksteel Dagger of Holy Smite", 166, 210, 3, "A Darksteel dagger with a holy smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "holy smite", 6 }
            }),
            new Weapon("Adamantite Dagger of Holy Smite", 176, 300, 4, "An Adamantite dagger with a holy smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "holy smite", 7 }
            }),
// end of dagger
// start sword
            new Weapon("Bronze Sword", 210, 5, 0, "A simple Bronze Sword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 }
            }),
            new Weapon("Iron Sword", 220, 11, 1, "A simple Iron Sword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 }
            }),
            new Weapon("Steel Sword", 230, 20, 1, "A simple Steel Sword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 }
            }),
            new Weapon("Orichalcum Sword", 240, 30, 2, "A simple Orichalcum Sword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 }
            }),
            new Weapon("Quicksilver Sword", 250, 70, 3, "A simple Quicksilver Sword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 }
            }),
            new Weapon("Darksteel Sword", 260, 120, 3, "A simple Darksteel Sword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 }
            }),
            new Weapon("Adamantite Sword", 270, 240, 4, "A simple Adamantite Sword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 }
            }),
            // echantment 1
            new Weapon("Bronze Sword of Fire", 211, 21, 1, "A Bronze Sword with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "fire", 1 }
            }),
            new Weapon("Iron Sword of Fire", 221, 25, 1, "An Iron Sword with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "fire", 2 }
            }),
            new Weapon("Steel Sword of Fire", 231, 30, 1, "A Steel Sword with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "fire", 3 }
            }),
            new Weapon("Orichalcum Sword of Fire", 241, 55, 2, "An Orichalcum Sword with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "fire", 4 }
            }),
            new Weapon("Quicksilver Sword of Fire", 251, 90, 3, "A Quicksilver Sword with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "fire", 5 }
            }),
            new Weapon("Darksteel Sword of Fire", 261, 170, 3, "A Darksteel Sword with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "fire", 6 }
            }),
            new Weapon("Adamantite Sword of Fire", 271, 270, 4, "An Adamantite Sword with a fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "fire", 7 }
            }),
            // echantment 2
            new Weapon("Bronze Sword of Ice", 212, 21, 1, "A Bronze Sword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "ice", 1 }
            }),
            new Weapon("Iron Sword of Ice", 222, 25, 1, "A Iron Sword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "ice", 2 }
            }),
            new Weapon("Steel Sword of Ice", 232, 30, 1, "A Steel Sword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "ice", 3 }
            }),
            new Weapon("Orichalcum Sword of Ice", 242, 55, 2, "A Orichalcum Sword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "ice", 4 }
            }),
            new Weapon("Quicksilver Sword of Ice", 252, 90, 3, "A Quicksilver Sword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "ice", 5 }
            }),
            new Weapon("Darksteel Sword of Ice", 262, 170, 3, "A Darksteel Sword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "ice", 6 }
            }),
            new Weapon("Adamantite Sword of Ice", 272, 270, 4, "A Adamantite Sword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "ice", 7 }
            }),
            // echantment 3
            new Weapon("Bronze Sword of Lightning", 213, 21, 1, "A Bronze Sword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "lightning", 1 }
            }),
            new Weapon("Iron Sword of Lightning", 223, 25, 1, "A Iron Sword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "lightning", 2 }
            }),
            new Weapon("Steel Sword of Lightning", 233, 30, 1, "A Steel Sword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "lightning", 3 }
            }),
            new Weapon("Orichalcum Sword of Lightning", 243, 55, 2, "A Orichalcum Sword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "lightning", 4 }
            }),
            new Weapon("Quicksilver Sword of Lightning", 253, 90, 3, "A Quicksilver Sword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "lightning", 5 }
            }),
            new Weapon("Darksteel Sword of Lightning", 263, 170, 3, "A Darksteel Sword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "lightning", 6 }
            }),
            new Weapon("Adamantite Sword of Lightning", 273, 270, 4, "A Adamantite Sword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "lightning", 7 }
            }),
            // echantment 4
            new Weapon("Bronze Sword of Armor Piercing", 214, 30, 2, "A Bronze Sword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "armor piercing", 1 }
            }),
            new Weapon("Iron Sword of Armor Piercing", 224, 35, 2, "A Iron Sword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "armor piercing", 2 }
            }),
            new Weapon("Steel Sword of Armor Piercing", 234, 55, 2, "A Steel Sword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "armor piercing", 3 }
            }),
            new Weapon("Orichalcum Sword of Armor Piercing", 244, 85, 2, "A Orichalcum Sword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "armor piercing", 4 }
            }),
            new Weapon("Quicksilver Sword of Armor Piercing", 254, 140, 3, "A Quicksilver Sword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "armor piercing", 5 }
            }),
            new Weapon("Darksteel Sword of Armor Piercing", 264, 210, 3, "A Darksteel Sword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "armor piercing", 6 }
            }),
            new Weapon("Adamantite Sword of Armor Piercing", 274, 320, 4, "A Adamantite Sword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "armor piercing", 7 }
            }),
            // echantment 5
            new Weapon("Bronze Sword of Monster Slaying", 215, 30, 2, "A Bronze Sword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "monster slaying", 1 }
            }),
            new Weapon("Iron Sword of Monster Slaying", 225, 35, 2, "A Iron Sword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "monster slaying", 2 }
            }),
            new Weapon("Steel Sword of Monster Slaying", 235, 55, 2, "A Steel Sword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "monster slaying", 3 }
            }),
            new Weapon("Orichalcum Sword of Monster Slaying", 245, 85, 2, "A Orichalcum Sword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "monster slaying", 4 }
            }),
            new Weapon("Quicksilver Sword of Monster Slaying", 255, 140, 3, "A Quicksilver Sword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "monster slaying", 5 }
            }),
            new Weapon("Darksteel Sword of Monster Slaying", 265, 210, 3, "A Darksteel Sword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "monster slaying", 6 }
            }),
            new Weapon("Adamantite Sword of Monster Slaying", 275, 320, 4, "A Adamantite Sword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "monster slaying", 7 }
            }),
            // echantment 6
            new Weapon("Bronze Sword of Holy Smite", 216, 40, 3, "A Bronze Sword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "holy smite", 1 }
            }),
            new Weapon("Iron Sword of Holy Smite", 226, 55, 3, "A Iron Sword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "holy smite", 2 }
            }),
            new Weapon("Steel Sword of Holy Smite", 236, 70, 3, "A Steel Sword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "holy smite", 3 }
            }),
            new Weapon("Orichalcum Sword of Holy Smite", 246, 125, 3, "A Orichalcum Sword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "holy smite", 4 }
            }),
            new Weapon("Quicksilver Sword of Holy Smite", 256, 170, 3, "A Quicksilver Sword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "holy smite", 5 }
            }),
            new Weapon("Darksteel Sword of Holy Smite", 266, 250, 3, "A Darksteel Sword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "holy smite", 6 }
            }),
            new Weapon("Adamantite Sword of Holy Smite", 276, 390, 4, "A Adamantite Sword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "holy smite", 7 }
            }),
// end of sword
// start axe
            new Weapon("Bronze Axe", 310, 5, 0, "A simple Bronze Axe",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 }
            }),
            new Weapon("Iron Axe", 320, 11, 1, "A simple Iron Axe",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 }
            }),
            new Weapon("Steel Axe", 330, 20, 1, "A simple Steel Axe",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 }
            }),
            new Weapon("Orichalcum Axe", 340, 30, 2, "A simple Orichalcum Axe",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 }
            }),
            new Weapon("Quicksilver Axe", 350, 70, 3, "A simple Quicksilver Axe",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 }
            }),
            new Weapon("Darksteel Axe", 360, 120, 3, "A simple Darksteel Axe",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 }
            }),
            new Weapon("Adamantite Axe", 370, 240, 4, "A simple Adamantite Axe",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 }
            }),
// enchantment 1
            new Weapon("Bronze Axe of Fire", 311, 21, 1, "A Bronze Axe with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "fire", 1 }
            }),
            new Weapon("Iron Axe of Fire", 321, 25, 1, "A Iron Axe with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "fire", 2 }
            }),
            new Weapon("Steel Axe of Fire", 331, 30, 1, "A Steel Axe with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "fire", 3 }
            }),
            new Weapon("Orichalcum Axe of Fire", 341, 55, 2, "A Orichalcum Axe with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "fire", 4 }
            }),
            new Weapon("Quicksilver Axe of Fire", 351, 90, 3, "A Quicksilver Axe with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "fire", 5 }
            }),
            new Weapon("Darksteel Axe of Fire", 361, 170, 3, "A Darksteel Axe with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "fire", 6 }
            }),
            new Weapon("Adamantite Axe of Fire", 371, 270, 4, "A Adamantite Axe with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "fire", 7 }
            }),
// enchantment 2
            new Weapon("Bronze Axe of Ice", 312, 21, 1, "A Bronze Axe with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "ice", 1 }
            }),
            new Weapon("Iron Axe of Ice", 322, 25, 1, "A Iron Axe with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "ice", 2 }
            }),
            new Weapon("Steel Axe of Ice", 332, 30, 1, "A Steel Axe with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "ice", 3 }
            }),
            new Weapon("Orichalcum Axe of Ice", 342, 55, 2, "A Orichalcum Axe with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "ice", 4 }
            }),
            new Weapon("Quicksilver Axe of Ice", 352, 90, 3, "A Quicksilver Axe with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "ice", 5 }
            }),
            new Weapon("Darksteel Axe of Ice", 362, 170, 3, "A Darksteel Axe with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "ice", 6 }
            }),
            new Weapon("Adamantite Axe of Ice", 372, 270, 4, "A Adamantite Axe with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "ice", 7 }
            }),
// enchantment 3
            new Weapon("Bronze Axe of Lightning", 313, 21, 1, "A Bronze Axe with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "lightning", 1 }
            }),
            new Weapon("Iron Axe of Lightning", 323, 25, 1, "A Iron Axe with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "lightning", 2 }
            }),
            new Weapon("Steel Axe of Lightning", 333, 30, 1, "A Steel Axe with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "lightning", 3 }
            }),
            new Weapon("Orichalcum Axe of Lightning", 343, 55, 2, "A Orichalcum Axe with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "lightning", 4 }
            }),
            new Weapon("Quicksilver Axe of Lightning", 353, 90, 3, "A Quicksilver Axe with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "lightning", 5 }
            }),
            new Weapon("Darksteel Axe of Lightning", 363, 170, 3, "A Darksteel Axe with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "lightning", 6 }
            }),
            new Weapon("Adamantite Axe of Lightning", 373, 270, 4, "A Adamantite Axe with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "lightning", 7 }
            }),
// enchantment 4
            new Weapon("Bronze Axe of Armor Piercing", 314, 30, 2, "A Bronze Axe with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "armor piercing", 1 }
            }),
            new Weapon("Iron Axe of Armor Piercing", 324, 35, 2, "A Iron Axe with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "armor piercing", 2 }
            }),
            new Weapon("Steel Axe of Armor Piercing", 334, 55, 2, "A Steel Axe with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "armor piercing", 3 }
            }),
            new Weapon("Orichalcum Axe of Armor Piercing", 344, 85, 2, "A Orichalcum Axe with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "armor piercing", 4 }
            }),
            new Weapon("Quicksilver Axe of Armor Piercing", 354, 140, 3, "A Quicksilver Axe with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "armor piercing", 5 }
            }),
            new Weapon("Darksteel Axe of Armor Piercing", 364, 210, 3, "A Darksteel Axe with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "armor piercing", 6 }
            }),
            new Weapon("Adamantite Axe of Armor Piercing", 374, 320, 4, "A Adamantite Axe with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "armor piercing", 7 }
            }),
// enchantment 5
            new Weapon("Bronze Axe of Monster Slaying", 315, 30, 2, "A Bronze Axe with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "monster slaying", 1 }
            }),
            new Weapon("Iron Axe of Monster Slaying", 325, 35, 2, "A Iron Axe with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "monster slaying", 2 }
            }),
            new Weapon("Steel Axe of Monster Slaying", 335, 55, 2, "A Steel Axe with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "monster slaying", 3 }
            }),
            new Weapon("Orichalcum Axe of Monster Slaying", 345, 85, 2, "A Orichalcum Axe with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "monster slaying", 4 }
            }),
            new Weapon("Quicksilver Axe of Monster Slaying", 355, 140, 3, "A Quicksilver Axe with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "monster slaying", 5 }
            }),
            new Weapon("Darksteel Axe of Monster Slaying", 365, 210, 3, "A Darksteel Axe with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "monster slaying", 6 }
            }),
            new Weapon("Adamantite Axe of Monster Slaying", 375, 320, 4, "A Adamantite Axe with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "monster slaying", 7 }
            }),
// enchantment 6
            new Weapon("Bronze Axe of Holy Smite", 316, 40, 3, "A Bronze Axe with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "holy smite", 1 }
            }),
            new Weapon("Iron Axe of Holy Smite", 326, 55, 3, "A Iron Axe with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "holy smite", 2 }
            }),
            new Weapon("Steel Axe of Holy Smite", 336, 70, 3, "A Steel Axe with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "holy smite", 3 }
            }),
            new Weapon("Orichalcum Axe of Holy Smite", 346, 125, 3, "A Orichalcum Axe with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "holy smite", 4 }
            }),
            new Weapon("Quicksilver Axe of Holy Smite", 356, 170, 3, "A Quicksilver Axe with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "holy smite", 5 }
            }),
            new Weapon("Darksteel Axe of Holy Smite", 366, 250, 3, "A Darksteel Axe with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "holy smite", 6 }
            }),
            new Weapon("Adamantite Axe of Holy Smite", 376, 390, 4, "A Adamantite Axe with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "holy smite", 7 }
            }),
// end of axe
// start Spear
            new Weapon("Bronze Spear", 410, 5, 0, "A simple Bronze Spear",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 }
            }),
            new Weapon("Iron Spear", 420, 11, 1, "A simple Iron Spear",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 }
            }),
            new Weapon("Steel Spear", 430, 20, 1, "A simple Steel Spear",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 }
            }),
            new Weapon("Orichalcum Spear", 440, 30, 2, "A simple Orichalcum Spear",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 }
            }),
            new Weapon("Quicksilver Spear", 450, 70, 3, "A simple Quicksilver Spear",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 }
            }),
            new Weapon("Darksteel Spear", 460, 120, 3, "A simple Darksteel Spear",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 }
            }),
            new Weapon("Adamantite Spear", 470, 240, 4, "A simple Adamantite Spear",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 }
            }),
// enchantment 1
            new Weapon("Bronze Spear of Fire", 411, 21, 1, "A Bronze Spear with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "fire", 1 }
            }),
            new Weapon("Iron Spear of Fire", 421, 25, 1, "A Iron Spear with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "fire", 2 }
            }),
            new Weapon("Steel Spear of Fire", 431, 30, 1, "A Steel Spear with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "fire", 3 }
            }),
            new Weapon("Orichalcum Spear of Fire", 441, 55, 2, "A Orichalcum Spear with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "fire", 4 }
            }),
            new Weapon("Quicksilver Spear of Fire", 451, 90, 3, "A Quicksilver Spear with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "fire", 5 }
            }),
            new Weapon("Darksteel Spear of Fire", 461, 170, 3, "A Darksteel Spear with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "fire", 6 }
            }),
            new Weapon("Adamantite Spear of Fire", 471, 270, 4, "A Adamantite Spear with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "fire", 7 }
            }),
// enchantment 2
            new Weapon("Bronze Spear of Ice", 412, 21, 1, "A Bronze Spear with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "ice", 1 }
            }),
            new Weapon("Iron Spear of Ice", 422, 25, 1, "A Iron Spear with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "ice", 2 }
            }),
            new Weapon("Steel Spear of Ice", 432, 30, 1, "A Steel Spear with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "ice", 3 }
            }),
            new Weapon("Orichalcum Spear of Ice", 442, 55, 2, "A Orichalcum Spear with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "ice", 4 }
            }),
            new Weapon("Quicksilver Spear of Ice", 452, 90, 3, "A Quicksilver Spear with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "ice", 5 }
            }),
            new Weapon("Darksteel Spear of Ice", 462, 170, 3, "A Darksteel Spear with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "ice", 6 }
            }),
            new Weapon("Adamantite Spear of Ice", 472, 270, 4, "A Adamantite Spear with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "ice", 7 }
            }),
// enchantment 3
            new Weapon("Bronze Spear of Lightning", 413, 21, 1, "A Bronze Spear with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "lightning", 1 }
            }),
            new Weapon("Iron Spear of Lightning", 423, 25, 1, "A Iron Spear with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "lightning", 2 }
            }),
            new Weapon("Steel Spear of Lightning", 433, 30, 1, "A Steel Spear with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "lightning", 3 }
            }),
            new Weapon("Orichalcum Spear of Lightning", 443, 55, 2, "A Orichalcum Spear with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "lightning", 4 }
            }),
            new Weapon("Quicksilver Spear of Lightning", 453, 90, 3, "A Quicksilver Spear with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "lightning", 5 }
            }),
            new Weapon("Darksteel Spear of Lightning", 463, 170, 3, "A Darksteel Spear with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "lightning", 6 }
            }),
            new Weapon("Adamantite Spear of Lightning", 473, 270, 4, "A Adamantite Spear with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "lightning", 7 }
            }),
// enchantment 4
            new Weapon("Bronze Spear of Armor Piercing", 414, 30, 2, "A Bronze Spear with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "armor piercing", 1 }
            }),
            new Weapon("Iron Spear of Armor Piercing", 424, 35, 2, "A Iron Spear with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "armor piercing", 2 }
            }),
            new Weapon("Steel Spear of Armor Piercing", 434, 55, 2, "A Steel Spear with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "armor piercing", 3 }
            }),
            new Weapon("Orichalcum Spear of Armor Piercing", 444, 85, 2, "A Orichalcum Spear with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "armor piercing", 4 }
            }),
            new Weapon("Quicksilver Spear of Armor Piercing", 454, 140, 3, "A Quicksilver Spear with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "armor piercing", 5 }
            }),
            new Weapon("Darksteel Spear of Armor Piercing", 464, 210, 3, "A Darksteel Spear with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "armor piercing", 6 }
            }),
            new Weapon("Adamantite Spear of Armor Piercing", 474, 320, 4, "A Adamantite Spear with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "armor piercing", 7 }
            }),
// enchantment 5
            new Weapon("Bronze Spear of Monster Slaying", 415, 30, 2, "A Bronze Spear with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "monster slaying", 1 }
            }),
            new Weapon("Iron Spear of Monster Slaying", 425, 35, 2, "A Iron Spear with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "monster slaying", 2 }
            }),
            new Weapon("Steel Spear of Monster Slaying", 435, 55, 2, "A Steel Spear with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "monster slaying", 3 }
            }),
            new Weapon("Orichalcum Spear of Monster Slaying", 445, 85, 2, "A Orichalcum Spear with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "monster slaying", 4 }
            }),
            new Weapon("Quicksilver Spear of Monster Slaying", 455, 140, 3, "A Quicksilver Spear with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "monster slaying", 5 }
            }),
            new Weapon("Darksteel Spear of Monster Slaying", 465, 210, 3, "A Darksteel Spear with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "monster slaying", 6 }
            }),
            new Weapon("Adamantite Spear of Monster Slaying", 475, 320, 4, "A Adamantite Spear with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "monster slaying", 7 }
            }),
// enchantment 6
            new Weapon("Bronze Spear of Holy Smite", 416, 40, 3, "A Bronze Spear with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 5 },
                { "holy smite", 1 }
            }),
            new Weapon("Iron Spear of Holy Smite", 426, 55, 3, "A Iron Spear with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 7 },
                { "holy smite", 2 }
            }),
            new Weapon("Steel Spear of Holy Smite", 436, 70, 3, "A Steel Spear with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 9 },
                { "holy smite", 3 }
            }),
            new Weapon("Orichalcum Spear of Holy Smite", 446, 125, 3, "A Orichalcum Spear with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 11 },
                { "holy smite", 4 }
            }),
            new Weapon("Quicksilver Spear of Holy Smite", 456, 170, 3, "A Quicksilver Spear with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 13 },
                { "holy smite", 5 }
            }),
            new Weapon("Darksteel Spear of Holy Smite", 466, 250, 3, "A Darksteel Spear with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 15 },
                { "holy smite", 6 }
            }),
            new Weapon("Adamantite Spear of Holy Smite", 476, 390, 4, "A Adamantite Spear with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDamage", 17 },
                { "holy smite", 7 }
            }),
// end of Spear
// start Sheild
            new Weapon("Bronze Shield", 510, 5, 0, "A simple Bronze Shield",
            new Dictionary<string, int>
            {
                { "weaponDefense", 3 }
            }),
            new Weapon("Iron Shield", 520, 11, 1, "A simple Iron Shield",
            new Dictionary<string, int>
            {
                { "weaponDefense", 5 }
            }),
            new Weapon("Steel Shield", 530, 20, 1, "A simple Steel Shield",
            new Dictionary<string, int>
            {
                { "weaponDefense", 7 }
            }),
            new Weapon("Orichalcum Shield", 540, 30, 2, "A simple Orichalcum Shield",
            new Dictionary<string, int>
            {
                { "weaponDefense", 9 }
            }),
            new Weapon("Quicksilver Shield", 550, 70, 3, "A simple Quicksilver Shield",
            new Dictionary<string, int>
            {
                { "weaponDefense", 11 }
            }),
            new Weapon("Darksteel Shield", 560, 120, 3, "A simple Darksteel Shield",
            new Dictionary<string, int>
            {
                { "weaponDefense", 13 }
            }),
            new Weapon("Adamantite Shield", 570, 200, 4, "A simple Adamantite Shield",
            new Dictionary<string, int>
            {
                { "weaponDefense", 15 }
            }),
// enchantment 1
            new Weapon("Bronze Shield of Fire", 511, 25, 1, "A Bronze Shield with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 5 },
                { "fire", 1 }
            }),
            new Weapon("Iron Shield of Fire", 521, 30, 1, "A Iron Shield with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 7 },
                { "fire", 2 }
            }),
            new Weapon("Steel Shield of Fire", 531, 35, 1, "A Steel Shield with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 9 },
                { "fire", 3 }
            }),
            new Weapon("Orichalcum Shield of Fire", 541, 65, 2, "A Orichalcum Shield with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 11 },
                { "fire", 4 }
            }),
            new Weapon("Quicksilver Shield of Fire", 551, 100, 3, "A Quicksilver Shield with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 13 },
                { "fire", 5 }
            }),
            new Weapon("Darksteel Shield of Fire", 561, 180, 3, "A Darksteel Shield with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 15 },
                { "fire", 6 }
            }),
            new Weapon("Adamantite Shield of Fire", 571, 240, 4, "A Adamantite Shield with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 17 },
                { "fire", 7 }
            }),
// enchantment 2
            new Weapon("Bronze Shield of Ice", 512, 25, 1, "A Bronze Shield with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 5 },
                { "ice", 1 }
            }),
            new Weapon("Iron Shield of Ice", 522, 30, 1, "A Iron Shield with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 7 },
                { "ice", 2 }
            }),
            new Weapon("Steel Shield of Ice", 532, 35, 1, "A Steel Shield with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 9 },
                { "ice", 3 }
            }),
            new Weapon("Orichalcum Shield of Ice", 542, 65, 2, "A Orichalcum Shield with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 11 },
                { "ice", 4 }
            }),
            new Weapon("Quicksilver Shield of Ice", 552, 100, 3, "A Quicksilver Shield with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 13 },
                { "ice", 5 }
            }),
            new Weapon("Darksteel Shield of Ice", 562, 180, 3, "A Darksteel Shield with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 15 },
                { "ice", 6 }
            }),
            new Weapon("Adamantite Shield of Ice", 572, 240, 4, "A Adamantite Shield with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 17 },
                { "ice", 7 }
            }),
// enchantment 3
            new Weapon("Bronze Shield of Lightning", 513, 25, 1, "A Bronze Shield with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 5 },
                { "lightning", 1 }
            }),
            new Weapon("Iron Shield of Lightning", 523, 30, 1, "A Iron Shield with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 7 },
                { "lightning", 2 }
            }),
            new Weapon("Steel Shield of Lightning", 533, 35, 1, "A Steel Shield with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 9 },
                { "lightning", 3 }
            }),
            new Weapon("Orichalcum Shield of Lightning", 543, 65, 2, "A Orichalcum Shield with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 11 },
                { "lightning", 4 }
            }),
            new Weapon("Quicksilver Shield of Lightning", 553, 100, 3, "A Quicksilver Shield with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 13 },
                { "lightning", 5 }
            }),
            new Weapon("Darksteel Shield of Lightning", 563, 180, 3, "A Darksteel Shield with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 15 },
                { "lightning", 6 }
            }),
            new Weapon("Adamantite Shield of Lightning", 573, 240, 4, "A Adamantite Shield with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 17 },
                { "lightning", 7 }
            }),
// enchantment 4
            new Weapon("Bronze Shield of Armor Piercing", 514, 35, 2, "A Bronze Shield with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 5 },
                { "armor piercing", 1 }
            }),
            new Weapon("Iron Shield of Armor Piercing", 524, 40, 2, "A Iron Shield with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 7 },
                { "armor piercing", 2 }
            }),
            new Weapon("Steel Shield of Armor Piercing", 534, 45, 2, "A Steel Shield with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 9 },
                { "armor piercing", 3 }
            }),
            new Weapon("Orichalcum Shield of Armor Piercing", 544, 75, 2, "A Orichalcum Shield with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 11 },
                { "armor piercing", 4 }
            }),
            new Weapon("Quicksilver Shield of Armor Piercing", 554, 115, 3, "A Quicksilver Shield with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 13 },
                { "armor piercing", 5 }
            }),
            new Weapon("Darksteel Shield of Armor Piercing", 564, 210, 3, "A Darksteel Shield with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 15 },
                { "armor piercing", 6 }
            }),
            new Weapon("Adamantite Shield of Armor Piercing", 574, 275, 4, "A Adamantite Shield with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 17 },
                { "armor piercing", 7 }
            }),
// enchantment 5
            new Weapon("Bronze Shield of Monster Slaying", 515, 35, 2, "A Bronze Shield with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 5 },
                { "monster slaying", 1 }
            }),
            new Weapon("Iron Shield of Monster Slaying", 525, 40, 2, "A Iron Shield with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 7 },
                { "monster slaying", 2 }
            }),
            new Weapon("Steel Shield of Monster Slaying", 535, 45, 2, "A Steel Shield with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 9 },
                { "monster slaying", 3 }
            }),
            new Weapon("Orichalcum Shield of Monster Slaying", 545, 75, 2, "A Orichalcum Shield with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 11 },
                { "monster slaying", 4 }
            }),
            new Weapon("Quicksilver Shield of Monster Slaying", 555, 115, 3, "A Quicksilver Shield with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 13 },
                { "monster slaying", 5 }
            }),
            new Weapon("Darksteel Shield of Monster Slaying", 565, 210, 3, "A Darksteel Shield with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 15 },
                { "monster slaying", 6 }
            }),
            new Weapon("Adamantite Shield of Monster Slaying", 575, 275, 4, "A Adamantite Shield with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 17 },
                { "monster slaying", 7 }
            }),
// enchantment 6
            new Weapon("Bronze Shield of Holy Smite", 516, 45, 3, "A Bronze Shield with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 5 },
                { "holy smite", 1 }
            }),
            new Weapon("Iron Shield of Holy Smite", 526, 60, 3, "A Iron Shield with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 7 },
                { "holy smite", 2 }
            }),
            new Weapon("Steel Shield of Holy Smite", 536, 75, 3, "A Steel Shield with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 9 },
                { "holy smite", 3 }
            }),
            new Weapon("Orichalcum Shield of Holy Smite", 546, 130, 3, "A Orichalcum Shield with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 11 },
                { "holy smite", 4 }
            }),
            new Weapon("Quicksilver Shield of Holy Smite", 556, 180, 3, "A Quicksilver Shield with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 13 },
                { "holy smite", 5 }
            }),
            new Weapon("Darksteel Shield of Holy Smite", 566, 260, 3, "A Darksteel Shield with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 15 },
                { "holy smite", 6 }
            }),
            new Weapon("Adamantite Shield of Holy Smite", 576, 330, 4, "A Adamantite Shield with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 17 },
                { "holy smite", 7 }
            }),
// end of Shield
// start Longsword
            new Weapon("Bronze Longsword", 610, 5, 0, "A simple Bronze Longsword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 6 }
            }),
            new Weapon("Iron Longsword", 620, 11, 1, "A simple Iron Longsword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 8 }
            }),
            new Weapon("Steel Longsword", 630, 20, 1, "A simple Steel Longsword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 10 }
            }),
            new Weapon("Orichalcum Longsword", 640, 30, 2, "A simple Orichalcum Longsword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 12 }
            }),
            new Weapon("Quicksilver Longsword", 650, 70, 3, "A simple Quicksilver Longsword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 14 }
            }),
            new Weapon("Darksteel Longsword", 660, 120, 3, "A simple Darksteel Longsword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 16 }
            }),
            new Weapon("Adamantite Longsword", 670, 240, 4, "A simple Adamantite Longsword",
            new Dictionary<string, int>
            {
                { "weaponDamage", 18 }
            }),
// enchantment 1
            new Weapon("Bronze Longsword of Fire", 611, 28, 1, "A Bronze Longsword with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "fire", 1 }
            }),
            new Weapon("Iron Longsword of Fire", 621, 32, 1, "A Iron Longsword with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "fire", 2 }
            }),
            new Weapon("Steel Longsword of Fire", 631, 38, 1, "A Steel Longsword with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "fire", 3 }
            }),
            new Weapon("Orichalcum Longsword of Fire", 641, 70, 2, "A Orichalcum Longsword with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "fire", 4 }
            }),
            new Weapon("Quicksilver Longsword of Fire", 651, 110, 3, "A Quicksilver Longsword with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "fire", 5 }
            }),
            new Weapon("Darksteel Longsword of Fire", 661, 195, 3, "A Darksteel Longsword with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "fire", 6 }
            }),
            new Weapon("Adamantite Longsword of Fire", 671, 300, 4, "A Adamantite Longsword with a Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "fire", 7 }
            }),
// enchantment 2
            new Weapon("Bronze Longsword of Ice", 612, 28, 1, "A Bronze Longsword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "ice", 1 }
            }),
            new Weapon("Iron Longsword of Ice", 622, 32, 1, "A Iron Longsword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "ice", 2 }
            }),
            new Weapon("Steel Longsword of Ice", 632, 38, 1, "A Steel Longsword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "ice", 3 }
            }),
            new Weapon("Orichalcum Longsword of Ice", 642, 70, 2, "A Orichalcum Longsword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "ice", 4 }
            }),
            new Weapon("Quicksilver Longsword of Ice", 652, 110, 3, "A Quicksilver Longsword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "ice", 5 }
            }),
            new Weapon("Darksteel Longsword of Ice", 662, 195, 3, "A Darksteel Longsword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "ice", 6 }
            }),
            new Weapon("Adamantite Longsword of Ice", 672, 300, 4, "A Adamantite Longsword with a Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "ice", 7 }
            }),
// enchantment 3
            new Weapon("Bronze Longsword of Lightning", 613, 28, 1, "A Bronze Longsword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "lightning", 1 }
            }),
            new Weapon("Iron Longsword of Lightning", 623, 32, 1, "A Iron Longsword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "lightning", 2 }
            }),
            new Weapon("Steel Longsword of Lightning", 633, 38, 1, "A Steel Longsword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "lightning", 3 }
            }),
            new Weapon("Orichalcum Longsword of Lightning", 643, 70, 2, "A Orichalcum Longsword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "lightning", 4 }
            }),
            new Weapon("Quicksilver Longsword of Lightning", 653, 110, 3, "A Quicksilver Longsword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "lightning", 5 }
            }),
            new Weapon("Darksteel Longsword of Lightning", 663, 195, 3, "A Darksteel Longsword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "lightning", 6 }
            }),
            new Weapon("Adamantite Longsword of Lightning", 673, 300, 4, "A Adamantite Longsword with a Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "lightning", 7 }
            }),
// enchantment 4
            new Weapon("Bronze Longsword of Armor Piercing", 614, 38, 2, "A Bronze Longsword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "armor piercing", 1 }
            }),
            new Weapon("Iron Longsword of Armor Piercing", 624, 42, 2, "A Iron Longsword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "armor piercing", 2 }
            }),
            new Weapon("Steel Longsword of Armor Piercing", 634, 60, 2, "A Steel Longsword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "armor piercing", 3 }
            }),
            new Weapon("Orichalcum Longsword of Armor Piercing", 644, 90, 2, "A Orichalcum Longsword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "armor piercing", 4 }
            }),
            new Weapon("Quicksilver Longsword of Armor Piercing", 654, 165, 3, "A Quicksilver Longsword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "armor piercing", 5 }
            }),
            new Weapon("Darksteel Longsword of Armor Piercing", 664, 240, 3, "A Darksteel Longsword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "armor piercing", 6 }
            }),
            new Weapon("Adamantite Longsword of Armor Piercing", 674, 350, 4, "A Adamantite Longsword with a Armor Piercing enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "armor piercing", 7 }
            }),
// enchantment 5
            new Weapon("Bronze Longsword of Monster Slaying", 615, 38, 2, "A Bronze Longsword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "monster slaying", 1 }
            }),
            new Weapon("Iron Longsword of Monster Slaying", 625, 42, 2, "A Iron Longsword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "monster slaying", 2 }
            }),
            new Weapon("Steel Longsword of Monster Slaying", 635, 60, 2, "A Steel Longsword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "monster slaying", 3 }
            }),
            new Weapon("Orichalcum Longsword of Monster Slaying", 645, 90, 2, "A Orichalcum Longsword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "monster slaying", 4 }
            }),
            new Weapon("Quicksilver Longsword of Monster Slaying", 655, 165, 3, "A Quicksilver Longsword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "monster slaying", 5 }
            }),
            new Weapon("Darksteel Longsword of Monster Slaying", 665, 240, 3, "A Darksteel Longsword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "monster slaying", 6 }
            }),
            new Weapon("Adamantite Longsword of Monster Slaying", 675, 350, 4, "A Adamantite Longsword with a Monster Slaying enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "monster slaying", 7 }
            }),
// enchantment 6
            new Weapon("Bronze Longsword of Holy Smite", 616, 48, 3, "A Bronze Longsword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "holy smite", 1 }
            }),
            new Weapon("Iron Longsword of Holy Smite", 626, 62, 3, "A Iron Longsword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "holy smite", 2 }
            }),
            new Weapon("Steel Longsword of Holy Smite", 636, 90, 3, "A Steel Longsword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "holy smite", 3 }
            }),
            new Weapon("Orichalcum Longsword of Holy Smite", 646, 130, 3, "A Orichalcum Longsword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "holy smite", 4 }
            }),
            new Weapon("Quicksilver Longsword of Holy Smite", 656, 200, 3, "A Quicksilver Longsword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "holy smite", 5 }
            }),
            new Weapon("Darksteel Longsword of Holy Smite", 666, 280, 3, "A Darksteel Longsword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "holy smite", 6 }
            }),
            new Weapon("Adamantite Longsword of Holy Smite", 676, 420, 4, "A Adamantite Longsword with a Holy Smite enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "holy smite", 7 }
            })
        };
    }
    void ArmorDatabase()
    {
        armors = new List<Armor>()
        {
// null enchantment
// armor 1
            new Armor("Bronze Helmet-Light", 110, 5, 0, "A simple Bronze Helmet-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Helmet-Light", 120, 15, 1, "A simple Iron Helmet-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Helmet-Light", 130, 30, 1, "A simple Steel Helmet-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Helmet-Light", 140, 55, 2, "A simple Orichalcum Helmet-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Helmet-Light", 150, 85, 3, "A simple Quicksilver Helmet-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Helmet-Light", 160, 125, 3, "A simple Darksteel Helmet-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Helmet-Light", 170, 175, 4, "A simple Adamantite Helmet-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 2
            new Armor("Bronze Helmet-Medium", 210, 7, 0, "A simple Bronze Helmet-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Helmet-Medium", 220, 18, 1, "A simple Iron Helmet-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Helmet-Medium", 230, 38, 1, "A simple Steel Helmet-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Helmet-Medium", 240, 65, 2, "A simple Orichalcum Helmet-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Helmet-Medium", 250, 95, 3, "A simple Quicksilver Helmet-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Helmet-Medium", 260, 135, 3, "A simple Darksteel Helmet-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Helmet-Medium", 270, 190, 4, "A simple Adamantite Helmet-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 3
            new Armor("Bronze Helmet-Heavy", 310, 9, 0, "A simple Bronze Helmet-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Helmet-Heavy", 320, 20, 1, "A simple Iron Helmet-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Helmet-Heavy", 330, 40, 1, "A simple Steel Helmet-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Helmet-Heavy", 340, 70, 2, "A simple Orichalcum Helmet-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Helmet-Heavy", 350, 105, 3, "A simple Quicksilver Helmet-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Helmet-Heavy", 360, 150, 3, "A simple Darksteel Helmet-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Helmet-Heavy", 370, 210, 4, "A simple Adamantite Helmet-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 4
            new Armor("Bronze Chest-Light", 410, 5, 0, "A simple Bronze Chest-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Chest-Light", 420, 15, 1, "A simple Iron Chest-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Chest-Light", 430, 30, 1, "A simple Steel Chest-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Chest-Light", 440, 55, 2, "A simple Orichalcum Chest-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Chest-Light", 450, 85, 3, "A simple Quicksilver Chest-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Chest-Light", 460, 125, 3, "A simple Darksteel Chest-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Chest-Light", 470, 175, 4, "A simple Adamantite Chest-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 5
            new Armor("Bronze Chest-Medium", 510, 7, 0, "A simple Bronze Chest-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Chest-Medium", 520, 18, 1, "A simple Iron Chest-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Chest-Medium", 530, 38, 1, "A simple Steel Chest-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Chest-Medium", 540, 65, 2, "A simple Orichalcum Chest-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Chest-Medium", 550, 95, 3, "A simple Quicksilver Chest-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Chest-Medium", 560, 135, 3, "A simple Darksteel Chest-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Chest-Medium", 570, 190, 4, "A simple Adamantite Chest-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 6
            new Armor("Bronze Chest-Heavy", 610, 9, 0, "A simple Bronze Chest-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Chest-Heavy", 620, 20, 1, "A simple Iron Chest-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Chest-Heavy", 630, 40, 1, "A simple Steel Chest-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Chest-Heavy", 640, 70, 2, "A simple Orichalcum Chest-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Chest-Heavy", 650, 105, 3, "A simple Quicksilver Chest-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Chest-Heavy", 660, 150, 3, "A simple Darksteel Chest-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Chest-Heavy", 670, 210, 4, "A simple Adamantite Chest-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 7
            new Armor("Bronze Arms-Light", 710, 5, 0, "A simple Bronze Arms-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Arms-Light", 720, 15, 1, "A simple Iron Arms-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Arms-Light", 730, 30, 1, "A simple Steel Arms-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Arms-Light", 740, 55, 2, "A simple Orichalcum Arms-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Arms-Light", 750, 85, 3, "A simple Quicksilver Arms-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Arms-Light", 760, 125, 3, "A simple Darksteel Arms-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Arms-Light", 770, 175, 4, "A simple Adamantite Arms-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 8
            new Armor("Bronze Arms-Medium", 810, 7, 0, "A simple Bronze Arms-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Arms-Medium", 820, 18, 1, "A simple Iron Arms-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Arms-Medium", 830, 38, 1, "A simple Steel Arms-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Arms-Medium", 840, 65, 2, "A simple Orichalcum Arms-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Arms-Medium", 850, 95, 3, "A simple Quicksilver Arms-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Arms-Medium", 860, 135, 3, "A simple Darksteel Arms-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Arms-Medium", 870, 190, 4, "A simple Adamantite Arms-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 9
            new Armor("Bronze Arms-Heavy", 910, 9, 0, "A simple Bronze Arms-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Arms-Heavy", 920, 20, 1, "A simple Iron Arms-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Arms-Heavy", 930, 40, 1, "A simple Steel Arms-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Arms-Heavy", 940, 70, 2, "A simple Orichalcum Arms-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Arms-Heavy", 950, 105, 3, "A simple Quicksilver Arms-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Arms-Heavy", 960, 150, 3, "A simple Darksteel Arms-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Arms-Heavy", 970, 210, 4, "A simple Adamantite Arms-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 10
            new Armor("Bronze Legs-Light", 1010, 5, 0, "A simple Bronze Legs-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Legs-Light", 1020, 15, 1, "A simple Iron Legs-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Legs-Light", 1030, 30, 1, "A simple Steel Legs-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Legs-Light", 1040, 55, 2, "A simple Orichalcum Legs-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Legs-Light", 1050, 85, 3, "A simple Quicksilver Legs-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Legs-Light", 1060, 125, 3, "A simple Darksteel Legs-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Legs-Light", 1070, 175, 4, "A simple Adamantite Legs-Light",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 11
            new Armor("Bronze Legs-Medium", 1110, 7, 0, "A simple Bronze Legs-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Legs-Medium", 1120, 18, 1, "A simple Iron Legs-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Legs-Medium", 1130, 38, 1, "A simple Steel Legs-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Legs-Medium", 1140, 65, 2, "A simple Orichalcum Legs-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Legs-Medium", 1150, 95, 3, "A simple Quicksilver Legs-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Legs-Medium", 1160, 135, 3, "A simple Darksteel Legs-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Legs-Medium", 1170, 190, 4, "A simple Adamantite Legs-Medium",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// armor 12
            new Armor("Bronze Legs-Heavy", 1210, 9, 0, "A simple Bronze Legs-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
            }),
            new Armor("Iron Legs-Heavy", 1220, 20, 1, "A simple Iron Legs-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
            }),
            new Armor("Steel Legs-Heavy", 1230, 40, 1, "A simple Steel Legs-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
            }),
            new Armor("Orichalcum Legs-Heavy", 1240, 70, 2, "A simple Orichalcum Legs-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
            }),
            new Armor("Quicksilver Legs-Heavy", 1250, 105, 3, "A simple Quicksilver Legs-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
            }),
            new Armor("Darksteel Legs-Heavy", 1260, 150, 3, "A simple Darksteel Legs-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
            }),
            new Armor("Adamantite Legs-Heavy", 1270, 210, 4, "A simple Adamantite Legs-Heavy",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
            }),
// Fire Enchantment
// armor 1
            new Armor("Bronze Helmet-Light", 111, 15, 2, "A Bronze Helmet-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Helmet-Light", 121, 25, 2, "A Iron Helmet-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Helmet-Light", 131, 45, 2, "A Steel Helmet-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Helmet-Light", 141, 65, 2, "A Orichalcum Helmet-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Helmet-Light", 151, 105, 3, "A Quicksilver Helmet-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Helmet-Light", 161, 145, 3, "A Darksteel Helmet-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Helmet-Light", 171, 195, 4, "A Adamantite Helmet-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 2
            new Armor("Bronze Helmet-Medium", 211, 17, 2, "A Bronze Helmet-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Helmet-Medium", 221, 28, 2, "A Iron Helmet-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Helmet-Medium", 231, 48, 2, "A Steel Helmet-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Helmet-Medium", 241, 75, 2, "A Orichalcum Helmet-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Helmet-Medium", 251, 115, 3, "A Quicksilver Helmet-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Helmet-Medium", 261, 155, 3, "A Darksteel Helmet-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Helmet-Medium", 271, 210, 4, "A Adamantite Helmet-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 3
            new Armor("Bronze Helmet-Heavy", 311, 19, 2, "A Bronze Helmet-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Helmet-Heavy", 321, 30, 2, "A Iron Helmet-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Helmet-Heavy", 331, 50, 2, "A Steel Helmet-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Helmet-Heavy", 341, 90, 2, "A Orichalcum Helmet-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Helmet-Heavy", 351, 125, 3, "A Quicksilver Helmet-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Helmet-Heavy", 361, 170, 3, "A Darksteel Helmet-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Helmet-Heavy", 371, 230, 4, "A Adamantite Helmet-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 4
            new Armor("Bronze Chest-Light", 411, 15, 2, "A Bronze Chest-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Chest-Light", 421, 25, 2, "A Iron Chest-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Chest-Light", 431, 45, 2, "A Steel Chest-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Chest-Light", 441, 65, 2, "A Orichalcum Chest-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Chest-Light", 451, 105, 3, "A Quicksilver Chest-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Chest-Light", 461, 145, 3, "A Darksteel Chest-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Chest-Light", 471, 195, 4, "A Adamantite Chest-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 5
            new Armor("Bronze Chest-Medium", 511, 17, 2, "A Bronze Chest-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Chest-Medium", 521, 28, 2, "A Iron Chest-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Chest-Medium", 531, 48, 2, "A Steel Chest-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Chest-Medium", 541, 75, 2, "A Orichalcum Chest-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Chest-Medium", 551, 115, 3, "A Quicksilver Chest-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Chest-Medium", 561, 155, 3, "A Darksteel Chest-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Chest-Medium", 571, 210, 4, "A Adamantite Chest-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 6
            new Armor("Bronze Chest-Heavy", 611, 19, 2, "A Bronze Chest-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Chest-Heavy", 621, 30, 2, "A Iron Chest-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Chest-Heavy", 631, 50, 2, "A Steel Chest-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Chest-Heavy", 641, 90, 2, "A Orichalcum Chest-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Chest-Heavy", 651, 125, 3, "A Quicksilver Chest-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Chest-Heavy", 661, 170, 3, "A Darksteel Chest-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Chest-Heavy", 671, 230, 4, "A Adamantite Chest-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 7
            new Armor("Bronze Arms-Light", 711, 15, 2, "A Bronze Arms-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Arms-Light", 721, 25, 2, "A Iron Arms-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Arms-Light", 731, 45, 2, "A Steel Arms-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Arms-Light", 741, 65, 2, "A Orichalcum Arms-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Arms-Light", 751, 105, 3, "A Quicksilver Arms-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Arms-Light", 761, 145, 3, "A Darksteel Arms-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Arms-Light", 771, 195, 4, "A Adamantite Arms-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 8
            new Armor("Bronze Arms-Medium", 811, 17, 2, "A Bronze Arms-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Arms-Medium", 821, 28, 2, "A Iron Arms-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Arms-Medium", 831, 48, 2, "A Steel Arms-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Arms-Medium", 841, 75, 2, "A Orichalcum Arms-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Arms-Medium", 851, 115, 3, "A Quicksilver Arms-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Arms-Medium", 861, 155, 3, "A Darksteel Arms-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Arms-Medium", 871, 210, 4, "A Adamantite Arms-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 9
            new Armor("Bronze Arms-Heavy", 911, 19, 2, "A Bronze Arms-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Arms-Heavy", 921, 30, 2, "A Iron Arms-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Arms-Heavy", 931, 50, 2, "A Steel Arms-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Arms-Heavy", 941, 90, 2, "A Orichalcum Arms-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Arms-Heavy", 951, 125, 3, "A Quicksilver Arms-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Arms-Heavy", 961, 170, 3, "A Darksteel Arms-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Arms-Heavy", 971, 230, 4, "A Adamantite Arms-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 10
            new Armor("Bronze Legs-Light", 1011, 15, 2, "A Bronze Legs-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Legs-Light", 1021, 25, 2, "A Iron Legs-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Legs-Light", 1031, 45, 2, "A Steel Legs-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Legs-Light", 1041, 65, 2, "A Orichalcum Legs-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Legs-Light", 1051, 105, 3, "A Quicksilver Legs-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Legs-Light", 1061, 145, 3, "A Darksteel Legs-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Legs-Light", 1071, 195, 4, "A Adamantite Legs-Light with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 11
            new Armor("Bronze Legs-Medium", 1111, 17, 2, "A Bronze Legs-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Legs-Medium", 1121, 28, 2, "A Iron Legs-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Legs-Medium", 1131, 48, 2, "A Steel Legs-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Legs-Medium", 1141, 75, 2, "A Orichalcum Legs-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Legs-Medium", 1151, 115, 3, "A Quicksilver Legs-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Legs-Medium", 1161, 155, 3, "A Darksteel Legs-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Legs-Medium", 1171, 210, 4, "A Adamantite Legs-Medium with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
// armor 12
            new Armor("Bronze Legs-Heavy", 1211, 19, 2, "A Bronze Legs-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Fire", 1 }
            }),
            new Armor("Iron Legs-Heavy", 1221, 30, 2, "A Iron Legs-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Fire", 2 }
            }),
            new Armor("Steel Legs-Heavy", 1231, 50, 2, "A Steel Legs-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Fire", 3 }
            }),
            new Armor("Orichalcum Legs-Heavy", 1241, 90, 2, "A Orichalcum Legs-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Fire", 4 }
            }),
            new Armor("Quicksilver Legs-Heavy", 1251, 125, 3, "A Quicksilver Legs-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Fire", 5 }
            }),
            new Armor("Darksteel Legs-Heavy", 1261, 170, 3, "A Darksteel Legs-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Fire", 6 }
            }),
            new Armor("Adamantite Legs-Heavy", 1271, 230, 4, "A Adamantite Legs-Heavy with a Absorb Fire enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Fire", 7 }
            }),
//Absorb Ice Enchantment
// armor 1
            new Armor("Bronze Helmet-Light", 112, 15, 2, "A Bronze Helmet-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Helmet-Light", 122, 25, 2, "A Iron Helmet-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Helmet-Light", 132, 45, 2, "A Steel Helmet-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Helmet-Light", 142, 65, 2, "A Orichalcum Helmet-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Helmet-Light", 152, 105, 3, "A Quicksilver Helmet-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Helmet-Light", 162, 145, 3, "A Darksteel Helmet-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Helmet-Light", 172, 195, 4, "A Adamantite Helmet-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 2
            new Armor("Bronze Helmet-Medium", 212, 17, 2, "A Bronze Helmet-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Helmet-Medium", 222, 28, 2, "A Iron Helmet-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Helmet-Medium", 232, 48, 2, "A Steel Helmet-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Helmet-Medium", 242, 75, 2, "A Orichalcum Helmet-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Helmet-Medium", 252, 115, 3, "A Quicksilver Helmet-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Helmet-Medium", 262, 155, 3, "A Darksteel Helmet-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Helmet-Medium", 272, 210, 4, "A Adamantite Helmet-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 3
            new Armor("Bronze Helmet-Heavy", 312, 19, 2, "A Bronze Helmet-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Helmet-Heavy", 322, 30, 2, "A Iron Helmet-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Helmet-Heavy", 332, 50, 2, "A Steel Helmet-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Helmet-Heavy", 342, 90, 2, "A Orichalcum Helmet-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Helmet-Heavy", 352, 125, 3, "A Quicksilver Helmet-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Helmet-Heavy", 362, 170, 3, "A Darksteel Helmet-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Helmet-Heavy", 372, 230, 4, "A Adamantite Helmet-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 4
            new Armor("Bronze Chest-Light", 412, 15, 2, "A Bronze Chest-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Chest-Light", 422, 25, 2, "A Iron Chest-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Chest-Light", 432, 45, 2, "A Steel Chest-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Chest-Light", 442, 65, 2, "A Orichalcum Chest-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Chest-Light", 452, 105, 3, "A Quicksilver Chest-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Chest-Light", 462, 145, 3, "A Darksteel Chest-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Chest-Light", 472, 195, 4, "A Adamantite Chest-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 5
            new Armor("Bronze Chest-Medium", 512, 17, 2, "A Bronze Chest-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Chest-Medium", 522, 28, 2, "A Iron Chest-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Chest-Medium", 532, 48, 2, "A Steel Chest-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Chest-Medium", 542, 75, 2, "A Orichalcum Chest-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Chest-Medium", 552, 115, 3, "A Quicksilver Chest-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Chest-Medium", 562, 155, 3, "A Darksteel Chest-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Chest-Medium", 572, 210, 4, "A Adamantite Chest-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 6
            new Armor("Bronze Chest-Heavy", 612, 19, 2, "A Bronze Chest-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Chest-Heavy", 622, 30, 2, "A Iron Chest-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Chest-Heavy", 632, 50, 2, "A Steel Chest-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Chest-Heavy", 642, 90, 2, "A Orichalcum Chest-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Chest-Heavy", 652, 125, 3, "A Quicksilver Chest-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Chest-Heavy", 662, 170, 3, "A Darksteel Chest-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Chest-Heavy", 672, 230, 4, "A Adamantite Chest-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 7
            new Armor("Bronze Arms-Light", 712, 15, 2, "A Bronze Arms-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Arms-Light", 722, 25, 2, "A Iron Arms-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Arms-Light", 732, 45, 2, "A Steel Arms-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Arms-Light", 742, 65, 2, "A Orichalcum Arms-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Arms-Light", 752, 105, 3, "A Quicksilver Arms-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Arms-Light", 762, 145, 3, "A Darksteel Arms-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Arms-Light", 772, 195, 4, "A Adamantite Arms-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 8
            new Armor("Bronze Arms-Medium", 812, 17, 2, "A Bronze Arms-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Arms-Medium", 822, 28, 2, "A Iron Arms-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Arms-Medium", 832, 48, 2, "A Steel Arms-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Arms-Medium", 842, 75, 2, "A Orichalcum Arms-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Arms-Medium", 852, 115, 3, "A Quicksilver Arms-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Arms-Medium", 862, 155, 3, "A Darksteel Arms-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Arms-Medium", 872, 210, 4, "A Adamantite Arms-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 9
            new Armor("Bronze Arms-Heavy", 912, 19, 2, "A Bronze Arms-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Arms-Heavy", 922, 30, 2, "A Iron Arms-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Arms-Heavy", 932, 50, 2, "A Steel Arms-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Arms-Heavy", 942, 90, 2, "A Orichalcum Arms-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Arms-Heavy", 952, 125, 3, "A Quicksilver Arms-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Arms-Heavy", 962, 170, 3, "A Darksteel Arms-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Arms-Heavy", 972, 230, 4, "A Adamantite Arms-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 10
            new Armor("Bronze Legs-Light", 1012, 15, 2, "A Bronze Legs-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Legs-Light", 1022, 25, 2, "A Iron Legs-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Legs-Light", 1032, 45, 2, "A Steel Legs-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Legs-Light", 1042, 65, 2, "A Orichalcum Legs-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Legs-Light", 1052, 105, 3, "A Quicksilver Legs-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Legs-Light", 1062, 145, 3, "A Darksteel Legs-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Legs-Light", 1072, 195, 4, "A Adamantite Legs-Light with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 11
            new Armor("Bronze Legs-Medium", 1112, 17, 2, "A Bronze Legs-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Legs-Medium", 1122, 28, 2, "A Iron Legs-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Legs-Medium", 1132, 48, 2, "A Steel Legs-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Legs-Medium", 1142, 75, 2, "A Orichalcum Legs-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Legs-Medium", 1152, 115, 3, "A Quicksilver Legs-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Legs-Medium", 1162, 155, 3, "A Darksteel Legs-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Legs-Medium", 1172, 210, 4, "A Adamantite Legs-Medium with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
// armor 12
            new Armor("Bronze Legs-Heavy", 1212, 19, 2, "A Bronze Legs-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Ice", 1 }
            }),
            new Armor("Iron Legs-Heavy", 1222, 30, 2, "A Iron Legs-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Ice", 2 }
            }),
            new Armor("Steel Legs-Heavy", 1232, 50, 2, "A Steel Legs-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Ice", 3 }
            }),
            new Armor("Orichalcum Legs-Heavy", 1242, 90, 2, "A Orichalcum Legs-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Ice", 4 }
            }),
            new Armor("Quicksilver Legs-Heavy", 1252, 125, 3, "A Quicksilver Legs-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Ice", 5 }
            }),
            new Armor("Darksteel Legs-Heavy", 1262, 170, 3, "A Darksteel Legs-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Ice", 6 }
            }),
            new Armor("Adamantite Legs-Heavy", 1272, 230, 4, "A Adamantite Legs-Heavy with a Absorb Ice enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Ice", 7 }
            }),
//Absorb Lightning
// armor 1
            new Armor("Bronze Helmet-Light", 113, 15, 2, "A Bronze Helmet-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Helmet-Light", 123, 25, 2, "A Iron Helmet-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Helmet-Light", 133, 45, 2, "A Steel Helmet-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Helmet-Light", 143, 65, 2, "A Orichalcum Helmet-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Helmet-Light", 153, 105, 3, "A Quicksilver Helmet-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Helmet-Light", 163, 145, 3, "A Darksteel Helmet-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Helmet-Light", 173, 195, 4, "A Adamantite Helmet-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 2
            new Armor("Bronze Helmet-Medium", 213, 17, 2, "A Bronze Helmet-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Helmet-Medium", 223, 28, 2, "A Iron Helmet-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Helmet-Medium", 233, 48, 2, "A Steel Helmet-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Helmet-Medium", 243, 75, 2, "A Orichalcum Helmet-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Helmet-Medium", 253, 115, 3, "A Quicksilver Helmet-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Helmet-Medium", 263, 155, 3, "A Darksteel Helmet-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Helmet-Medium", 273, 210, 4, "A Adamantite Helmet-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 3
            new Armor("Bronze Helmet-Heavy", 313, 19, 2, "A Bronze Helmet-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Helmet-Heavy", 323, 30, 2, "A Iron Helmet-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Helmet-Heavy", 333, 50, 2, "A Steel Helmet-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Helmet-Heavy", 343, 90, 2, "A Orichalcum Helmet-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Helmet-Heavy", 353, 125, 3, "A Quicksilver Helmet-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Helmet-Heavy", 363, 170, 3, "A Darksteel Helmet-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Helmet-Heavy", 373, 230, 4, "A Adamantite Helmet-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 4
            new Armor("Bronze Chest-Light", 413, 15, 2, "A Bronze Chest-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Chest-Light", 423, 25, 2, "A Iron Chest-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Chest-Light", 433, 45, 2, "A Steel Chest-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Chest-Light", 443, 65, 2, "A Orichalcum Chest-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Chest-Light", 453, 105, 3, "A Quicksilver Chest-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Chest-Light", 463, 145, 3, "A Darksteel Chest-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Chest-Light", 473, 195, 4, "A Adamantite Chest-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 5
            new Armor("Bronze Chest-Medium", 513, 17, 2, "A Bronze Chest-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Chest-Medium", 523, 28, 2, "A Iron Chest-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Chest-Medium", 533, 48, 2, "A Steel Chest-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Chest-Medium", 543, 75, 2, "A Orichalcum Chest-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Chest-Medium", 553, 115, 3, "A Quicksilver Chest-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Chest-Medium", 563, 155, 3, "A Darksteel Chest-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Chest-Medium", 573, 210, 4, "A Adamantite Chest-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 6
            new Armor("Bronze Chest-Heavy", 613, 19, 2, "A Bronze Chest-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Chest-Heavy", 623, 30, 2, "A Iron Chest-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Chest-Heavy", 633, 50, 2, "A Steel Chest-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Chest-Heavy", 643, 90, 2, "A Orichalcum Chest-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Chest-Heavy", 653, 125, 3, "A Quicksilver Chest-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Chest-Heavy", 663, 170, 3, "A Darksteel Chest-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Chest-Heavy", 673, 230, 4, "A Adamantite Chest-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 7
            new Armor("Bronze Arms-Light", 713, 15, 2, "A Bronze Arms-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Arms-Light", 723, 25, 2, "A Iron Arms-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Arms-Light", 733, 45, 2, "A Steel Arms-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Arms-Light", 743, 65, 2, "A Orichalcum Arms-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Arms-Light", 753, 105, 3, "A Quicksilver Arms-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Arms-Light", 763, 145, 3, "A Darksteel Arms-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Arms-Light", 773, 195, 4, "A Adamantite Arms-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 8
            new Armor("Bronze Arms-Medium", 813, 17, 2, "A Bronze Arms-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Arms-Medium", 823, 28, 2, "A Iron Arms-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Arms-Medium", 833, 48, 2, "A Steel Arms-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Arms-Medium", 843, 75, 2, "A Orichalcum Arms-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Arms-Medium", 853, 115, 3, "A Quicksilver Arms-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Arms-Medium", 863, 155, 3, "A Darksteel Arms-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Arms-Medium", 873, 210, 4, "A Adamantite Arms-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 9
            new Armor("Bronze Arms-Heavy", 913, 19, 2, "A Bronze Arms-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Arms-Heavy", 923, 30, 2, "A Iron Arms-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Arms-Heavy", 933, 50, 2, "A Steel Arms-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Arms-Heavy", 943, 90, 2, "A Orichalcum Arms-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Arms-Heavy", 953, 125, 3, "A Quicksilver Arms-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Arms-Heavy", 963, 170, 3, "A Darksteel Arms-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Arms-Heavy", 973, 230, 4, "A Adamantite Arms-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 10
            new Armor("Bronze Legs-Light", 1013, 15, 2, "A Bronze Legs-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Legs-Light", 1023, 25, 2, "A Iron Legs-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Legs-Light", 1033, 45, 2, "A Steel Legs-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Legs-Light", 1043, 65, 2, "A Orichalcum Legs-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Legs-Light", 1053, 105, 3, "A Quicksilver Legs-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Legs-Light", 1063, 145, 3, "A Darksteel Legs-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Legs-Light", 1073, 195, 4, "A Adamantite Legs-Light with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 11
            new Armor("Bronze Legs-Medium", 1113, 17, 2, "A Bronze Legs-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Legs-Medium", 1123, 28, 2, "A Iron Legs-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Legs-Medium", 1133, 48, 2, "A Steel Legs-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Legs-Medium", 1143, 75, 2, "A Orichalcum Legs-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Legs-Medium", 1153, 115, 3, "A Quicksilver Legs-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Legs-Medium", 1163, 155, 3, "A Darksteel Legs-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Legs-Medium", 1173, 210, 4, "A Adamantite Legs-Medium with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
// armor 12
            new Armor("Bronze Legs-Heavy", 1213, 19, 2, "A Bronze Legs-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Absorb Lightning", 1 }
            }),
            new Armor("Iron Legs-Heavy", 1223, 30, 2, "A Iron Legs-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Absorb Lightning", 2 }
            }),
            new Armor("Steel Legs-Heavy", 1233, 50, 2, "A Steel Legs-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Absorb Lightning", 3 }
            }),
            new Armor("Orichalcum Legs-Heavy", 1243, 90, 2, "A Orichalcum Legs-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Absorb Lightning", 4 }
            }),
            new Armor("Quicksilver Legs-Heavy", 1253, 125, 3, "A Quicksilver Legs-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Absorb Lightning", 5 }
            }),
            new Armor("Darksteel Legs-Heavy", 1263, 170, 3, "A Darksteel Legs-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Absorb Lightning", 6 }
            }),
            new Armor("Adamantite Legs-Heavy", 1273, 230, 4, "A Adamantite Legs-Heavy with a Absorb Lightning enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Absorb Lightning", 7 }
            }),
//Mana Regeneration
// armor 1
            new Armor("Bronze Helmet-Light", 114, 25, 3, "A Bronze Helmet-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Helmet-Light", 124, 35, 3, "A Iron Helmet-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Helmet-Light", 134, 55, 3, "A Steel Helmet-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Helmet-Light", 144, 85, 3, "A Orichalcum Helmet-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Helmet-Light", 154, 125, 3, "A Quicksilver Helmet-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Helmet-Light", 164, 165, 3, "A Darksteel Helmet-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Helmet-Light", 174, 215, 4, "A Adamantite Helmet-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 2
            new Armor("Bronze Helmet-Medium", 214, 27, 3, "A Bronze Helmet-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Helmet-Medium", 224, 38, 3, "A Iron Helmet-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Helmet-Medium", 234, 58, 3, "A Steel Helmet-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Helmet-Medium", 244, 95, 3, "A Orichalcum Helmet-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Helmet-Medium", 254, 135, 3, "A Quicksilver Helmet-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Helmet-Medium", 264, 175, 3, "A Darksteel Helmet-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Helmet-Medium", 274, 230, 4, "A Adamantite Helmet-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 3
            new Armor("Bronze Helmet-Heavy", 314, 29, 3, "A Bronze Helmet-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Helmet-Heavy", 324, 40, 3, "A Iron Helmet-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Helmet-Heavy", 334, 60, 3, "A Steel Helmet-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Helmet-Heavy", 344, 110, 3, "A Orichalcum Helmet-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Helmet-Heavy", 354, 150, 3, "A Quicksilver Helmet-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Helmet-Heavy", 364, 195, 3, "A Darksteel Helmet-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Helmet-Heavy", 374, 260, 4, "A Adamantite Helmet-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 4
            new Armor("Bronze Chest-Light", 414, 25, 3, "A Bronze Chest-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Chest-Light", 424, 35, 3, "A Iron Chest-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Chest-Light", 434, 55, 3, "A Steel Chest-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Chest-Light", 444, 85, 3, "A Orichalcum Chest-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Chest-Light", 454, 125, 3, "A Quicksilver Chest-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Chest-Light", 464, 165, 3, "A Darksteel Chest-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Chest-Light", 474, 215, 4, "A Adamantite Chest-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 5
            new Armor("Bronze Chest-Medium", 514, 27, 3, "A Bronze Chest-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Chest-Medium", 524, 38, 3, "A Iron Chest-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Chest-Medium", 534, 58, 3, "A Steel Chest-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Chest-Medium", 544, 95, 3, "A Orichalcum Chest-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Chest-Medium", 554, 135, 3, "A Quicksilver Chest-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Chest-Medium", 564, 175, 3, "A Darksteel Chest-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Chest-Medium", 574, 230, 4, "A Adamantite Chest-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 6
            new Armor("Bronze Chest-Heavy", 614, 29, 3, "A Bronze Chest-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Chest-Heavy", 624, 40, 3, "A Iron Chest-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Chest-Heavy", 634, 60, 3, "A Steel Chest-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Chest-Heavy", 644, 110, 3, "A Orichalcum Chest-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Chest-Heavy", 654, 150, 3, "A Quicksilver Chest-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Chest-Heavy", 664, 195, 3, "A Darksteel Chest-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Chest-Heavy", 674, 260, 4, "A Adamantite Chest-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 7
            new Armor("Bronze Arms-Light", 714, 25, 3, "A Bronze Arms-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Arms-Light", 724, 35, 3, "A Iron Arms-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Arms-Light", 734, 55, 3, "A Steel Arms-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Arms-Light", 744, 85, 3, "A Orichalcum Arms-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Arms-Light", 754, 125, 3, "A Quicksilver Arms-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Arms-Light", 764, 165, 3, "A Darksteel Arms-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Arms-Light", 774, 215, 4, "A Adamantite Arms-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 8
            new Armor("Bronze Arms-Medium", 814, 27, 3, "A Bronze Arms-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Arms-Medium", 824, 38, 3, "A Iron Arms-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Arms-Medium", 834, 58, 3, "A Steel Arms-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Arms-Medium", 844, 95, 3, "A Orichalcum Arms-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Arms-Medium", 854, 135, 3, "A Quicksilver Arms-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Arms-Medium", 864, 175, 3, "A Darksteel Arms-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Arms-Medium", 874, 230, 4, "A Adamantite Arms-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 9
            new Armor("Bronze Arms-Heavy", 914, 29, 3, "A Bronze Arms-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Arms-Heavy", 924, 40, 3, "A Iron Arms-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Arms-Heavy", 934, 60, 3, "A Steel Arms-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Arms-Heavy", 944, 110, 3, "A Orichalcum Arms-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Arms-Heavy", 954, 150, 3, "A Quicksilver Arms-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Arms-Heavy", 964, 195, 3, "A Darksteel Arms-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Arms-Heavy", 974, 260, 4, "A Adamantite Arms-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 10
            new Armor("Bronze Legs-Light", 1014, 25, 3, "A Bronze Legs-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Legs-Light", 1024, 35, 3, "A Iron Legs-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Legs-Light", 1034, 55, 3, "A Steel Legs-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Legs-Light", 1044, 85, 3, "A Orichalcum Legs-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Legs-Light", 1054, 125, 3, "A Quicksilver Legs-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Legs-Light", 1064, 165, 3, "A Darksteel Legs-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Legs-Light", 1074, 215, 4, "A Adamantite Legs-Light with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 11
            new Armor("Bronze Legs-Medium", 1114, 27, 3, "A Bronze Legs-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Legs-Medium", 1124, 38, 3, "A Iron Legs-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Legs-Medium", 1134, 58, 3, "A Steel Legs-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Legs-Medium", 1144, 95, 3, "A Orichalcum Legs-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Legs-Medium", 1154, 135, 3, "A Quicksilver Legs-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Legs-Medium", 1164, 175, 3, "A Darksteel Legs-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Legs-Medium", 1174, 230, 4, "A Adamantite Legs-Medium with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// armor 12
            new Armor("Bronze Legs-Heavy", 1214, 29, 3, "A Bronze Legs-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Mana Regen", 1 }
            }),
            new Armor("Iron Legs-Heavy", 1224, 40, 3, "A Iron Legs-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Mana Regen", 2 }
            }),
            new Armor("Steel Legs-Heavy", 1234, 60, 3, "A Steel Legs-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Mana Regen", 3 }
            }),
            new Armor("Orichalcum Legs-Heavy", 1244, 110, 3, "A Orichalcum Legs-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Mana Regen", 4 }
            }),
            new Armor("Quicksilver Legs-Heavy", 1254, 150, 3, "A Quicksilver Legs-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Mana Regen", 5 }
            }),
            new Armor("Darksteel Legs-Heavy", 1264, 195, 3, "A Darksteel Legs-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Mana Regen", 6 }
            }),
            new Armor("Adamantite Legs-Heavy", 1274, 260, 4, "A Adamantite Legs-Heavy with a Mana Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Mana Regen", 7 }
            }),
// Health Regeneration
// armor 1
            new Armor("Bronze Helmet-Light", 115, 25, 3, "A Bronze Helmet-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Helmet-Light", 125, 35, 3, "A Iron Helmet-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Helmet-Light", 135, 55, 3, "A Steel Helmet-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Helmet-Light", 145, 85, 3, "A Orichalcum Helmet-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Helmet-Light", 155, 125, 3, "A Quicksilver Helmet-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Helmet-Light", 165, 165, 3, "A Darksteel Helmet-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Helmet-Light", 175, 215, 4, "A Adamantite Helmet-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 2
            new Armor("Bronze Helmet-Medium", 215, 27, 3, "A Bronze Helmet-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Helmet-Medium", 225, 38, 3, "A Iron Helmet-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Helmet-Medium", 235, 58, 3, "A Steel Helmet-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Helmet-Medium", 245, 95, 3, "A Orichalcum Helmet-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Helmet-Medium", 255, 135, 3, "A Quicksilver Helmet-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Helmet-Medium", 265, 175, 3, "A Darksteel Helmet-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Helmet-Medium", 275, 230, 4, "A Adamantite Helmet-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 3
            new Armor("Bronze Helmet-Heavy", 315, 29, 3, "A Bronze Helmet-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Helmet-Heavy", 325, 40, 3, "A Iron Helmet-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Helmet-Heavy", 335, 60, 3, "A Steel Helmet-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Helmet-Heavy", 345, 110, 3, "A Orichalcum Helmet-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Helmet-Heavy", 355, 150, 3, "A Quicksilver Helmet-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Helmet-Heavy", 365, 195, 3, "A Darksteel Helmet-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Helmet-Heavy", 375, 260, 4, "A Adamantite Helmet-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 4
            new Armor("Bronze Chest-Light", 415, 25, 3, "A Bronze Chest-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Chest-Light", 425, 35, 3, "A Iron Chest-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Chest-Light", 435, 55, 3, "A Steel Chest-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Chest-Light", 445, 85, 3, "A Orichalcum Chest-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Chest-Light", 455, 125, 3, "A Quicksilver Chest-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Chest-Light", 465, 165, 3, "A Darksteel Chest-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Chest-Light", 475, 215, 4, "A Adamantite Chest-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 5
            new Armor("Bronze Chest-Medium", 515, 27, 3, "A Bronze Chest-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Chest-Medium", 525, 38, 3, "A Iron Chest-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Chest-Medium", 535, 58, 3, "A Steel Chest-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Chest-Medium", 545, 95, 3, "A Orichalcum Chest-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Chest-Medium", 555, 135, 3, "A Quicksilver Chest-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Chest-Medium", 565, 175, 3, "A Darksteel Chest-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Chest-Medium", 575, 230, 4, "A Adamantite Chest-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 6
            new Armor("Bronze Chest-Heavy", 615, 29, 3, "A Bronze Chest-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Chest-Heavy", 625, 40, 3, "A Iron Chest-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Chest-Heavy", 635, 60, 3, "A Steel Chest-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Chest-Heavy", 645, 110, 3, "A Orichalcum Chest-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Chest-Heavy", 655, 150, 3, "A Quicksilver Chest-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Chest-Heavy", 665, 195, 3, "A Darksteel Chest-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Chest-Heavy", 675, 260, 4, "A Adamantite Chest-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 7
            new Armor("Bronze Arms-Light", 715, 25, 3, "A Bronze Arms-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Arms-Light", 725, 35, 3, "A Iron Arms-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Arms-Light", 735, 55, 3, "A Steel Arms-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Arms-Light", 745, 85, 3, "A Orichalcum Arms-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Arms-Light", 755, 125, 3, "A Quicksilver Arms-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Arms-Light", 765, 165, 3, "A Darksteel Arms-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Arms-Light", 775, 215, 4, "A Adamantite Arms-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 8
            new Armor("Bronze Arms-Medium", 815, 27, 3, "A Bronze Arms-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Arms-Medium", 825, 38, 3, "A Iron Arms-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Arms-Medium", 835, 58, 3, "A Steel Arms-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Arms-Medium", 845, 95, 3, "A Orichalcum Arms-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Arms-Medium", 855, 135, 3, "A Quicksilver Arms-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Arms-Medium", 865, 175, 3, "A Darksteel Arms-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Arms-Medium", 875, 230, 4, "A Adamantite Arms-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 9
            new Armor("Bronze Arms-Heavy", 915, 29, 3, "A Bronze Arms-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Arms-Heavy", 925, 40, 3, "A Iron Arms-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Arms-Heavy", 935, 60, 3, "A Steel Arms-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Arms-Heavy", 945, 110, 3, "A Orichalcum Arms-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Arms-Heavy", 955, 150, 3, "A Quicksilver Arms-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Arms-Heavy", 965, 195, 3, "A Darksteel Arms-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Arms-Heavy", 975, 260, 4, "A Adamantite Arms-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 10
            new Armor("Bronze Legs-Light", 1015, 25, 3, "A Bronze Legs-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Legs-Light", 1025, 35, 3, "A Iron Legs-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Legs-Light", 1035, 55, 3, "A Steel Legs-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Legs-Light", 1045, 85, 3, "A Orichalcum Legs-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Legs-Light", 1055, 125, 3, "A Quicksilver Legs-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Legs-Light", 1065, 165, 3, "A Darksteel Legs-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Legs-Light", 1075, 215, 4, "A Adamantite Legs-Light with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 11
            new Armor("Bronze Legs-Medium", 1115, 27, 3, "A Bronze Legs-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Legs-Medium", 1125, 38, 3, "A Iron Legs-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Legs-Medium", 1135, 58, 3, "A Steel Legs-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Legs-Medium", 1145, 95, 3, "A Orichalcum Legs-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Legs-Medium", 1155, 135, 3, "A Quicksilver Legs-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Legs-Medium", 1165, 175, 3, "A Darksteel Legs-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Legs-Medium", 1175, 230, 4, "A Adamantite Legs-Medium with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
// armor 12
            new Armor("Bronze Legs-Heavy", 1215, 29, 3, "A Bronze Legs-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 6 },
                { "Health Regen", 1 }
            }),
            new Armor("Iron Legs-Heavy", 1225, 40, 3, "A Iron Legs-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 8 },
                { "Health Regen", 2 }
            }),
            new Armor("Steel Legs-Heavy", 1235, 60, 3, "A Steel Legs-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 10 },
                { "Health Regen", 3 }
            }),
            new Armor("Orichalcum Legs-Heavy", 1245, 110, 3, "A Orichalcum Legs-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 12 },
                { "Health Regen", 4 }
            }),
            new Armor("Quicksilver Legs-Heavy", 1255, 150, 3, "A Quicksilver Legs-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 14 },
                { "Health Regen", 5 }
            }),
            new Armor("Darksteel Legs-Heavy", 1265, 195, 3, "A Darksteel Legs-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 16 },
                { "Health Regen", 6 }
            }),
            new Armor("Adamantite Legs-Heavy", 1275, 260, 4, "A Adamantite Legs-Heavy with a Health Regen enchantment",
            new Dictionary<string, int>
            {
                { "weaponDefense", 18 },
                { "Health Regen", 7 }
            }),
        };
    }


}
