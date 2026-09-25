using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public void Knockback(Vector3 knockbackSource, float knockbackStrength)
    {
        Vector3 knockbackDirection = (transform.position - knockbackSource).normalized;
        Vector3 knockbackAmount = knockbackDirection * knockbackStrength;
        transform.position = knockbackAmount + transform.position;

    }



}
