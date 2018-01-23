using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPadScript : MonoBehaviour {

    GameObject Ship1;
    GameObject Ship2;
    GameObject TargetPad;
    GameObject LastTargetPad;
    public Color s1 = Color.blue;
    public Color s2 = Color.yellow;
    public Color targetcolor = Color.green;
    public Renderer rend;
    public Material material;
    float distance1;
    float distance2;
    bool reach;
    public int level = 1;
    void Start()
    {
        distance1 = 0f;
        distance2 = 0f;
        Ship1 = GameObject.FindGameObjectsWithTag("Ship1")[0];

        TargetPad = GameObject.FindGameObjectsWithTag("TargetPad")[0];
        //LastTargetPad = GameObject.FindGameObjectsWithTag("LastTargetPad")[0];
        reach = false;
    }
    // Update is called once per frame
    void Update () {
        distance1 = Vector3.Distance(Ship1.transform.position, TargetPad.transform.position);
       // distance2 = Vector3.Distance(Ship2.transform.position, TargetPad.transform.position);
        if (reach == false)
        {
            if (distance1 < 10)
            {
                
                TargetPad.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else
            {
                TargetPad.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
            reach = true;
            TargetPad.GetComponent<Renderer>().material.color = Color.green;
        
    }
}
