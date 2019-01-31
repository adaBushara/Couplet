using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour, IMovable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //This class will simply move down
    public void Move()
    {
        Vector3 translation = Vector3.down * Time.deltaTime;
       
        translation *= Manager.MoveSpeed;
        transform.Translate(translation,Space.World);
    }
}
