using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Near : MonoBehaviour {
    public Transform other;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject waypoint = GameObject.Find("Tank_Waypoint(Clone)");
        float dist = Vector3.Distance(waypoint.transform.position, transform.position);
        print("Distance to other: " + dist);
    }
    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Ship1")
        {
            GameObject gos;
            gos = GameObject.FindGameObjectsWithTag("TargetPad")[0];
            gos.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (collider.gameObject.tag == "Ship2")
        {
            GameObject gos;
            gos = GameObject.FindGameObjectsWithTag("TargetPad")[0];
            gos.GetComponent<Renderer>().material.color = Color.yellow;
        }
        Debug.Log(collider.gameObject.tag);
    }
    void OnTriggerStay(Collider collider)
    {

    }
    void OnTriggerExit(Collider collider)
    {
        GameObject gos;
        gos = GameObject.FindGameObjectsWithTag("TargetPad")[0];
        gos.GetComponent<Renderer>().material.color = Color.red;
    }
}
