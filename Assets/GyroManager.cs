using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;

        transform.localEulerAngles = Input.gyro.attitude.eulerAngles + new Vector3(0,-90,-90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += Input.gyro.rotationRate;
    }
}
