using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider healthSlider;
    public Text die;
    static int life;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        life = 10;
        healthSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        health = life;
        healthSlider.value = health;
    }

    public static void beenShooted()
    {
        life--;
    }
}
