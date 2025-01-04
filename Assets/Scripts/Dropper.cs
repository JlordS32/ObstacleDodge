using TMPro.EditorUtilities;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float _dropTime = 3f;

    // Components
    private Rigidbody _body;
    private MeshRenderer _renderer;

    private void Awake()
    {
        _body = GetComponent<Rigidbody>();
        _renderer = GetComponent<MeshRenderer>();
        _renderer.enabled = false;
    }

    private void Update()
    {
        float time = Time.time;

        if (time >= _dropTime)
        {
            _body.useGravity = true;
            _renderer.enabled = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("Hit the player");
        }
    }
}
