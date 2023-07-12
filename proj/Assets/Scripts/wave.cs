using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    public X xScript;
    public Y yScript;
    // Start is called before the first frame update
    void Start()
    {
        xScript = GameObject.Find("X").GetComponent<X>();
        yScript = GameObject.Find("Y").GetComponent<Y>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 ( xScript.x , yScript.y , transform.position.z);
    }
}
