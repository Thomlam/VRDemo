using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrabActions : MonoBehaviour
{
    public GameObject prefabOsef;

    public void SpawnNewPrefabOsef()
    {
        Instantiate(prefabOsef, new Vector3(transform.position.x, transform.position.y+1, transform.position.z), Quaternion.identity);
    }
}
