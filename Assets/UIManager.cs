using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text name, age, location, gender, favoriteCompany;
	private Name _name;
	private AGL _agl;
	private Company _company;

	void Start () {
		_name = GetComponent<Name>();
		_agl = GameObject.Find("Main Camera").GetComponent<AGL>();
		_company = GameObject.Find("Company").GetComponent<Company>();

		name.text = "Name: " + _name.name;
		age.text = "Age: " + _agl.age;
		location.text = "Location: " + _agl.location;
		gender.text = "Gender: " + _agl.gender;
		favoriteCompany.text = "Favorite Company: " + _company.favoriteCompany;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
