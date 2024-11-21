using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //싱글톤
    //어디에서나 접근할 수 있도록 static(정적)으로 자기자신을 저장해서 사용.

    public static GameManager Instance;
    public Text scoreText;

    int score = 0;
    void Start()
    {
        if(Instance == null)//자기자신이 null인지 체크
        {
            Instance = this; //자기자신을 저장
        }
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score; //텍스트에 반영합니다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
