using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    InputHandler _input;
    public int moveSpeed;
    private bool hitDecoy = false;
    public BoxCollider boxCollider;
    private bool isShoot = false;

    void Start()
    {
        GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        _input = FindObjectOfType<InputHandler>();
    }

    void Update()
    {
       if (isShoot)
        {
            boxCollider.enabled = true;
        }
        else if (!isShoot)
        {
            boxCollider.enabled = false;
        }

        /*if (Input.GetKey(KeyCode.R))
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
        }*/
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
        isShoot = true;
    }

    public void notShoot()
    {
        isShoot = false;
    }
    public bool HitDecoy()
    {
        return hitDecoy;
    }

    public void Hit()
    {
        if (hitDecoy)
        {
            hitDecoy = false;
            Debug.Log("Control normal");
        }
        else
        {
            hitDecoy = true;
            Debug.Log("Control reversed");
        }
    }

}
