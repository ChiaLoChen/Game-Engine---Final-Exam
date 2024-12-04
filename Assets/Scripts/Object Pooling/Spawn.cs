using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private ObjectPool objectPool;
    private float timer;
    public float time = 3;
    // Start is called before the first frame update
    void Start()
    {
        objectPool = gameObject.AddComponent<ObjectPool>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time)
        {
            objectPool.Spawn(this.gameObject.transform);
            timer = 0;
        }
    }
}
