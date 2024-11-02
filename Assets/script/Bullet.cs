using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public GameObject explosion;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪히면
        if (collision.gameObject.tag == "Enemy")
        {
            //폭발 이펙트 생성
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);//적 지우기
            Destroy(this.gameObject);//총알 지우기
        }
    }

    //오브젝트가 화면 밖으로 나가서 안보이게 되면 호출되는 함수
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
