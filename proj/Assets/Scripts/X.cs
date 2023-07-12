using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{
    public float x;
    
    public float xAmplitude = 10;
    public teta tet;
    // Start is called before the first frame update
    void Start()
    {
        tet = GameObject.Find("Teta").GetComponent<teta>();
    }

    // Update is called once per frame
    void Update()
    {
        x = xAmplitude* Mathf.Cos(tet.Teta * Mathf.PI / 180);
        transform.position = new Vector3( x, transform.position.y , transform.position.z);
    }
}
