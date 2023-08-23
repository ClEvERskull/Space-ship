using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
   
{
    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            transform.position += transform.up * Time.deltaTime * 30;
            timeLeft -= Time.deltaTime;
        }
        else
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyHealth.attack();
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            Player.beenShooted();
            Destroy(gameObject);
        }
    }
}
