using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MyVector2D
{
    public float X;
    public float Y;

    public MyVector2D(float x, float y)
    {
        X = x;
        Y = y;
    }

    public MyVector2D Sum(MyVector2D other)
    {
        return this + other;
    }

    public static MyVector2D operator+(MyVector2D a, MyVector2D b)
    {
        return new MyVector2D(a.X + b.X, a.Y + b.Y);
    }

    public static MyVector2D operator-(MyVector2D a, MyVector2D b)
    {
        return new MyVector2D(a.X - b.X, a.Y - b.Y);
    }

    public static MyVector2D operator*(MyVector2D a, float scalar)
    {
        return new MyVector2D(a.X * scalar, a.Y * scalar);
    }

    public static MyVector2D operator*(float scalar, MyVector2D a)
    {
        return new MyVector2D(a.X * scalar, a.Y * scalar);
    }

    public static MyVector2D operator/(MyVector2D a, float scalar)
    {
        return new MyVector2D(a.X / scalar, a.Y / scalar);
    }
    //public static MyVector2D operator+(MyVector2D a, MyVector2D b)
    //{
    //    return new MyVector2D(a.X + b.X, a.Y + b.Y);
    //}

    //public static MyVector2D operator *(MyVector2D a, float b)
    //{
    //    return new MyVector2D(a.X * b, a.Y * b);
    //}

    //public static MyVector2D operator *(float a,MyVector2D b )//por sam P:D
    //{
    //    return new MyVector2D(a * b.X, a* b.Y);
    //}

    //public static float operator *(MyVector2D a, MyVector2D b)
    //{
    //    return a.X * b.X + a.Y * b.Y;
    //}

    public MyVector2D Resta(MyVector2D other)
    {
        return this - other;
    }

    public MyVector2D Escalar(float k)
    {
        return this * k;
    }

    public float Magnitud()
    {
        return Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2));
    }

    public MyVector2D Normalizar()
    {

        return new MyVector2D(X/Magnitud() , Y/Magnitud());
    }

    public void Draw(Color color = default)
    {
        Debug.DrawLine(Vector3.zero, new Vector3(X, Y), color);
    }

    public void Draw(MyVector2D customOrigin, Color color = default)
    {
        Debug.DrawLine(new Vector3(customOrigin.X, customOrigin.Y), new Vector3(customOrigin.X + X, customOrigin.Y + Y), color);
    }

    //public MyVector2D Lerp(MyVector2D start, MyVector2D end, float t)
    //{
    //    MyVector2D c = end.Resta(start);
    //    c = c.Escalar(t);
    //    MyVector2D result = start.Sum(c);
    //    return result;
    //}

    public MyVector2D Lerp(MyVector2D end, float scale)
    {

        return this * (1 - scale) + end; //new MyVector2D((X * (1 - scale) + (vector2D.X * scale)), (Y * (1 - scale) + (vector2D.Y * scale)));
    }

    public override string ToString()
    {
        return "(" + X + ", " + Y +")";
    }
}
