using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotate : MonoBehaviour
{
    [HideInInspector] public GameObject _target;

    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        LookAtTarget();
    }

    private void LookAtTarget()
    {
        if (_target != null)
        {
            Vector3 direction = _target.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


            if (angle > 90f || angle < -90f)
            {
                _sprite.flipX = false;
            }
            else if (angle > 90f || angle < 270f)
            {
                _sprite.flipX = true;
            }
        }
    }
}
