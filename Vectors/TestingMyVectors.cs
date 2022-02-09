using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMyVectors : MonoBehaviour
{

    [SerializeField]
    MyVector2D first;

    [SerializeField]
    MyVector2D second;

    [SerializeField]
    [Range(0, 1)]
    public float range = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 a = new Vector2(1, 2);
        Vector2 b = new Vector2(3, 4);
        Vector2 c = a + (b / 2);


        MyVector2D first = new MyVector2D(1, 2);
        MyVector2D second = new MyVector2D(3, 4);
        MyVector2D result = first / 2; //first + range * (second - first); //first.Sum(second).Escalar(0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {


        // Draw the first and second
        first.Draw(Color.red);
        second.Draw(Color.green);

        // Draw the diff vector
        var diffVector = second.Resta(first);
        diffVector = diffVector.Escalar(range);
        diffVector.Draw(Color.blue);
        diffVector.Draw(first);

        // Calculate the lerp
        var lerp = first.Lerp(second, range);
        lerp.Draw();
    }
}
