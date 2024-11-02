namespace SortedListAsPriorityQueue_Example.Library;

public class PassengerBoarding
{
    public SortedList<Passenger, Status> Passengers { get; set; } = new();

    public void Enqueue(Passenger passenger)
    {
        Passengers.Add(passenger, passenger.MedallionStatus);
    }

    public Passenger Dequeue()
    {

    }

    public Passenger Peek()
    {

    }
}

public class Passenger
{
    public string Name { get; set; }
    public Status MedallionStatus { get; set; }

    public Passenger(string name, Status status)
    {
        Name = name;
        MedallionStatus = status;
    }


}

public enum Status
{
    Platinum,
    Gold,
    Silver,
    Bronze
}