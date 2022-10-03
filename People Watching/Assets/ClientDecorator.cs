using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private People _people;
    private bool _isWeaponDecorated;

    // Start is called before the first frame update
    void Start()
    {
        _people = (People)FindObjectOfType(typeof(People));
    }

    private void OnGUI()
    {
        if (!_isWeaponDecorated)
        {
            if(GUILayout.Button("Decorate Person"))
            {
                _people.Decorate();
                _isWeaponDecorated = !_isWeaponDecorated;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
