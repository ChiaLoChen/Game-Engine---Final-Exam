using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    public GameObject targetPrefab;
    public int maxPoolSize = 50;
    public int stackDefaultCapacity = 10;
    private IObjectPool<Target> _pool;

    public IObjectPool<Target> Pool
    {
        get
        {
            if (_pool == null)
                _pool = new ObjectPool<Target>(
                    CreatedPooledItem,
                    OnTakeFromPool,
                    OnReturnedToPool,
                    OnDestroyPoolObject,
                    true,
                    stackDefaultCapacity,
                    maxPoolSize);
            return _pool;
        }
    }

    private Target CreatedPooledItem()
    {
        var go =
            GameObject.CreatePrimitive(PrimitiveType.Cube);
        Target target = go.AddComponent<Target>();
        go.name = "Target";
        target.Pool = Pool;
        return target;
    }

    private void OnReturnedToPool(Target target)
    {
        target.gameObject.SetActive(false);
    }

    private void OnTakeFromPool(Target target)
    {
        target.gameObject.SetActive(true);
    }

    private void OnDestroyPoolObject(Target target)
    {
        Destroy(target.gameObject);
    }

    public void Spawn(Transform parent)
    {
        var target = Pool.Get();
        target.transform.position = parent.position;
    }
}
