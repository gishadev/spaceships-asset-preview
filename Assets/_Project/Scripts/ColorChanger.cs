using UnityEngine;

namespace gishadev
{
    public class ColorChanger : MonoBehaviour
    {
        [SerializeField] private Sprite[] colorSprites;

        private SpriteRenderer _sr;

        private void Awake()
        {
            _sr = GetComponent<SpriteRenderer>();
            GameManager.ColorChanged += ChangeColor;
        }

        private void OnDestroy()
        {
            GameManager.ColorChanged -= ChangeColor;
        }

        private void ChangeColor(int index)
        {
            _sr.sprite = colorSprites[index];
        }
    }
}