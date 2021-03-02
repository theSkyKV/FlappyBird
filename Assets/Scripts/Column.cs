using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.x < 0)
            Pool.PutToPool(gameObject);
    }
}
