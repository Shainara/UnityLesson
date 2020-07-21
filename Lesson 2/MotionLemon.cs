using UnityEngine;


public class MotionLemon : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
            transform.position += transform.right * horizontal * _speed * Time.deltaTime;

        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
            transform.position += transform.forward * vertical * _speed * Time.deltaTime;
    }
}
