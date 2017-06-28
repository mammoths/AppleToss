using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public GameObject player;
    public float distance = 10f;
    GameObject spawnPoint;
    SceneController sceneController; 
	// Use this for initialization
	void Start () {
        
        spawnPoint = GameObject.Find("SpawnPoint");
        sceneController =  spawnPoint.gameObject.GetComponent<SceneController>();
    }
	
	// Update is called once per frame
	void Update () {
		
        if (gameObject.transform.position.x > player.transform.position.x + distance || 
            gameObject.transform.position.x < player.transform.position.x - distance ||
            gameObject.transform.position.z > player.transform.position.z + distance || 
            gameObject.transform.position.z < player.transform.position.z - distance)
        {
            DestroyObject();
        }

      
    }


    void DestroyObject()
    {
        Destroy(gameObject);
        sceneController.needNewSpawn = true;
        sceneController.currentItems--;
        return; 
    }
}
