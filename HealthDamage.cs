using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDamage : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthBar.Health -= 20f;
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);
        }
    }
}
