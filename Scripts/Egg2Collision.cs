using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg2Collision : MonoBehaviour
{
    public delegate void OnEggCollisionType2();
    public event OnEggCollisionType2 OnEggCollisionWithCube;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Cube") {
            if (OnEggCollisionWithCube != null) {
                OnEggCollisionWithCube();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
