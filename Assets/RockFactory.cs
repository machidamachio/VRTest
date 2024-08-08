using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFactory : MonoBehaviour
{
    [SerializeField,Tooltip("クローン生成するときの岩のプレファブ")]
    private GameObject rockPrefab;
    [SerializeField,Tooltip("岩を飛ばすスピード")]
    private float rockSpeed = 1000;
    [SerializeField,Tooltip("生成する岩の数")]
    private int maxCount = 100;
    [SerializeField,Tooltip("左側のクリアテキスト")]
    private GameObject clearTextLeft;
    [SerializeField,Tooltip("右側のクリアテキスト")]
    private GameObject clearTextRight;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Generate),1,1);
        clearTextLeft.SetActive(false);
        clearTextRight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Generate()
    {
        if(count >= maxCount)
        {
            CancelInvoke();
            clearTextLeft.SetActive(true);
            clearTextRight.SetActive(true);
        }
        GameObject rock = Instantiate(rockPrefab);
        float randomX = Random.Range(-50f,50f);

        float randomY = Random.Range(-50f,50f);

        rock.transform.position = new Vector3(randomX,randomY,100);
        rock.transform.LookAt(this.gameObject.transform);
        Vector3 rockForce = rock.transform.forward * rockSpeed;
        rock.GetComponent<Rigidbody>().AddForce(rockForce);
        count++;

    }
}
