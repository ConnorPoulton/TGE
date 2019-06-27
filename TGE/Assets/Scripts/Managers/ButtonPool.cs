using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPool : MonoBehaviour {

    public GameObject prefab;
    public Stack<GameObject> prefabStack = new Stack<GameObject>();


    public GameObject GetPooledObject()
    {
        GameObject prefabToReturn;
        if (prefabStack.Count > 0)
        {
            prefabToReturn = prefabStack.Pop();
        } else
        {
            prefabToReturn = GameObject.Instantiate(prefab);
            //attach the PooledObject helper class to ID which pool the prefab came from
            PooledObject pooledObject = prefabToReturn.AddComponent<PooledObject> ();
            pooledObject.pool = this;
        }
        prefabToReturn.SetActive (true);
        prefabToReturn.transform.SetParent(null);
        return prefabToReturn;
    }

    public void ReturnToPool(GameObject toReturn)
    {
        PooledObject OriginPool = toReturn.GetComponent<PooledObject>();
        if (OriginPool != null && OriginPool == this)
        {
            toReturn.transform.SetParent(transform);
            toReturn.SetActive(false);
            prefabStack.Push(toReturn);
        } else
        {
            Debug.LogWarning(toReturn.name + "was returned to the wrong pool! Destroying...");
            Destroy(toReturn);
        }
    }
}

//this is a small helper class used to identify which pool an object is associated with
public class PooledObject : MonoBehaviour
{
    public ButtonPool pool;
}
