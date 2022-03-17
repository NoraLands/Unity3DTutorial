using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlCoin : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) {
        Debug.Log("Be eaten by " + other.name);
        if (other.name == "Ball"){           
            Destroy(gameObject);
        }
    }
}
