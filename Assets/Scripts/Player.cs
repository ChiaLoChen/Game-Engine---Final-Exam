using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Subject
{
    Rigidbody rb;
    InputHandler _input;
    private ObjectPool _pool;
    public int moveSpeed;
    private bool hitDecoy = false;
    private bool targetAimed = false;

    void Start()
    {
        _pool = gameObject.GetComponent<ObjectPool>();
        GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        _input = FindObjectOfType<InputHandler>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            if (!hitDecoy)
            {
                hitDecoy = true;
                Debug.Log("Hit a decoy");
            }
            else if (hitDecoy)
            {
                hitDecoy = false;
                Debug.Log("didn't hit a decoy");
            }
        }
    }

    public void MoveUp()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    public void MoveLeft()
    {
        transform.position -= transform.right * moveSpeed * Time.deltaTime;
    }

    public void MoveRight()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime;
    }

    public void MoveDown()
    {
        transform.position -= transform.forward * moveSpeed * Time.deltaTime;
    }

    public void Shoot()
    {
        Debug.Log("Shoot");
        
    }

    public bool HitDecoy()
    {
        return hitDecoy;
    }
    
}
