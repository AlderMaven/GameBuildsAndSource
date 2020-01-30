using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standby : MonoBehaviour
{
    void OnEnable()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetInteger("Attacking", 0);
        Debug.Log("Now in Standby");
        if(!Turns.turnTimer)
        {
            Turns.endTurn = false;
        }
    }
}
