using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProcessor_GrahamPark_259907;

namespace FinalUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest_BlankVector()
        {
            Vector3 nVect = new Vector3();
            Assert.AreEqual(nVect.x,0);
            Assert.AreEqual(nVect.y,0);
            Assert.AreEqual(nVect.z,0);
        }

        [TestMethod]
        public void ConstructorTest_setVector()
        {
            Vector3 nVect = new Vector3(2.5f,3.6f,1.0f);
            Assert.AreEqual(nVect.x, 2.5f);
            Assert.AreEqual(nVect.y, 3.6f);
            Assert.AreEqual(nVect.z, 1.0f);
        }

        [TestMethod]
        public void DistanceFormulaCheck()
        {
            Vector3 nV1 = new Vector3(2, 6, 5);
            Vector3 nV2 = new Vector3(3, 1, 2);
            float temp = nV1.GetDistanceFrom(nV2);
            string t1 = temp.ToString("n2");
            string t2 = "5.92";
            Assert.IsTrue(t1 == t2);
        }


        [TestMethod]
        public void CheckLoop()
        {
            Process mPro = new Process();

            Vector3 nV1 = new Vector3(2, 6, 5);
            Vector3 nV2 = new Vector3(2, 5, 5);
            Vector3 nV3 = new Vector3(8, 7, 9);

            mPro.mVectors.Add(nV1);
            mPro.mVectors.Add(nV2);
            mPro.mVectors.Add(nV3);

            Assert.AreEqual(3, mPro.mVectors.Count);


            mPro.SortVectors(2);


            Assert.AreEqual(2, mPro.mVectors.Count);

        }

        //[TestMethod]
        //public void FailedTestExample()
        //{
        //    Assert.AreEqual(true, false);
        //}

    }

}
