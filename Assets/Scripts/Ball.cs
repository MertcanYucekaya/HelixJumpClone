using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float jumpAmount;
    Rigidbody rigi;
    public GameObject splashPoint;
    public GameObject splash;
    public GameObject cylinder;
    public GameObject canvas;
   
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Black"))
        {
            rigi.velocity = Vector3.up * jumpAmount;
            GameObject newSplash = Instantiate(splash, Vector3.zero, splashPoint.transform.rotation);
            newSplash.transform.SetParent(transform);
            newSplash.transform.position = splashPoint.transform.position;
            newSplash.transform.SetParent(cylinder.transform);
           
        }
        if (collision.transform.CompareTag("Red"))
        {
            canvas.SetActive(true);
        }
        if (collision.transform.CompareTag("Final"))
        {
            Debug.Log("next level");
        }
    }

}
