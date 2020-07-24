using UnityEngine;


public class MotionLemon : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void FixedUpdate()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");    

        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
        transform.Rotate(0, _direction.x, 0);
    }

}
    
    
