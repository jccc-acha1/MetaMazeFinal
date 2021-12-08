using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{   
    public GameObject handKey;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            FirstPersonController.keyNum++;
            Debug.Log($"Picked up key : {FirstPersonController.keyNum}");
            handKey.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
