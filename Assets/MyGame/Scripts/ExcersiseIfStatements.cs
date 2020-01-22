using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcersiseIfStatements : MonoBehaviour
{
    public bool condition;

    void Start()
    {
        if (condition)
        {
            Debug.Log("Dark mode is true");
        }

        else
        {
            Debug.Log("Dark mode is false");
        }
    }
}
