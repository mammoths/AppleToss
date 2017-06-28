using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovedFromSpawnPoint : MonoBehaviour {

    public GameObject spawnPoint;
    SceneController sceneController;
    Transform spawnPointTransform;
	// Use this for initialization
	void Start () {
        spawnPoint = GameObject.Find("SpawnPoint");
        sceneController = spawnPoint.gameObject.GetComponent<SceneController>();
        spawnPointTransform = spawnPoint.transform;
    }
	
	// Update is called once per frame
	void Update () {

        if (gameObject.transform.position != spawnPointTransform.position)
        {
            Invoke("SpawnDelay", 5);
        }
	}

    void SpawnDelay()
    {
        sceneController.needNewSpawn = true;
       
    }
}


