using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _speed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * _speed);
    }
}
