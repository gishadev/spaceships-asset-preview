using System;
using UnityEngine;

namespace gishadev
{
    [RequireComponent(typeof(Camera))]
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float cameraZoomSpeed = 1f;
        [SerializeField] private float moveSpeed = 1f;
        
        private Camera _camera;
        private float _targetSize;

        public float MoveSpeed => moveSpeed;

        private void Awake()
        {
            _camera = GetComponent<Camera>();
        }

        private void Update()
        {
            _camera.orthographicSize = Mathf.Lerp(_camera.orthographicSize, _targetSize, Time.deltaTime * cameraZoomSpeed);
            transform.Translate(Vector3.up * (MoveSpeed * Time.deltaTime));
        }

        public void SetTargetSize(float targetSize)
        {
            _targetSize = targetSize;
        }
    }
}