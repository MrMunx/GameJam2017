using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour {
    //worm attributes
    //speed
    //health?
    private GameObject worm;
    public float speed;
    public bool alive;

	// Use this for initialization
	void Awake () {
        alive = true;
        worm = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(!alive)
        {
            Destroy(worm);
        }
	}

    public void OnTriggerEnter(Collider other)
    {
        alive = false;
    }

    void Move()
    {
        //force based movement
    }
    
    void PathFind()
    {
        //pathfind
    }
}
