using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCon : MonoBehaviour
{
    Rigidbody myRb;

    Vector3 DropUp;
    // Start is called before the first frame update
    void Start()
    {
        DropUp=new Vector3(0,3f,0);
        //myRb.AddForce(DropUp,ForceMode.Impulse);
        transform.position += DropUp; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
