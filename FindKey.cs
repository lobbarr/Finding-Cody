using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FindKey : MonoBehaviour
{
    public Image ButtonDoorLock;
    public Image ButtonDoorLock2;
    public float RayLength;

    public static float Key;
    [SerializeField] private Animator anim;
    
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        ButtonDoorLock.color = new Color32(255, 255, 255, 0);
    }
    IEnumerator waiter2()
    {
        yield return new WaitForSeconds(5);
        ButtonDoorLock2.color = new Color32(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Start ()
    {
        //Key = 0;
    }
    void Update()
    {
        RaycastHit hit;
        Ray custRay = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag == "Door" && Key != 1)
        {
            ButtonDoorLock.color = new Color32(255, 255, 255, 180);
            StartCoroutine(waiter());
        }
        else if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag == "Door" && Key == 1)
        {
            anim.SetBool("openDoor", true);
        }
        else if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag == "Door2" && Key == 1)
        {
            ButtonDoorLock2.color = new Color32(255, 255, 255, 180);
            StartCoroutine(waiter());
        }
        else if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag == "Door2" && Key == 2)
        {
            SceneManager.LoadScene(1);
        }

        /*else if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag == "Door" && Key == 2)
        {
            anim.SetBool("openDoor2", true);
        }*/
    }
}
