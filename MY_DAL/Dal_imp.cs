﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MY_DAL
{
    public class Dal_imp:Idal
    {
        public Dal_imp()
        {
            DS.DataSource.testersList = new List<MY_BE.Tester>();
            DS.DataSource.testsList = new List<MY_BE.Test>();
            DS.DataSource.traineesList = new List<MY_BE.Trainee>();
        }
        public int testid;
        public void addTester(MY_BE.Tester tester)
        {
            DS.DataSource.testersList.Add(tester);
        }
        public void removeTester(MY_BE.Tester tester)
        {
            DS.DataSource.testersList.Remove(tester);
        }
        public void updateTester(MY_BE.Tester tester)
        {
            foreach(MY_BE.Tester item in DS.DataSource.testersList)
            {
                if (item.id == tester.id)
                {
                    DS.DataSource.testersList.Remove(item);
                    DS.DataSource.testersList.Add(tester);
                    break;
                }
            }
        }
        public void addTrainee(MY_BE.Trainee trainee)
        {
            DS.DataSource.traineesList.Add(trainee);
        }
        public void removeTrainee(MY_BE.Trainee trainee)
        {
            DS.DataSource.traineesList.Remove(trainee);
        }
        public void updateTrainee(MY_BE.Trainee trainee)
        {
            foreach (MY_BE.Trainee item in DS.DataSource.traineesList)
            {
                if (item.id == trainee.id)
                {
                    DS.DataSource.traineesList.Remove(trainee);
                    DS.DataSource.traineesList.Add(trainee);
                    break;
                }
            }
        }
         
        public void addTest(MY_BE.Test test)
        {
            test.TestNumber = (MY_BE.Configuration.TEST_ID++).ToString("00000000");
            DS.DataSource.testsList.Add(test);
        }
        public void updateTestOnFinish(MY_BE.Test test)
        {
            foreach(MY_BE.Test item in DS.DataSource.testsList)
            {
                if (item.TestNumber == test.TestNumber)
                {
                    DS.DataSource.testsList.Remove(item);
                    DS.DataSource.testsList.Add(test);
                    break;
                }
            }
        }
        public List<MY_BE.Tester> getAllTesters()
        {
            return DS.DataSource.testersList;
        }    //**need to return a copy. not areference that can change the source
        public List<MY_BE.Trainee> getAllTrainees()
        {
            return DS.DataSource.traineesList;
        }  //**need to return a copy. not areference that can change the source
        public List<MY_BE.Test> getAllTests()
        {
            return DS.DataSource.testsList;
        }        //**need to return a copy. not areference that can change the source
    }
}
