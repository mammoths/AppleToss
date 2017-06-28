using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public bool needNewSpawn;
    Chute chute;
   public int maxItems = 2;
   public int currentItems = 0; 
	// Use this for initialization
	void Start () {
        chute = GetComponent<Chute>();
        needNewSpawn = true; 
    }
	
	// Update is called once per frame
	void Update () {
		
        if (needNewSpawn && currentItems < maxItems)
        {
            chute.Spawn();
            currentItems++; 
            needNewSpawn = false; 
        }

       

	}
}
