using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider HungerSlider;
    float maxHunger = 100;

    public static float Hunger;
    // Start is called before the first frame update
    void Start()
    {
        Hunger = maxHunger;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Hunger);
        
        HungerSlider.value = Hunger;

        if (Hunger > 0)
        {
            Hunger -= 1f * Time.deltaTime;

            if (Input.GetKey(KeyCode.W))
            {
                Hunger -= 2f * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Hunger -= 2f * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Hunger -= 4f * Time.deltaTime;
            }
        }

        if (Hunger <= 0)
        {
            HealthBar.Health -= 0.1f;
        }
    }
}
