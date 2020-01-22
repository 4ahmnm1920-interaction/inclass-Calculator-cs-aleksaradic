using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcersiseReturnValue : MonoBehaviour
{
    void Start()
    {
        Debug.Log("My name is: " + ReturnString());
        Debug.Log("How young am I? I am: " + ReturnInt());
        Debug.Log("I am also very high! My height is: " + ReturnFloat());
    }


    public string ReturnString()
    {
        string NameVal ="Aleks";
        return NameVal;
    }

    public int ReturnInt()
    {
        int YearsVal = 18;
        return YearsVal;
    }

    public float ReturnFloat()
    {
        float HeightVal = 1.77f;
        return HeightVal;
    }

}
