using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialRotationTowardsTarget : MonoBehaviour
{
  [SerializeField] private string _targetName;
  [SerializeField] private Vector3 _randomOffset;

  void Start()
  {
    // look for the target in the hierarchy
    GameObject targetObject = GameObject.Find(_targetName);

    // make sure the target exists, if not return and do nothing
    if (targetObject == null) return;

    // get the target's position to get the direction
    Vector3 direction = targetObject.transform.position - transform.position;

    // randomize based on the offset and add to the direction
    direction += new Vector3(Random.Range(-_randomOffset.x, _randomOffset.x),
      Random.Range(-_randomOffset.y, _randomOffset.y),
      Random.Range(-_randomOffset.z, _randomOffset.z));

    // set the target's initial rotation based on the direction
    transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
  }
}