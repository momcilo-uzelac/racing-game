using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngine : MonoBehaviour
{
    [SerializeField] private WheelCollider[] wheelColliders;

    [SerializeField] private Transform wheelFrontLeft;
    [SerializeField] private Transform wheelFrontRight;
    [SerializeField] private Transform wheelRearLeft;
    [SerializeField] private Transform wheelRearRight;

    [SerializeField] private float engineTorque = 400f;
    [SerializeField] private float maxSteerAngle = 30f;

    void FixedUpdate() {
        wheelColliders[0].steerAngle = Input.GetAxis("Horizontal") * maxSteerAngle;
        wheelColliders[1].steerAngle = Input.GetAxis("Horizontal") * maxSteerAngle;

        wheelColliders[2].motorTorque = Input.GetAxis("Vertical") * engineTorque;
        wheelColliders[3].motorTorque = Input.GetAxis("Vertical") * engineTorque;

        UpdateWheel(wheelColliders[0], wheelFrontLeft);
        UpdateWheel(wheelColliders[1], wheelFrontRight);
        UpdateWheel(wheelColliders[2], wheelRearLeft);
        UpdateWheel(wheelColliders[3], wheelRearRight);
    }

    private void UpdateWheel(WheelCollider collider, Transform wheel) {

        Vector3 pos = Vector3.zero;
        Quaternion rot = Quaternion.identity;

        collider.GetWorldPose(out pos, out rot);
        wheel.position = pos;
        wheel.rotation = rot;

    }
}
