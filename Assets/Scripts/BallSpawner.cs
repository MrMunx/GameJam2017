using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    public Box box;
    private GameObject collidingObject;
    // 2
    private GameObject objectInHand;
    private  GameObject ball;
    private float newPosition;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        ball = GameObject.Find("itchbal");
        collidingObject = GameObject.Find("box1");
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = trackedObj.transform.position.y + 1;

        if (Controller.GetHairTriggerDown())
        {
            if (box.boxPrepareSpawn)
            {
                Instantiate(ball, new Vector3(trackedObj.transform.position.x, newPosition, trackedObj.transform.position.z), ball.transform.rotation);
            }
        }
    }

}
