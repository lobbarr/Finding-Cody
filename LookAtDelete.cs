using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtDelete : MonoBehaviour
{
    public Image ButtonTrigger;
    public float RayLength;
    public string Tag;

    void Update()
    {
        RaycastHit hit;
        Ray custRay = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag == Tag)
        {
            GameObject rayHitObj = hit.transform.gameObject;
            
            ButtonTrigger.color = new Color32(255, 255, 255, 180);

            if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag == Tag && Input.GetKeyDown(KeyCode.E))
            {                
                ButtonTrigger.color = new Color32(255, 255, 255, 0);
                Destroy(rayHitObj);
            }
        }
        else if (Physics.Raycast(custRay, out hit, RayLength) && hit.collider.gameObject.tag != Tag)
        {
            ButtonTrigger.color = new Color32(255, 255, 255, 0);
        }
    }
}
