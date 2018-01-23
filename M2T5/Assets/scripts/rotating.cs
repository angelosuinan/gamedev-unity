using System.Collections.Generic;
using UnityEngine;

public class FloatScript : MonoBehaviour
{

    public float degreesPerSecond = 15f;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    public enum Axis { Horizontal, Vertical };
    public Axis floatAxis;

    public bool Rotate = true;

    public bool random = false;
    // Use this for initialization
    void Start()
    {
        posOffset = transform.position;
        if (random)
        {
            RandomFloat();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (floatAxis == Axis.Horizontal)
        {
            FloatObjectHorizontal();
        }
        else
        {
            FloatObjectVertical();
        }

        if (Rotate)
        {
            RotateObject();
        }
    }

    void RotateObject()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
    }

    void FloatObjectVertical()
    {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }

    void FloatObjectHorizontal()
    {
        tempPos = posOffset;
        tempPos.x += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }

    void RandomFloat()
    {
        float randAmpli = Random.Range(0, amplitude);
        float randFreq = Random.Range(0, frequency);
        amplitude = randAmpli;
        frequency = randFreq;
    }
}