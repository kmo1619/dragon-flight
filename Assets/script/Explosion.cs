using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.3f);//0.3�� �ڿ� �ڱ��ڽ� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
