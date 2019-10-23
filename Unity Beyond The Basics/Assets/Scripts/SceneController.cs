using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public List<Shape> gameShapes;
    [SerializeField] public Dictionary<string, Shape> shapeDictionary;

    // Start is called before the first frame update
    void Start()
    {
        shapeDictionary = new Dictionary<string, Shape>();

        foreach(Shape shape in gameShapes)
        {
            shapeDictionary.Add(shape.Name, shape);
        }

        
    }

    private void SetRedByName(string shapeName)
    {
        shapeDictionary[shapeName].SetColor(Color.red);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SetRedByName("Square");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SetRedByName("Circle");
        }

    }

    private void FindExample()
    {
        Shape octagon = gameShapes.Find(s => s.Name == "Octagon");
        octagon.SetColor(Color.red);
    }

    private void ListExample()
    {
        string[] shapes = { "circle", "square", "triangle", "octagon" };
        List<string> moreShapes;

        moreShapes = new List<string> { "circle", "square", "triangle", "octagon" };

        moreShapes.Add("rectangle");
        moreShapes.Insert(2, "Diamond");
        moreShapes.Sort();

        for (int i = 0; i < moreShapes.Count; i++)
        {
            moreShapes[i] = moreShapes[i].ToUpper();
            Debug.Log(moreShapes[i]);
        }
    }
}
