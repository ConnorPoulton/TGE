using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPool : MonoBehaviour {

    public GameObject prefab;
    public Stack<GameObject> prefabStack = new Stack<GameObject>();

    public GameObject GetPooledObject()
    {
        Debug.Log("get pooled object");
        GameObject prefabToSpawn;
        if (prefabStack.Count == 0)
        {
            prefabToSpawn = GameObject.Instantiate(prefab);
            prefabToSpawn.AddComponent<Pool>().pool = this;
            return prefabToSpawn;
        }
        else
        {
            prefabToSpawn = prefabStack.Pop();
            return prefabToSpawn;
        }
    }

    public void ReturnToPool(GameObject toReturn)
    {
        if (toReturn.GetComponent<Pool>().pool == this)
        {
            toReturn.SetActive(false);
            toReturn.transform.SetParent(null);
            prefabStack.Push(toReturn);
        }
        else
        {
            Destroy(toReturn);
            Debug.Log("Object sent to wrong pool. Deleting...");
        }
    }
}

public class Pool : MonoBehaviour
{
    public ButtonPool pool;
}

