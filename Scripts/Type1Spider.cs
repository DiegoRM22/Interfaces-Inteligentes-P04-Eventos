using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type1Spider : MonoBehaviour
{
    // Start is called before the first frame update
    public CubeCollision cubeCollision; // Referencia al CubeCollision
    public GameObject Group2Egg;        // Referencia al huevo del grupo 2
    private MoveTowardsSelected moveTowardsSelected;
    private GameObject oldTarget;       // Referencia al objetivo anterior
    void Start()
    {
        // Suscripción al evento estático usando la instancia de CubeCollision
        cubeCollision.OnCubeCollisionWithSpider2Event += MoveTowardsSelected;
        cubeCollision.OnCubeCollisionWithSpider1Event += MoveTowardsEgg;
        moveTowardsSelected = GetComponent<MoveTowardsSelected>();
        oldTarget = moveTowardsSelected.target;
    }

    void MoveTowardsSelected() {
        // Obtiene el componente MoveTowardsSphere2
        if (moveTowardsSelected.target != oldTarget) {
            moveTowardsSelected.target = oldTarget;
        }
        moveTowardsSelected.enabled = !moveTowardsSelected.enabled;
    }

    void MoveTowardsEgg() {
        // Obtiene el componente MoveTowardsSphere2
        moveTowardsSelected.target = Group2Egg;
        moveTowardsSelected.enabled = !moveTowardsSelected.enabled;
    }
}
