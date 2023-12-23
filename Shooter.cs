using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Transform _target;

    private Coroutine _coroutine;

    private void Start()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(Play(_delay));
    }

    private IEnumerator Play(float delay)
    {
        bool isWork = true;

        var wait = new WaitForSeconds(delay);

        while (isWork)
        {
            var newBullet = Instantiate(_bullet, _shootPoint.position, Quaternion.identity);

            newBullet.Init(_target);

            yield return wait;
        }
    }
}
