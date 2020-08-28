using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject, 2);
    }
}
