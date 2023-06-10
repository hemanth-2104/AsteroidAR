using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent OnShoot;
    [SerializeField] private float _fireRate = 0.3f;

    private bool _canShoot = true;
    private bool _shoot;

    void Update()
    {
        _shoot = Input.GetMouseButtonDown(0);

        if (_shoot && _canShoot)
        {
            OnShoot?.Invoke();

            _canShoot = false;
            StartCoroutine(EnableShooting());
        }
    }

    IEnumerator EnableShooting()
    {
        yield return new WaitForSeconds(_fireRate);
        _canShoot = true;
    }
}