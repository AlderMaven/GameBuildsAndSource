package com.company;
public class Main {









    public static void main(String[] args) {
        String[] element = new String[] {"Bronze", "Iron", "Steel", "Orichalcum",
                "Quicksilver", "Darksteel", "Adamantite"};
        int armDef= 6;
        int elementID= 1;
        int[][] value = new int[][] {
                {25,35,55,85 ,125,165,215},
                {27,38,58,95 ,135,175,230},
                {29,40,60,110,150,195,260},
                {25,35,55,85 ,125,165,215},
                {27,38,58,95 ,135,175,230},
                {29,40,60,110,150,195,260},
                {25,35,55,85 ,125,165,215},
                {27,38,58,95 ,135,175,230},
                {29,40,60,110,150,195,260},
                {25,35,55,85 ,125,165,215},
                {27,38,58,95 ,135,175,230},
                {29,40,60,110,150,195,260}
        };
        int[][] rare = new int[][]{
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
                {3 ,3 ,3 ,3  ,3  ,3  ,4  },
        };
        String [] enchaType = {"Fire","Ice","Lightning","Armor Piercing","Monster Slaying","Holy Smite"};
        String [] enctype = {"fire","ice","lightning","armor piercing","monster slaying","holy smite"};
        String weap = "Longsword";
        String [] armor = {"Helmet-Light","Helmet-Medium","Helmet-Heavy","Chest-Light","Chest-Medium","Chest-Heavy",
                "Arms-Light","Arms-Medium","Arms-Heavy","Legs-Light","Legs-Medium","Legs-Heavy"};
        int armorID = 1;
        int enchanId = 5;
        String enchantment = "Health Regen";
        for (int j = 0; j< 12; j++ ){
            System.out.println("// armor "+ armorID);
            for (int i = 0; i < 7; i++)

            {
                System.out.println("            new Armor(\"" + element[i] + " " + armor[j]  + "\", "+ armorID + elementID
                        + enchanId + ", " + value[j][i] + ", " + rare[j][i] + ", \"A " + element[i] +
                        " " + armor[j] + " with a " + enchantment + " enchantment\",\n" +
                        "            new Dictionary<string, int>\n" +
                        "            {\n" +
                        "                { \"weaponDefense\", " + armDef + " },\n" +
                        "                { \""+enchantment+"\", " + elementID + " }\n" +
                        "            }),");
                armDef += 2;
                elementID++;

            }

            armDef= 6;
            elementID= 1;
            armorID++;
        }
	// write your code here
    }
}
