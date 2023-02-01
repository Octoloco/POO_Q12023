using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyMarioS : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
            Destroy(collision.gameObject);
    }
}
