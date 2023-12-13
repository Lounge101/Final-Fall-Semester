using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"));
        {
            Debug.Log("Player collected a coin");
            Destroy(this.gameObject);
        }

    }

    
}
