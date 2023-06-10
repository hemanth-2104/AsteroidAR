using System.Collections;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour
{
    [SerializeField] private GameObject _objectToCreate;
    [SerializeField] private Transform _referenceObjectRotation;
    [SerializeField] private GameObject _spriteObject;

    private Camera _mainCamera;
    private bool _canShoot = true;
    private bool _shoot = false;

    public bool isEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject targetObject = GameObject.Find("Player");

        _mainCamera = Camera.main;

        if (targetObject == null)
        {
            Debug.Log($"Player not found");
            return;
        }

        if (_mainCamera == null)
        {
            Debug.Log($"Main Camera not found, check our Tags");
            return;
        }

        // disable the Player component when running in Editor
#if UNITY_EDITOR
        isEnabled = true;
        Behaviour comp = targetObject.transform.GetComponent("Player") as Behaviour;
        comp.enabled = false;
#endif
    }

    // Update is called once per frame
    void Update()
    {
        if (!isEnabled) return;

        // get mouse position
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10;

        // get mouse world position
        Vector3 worldPosition = _mainCamera.ScreenToWorldPoint(mousePosition);
        _spriteObject.transform.position = mousePosition;

        // get mouse button
        _shoot = Input.GetMouseButtonDown(0);

        if (_shoot && _canShoot)
        {
            ShootBullet();

            _canShoot = false;
            StartCoroutine(EnableShooting());
        }
    }

    public void ShootBullet()
    {
        Vector3 worldPositionRef = _mainCamera.ScreenToWorldPoint(_referenceObjectRotation.position);
        Vector3 spawnPoint = transform.position;
        Quaternion fromRotation = Quaternion.LookRotation(worldPositionRef, Vector3.up);

        GameObject clone = Instantiate(_objectToCreate, spawnPoint, fromRotation);
        clone.name = $"{clone.name} {clone.GetInstanceID()}";
    }

    IEnumerator EnableShooting()
    {
        yield return new WaitForSeconds(0.3f);

        _canShoot = true;
    }
}
