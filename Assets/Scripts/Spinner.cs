using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _xAngle;
    [SerializeField] private float _yAngle;
    [SerializeField] private float _zAngle;

    private void Update() {
        transform.Rotate(_xAngle, _yAngle, _zAngle);
    }
}
