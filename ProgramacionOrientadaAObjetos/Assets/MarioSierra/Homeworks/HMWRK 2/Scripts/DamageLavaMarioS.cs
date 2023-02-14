using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageLavaMarioS : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerRespawnMarioS>().PlayerDamaged();
            
        }
    }
}
