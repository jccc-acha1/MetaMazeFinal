using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRandomizer : MonoBehaviour
{
    public GameObject[] keyLocations;
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        int keyLoc = Random.Range(0, 3);
        key.transform.position = keyLocations[keyLoc].transform.position;
    }
}
