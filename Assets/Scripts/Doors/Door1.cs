using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public GameObject handKey;
    public GameObject[] level1Group;
    public Material material;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && FirstPersonController.keyNum == 1)
        {
            handKey.SetActive(false);

            // Side Effect
            foreach (var obj in level1Group)
            {
                obj.GetComponent<Renderer>().sharedMaterial = material;
            }

            Destroy(gameObject);
        }
    }
}
