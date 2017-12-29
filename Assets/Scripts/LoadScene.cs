using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string name;
    public GameObject light;
    public AudioSource scream;

    void Awake()
    {
        scream = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        //play scream
        scream.Play();
        //turn on light
        light.SetActive(true);
        StartCoroutine(Wait());
    }
    
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(15);
        SceneManager.LoadScene(name);
    }
}
