using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerRefill : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (HungerBar.Hunger <= 40) 
            {
                HungerBar.Hunger += 60f;
                Destroy(transform.parent.gameObject);
                Destroy(gameObject);
            }
            else if (HungerBar.Hunger > 40) 
            {
                HungerBar.Hunger = 100;
                Destroy(transform.parent.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
