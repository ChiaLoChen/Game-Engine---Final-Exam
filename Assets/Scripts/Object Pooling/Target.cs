using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Target : MonoBehaviour
{
    public IObjectPool<Target> Pool { get; set; }
    Rigidbody rb;
    public int moveSpeed;

    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * moveSpeed * Time.deltaTime;
    }

    public void ResetTarget()
    {
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
        }
    }

    private void ReturnToPool()
    {
        Pool.Release(this);
    }

    private void OnDisable()
    {
        ResetTarget();
        CancelInvoke("ReturnToPool");
    }

    private void OnEnable()
    {
        moveSpeed = 10;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Border"))
        {
            Debug.Log("Hit");
            if (Random.value < 0.3f)
            {
                player.Hit();
            }
            ReturnToPool();
        }

    }
}
