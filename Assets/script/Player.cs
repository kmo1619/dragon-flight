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
        //������ Axis�� ���� Ű�� ������ �Ǵ��ϰ� �ӵ��� ������ ������ ���� �̵����� ���Ѵ�.
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

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
