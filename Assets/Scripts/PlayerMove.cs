using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
    
{
public float speed = 90, movementSpeed = 2.2f;
    public Slider boostSlider;
    public Transform ray;
    public Transform shoot;
    bool speeding = false;
    // Start is called before the first frame update
    void Start()
    {
        boostSlider.maxValue = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
         {
            transform.position += transform.up * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.up * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, Time.deltaTime * -speed);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, Time.deltaTime * speed);
        }
        if ((Input.GetKeyDown("space")) && (boostSlider.value > 0))
        {
                movementSpeed = 8;
                speeding = true;
        }
        if ((Input.GetKeyUp("space")) || (boostSlider.value <= 0))
        {
            movementSpeed = 2.2f;
            speeding = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ray, shoot.transform.position, transform.rotation);
        }

        if (speeding)
        {
            if(boostSlider.value > 0)
                boostSlider.value -= Time.deltaTime;
            if (Camera.main.fieldOfView <= 65)
            {
                Camera.main.fieldOfView += Time.deltaTime * 10;
            }
        }
        else if (!speeding)
        {
            boostSlider.value += Time.deltaTime * 0.2f;
            if (Camera.main.fieldOfView >= 48)
            {
                Camera.main.fieldOfView -= Time.deltaTime * 15;
            }
        }
    }
}
