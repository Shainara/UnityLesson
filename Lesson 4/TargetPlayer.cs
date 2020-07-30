using UnityEngine;


public class TargetPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _bullet;
    [SerializeField] private Transform _spawnBullet;
    [SerializeField] private float _distance;

    private void Update()
    {
        if (Vector3.Distance(gameObject.transform.position,_player.position) <= _distance)
        {
            Vector3 relativePos = _player.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = rotation;

            Instantiate(_bullet, _spawnBullet.transform.position, _spawnBullet.transform.rotation);
        }
    }
}
