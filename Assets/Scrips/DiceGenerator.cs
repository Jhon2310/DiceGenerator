using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;


public class DiceGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    private GameObject _newCube;

    private Color _startColor;
    private Color _endColor;
   

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _newCube = Instantiate(_cube);
            _newCube.transform.position = new Vector3(Random.Range(-20,20),10,Random.Range(-20,20));
            
        }
    }
}
