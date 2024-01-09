using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();    
    }

    private void Update()
    {
        var direction = (_target.position - transform.position).normalized;

        _rigidbody.velocity = direction * _speed;
    }

    public void Init(Transform target)
    {
        _target = target;
    }
}
