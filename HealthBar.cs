using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider HealthSlider;
    float maxHealth = 100;

    public static float Health;
    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Health);
        
        HealthSlider.value = Health;
        
        // Codigo para a regeneração e perda com fome

        if (Health <= 100)
        {
            if (HungerBar.Hunger >= 50)
            {
                Health += 1f * Time.deltaTime;
            }
            if (HungerBar.Hunger <= 1)
            {
                Health -= 1f * Time.deltaTime;
            }
        }
        // Codigo para a morte
        if ( Health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
