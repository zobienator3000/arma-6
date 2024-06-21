using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletLife = 2;

    private void Awake()
    {
        Destroy(gameObject, bulletLife);
    }

    
}
