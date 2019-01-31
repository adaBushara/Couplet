using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRight : MonoBehaviour, IMovable {

	// Use this for initialization
	void Start () {
		
	}
	
    public void Move()
    {
        //Rotate the character
        Vector3 rotation = Vector3.forward  * Manager.MoveSpeed;
        transform.Rotate(rotation);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
