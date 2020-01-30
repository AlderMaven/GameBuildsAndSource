using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPartyOnMenu : MonoBehaviour
{
    GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectsWithTag("Respawn");
        foreach(GameObject team in obj)
        {
            if(team != null)
            {
                Destroy(team);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
