using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public GameObject obj;
    public float delay;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") StartCoroutine("ActivateObj");
    }
    
    IEnumerator ActivateObj()
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(true);
    }
}
