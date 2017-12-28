using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    public bool boxPrepareSpawn;

    public void OnTriggerEnter(Collider other)
    {
        boxPrepareSpawn = true;
    }

    // 3
    public void OnTriggerExit(Collider other)
    {
        boxPrepareSpawn = false;
    }
}
