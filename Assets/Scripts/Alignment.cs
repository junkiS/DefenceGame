using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Alignment : MonoBehaviour {

    Ships ships;

    GameTime gametime;

    IEnumerator Start()
    {
        ships = GetComponent<Ships>();//Shipsコンポーネント取得

        gametime = GameObject.Find("GameTime").GetComponent<GameTime>();//gameTimeコンポーネント

        while (true)
        {
            //ships.Shot(transform);//弾をプレイヤーと同じ位置角度で作成

            yield return new WaitForSeconds(ships.shotDelay);
        }
    }

	
	// Update is called once per frame
	void Update () {
        //isEndがtrueで操作不可
        if (gametime.isEnd == true)
        {
            GetComponent<BoxCollider2D>().enabled = false;//BoxColider2dを無効にする
            //操作の停止
            return;
           
        }

        float x = CrossPlatformInputManager.GetAxisRaw("Horizontal"); //右左仮想コン

        float y = CrossPlatformInputManager.GetAxisRaw("Vertical");// 上下仮想コン

        //Vector2 direction = new Vector2(x,y).normalized; //方向を正規化（標準）された
        Vector2 direction = new Vector2(x, y);

        ships.Move(direction);

        Clamp();//移動制限
    }
    void Clamp()
    {

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

        Vector2 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        transform.position = pos;
    }
}
