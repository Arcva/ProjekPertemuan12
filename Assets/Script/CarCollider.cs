using UnityEngine;

public class CarCollider : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.collider.CompareTag("wall"))
        {
            Debug.Log("Awas nabrak nabrak, duar!");
        }
        if(obj.collider.CompareTag("enemy"))
        {
            Debug.Log("Car collided with enemy!");
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("item"))
        {
            Debug.Log("item collected!");
            Destroy(obj.gameObject);
        }
    }
}
