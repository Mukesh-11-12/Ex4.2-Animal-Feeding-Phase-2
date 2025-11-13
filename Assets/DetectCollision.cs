using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    //start is called before the first frame update
    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onTriggerEnter(collider other)
    {
        Destroy(gameObject);
        Destroy(others.gameObject);
    }
}