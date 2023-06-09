using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyAdd : MonoBehaviour
{
    public Image ButtonKey;

    IEnumerator waiter()
    {
        ButtonKey.color = new Color32(255, 255, 255, 180);
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(5);
        ButtonKey.color = new Color32(255, 255, 255, 0);
        Destroy(transform.parent.gameObject);
        Destroy(gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindKey.Key = 1;
            
            StartCoroutine(waiter());
            
        }
    }
}
