using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{

    public GameObject[] waves;

    private int currentWave;


    IEnumerator Start()
    {
        if (waves.Length == 0)//waveが存在しなければコルーチンが終了する
        {
            yield break;
        }

      
        while (true)
        {

    

            //Waveを作成
            GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity);

            wave.transform.parent = transform;//WaveをEmitterの子要素にする

            while (wave.transform.childCount != 0)//Waveの子要素のEnemyがすべて削除されるまで待機する
            {
                yield return new WaitForEndOfFrame();
            }

            Destroy(wave);

            //格納されているWaveを全て実行したらcurrentWaveを０にする（最初から -> ループ）
            if (waves.Length <= ++currentWave)
            {
                currentWave = 0;

            }
        }
    }
}
		
	

