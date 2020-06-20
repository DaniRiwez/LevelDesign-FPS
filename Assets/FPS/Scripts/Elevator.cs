using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float heightLimit = 90;
    public float speed = 5;
    bool isPlayerIn = false;

    void Update()
    {
        if(isPlayerIn && transform.position.y < heightLimit) transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerIn = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerIn = false;
        }
    }
}
