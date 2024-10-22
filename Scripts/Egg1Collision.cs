using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg1Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void OnEggCollisionType1();
    public event OnEggCollisionType1 OnEggCollisionWithCube;
    void Start()
    {
        
    }

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
