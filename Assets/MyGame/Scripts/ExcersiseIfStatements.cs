using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcersiseIfStatements : MonoBehaviour
{
    public string text;
    public string text2;
    public bool condition;

    void Start()
    {
        //if Statement bool

        if (condition)
        {
            //Debug.Log("Die Kondition is true");
        }

        else
        {
           //Debug.Log("Die Kondition is false");
        }

    }

    void Update()
    {
        //if Statement float

        var rndfloat = Random.Range(5f, 15f);

        if (rndfloat < 10)
        {
            //Debug.Log("Number is under 10");
        }

        else
        {
            //Debug.Log("Number is over 10");
        }

        //if Statement string

        if (text == text2)
        {
            //Debug.Log("Text entspricht Text2!");
        }

        else
        {
            //Debug.Log("Text entspricht NICHT Text2!");
        }

        //if Statement mit mehreren Funktionen

        if (text == text2 && condition)
        {
            //Debug.Log("Beide Konditionen sind richtig.");
        }

        else
        {
            //Debug.Log("Beide Konditionen sind falsch.");
        }

        //if Statement mit oder

        if (text == text2 || condition)
        {
            //Debug.Log("Eine der beiden Konditionen ist richtig");
        }

        else
        {
            //Debug.Log("Keine der beiden Konditionen ist richtig");  
        }

        //if Statement inside if Statement

        if (text == text2)
        {
            if (condition)
            {
                //Debug.Log("tralala");
            }
        }
    }
}
