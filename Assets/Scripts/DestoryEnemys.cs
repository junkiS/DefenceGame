using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEnemys : MonoBehaviour {

    //敵とその弾を消去するスクリプト。

    public GameObject explosion;//爆発のprefab

    public int point = 10;//スコア用

    public void Explosion()//爆発作成
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
    void OnTriggerEnter2D(Collider2D c)//接触したら呼ぶ
    {
        Debug.Log("enemy.point");
        if (c.gameObject.tag == "Player")
        {
            FindObjectOfType<Score>().AddPoint(point);

            Explosion();

            Destroy(gameObject);


        }

        }
    }
