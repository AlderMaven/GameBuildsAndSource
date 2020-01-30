using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    private float timer2 = 0;

    void OnEnable()
    {
        Debug.Log("Now in Attacking");
    }

    void Update()
    {
        if (timer2 > 10)
        {
            GetComponent<Strike>().enabled = false;
            GetComponent<Standby>().enabled = true;
            timer2 = 0;
            this.enabled = false;
        }
        else
        {
            timer2 += 0.75f;
        }
    }
}
