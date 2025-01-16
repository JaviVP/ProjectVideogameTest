using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;

public class Board : MonoBehaviour
{

    private List <Square> myBoard = new List<Square> ();
    [SerializeField] private GameObject orderSquare;
    private GameObject orderSquareClon;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            Square sq = new Square ();
            sq.SquareObject = this.gameObject.transform.GetChild(i).gameObject;
            orderSquare.SetActive(true);
            orderSquareClon = (GameObject)Instantiate(orderSquare);
            orderSquareClon.transform.SetParent(transform.GetChild(i).gameObject.transform);
            orderSquareClon.transform.localPosition = new Vector3 (0, 0.256f, 0);
            orderSquareClon.transform.localRotation = Quaternion.Euler(90, -100.411f, -10.576f);
            orderSquareClon.GetComponent<TMP_Text>().text = "" + i;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
