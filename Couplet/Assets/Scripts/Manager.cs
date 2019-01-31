using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Alive = 1,
    Dead = 2,
    Respawning = 3
}

public class Manager : MonoBehaviour {

    
    public static float MoveSpeed = 1.0f;
    // Use this for initialization
    List<IMovable> MovableObjects = new List<IMovable>();
    void Start () {
       
        RegisterMoveables();
	}

    void RegisterMoveables()
    {

        //get the entire list of all gameobjects in the scene
        MonoBehaviour[] g = GameObject.FindObjectsOfType<MonoBehaviour>();

        //go through each game object and check to see if it contains the iMoveable interface
        foreach (MonoBehaviour obj in g)
        {
            if (obj is IMovable)
            {
                MovableObjects.Add((IMovable)obj);
                Debug.Log(obj.gameObject.name + " Registered to List");
            }
        }
    }

    void UpdateMovables()
    {
        foreach(IMovable m in MovableObjects)
        {
            m.Move();
        }
    }

	// Update is called once per frame
	void Update () {
        UpdateMovables();
	}
}
