using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePollution : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthBar.Health -= 5f * Time.deltaTime;
        }
    }
}
