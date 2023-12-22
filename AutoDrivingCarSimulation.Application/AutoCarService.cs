using AutoDrivingCarSimulation.Domain;

namespace AutoDrivingCarSimulation.Application
{
    public class AutoCarService
    {
        public void MoveAutoCar(AutoCar car, string commands)
        {
            // Logic for moving the car
            car.Move(commands);
        }
    }
}
