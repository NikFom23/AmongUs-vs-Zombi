using UnityEngine;
using UnityEngine.Events;

public class TriggerSpawn : MonoBehaviour
{
    [SerializeField] UnityEvent _action;

    

    private void OnTriggerEnter2D(Collider2D other)
    {      
        if (other.gameObject.tag == "Player")
        {
            _action.Invoke();
            
        }
    }
}
