using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcersiseReturnValue : MonoBehaviour
{
    public float Min;
    public float Max;

    void Start()
    {
        Debug.Log("My name is: " + ReturnString());
        Debug.Log("How young am I? I am: " + ReturnInt());
        Debug.Log("I am also very high! My height is: " + ReturnFloat());
    }

    void Update()
    {
        Debug.Log(Random.Range(Min, Max));
    }

    public string ReturnString()
    {
        string Name ="Aleks";
        return Name;
    }

    public int ReturnInt()
    {
        int Years = 18;
        return Years;
    }

    public float ReturnFloat()
    {
        float Height = 1.77f;
        return Height;
    }

}
