using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //싱글톤
    public static SoundManager instance; //자기 자신을 변수로 담고

    public AudioClip soundExplosion; //재생할 소리를 변수로 담는다.
    public AudioClip soundDie; //죽을 때 재생할 소리를 변수로 담는다

    AudioSource myAudio; //AudioSource 컴포넌트를 변수로 담는다.

    private void Awake() //Start보다도 먼저, 객체가 생성될때 호출됨
    {
        if (instance == null) //instance가 비어있는지 검사
        {
            instance = this;
        }

        
    }
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>(); //AudioSource 컴포넌트 가져오기
    }
    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
    public void PlaySound()
    {
        myAudio.PlayOneShot(soundExplosion);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
