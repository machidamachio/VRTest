using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDestroyer : MonoBehaviour
{
    [SerializeField,Tooltip("爆発エフェクトのプレファブ")]
    private GameObject explosionEffPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other) 
     {
        if(other.gameObject.tag == "Bullet")
        {
            GameObject explosionEff = Instantiate(explosionEffPrefab,this.gameObject.transform.position,this.gameObject.transform.rotation);
            Destroy(explosionEff,3);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
     }
}
