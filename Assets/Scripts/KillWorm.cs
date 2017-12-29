using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillWorm : Worm
{
    public GameObject[] balls;
    private bool dead;
    private AudioClip bounce;
    private AudioSource audio;

    void Awake()
    {
        dead = false;
        audio = GetComponent<AudioSource>();
        if(balls == null)
            balls = GameObject.FindGameObjectsWithTag("Ball");
    }

    void Update ()
    {
        balls = GameObject.FindGameObjectsWithTag("Ball");
    }

    public void OnTriggerEnter(Collider other)
    {
        foreach (GameObject ball in balls)
        {
            if (other == ball.GetComponent<SphereCollider>())
            {
                dead = true;
            }
        }

        if(dead)
        {
            audio.Play();
            Destroy(thisworm);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        foreach (GameObject ball in balls)
        {
            if (other == ball.GetComponent<SphereCollider>())
            {
                dead = true;
            }
        }

        if (dead)
        {
            audio.Play();
            Destroy(thisworm);
        }
    }

}
