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

        //scale our speed depending on the movement of the blocks
        float scaledSpeed = moveSpeed * Manager.MoveSpeed;

        //left button, rotate left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 1 * scaledSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -1 * scaledSpeed);
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
