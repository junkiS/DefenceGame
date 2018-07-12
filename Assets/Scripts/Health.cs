using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Text PlayerLife;

    

    public const int maxHP = 100; //初期体力100％
    public int currentHP = maxHP;

	public void TakeDamege(int amount)
    {
        currentHP -= amount;
        if(currentHP <= 0)
        {
            currentHP = 0;
            Debug.Log("LifeEnd.");
        }
    }
		
	}
