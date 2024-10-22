using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void OnCubeCollision();
    public event OnCubeCollision OnCubeCollisionWithSpider1Event;
    public event OnCubeCollision OnCubeCollisionWithSpider2Event;
    public event OnCubeCollision OnApproximation;
    public event OnCubeCollision OnCubeCollisionWithEgg1;
    public event OnCubeCollision OnCubeCollisionWithEgg2;
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "SpiderType1") {
            if (OnCubeCollisionWithSpider1Event != null) {
                OnCubeCollisionWithSpider1Event();
            } else {
                Debug.Log("No subscribers");
            }
        } else if (collision.gameObject.tag == "SpiderType2") {
            if (OnCubeCollisionWithSpider2Event != null) {
                OnCubeCollisionWithSpider2Event();
            } else {
                Debug.Log("No subscribers");
            }
        } else if  (collision.gameObject.tag == "ReferenceObject") {
            if (OnApproximation != null) {
                OnApproximation();
            }
        } else if (collision.gameObject.tag == "Egg1") {
            if (OnCubeCollisionWithEgg1 != null) {
                OnCubeCollisionWithEgg1();
            }
        } else if (collision.gameObject.tag == "Egg2") {
            if (OnCubeCollisionWithEgg2 != null) {
                OnCubeCollisionWithEgg2();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
