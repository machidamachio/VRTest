using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;
    public static float scoreCount;
    public TextMeshProUGUI scoreText; 
    public float clearCount;

    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += transform.TransformDirection(Vector3.back * moveSpeed * Time.deltaTime);
            
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left * moveSpeed * Time.deltaTime);
            
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.right * moveSpeed * Time.deltaTime);
            
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-1 * rotSpeed * Time.deltaTime,0); 
            
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,rotSpeed * Time.deltaTime,0);
            
        }
        scoreText.text = "Score" + scoreCount.ToString();
        if(scoreCount == clearCount)
        {
            SceneManager.LoadScene("Clear");

        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Treasure"))
        {
            Destroy(collision.gameObject);
            
            scoreCount++;
        }
    }
}
