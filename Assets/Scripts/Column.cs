using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Destroyer>())
            Pool.PutToPool(gameObject);
    }
}
