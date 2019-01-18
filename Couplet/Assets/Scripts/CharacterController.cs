using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float moveSpeed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	
    //use this to handle our input
    void HandleInput()
    {
        //let's get some keyboard input
        //and rotate depending on the key that we are pressing

        //left button, rotate left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 1 * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -1 * moveSpeed);
        }


    }


    void Update () {
        HandleInput();
        
	}

    //our collision code

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
    }
}
