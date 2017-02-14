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
        double CalculateTimeInHoursByDistanceAndSpeed(double distanceInKm, double speedInKmPerHours) {
            double timeInHours = distanceInKm / speedInKmPerHours;
            return timeInHours;
        }
        

        [TestMethod]
        public void TestCalculateDistanceMinus2Quarters() 
        {
            double remainingDistance = CalculateDistanceMinus2Quarters(100);
            Assert.AreEqual(50,remainingDistance);
        }
        public double CalculateDistanceMinus2Quarters(double initialDistance) {
            return initialDistance - 2 * initialDistance * 0.25;
        }



        [TestMethod]
        public void TestCalculateDistanceInKmBySpeedAndTime() {
            double distance = CalculateDistanceInKmBySpeedAndTime(100,1);
            Assert.AreEqual(100,distance);
        }
        public double CalculateDistanceInKmBySpeedAndTime(double speed, double time) {
            return speed * time;       
        }

        [TestMethod]
        public void TestTrainApp() {
            //double distance = CalculateBirdTotalDistance(120,10);

        }
        public double CalculateBirdTotalDistance(double distance, double trainSpeed) {
            double birdTotalDistance = 0;
            double birdSpeed = 2 * trainSpeed;
            double remainingDistance = CalculateDistanceMinus2Quarters(distance);
            double elapsedTime = 0;
            
            while (remainingDistance > 0) {
                
                elapsedTime = remainingDistance / (birdSpeed + trainSpeed);
                birdTotalDistance += CalculateDistanceInKmBySpeedAndTime(birdSpeed,elapsedTime);
                remainingDistance = remainingDistance -
                    2 * CalculateDistanceInKmBySpeedAndTime(trainSpeed, elapsedTime);
            }
            return birdTotalDistance;
        }

        


    }
}
