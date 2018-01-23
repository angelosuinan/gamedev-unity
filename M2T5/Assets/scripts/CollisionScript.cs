using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "TargetPad")
        {
            Debug.Log("tarrget reach");
            collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }

        else if (collision.gameObject.tag == "LaunchPad")
        {
            Debug.Log("Safe");
        }
        else if (collision.gameObject.tag == "TargetPadNear")
        {
            Debug.Log("Safe");
        }
        else
        {
            Debug.Log("Colllistions");
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
