using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBordWASD : MonoBehaviour {
    
    private enum Selection { lvl1, lvl2, lvl3 };
    [SerializeField]
    private Selection _levelSelected = Selection.lvl1;
    public Transform Bord;
    private Vector3 _basePoz;
// Use this for initialization
    void Start () {
        _basePoz = Bord.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
            Move(1);
        if (Input.GetKeyDown(KeyCode.S))
            Move(2);
        if (Input.GetKeyDown(KeyCode.A))
            Move(3);
        if (Input.GetKeyDown(KeyCode.D))
            Move(4);
    }
    private void Move(int index)
    {
        Vector3 _basePoz = Bord.transform.position;
        int _moveRange = 0;
        switch (_levelSelected)
        {
            case Selection.lvl1:
                _moveRange = 2;
                break;
            case Selection.lvl2:
                _moveRange = 4;
                break;
            case Selection.lvl3:
                _moveRange = 6;
                break;
        }

        switch (index)
        {
            case 1:
                Bord.position = 
                    new Vector3(Bord.position.x, Bord.position.y, Bord.position.z + _moveRange);
                break;
            case 2:
                Bord.position =
                    new Vector3(Bord.position.x, Bord.position.y, Bord.position.z - _moveRange);
                break;
            case 3:
                Bord.position =
                    new Vector3(Bord.position.x - _moveRange, Bord.position.y, Bord.position.z);
                break;
            case 4:
                Bord.position =
                    new Vector3(Bord.position.x + _moveRange, Bord.position.y, Bord.position.z);
                break;

        }
        StartCoroutine(BeckToBasePoz());
    }

    IEnumerator BeckToBasePoz()
    {
        yield return new WaitForSeconds(0.3f);
        Bord.position = _basePoz;
    }
}
