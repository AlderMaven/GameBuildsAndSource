using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private float timer1 = 0;

    void OnEnable()
    {
        Debug.Log("Now in Moving");
    }

    void Update()
    {
        if (timer1 > 300)
        {
            if(GetComponent<PlayerMove>() != null)
            {
                GetComponent<PlayerMove>().enabled = false;
            }
            else
            {
                GetComponent<NPCMove>().enabled = false;
            }
            GetComponent<Attack>().enabled = true;
            timer1 = 0;
            this.enabled = false;
        }
        else
        {
            timer1 += 0.75f;
        }
    }
}
