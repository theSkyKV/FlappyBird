using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTracker : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _xOffset;

    private void LateUpdate()
    {
        transform.position = new Vector3(_target.position.x + _xOffset, transform.position.y, transform.position.z);
    }
}
