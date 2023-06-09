using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinaleMenu : MonoBehaviour
{
    public GameObject videoPlayer;
    public GameObject rawImage;

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(66);
        
        videoPlayer.SetActive(false);
        rawImage.SetActive(false);
    }

    void Start ()
    {
        StartCoroutine(waiter());
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
