using UnityEngine;


public class Riddle : MonoBehaviour
{
    [SerializeField] private GameObject _wall1;
    [SerializeField] private GameObject _wall2;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(_wall1);
            Destroy(_wall2);
        }
    }
}
