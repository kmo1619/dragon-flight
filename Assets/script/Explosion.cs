using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.3f);//0.3초 뒤에 자기자신 지움
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
