using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    void OnEnable()
    {
        GetComponent<Standby>().enabled = false;
        GetComponent<Defend>().enabled = false;
        if (GetComponent<PlayerMove>() != null)
        {
          GetComponent<PlayerMove>().enabled = true;
        }
        else
        {
          GetComponent<NPCMove>().enabled = true;
        }
        Debug.Log("Now in Idle");
        
        //GetComponent<Animator>().Play("Idle");
    }

}
