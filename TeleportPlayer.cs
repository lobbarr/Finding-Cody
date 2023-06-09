using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;
    public float altura;
    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            playerg.SetActive(false);
            player.position = destination.position + new Vector3(0f, altura, 0f);
            playerg.SetActive(true);
        }
    }
}
