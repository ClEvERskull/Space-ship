using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingScript : MonoBehaviour {

    private Transform playerTransform;

    public GameObject bullet;
    public Transform shootPosition;

    public int minDist;
    public int maxDist;

	// Use this for initialization
	void Start () {

        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();

        if (Vector2.Distance(transform.position, playerTransform.position) >= minDist && Vector2.Distance(transform.position, playerTransform.position) <= maxDist)
            InvokeRepeating("Shooting", 1f, 1f);

	}
	
	// Update is called once per frame
	void Shooting () {

        Instantiate(bullet, shootPosition.transform.position,transform.rotation);

	}
}
