using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyAdd2 : MonoBehaviour
{
    public Image ButtonKey2;

    IEnumerator waiter()
    {
        ButtonKey2.color = new Color32(255, 255, 255, 180);
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(5);
        ButtonKey2.color = new Color32(255, 255, 255, 0);
        Destroy(transform.parent.gameObject);
        Destroy(gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindKey.Key = 2;
            
            StartCoroutine(waiter());
            
        }
    }
}

