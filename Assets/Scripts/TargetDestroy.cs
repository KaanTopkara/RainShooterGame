using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestroy : MonoBehaviour
{
    public static int score = 0;
    public Rigidbody AfterDestroy;
    private int numberOfAfterDestroy = 50;
    public static bool AudioOn = false;
    public static bool IsGameOver = false;
    public static int LooseCube = 10;
    void Update()
    {

    }
    void OnCollisionEnter(Collision collison)
    {
        if (collison.gameObject.tag == "bullet")
        {
            AudioOn = true;
            score ++;
            Destroy(this.gameObject);
            for (int i = 0; i < numberOfAfterDestroy; i++)
            {
                Rigidbody DestoryClone;
                DestoryClone = Instantiate(AfterDestroy, this.GetComponent<Transform>().position, this.GetComponent<Transform>().rotation);
            }
           
        }
        if (collison.gameObject.tag == "ground")
        {
            LooseCube -= 1;
            Destroy(this.gameObject);
            if(LooseCube == 0)
            {
                IsGameOver = true;
            }
        }
    }
}
