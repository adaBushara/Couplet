using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour, IMovable {

	// Use this for initialization
	void Start () {
		
	}

    float totalTime = 0.0f;
    public void Move()
    {
        totalTime += Time.deltaTime;
        Vector3 dir = Vector3.right * Time.deltaTime;
        if (totalTime < 1.0f)
        {
            //move right
            transform.Translate(dir,Space.World);
        }
        else if (totalTime >= 1.0f && totalTime <= 2.0f)
        {
            //move left
            transform.Translate(-dir,Space.World);
        }
        else
        {
            totalTime = 0.0f;
        }
               
    }
	// Update is called once per frame
	void Update () {
		
	}
}
