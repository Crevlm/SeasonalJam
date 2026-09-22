using UnityEngine;

public class CrowController : MonoBehaviour
{
    public Transform targetPumpkin;
    public float moveSpeed = 2f;
    public float stoppingDistance = 0.5f;

    public float attackCooldown = 3f;
    public float attackTimer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (targetPumpkin == null)
        {
            return;
        }


        attackTimer = attackTimer - Time.deltaTime;


        Vector3 direction = targetPumpkin.position - transform.position;

        

        float distanceToPumpkin = Vector3.Distance(transform.position, targetPumpkin.position);

        if (distanceToPumpkin > stoppingDistance) 
        {
            transform.position = transform.position + direction.normalized * (moveSpeed * Time.deltaTime);
        }

        if (distanceToPumpkin <= stoppingDistance)
        {
            PumpkinController pumpkin = targetPumpkin.GetComponent<PumpkinController>();
            if (attackTimer <=0)
            {
                pumpkin.TakeDamage(1);
                attackTimer = attackCooldown;
            }
            
        }
    }
}
