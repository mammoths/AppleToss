using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chute : MonoBehaviour {
    public GameObject prefab;
    public Transform spawnpoint;
    public bool needNewSpawn;
	// Use this for initialization
	void Start () {
        needNewSpawn = true; 
	}
	
	// Update is called once per frame
	void Update () {

        if (needNewSpawn)
        { Spawn(); }
        
      
        
    
    }


    void Spawn()
    {
        GameObject spawn = (GameObject)GameObject.Instantiate(prefab, spawnpoint.transform.position, Quaternion.identity);
        needNewSpawn = false; 
        
        if (spawn.transform.position != spawnpoint.transform.position)
        {
            needNewSpawn = true; 
        }
    }
}



