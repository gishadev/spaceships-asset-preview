using UnityEngine;

namespace gishadev
{
    public class Turret : MonoBehaviour
    {
        private void Update()
        {
            var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var direction = (worldPos - transform.position).normalized;

            var rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;
            transform.rotation = Quaternion.Euler(Vector3.forward * rotZ);
        }
    }
}