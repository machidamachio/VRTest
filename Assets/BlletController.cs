using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlletController : MonoBehaviour
{
    [SerializeField,Tooltip("クローン生成する弾のプレファブ")]
    private GameObject bulletPrefab;
    [SerializeField,Tooltip("弾を飛ばすスピード")]
    private float bulletSpeed = 1000;
    [SerializeField,Tooltip("左側のゲームオーバーテキスト")]
    private GameObject gameOverTextLeft;
    [SerializeField,Tooltip("右側のゲームオーバーテキスト")]
    private GameObject gameOverTextRight;
    public float destroystatus = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Shot),1,0.5f);
        gameOverTextLeft.SetActive(false);
        gameOverTextRight.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Shot()
    {
        GameObject bullet = Instantiate(bulletPrefab.gameObject,this.gameObject.transform.position,this.gameObject.transform.rotation);
        Vector3 bulletForce = bullet.transform.forward * bulletSpeed;
        bullet.GetComponent<Rigidbody>().AddForce(bulletForce);
        Destroy(bullet,5);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Rock")
        {
            gameOverTextLeft.SetActive(true);
            gameOverTextRight.SetActive(true);

            destroystatus += 1;
            
        }
    }
}
