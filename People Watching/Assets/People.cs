using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    public PersonConfig peopleConfig;
    public Accessory hat;
    public Accessory shirt;
    public Accessory shoes;
    public GameObject myHat;
    public GameObject myShirt;
    public GameObject myShoes;

    private IPerson _person;
    private bool _isDecorated;

    // Start is called before the first frame update
    void Start()
    {
        _person = new Person(peopleConfig);
    }

    private void OnGUI()
    {
        GUI.color = Color.white;

        GUI.Label(new Rect(5, 50, 150, 100), "Hat " + hat?.name);
        GUI.Label(new Rect(5, 70, 150, 100), "Shirt " + shirt?.name);
        GUI.Label(new Rect(5, 90, 150, 100), "Shoes " + shoes?.name);
    }

    public void Decorate()
    {
        if (hat && !shirt && !shoes)
        {
            _person = new PersonDecorator(_person, hat);
            myHat = Instantiate(hat.accessoryPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            myHat.transform.parent = this.gameObject.transform;
        }
        if (!hat && shirt && !shoes)
        {
            _person = new PersonDecorator(_person, shirt);
        }
        if (!hat && !shirt && shoes)
        {
            _person = new PersonDecorator(_person, shoes);
        }
        if (hat && shirt && !shoes)
        {
            _person = new PersonDecorator(new PersonDecorator(_person, hat), shirt);
        }
        if (hat && !shirt && shoes)
        {
            _person = new PersonDecorator(new PersonDecorator(_person, hat), shoes);
        }
        if (hat && shirt && shoes)
        {
            _person = new PersonDecorator( new PersonDecorator(new PersonDecorator(_person, hat), shirt), shoes);
        }
        _isDecorated = !_isDecorated;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
