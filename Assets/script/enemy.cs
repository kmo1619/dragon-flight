using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //움직일 속도를 지정해 줍니다.
    public float moveSpeed = 1.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //움직일 거리를 계산해줍니다.
        float distanceY = moveSpeed * Time.deltaTime;
        //움직임을 반영합니다.
        transform.Translate(0, -distanceY, 0);
    }
}
