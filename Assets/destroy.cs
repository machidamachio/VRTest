using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    BlletController blletController;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(blletController.destroystatus >= 1)
        {
             Destroy(this.gameObject);
        }
    }
}
