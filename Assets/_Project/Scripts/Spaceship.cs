using UnityEngine;

namespace gishadev
{
    public class Spaceship : MonoBehaviour
    {
        [SerializeField] private float zoomFactor = 5f;
        [SerializeField] private float rotationAmplitude = 30f;
        [SerializeField] private float xMoveOffset = 1f;

        private void OnEnable()
        {
            FindObjectOfType<CameraController>().SetTargetSize(zoomFactor);
        }

        private void Update()
        {
            transform.localPosition = Vector3.right * (Mathf.Sin(Time.time) * xMoveOffset);
            transform.localRotation = Quaternion.Euler(Vector3.forward * (Mathf.Sin(Time.time) * rotationAmplitude));
        }
    }
}