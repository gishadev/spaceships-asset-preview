using System;
using UnityEngine;

namespace gishadev
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] spaceships;
        [SerializeField] private int maxColorIndex;
        
        public static event Action<int> ColorChanged;
        
        private int _currentSpaceshipIndex;
        private int _currentColorIndex;

        private void Awake()
        {
            for (var i = 0; i < spaceships.Length; i++) 
                spaceships[i].SetActive(i == _currentSpaceshipIndex);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _currentSpaceshipIndex = (_currentSpaceshipIndex + 1) % spaceships.Length;
                for (var i = 0; i < spaceships.Length; i++) 
                    spaceships[i].SetActive(i == _currentSpaceshipIndex);
            }
            
            if (Input.GetMouseButtonDown(1))
            {
                _currentColorIndex = (_currentColorIndex + 1) % maxColorIndex;
                ColorChanged?.Invoke(_currentColorIndex);
            }
        }
    }
}