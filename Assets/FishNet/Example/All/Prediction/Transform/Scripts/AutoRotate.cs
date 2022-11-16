using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class AutoRotate : MonoBehaviour
{
    [System.Serializable]
    private enum RotateAxis
    {
        X,
        Y,
        Z
    }

    [SerializeField]
    private float rotateSpeed;

    [SerializeField]
    private bool clockWise;

    [SerializeField]
    private RotateAxis rotateAroundAxis;

    void Update()
    {
        int clockWiseFactor = clockWise ? -1 : 1;

        float rotateAngle = clockWiseFactor * rotateSpeed * Time.deltaTime;

        Vector3 rotationEuler = Vector3.zero;

        switch (rotateAroundAxis)
        {
            case RotateAxis.X:
                rotationEuler.x = rotateAngle;
                break;
            case RotateAxis.Y:
                rotationEuler.y = rotateAngle;
                break;
            case RotateAxis.Z:
                rotationEuler.z = rotateAngle;
                break;
        }

        transform.Rotate(rotationEuler);
    }
}
