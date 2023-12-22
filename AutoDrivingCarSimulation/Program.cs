using AutoDrivingCarSimulation.Application;
using AutoDrivingCarSimulation.Domain;

namespace AutoDrivingCarSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()?.Split(' ');
            int width = int.Parse(input[0]);
            int height = int.Parse(input[1]);

            input = Console.ReadLine()?.Split(' ');
            int initialX = int.Parse(input[0]);
            int initialY = int.Parse(input[1]);
            Direction initialDirection = (Direction)Enum.Parse(typeof(Direction), input[2]);

            string commands = Console.ReadLine();

            AutoCar car = new AutoCar(width, height, initialX, initialY, initialDirection);
            var carService = new AutoCarService();
            carService.MoveAutoCar(car, commands);

            Console.WriteLine(car.ToString());
        }
    }
}