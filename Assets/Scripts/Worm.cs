using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour {
    //worm attributes
    //speed
    //health?
    public GameObject thisworm;
    private GameObject player;
    private Transform goal;

	// Use this for initialization
	void Awake () {
        thisworm = this.gameObject;
        player = GameObject.Find("[CameraRig]");
        goal = player.transform;
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
    }
}
