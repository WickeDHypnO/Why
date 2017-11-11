using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxMovement : MonoBehaviour
{
    public Transform hotspot1, hotspot2;

    void OnTriggerStay2D(Collider2D col)
    {
        transform.position = new Vector3(((hotspot1.position.x - col.transform.position.x) +hotspot2.position.x), transform.position.y, 0) ;
    }
}