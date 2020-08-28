using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMovementWithKeyboard : MonoBehaviour
{
    private Vector3 MoveLeft = Vector3.left;
    private Vector3 MoveRight = Vector3.right;
    public float speed = 0.1f;
    private Vector3 movement;

    void Update()
    {
        
            if (Input.GetKey(KeyCode.A)) // To move left
            {
                if (this.gameObject.transform.position.x > -2.50)
                {
                    movement = MoveLeft * speed;
                    this.gameObject.transform.Translate(movement);
                }
            }


            if (Input.GetKey(KeyCode.D)) // To move left
            {
                if (this.gameObject.transform.position.x < 2.50)
                {
                    movement = MoveRight * speed;
                    this.gameObject.transform.Translate(movement);
                }
            }
        

    }
}
