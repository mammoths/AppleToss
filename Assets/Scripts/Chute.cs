using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chute : MonoBehaviour {
    public GameObject[] prefab;
    public Transform spawnpoint;

	// Use this for initialization


   public void Spawn()
    {
        int spawnObjectIndex = Random.Range(0, prefab.Length);
        GameObject randPrefab = prefab[spawnObjectIndex];
        GameObject spawn = (GameObject)GameObject.Instantiate(randPrefab, spawnpoint.transform.position, Quaternion.identity);
   
    }


}



