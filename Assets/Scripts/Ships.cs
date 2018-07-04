using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour {

    public float speed;

    public float shotDelay;

    public GameObject bullet; //

    public bool canShot; //弾を出さないか選択

    public GameObject explosion;//爆発のprefab

    public void Explosion()//爆発作成
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    public void Shot (Transform origin)//弾の作成
    {
        Debug.Log(bullet,this);
        Instantiate(bullet,origin.position,origin.rotation);
    }

    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
