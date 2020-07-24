using UnityEngine;


public class Heal : MonoBehaviour
{
    [SerializeField] private int _heal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.GetComponent<MyEnemy>();
            player.Heal(_heal);
            Destroy(gameObject);
        }
    }
}
