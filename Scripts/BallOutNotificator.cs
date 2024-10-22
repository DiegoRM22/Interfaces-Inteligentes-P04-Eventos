using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOutNotificator : MonoBehaviour
{
    public delegate void OnBallOut();
    public event OnBallOut OnBallOutEvent;
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball") {
            if (OnBallOutEvent != null) {
                OnBallOutEvent();
                Destroy(collision.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
