using UnityEngine;

public class CarTest : MonoBehaviour
{
    Car lambo = new Car();
    Car rarri = new Car();
    void Start()
    {
        // Exercise: Change more values of our cars, call different methods (ie Park() the car
        lambo.color = Color.yellow;
        rarri.color = Color.red;
        lambo.manufacturer = "Lamborghini";
        rarri.manufacturer = "Ferrari";

        lambo.Print();
        rarri.Print();


    }
}
