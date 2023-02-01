using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpit : MonoBehaviour
{
    [SerializeField] private float velocity;

    [SerializeField] private float damage;

    private void Update()
    {
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        Destroy(gameObject, 0.7f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }


}
