using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyStats : MonoBehaviour
{
	// Start is called before the first frame update
	int hp = 100;
	int mp = 200;
	int exp = 300;

	public int HP { get { return this.hp; } set { this.hp = value; } }
	public int MP { get { return this.mp; } set { this.mp = value; } }
	public int EXP { get { return this.exp; } set { this.exp = value; } }

	public DummyStats(){
		HP = 100;
		MP = 200;
		EXP = 300;
	}


	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
