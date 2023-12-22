namespace AutoDrivingCarSimulation.Tests
{
    [TestFixture]
    public class AutoCarTests
    {
        [Test]
        public void Move_ForwardWithinBounds_ShouldMove()
        {
            // Arrange
            AutoCar car = new AutoCar(5, 5, 2, 2, Direction.North);
            var carService = new AutoCarService();

            // Act
            carService.MoveAutoCar(car, "F");

            // Assert
            Assert.AreEqual("2 3 North", car.ToString());
        }

        [Test]
        public void Move_OutsideBounds_ShouldNotMove()
        {
            // Arrange
            AutoCar car = new AutoCar(5, 5, 4, 4, Direction.East);
            var carService = new AutoCarService();

            // Act
            carService.MoveAutoCar(car, "F");

            // Assert
            Assert.AreEqual("4 4 East", car.ToString());
        }

        [Test]
        public void Move_RotateLeft_ShouldChangeDirection()
        {
            // Arrange
            AutoCar car = new AutoCar(5, 5, 2, 2, Direction.West);
            var carService = new AutoCarService();

            // Act
            carService.MoveAutoCar(car, "L");

            // Assert
            Assert.AreEqual("2 2 South", car.ToString());
        }

        [Test]
        public void Move_RotateRight_ShouldChangeDirection()
        {
            // Arrange
            AutoCar car = new AutoCar(5, 5, 2, 2, Direction.South);
            var carService = new AutoCarService();

            // Act
            carService.MoveAutoCar(car, "R");

            // Assert
            Assert.AreEqual("2 2 West", car.ToString());
        }

        [Test]
        public void Move_MultipleCommands_ShouldMoveInCorrectly()
        {
            // Arrange
            AutoCar car = new AutoCar(5, 5, 1, 1, Direction.North);
            var carService = new AutoCarService();

            // Act
            carService.MoveAutoCar(car, "FFRFFFRRLF");

            // Assert
            Assert.AreEqual("1 2 North", car.ToString());
        }

        [Test]
        public void Move_SampleScenario_ShouldEndAtCorrectPosition()
        {
            // Arrange
            AutoCar car = new AutoCar(9, 9, 1, 2, Direction.North);
            var carService = new AutoCarService();

            // Act
            carService.MoveAutoCar(car, "FFRFFFRRLF");

            // Assert
            Assert.AreEqual("1 2 North", car.ToString());
        }
    }
}