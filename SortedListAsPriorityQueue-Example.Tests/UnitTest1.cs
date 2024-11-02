namespace SortedListAsPriorityQueue_Example.Tests;

using FluentAssertions;
using SortedListAsPriorityQueue_Example.Library;

public class TestPriorityQueue
{
    [Fact]
    public void PeekShouldBePlatinumStatus()
    {
        PassengerBoarding boardingOrder = new();

        Passenger Jane = new Passenger("Jane", Status.Gold);
        Passenger Sally = new Passenger("Jack", Status.Bronze);
        Passenger Jill = new Passenger("Jill", Status.Platinum);
        Passenger Jack = new Passenger("Jack", Status.Silver);
        Passenger Phil = new Passenger("Phil", Status.Bronze);
        Passenger Sarah = new Passenger("Sarah", Status.Platinum);

        List<Passenger> ListOfPassengers = [Jane, Sally, Jill, Jack, Phil, Sarah];

        foreach (var Passenger in ListOfPassengers)
        {
            boardingOrder.Enqueue(Passenger);
        }

        boardingOrder.Peek().Name.Should().Be("Jill");
    }
    [Fact]
    public void RemoveMinShouldRemoveInPriorityOrder()
    {
        PassengerBoarding boardingOrder = new();

        Passenger Jane = new Passenger("Jane", Status.Gold);
        Passenger Sally = new Passenger("Jack", Status.Bronze);
        Passenger Jill = new Passenger("Jill", Status.Platinum);
        Passenger Jack = new Passenger("Jack", Status.Silver);
        Passenger Phil = new Passenger("Phil", Status.Bronze);
        Passenger Sarah = new Passenger("Sarah", Status.Platinum);

        List<Passenger> ListOfPassengers = [Jane, Sally, Jill, Jack, Phil, Sarah];

        foreach (var Passenger in ListOfPassengers)
        {
            boardingOrder.Enqueue(Passenger);
        }

        var RemovedValue = boardingOrder.Dequeue();
        RemovedValue.MedallionStatus.Should().Be(Status.Platinum);
    }
}
