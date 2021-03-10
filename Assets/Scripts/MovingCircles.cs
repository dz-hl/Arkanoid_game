using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCircles : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 dir = Vector3.left;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        if (transform.position.x <= -4)
        {
            dir = Vector3.right;
        } else if (transform.position.x >= 4)
        {
            dir = Vector3.left;
        }
        
    }
}
