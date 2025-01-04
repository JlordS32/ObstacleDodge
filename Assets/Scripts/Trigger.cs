using System.Collections;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject[] _projectiles;
    [SerializeField] float _delay = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < _projectiles.Length; i++)
            {
                StartCoroutine(Shoot());
            }
        }
    }
    private IEnumerator Shoot()
    {
        if (_projectiles.Length > 0 && _projectiles != null)
        {
            foreach (GameObject projectile in _projectiles)
            {
                projectile.SetActive(true);
                yield return new WaitForSeconds(_delay);
            }
        }
    }
}
