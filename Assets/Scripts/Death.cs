using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    public string name;
    public GameObject[] worms;
    public GameObject spawners;
    public AudioSource scream;
    public bool dead;

    void Awake()
    {
        scream = GetComponent<AudioSource>();
        if (worms == null)
            worms = GameObject.FindGameObjectsWithTag("Worm");
    }

    void Update ()
    {
        worms = GameObject.FindGameObjectsWithTag("Worm");
    }

    void OnTriggerEnter(Collider other)
    {
        //if worm touches the platform
        for (int i = 0; i < worms.Length; i++)
        {
            if (other == worms[i].GetComponent<BoxCollider>())
            {

                dead = true;
                Debug.Log(dead);
            }
        }


        if(dead)
        {
            scream.Play();
            spawners.SetActive(false);
            foreach (GameObject worm in worms)
            {
                Destroy(worm);
            }
            StartCoroutine(Wait());
        }
        
    }


    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(10);
        SceneManager.LoadScene(name);
    }
}
