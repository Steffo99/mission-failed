using UnityEngine;
using System.Collections;

public class DestroyObjectOnHit : MonoBehaviour
{
    public bool destroyWithAnyTag = false;
    public string tagName;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObj = collision.gameObject;
        if (collidedObj.CompareTag(tagName))
        {
            Destroy(gameObject);
        }
    }
}
