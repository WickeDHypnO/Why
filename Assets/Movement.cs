using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float right, left;
    Rigidbody2D rigid;
    public float speed;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
	void Update () {
		if(Input.GetAxis("Horizontal") !=0)
        {
            if(Input.GetAxis("Horizontal") > 0)
            {
                right = 1;
                left = 0;
            }
            else
            {
                left = 1;
                right = 0;
            }
        }
        else
        {
            right = 0;
            left = 0;
        }
	}

    void FixedUpdate()
    {
        if(left != 0 || right != 0)
        rigid.MovePosition(transform.position + (right + -left) * transform.right * speed);
    }
}
