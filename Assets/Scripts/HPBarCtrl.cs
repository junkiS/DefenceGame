using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarCtrl : MonoBehaviour {

    Slider _slider;

	// Use this for initialization
	void Start () {
        //スライダーを取得
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
		
	}

    float _hp = 0;
	// Update is called once per frame
	void Update () {

        _hp += 1;
        if(_hp > _slider.maxValue)
        {
            _hp = _slider.minValue;
        }
        //HPゲージに値を設定
        _slider.value = _hp;
	}
}
