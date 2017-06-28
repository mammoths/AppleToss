using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawn : MonoBehaviour {
    Input_Listeners IPL;
    public GameObject spawnPoint;
    SceneController sceneController;
    // Use this for initialization
    void Start () {
        IPL = GameObject.Find("GM").GetComponent<Input_Listeners>();
        spawnPoint = GameObject.Find("SpawnPoint");
        sceneController = spawnPoint.gameObject.GetComponent<SceneController>();
    }
	
	// Update is called once per frame
	void Update () {

        if (IPL.rightTriggerInteracting)
        {
            Invoke("SpawnDelay", 1);
        }
    }

    void SpawnDelay()
    {
        sceneController.needNewSpawn = true;

    }
}
