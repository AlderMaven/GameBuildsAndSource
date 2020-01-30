using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioSource MusicSource;

    void OnEnable()
    {
        Animator animator = GetComponent<Animator>();
        MusicSource.clip = MusicClip;
        MusicSource.Play();
        animator.SetInteger("Dead", 1);
        Debug.Log("DEATH");
    }
}