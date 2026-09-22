using UnityEngine;

public class PumpkinController : MonoBehaviour
{
    public int pumpkinHealth = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
       if (pumpkinHealth > 0)
        {
            pumpkinHealth = pumpkinHealth - damageAmount;
        }

       if (pumpkinHealth <= 0)
        {
            pumpkinHealth = 0;
            Destroy(gameObject);
        }
        
     
    }

}
