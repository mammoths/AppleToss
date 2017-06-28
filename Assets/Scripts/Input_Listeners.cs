using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Listeners : MonoBehaviour {

    public bool leftTriggerInteracting = false;
    public bool rightTriggerInteracting = false;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Set_Left_Interacting(bool value) { leftTriggerInteracting = value; }
    public void Set_Right_Interacting(bool value) { rightTriggerInteracting = value; }

    public bool Get_Left_Interacting() { return leftTriggerInteracting; }
    public bool Get_Right_Interacting() { return rightTriggerInteracting; }
}
