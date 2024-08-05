using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void OnDestroy()
    {
        Destroy(gameObject);

    }
}
