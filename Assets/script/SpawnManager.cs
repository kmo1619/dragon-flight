using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy; //prefab�� ���� public�����Դϴ�.

    //���� �����ϴ� �Լ�
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);//���� ��Ÿ�� x��ǥ�� �������� �����ϱ�

        if (enableSpawn)
        {
            //���� �����Ѵ�. randomX������ x��
            GameObject go = Instantiate(enemy, new Vector3(randomX, transform.position.y,0f), Quaternion.identity);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //SpawnEnemy�� 3���� 1�ʸ��� �ݺ�
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
