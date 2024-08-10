using UnityEngine;
using UnityEngine.Events;


public class EnterCollisionComponent : MonoBehaviour
{
    [SerializeField] private UnityEvent _action;

    private string _tag;
    private int _damage;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BulletAK-47")
        {
            _tag = collision.gameObject.tag;
            _damage = -1;
            Debug.Log("-1");
        }

        if (gameObject.name != "Zombi(Clone)" && collision.gameObject.name == "Zombi(Clone)" )
        {
            _tag = collision.gameObject.tag;
            _damage = -1;
            Debug.Log("Zombie hit detected, setting damage to -1");
        }

        if (gameObject.name != "Zombi" && collision.gameObject.name == "Zombi")
        {
            _tag = collision.gameObject.tag;
            _damage = -1;
        }

        if (_tag != null)
        {
            if (collision.gameObject.CompareTag(_tag))
            {
                gameObject.GetComponent<Heals>()._healthDelta = _damage;
                _tag = null;
                _action?.Invoke();
            }
        }

    }

}
