using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _speed;
    
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, Time.deltaTime * _speed);
        Destroy(gameObject, 3);
    }
}
