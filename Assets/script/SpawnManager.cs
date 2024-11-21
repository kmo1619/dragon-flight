using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy; //prefab을 받을 public변수입니다.

    //적을 생성하는 함수
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);//적이 나타날 x좌표를 랜덤으로 생성하기

        if (enableSpawn)
        {
            //적을 생성한다. randomX랜덤한 x값
            GameObject go = Instantiate(enemy, new Vector3(randomX, transform.position.y,0f), Quaternion.identity);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //SpawnEnemy를 3초후 1초마다 반복
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
