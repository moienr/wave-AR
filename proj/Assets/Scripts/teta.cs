using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teta : MonoBehaviour
{
    public float Teta;
    public float Speed =1;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         Teta = Mathf.PingPong(Time.time * Speed  , 36000 ) ;
       
         Debug.Log("teta:  " + Teta);
    }
}
