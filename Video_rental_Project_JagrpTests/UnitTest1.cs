using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Video_rental_Project_JagrpTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Video_rental_Project_Jagrp.Movie obj = new Video_rental_Project_Jagrp.Movie();
            obj.bestClient();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Video_rental_Project_Jagrp.Movie obj = new Video_rental_Project_Jagrp.Movie();
            obj.getBookedCopies(1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Video_rental_Project_Jagrp.Movie obj = new Video_rental_Project_Jagrp.Movie();
            obj.getNoCopies(1);
        }

    }
}
