using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{

    public Slider healthSlider;
    static int life = 10;
    void Start()
    {
        healthSlider.value = life;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = life;
        if (healthSlider.value <= 0)
        {
            Destroy(gameObject);
        }
    }
    public static void attack()
    {
        life -= 1;
    }
}
