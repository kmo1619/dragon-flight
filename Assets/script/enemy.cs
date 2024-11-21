using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //������ �ӵ��� ������ �ݴϴ�.
    public float moveSpeed = 1.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //������ �Ÿ��� ������ݴϴ�.
        float distanceY = moveSpeed * Time.deltaTime;
        //�������� �ݿ��մϴ�.
        transform.Translate(0, -distanceY, 0);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnBecameinvisible()//화면밖으로 나가면
    {
        Destroy(this);
    }
}
