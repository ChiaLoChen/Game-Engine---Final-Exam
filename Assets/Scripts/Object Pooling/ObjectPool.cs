using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    public GameObject targetPrefab;
    public int maxPoolSize = 50;      
    public int stackDefaultCapacity = 10;  
    private IObjectPool<Target> _pool;
    /*
    public IObjectPool<Target> Pool
    {
        get
        {
            if (_pool == null)
                _pool = new ObjectPool<Target>(
                    CreatedPooledItem,        
                    Take,          
                    Returned,         
                    Destroy,      
                    true,                    
                    Capacity,     
                    maxPoolSize            
                );
            return _pool;
        }
    }

    private Target CreatedPooledItem()
    {
        GameObject targetObject = Instantiate(targetPrefab);
        Target target = targetObject.GetComponent<Target>();
        target.Pool = Pool;
        target.gameObject.SetActive(false);
        return target;
    }

    private void Take(Target target)
    {
        target.gameObject.SetActive(true);
        target.ResetPooledItem();            
    }

    private void Returned(Target target)
    {
        target.gameObject.SetActive(false);
    }

    private void Destroy(Target target)
    {
        Destroy(target.gameObject); 
    }
*/
    public void Spawn()
    {
        /*int amount = Random.Range(1, 5);
        for (int i = 0; i < amount; ++i)
        {
            poolobject name = Pool.Get();
            name.transform.position = transform.position;
            //name.LaunchBullet();
        }*/
    }

}
