using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGenerator : MonoBehaviour {

    public GameObject TargetObX;
    public GameObject TargetObZ;
    public Transform Bord;

    private Vector3 _x1StartPosition;
    private Vector3 _x2StartPosition;
    private Vector3 _z1StartPosition;
    private Vector3 _z2StartPosition;
    private int _distance = 10;
    private float _moveRage = 2f;
    private float _speed = 2f;
	// Use this for initialization
	void Start () {
        _z1StartPosition = new Vector3(Bord.position.x + _distance, Bord.position.y, Bord.position.z - _moveRage);
        _z2StartPosition = new Vector3(Bord.position.x + _distance, Bord.position.y, Bord.position.z + _moveRage);
        _x1StartPosition = new Vector3(Bord.position.x - _moveRage, Bord.position.y, Bord.position.z + _distance);
        _x2StartPosition = new Vector3(Bord.position.x + _moveRage, Bord.position.y, Bord.position.z + _distance);

        InvokeRepeating("CreateTarget",0f, _speed);
    }
	
	// Update is called once per frame
	void Update () {
      
    }


    public void CreateTarget()
    {
        int rand = Random.Range(0, 4);
        switch (rand)
        {
            case 0:
                Instantiate(TargetObX, _x1StartPosition, Quaternion.identity);
                break;
            case 1:
                Instantiate(TargetObX, _x2StartPosition, Quaternion.identity);
                break;
            case 2:
                Instantiate(TargetObZ, _z1StartPosition, Quaternion.identity);
                break;
            case 3:
                Instantiate(TargetObZ, _z2StartPosition, Quaternion.identity);
                break;
        }
    }
}
