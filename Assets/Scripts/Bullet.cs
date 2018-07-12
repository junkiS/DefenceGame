using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int speed = 10;

    public double bulletpower = 0.5;

    public int point = 10;

    Score mScore;

    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

        mScore = GameObject.Find("Score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D c)//接触したら呼ぶ
    {
        Debug.Log("enemy.point");
        if (c.gameObject.tag == "Player")
        {
            mScore.AddPoint(point);

        }
    }
}
