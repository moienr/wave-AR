using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y : MonoBehaviour
{
      public float y;
      public float phaseDifrens = -90;  
    public float yAmplitude = 10;
    public teta tet;
    // Start is called before the first frame update
    void Start()
    {
        tet = GameObject.Find("Teta").GetComponent<teta>();
    }

    // Update is called once per frame
    void Update()
    {
            y= yAmplitude* Mathf.Cos((tet.Teta + phaseDifrens) * Mathf.PI / 180);
        transform.position = new Vector3( transform.position.x , y , transform.position.z);
    }
}
