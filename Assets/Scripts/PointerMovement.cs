using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMovement : MonoBehaviour
{
    private Vector3 MoveLeft = Vector3.left;
    private Vector3 MoveRight = Vector3.right;
    public float speed = 0.1f;
    private Vector3 movement;
    public GameObject pointer;
    private int speedOfBullet = 50;
    public Rigidbody bullet;
    public GameObject FrontOfPointer;
    public void MoveLeftButton()
    {
        if(pointer.GetComponent<Transform>().position.x < 2.50 && pointer.GetComponent<Transform>().position.x > -2.50)
        {
            movement = MoveLeft * speed;
            pointer.transform.Translate(movement);
        }
    }
    public void MoveRightButton()
    {
        if (pointer.GetComponent<Transform>().position.x < 2.50 && pointer.GetComponent<Transform>().position.x > -2.50)
        {
            movement = MoveRight * speed;
            pointer.transform.Translate(movement);
        }
    }
    public void PointerShot()
    {
        pointer.gameObject.GetComponent<AudioSource>().Play();
        Rigidbody bulletClone;
        bulletClone = Instantiate(bullet, FrontOfPointer.GetComponent<Transform>().position, FrontOfPointer.GetComponent<Transform>().rotation);
        bulletClone.velocity = transform.TransformDirection(Vector3.forward * speedOfBullet);
    }
}
