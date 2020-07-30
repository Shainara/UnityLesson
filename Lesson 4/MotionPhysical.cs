using UnityEngine;


public class MotionPhysical : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _mass;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private Vector3 _direction;
    
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        _direction.Normalize();

        Vector3 desiredForward =
            Vector3.RotateTowards(transform.forward, _direction, _rotateSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(desiredForward);
        
        if (Input.GetKeyDown("space")){
            _rigidbody.AddForce (0, 10000, 0);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.mass = _mass;
        var speed = (_direction.sqrMagnitude > 0) ? _speed : 0;
        speed = speed * Time.fixedDeltaTime;

        var moveDirection = transform.forward * speed;
        _rigidbody.velocity = moveDirection;
    }
}
