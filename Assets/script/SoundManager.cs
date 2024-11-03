using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //�̱���
    public static SoundManager instance; //�ڱ� �ڽ��� ������ ���

    public AudioClip soundExplosion; //����� �Ҹ��� ������ ��´�.
    public AudioClip soundDie; //���� �� ����� �Ҹ��� ������ ��´�

    AudioSource myAudio; //AudioSource ������Ʈ�� ������ ��´�.

    private void Awake() //Start���ٵ� ����, ��ü�� �����ɶ� ȣ���
    {
        if (instance == null) //instance�� ����ִ��� �˻�
        {
            instance = this;
        }

        
    }
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>(); //AudioSource ������Ʈ ��������
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
