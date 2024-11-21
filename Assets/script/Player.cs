using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //�����̴� �ӵ��� ����
    public float moveSpeed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movecontroll();
    }

    void movecontroll()
    {
        //GetAxis는 점진적으로 속도가 증가 감소
        //float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //GetAxisRaw는 입력값에 따라 속도가 0과 1로 구분됨
        float distanceX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(distanceX, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
