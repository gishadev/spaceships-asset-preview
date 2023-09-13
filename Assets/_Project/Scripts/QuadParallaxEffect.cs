using UnityEngine;

namespace gishadev
{
    [RequireComponent(typeof(MeshRenderer))]
    public class QuadParallaxEffect : MonoBehaviour
    {
        [SerializeField] private float parallaxHorSpeed, parallaxVerSpeed;

        private Transform _camTrans;
        private MeshRenderer _quadRenderer;
        private Vector3 _previousCamPos;

        private void Awake()
        {
            _quadRenderer = GetComponent<MeshRenderer>();
            _camTrans = Camera.main.transform;
        }

        private void Update()
        {
            float parX = (_previousCamPos.x - _camTrans.position.x) * parallaxHorSpeed;
            float parY = (_previousCamPos.y - _camTrans.position.y) * parallaxVerSpeed;

            var xOffset =  _quadRenderer.material.mainTextureOffset.x;
            var yOffset =  _quadRenderer.material.mainTextureOffset.y;

            _quadRenderer.material.mainTextureOffset = new Vector2(xOffset + parX, yOffset + parY);
            _previousCamPos = _camTrans.position;
        }
    }
}