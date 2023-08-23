using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowScript : MonoBehaviour
{

    private Transform playerTransform;

    public float speed;
    public int maxRange;
    public int minRange;

    // Use this for initialization
    void Start()
    {

        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

        var dir = playerTransform.position - transform.position;
        var angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) - 90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Vector2.Distance(transform.position, playerTransform.position) >= minRange)
        {

            transform.position = Vector2.MoveTowards(transform.position, playerTransform.transform.position, speed * Time.deltaTime);

        }

    }
}
