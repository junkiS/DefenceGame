using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    Ships ships;

    GameTime gametime;


    IEnumerator Start()
    {
        gametime = GameObject.Find("GameTime").GetComponent<GameTime>();//gameTimeコンポーネント

        // Spaceshipコンポーネントを取得
        ships = GetComponent<Ships>();

        // ローカル座標のY軸のマイナス方向に移動する
        ships.Move(transform.up * -1);

        // canShotがfalseの場合、ここでコルーチンを終了させる
        if (ships.canShot == false)
        {
            yield break;
        }

        while (true)//無限ループ
        {
            if (gametime.isEnd == true)
            {

                yield break;//ループから抜け出して生成を止める
            }

                // 子要素を全て取得する
                for (int i = 0; i < transform.childCount; i++)
            {

                Transform shotPosition = transform.GetChild(i);

                // ShotPositionの位置/角度で弾を撃つ
                ships.Shot(shotPosition);
                Debug.Log("wh");
            }


            // shotDelay秒待つ
            yield return new WaitForSeconds(ships.shotDelay);
        }
    }

}
   
