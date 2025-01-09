using UnityEngine;

public class Car
{
    public Color color;
    public float speed;
    public float mileage;
    public float weight;
    public float horsePower;
    public float friction;
    public float gas;
    public float suspension;
    public float downforce;

    public Vector3 size;
    public int modelNumber;
    public string manufacturer;
    public bool isMoving;
    public bool isManual = true;

    // TODO -- add additional data 

    public void Print()
    {
        Debug.Log("Manufacturer:" + manufacturer + ", color: " + color);
    }

    public void Drive()
    {
        isMoving = true;
    }
    
    public void Park()
    {
        isMoving = false;
    }

    public void ToggleTransmission()
    {
        isManual = !isManual;
    }

    public float Momentum()
    {
        return weight * speed;
    }
}
