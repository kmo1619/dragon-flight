using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //�̱���
    //��𿡼��� ������ �� �ֵ��� static(����)���� �ڱ��ڽ��� �����ؼ� ���.

    public static GameManager Instance;
    public Text scoreText;

    int score = 0;
    void Start()
    {
        if(Instance == null)//�ڱ��ڽ��� null���� üũ
        {
            Instance = this; //�ڱ��ڽ��� ����
        }
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score; //�ؽ�Ʈ�� �ݿ��մϴ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
