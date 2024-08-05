using UnityEngine;
using UnityEngine.Events;

namespace Guns
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CapsuleCollider2D))]

    public class Bullet : MonoBehaviour
    {
        [SerializeField] private UnityEvent _action;

        private void OnCollisionEnter2D()
        {
            _action?.Invoke();
            return;
        }

        public void OnDestroy()
        {
            Destroy(gameObject);
            
        }
    }
}