using UnityEngine;
using UnityEngine.Events;

public class CollisionComponent : MonoBehaviour
{
    [SerializeField] private UnityEvent _action;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var tag = collision.gameObject.tag;

        if (tag == "Player")
        {
            _action?.Invoke();
            GetComponent<Collider2D>().enabled = false;
        }
    }


}
