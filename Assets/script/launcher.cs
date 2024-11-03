using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject bullet; //미사일 프리팹 가져올 변수

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating(함수이름, 초기지연시간, 지연할시간)
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        //미사일 프리팹, 런처 포지션, 방향값 안줌
        Instantiate(bullet,transform.position,quaternion.identity);
        //사운드 사용해보기 사운드매니저에서 총사운드 바로 실행함수 호출 싱글톤 사용
        SoundManager.instance.PlaySound();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
