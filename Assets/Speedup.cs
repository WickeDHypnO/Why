using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedup : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.GetComponent<Movement>())
        {
            col.GetComponent<Movement>().speed = .3f;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.GetComponent<Movement>())
        {
            col.GetComponent<Movement>().speed = 0.03f;
        }
    }
}
