using UnityEngine;


public class CameraPosition : MonoBehaviour {

    [SerializeField] private GameObject _playerPosition;
    [SerializeField] private Vector3 _offset;

    void Start () 
    {        
        _offset = transform.position - _playerPosition.transform.position;
    }

    void Update () 
    {        
        transform.position = _playerPosition.transform.position + _offset;
    }
}
