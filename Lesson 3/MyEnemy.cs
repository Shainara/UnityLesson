using UnityEngine;


public class MyEnemy : MonoBehaviour
{
    [SerializeField] private int _health;

    public void Hurt(int damage)
    {
        print("Ouch: " + damage);

        _health -= damage;

        if (_health <= 0)
        {
            Die();
        }
    }
    
    public void Heal(int heal)
    {
        print("Yes: " + heal);

        _health += heal;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}

