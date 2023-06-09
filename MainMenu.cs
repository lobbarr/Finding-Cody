using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject videoPlayer;
    public GameObject rawImage;

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(38);
        SceneManager.LoadScene(1);
    }

    void Start ()
    {
        videoPlayer.SetActive(false);
        rawImage.SetActive(false);
    }
    public void PlayGameAgain ()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayGame ()
    {
        videoPlayer.SetActive(true);
        rawImage.SetActive(true);
        StartCoroutine(waiter());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
