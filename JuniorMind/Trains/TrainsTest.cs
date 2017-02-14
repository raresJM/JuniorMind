using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class TrainsTest
    {
        
        [TestMethod]
        public void TestTimeByDistanceAndSpeed()
        {
            double timeInHours = CalculateTimeInHoursByDistanceAndSpeed(100,100);
            Assert.AreEqual(1,timeInHours);
        }
        public double CalculateTimeInHoursByDistanceAndSpeed(double distanceInKm, double speedInKmPerHours)
        {
            double result = distanceInKm / speedInKmPerHours;
            return Math.Round(result, 3);
        }
        

        [TestMethod]
        public void TestCalculateDistanceMinus2Quarters() 
        {
            double remainingDistance = CalculateDistanceMinus2Quarters(100);
            Assert.AreEqual(50,remainingDistance);
        }
        public double CalculateDistanceMinus2Quarters(double initialDistance)
        {
            double result = initialDistance - (2 * initialDistance * 0.25);
            return Math.Round(result, 3);
        }



        [TestMethod]
        public void TestCalculateDistanceInKmBySpeedAndTime() {
            double distance = CalculateDistanceInKmBySpeedAndTime(100,1);
            Assert.AreEqual(100,distance);
        }
        public double CalculateDistanceInKmBySpeedAndTime(double speed, double time)
        {
            double result = speed * time;
            return Math.Round(result, 3);
        }

        [TestMethod]
        public void TestTrainApp() {
            double distance = CalculateBirdTotalDistance(120,10);
            Assert.AreEqual(60, distance);

        }
        public double CalculateBirdTotalDistance(double distance, double trainSpeed)
        {
            double birdTotalDistance = 0;
            double birdSpeed = 2 * trainSpeed;
            double remainingDistance = CalculateDistanceMinus2Quarters(distance);
            double elapsedTime = 0;

            while (remainingDistance > 0)
            {
                //Console.Write("remainingDistance: ");
                //Console.WriteLine(remainingDistance);
                //Console.Write("elapsedTime: ");
                //Console.WriteLine(elapsedTime);               
                elapsedTime = Math.Round(remainingDistance / (birdSpeed + trainSpeed), 3);

                //Console.Write("birdTotalDistance: ");
                //Console.WriteLine(birdTotalDistance);
                birdTotalDistance = Math.Round(
                    birdTotalDistance +
                    CalculateDistanceInKmBySpeedAndTime(birdSpeed, elapsedTime), 3);



                remainingDistance = Math.Round(remainingDistance -
                2 * CalculateDistanceInKmBySpeedAndTime(trainSpeed, elapsedTime), 3);

                //Console.ReadKey();
            }
            return Math.Round(birdTotalDistance, 3);
        }
    }
}
