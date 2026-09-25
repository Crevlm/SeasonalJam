using UnityEngine;
using UnityEngine.InputSystem;

public class ScareAttack : MonoBehaviour
{
    public float scareRange;
    public float scareAngle;
    public float knockbackStrength; 
    public LayerMask enemyLayer;
    public Transform rotationPivot;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if( Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            
            PerformScareAttack();
        }


    }

    public void PerformScareAttack()
    {
        
        Collider[] collidersInRange = Physics.OverlapSphere(transform.position, scareRange, enemyLayer);
        //Debug.Log(collidersInRange.Length);

        foreach (Collider hitCollider in collidersInRange)
        {

            Vector3 directionToEnemy = hitCollider.transform.position - rotationPivot.transform.position;
            float angleToEnemy = Vector3.Angle(rotationPivot.forward, directionToEnemy);
            Debug.Log(angleToEnemy);

            if (angleToEnemy <= scareAngle/2f)
            {
               EnemyController enemy = hitCollider.GetComponent<EnemyController>();
                enemy.Knockback(transform.position, knockbackStrength);
            }


        }

    }


}
