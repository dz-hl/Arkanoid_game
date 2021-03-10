using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    public float speed = 5.0f;
    private GameObject _pad;
    Rigidbody _rigidbody;
    Vector3 _velocity;
    

    void Start()
    {
        Cursor.visible = false;
        _pad = GetComponent<GameObject>();
        _rigidbody = GetComponent<Rigidbody>();
        _velocity = Vector3.up * speed;
        
    }

    void FixedUpdate()
    {
        _rigidbody.MovePosition(new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 50)).x, -17, 0));
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //shoot
        GameObject bulletTransform = Instantiate(bullet, _pad.transform.up, Quaternion.identity);
        
        
    }
}
