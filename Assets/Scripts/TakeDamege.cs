using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamege : MonoBehaviour
{

    public const int maxHP = 100; //初期体力100％
    public int currentHP = maxHP;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Takedamege(int damege)
    {
        currentHP -= damege;
        if (currentHP <= 0)
        {
            currentHP = 0;
            Debug.Log("LifeEnd.");
        }
    }
}

