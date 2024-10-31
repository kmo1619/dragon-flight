using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision){
        //미사일과 적이 부딪히면
        if(collision.gameObject.tag == "Ememy"){
            Destroy(collision.gameObject);//적 지우기
            Destroy(this.gameObject);//총알 지우기
        }
    }
}
