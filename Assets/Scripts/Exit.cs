using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("SHUTDOWN");
        Application.Quit();
    }
}
