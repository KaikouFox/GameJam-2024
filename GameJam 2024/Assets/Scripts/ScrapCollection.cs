using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapCollection : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision!");
    }
}
