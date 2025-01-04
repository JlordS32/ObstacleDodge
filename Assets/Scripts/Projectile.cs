using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _speed;

    // Variables
    private Vector3 _playerPosition;

    private void Start() {
        _playerPosition = _playerTransform.position;            
    }

    private void Update() {
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition, _speed * Time.deltaTime);
        DestroyWhenReached();
    }

    private void DestroyWhenReached() {
        if (Vector3.Distance(transform.position, _playerPosition) < 0.1f) {
            Destroy(gameObject);
        }
    }
}
