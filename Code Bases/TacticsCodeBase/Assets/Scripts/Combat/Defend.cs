using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour
{
    void OnEnable()
    {
      Debug.Log("Now Defending");
        Animator animator = GetComponent<Animator>();
        animator.SetInteger("Attacking", 0);
        if (!Turns.turnTimer)
        {
            Turns.endTurn = false;
        }
    }
}
