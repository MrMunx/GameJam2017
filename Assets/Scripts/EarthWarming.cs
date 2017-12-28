using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthWarming : MonoBehaviour {
    //attach to earth ui on headset
    public float warmcurrent;
    public float warmrate;
    public float warmlimit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void earthDeathCheck()
    {
        //if warmcurrent > warmlimit
        //play death animation then change scene
    }
}
