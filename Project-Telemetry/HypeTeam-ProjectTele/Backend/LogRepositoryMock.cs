using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HypeTeam_ProjectTele.Models;

namespace HypeTeam_ProjectTele.Backend
{
    public class LogRepositoryMock : ILogRepository
    {
        public List<LogModel> dataset = new List<LogModel>();

        /// <summary>
        /// Constructor for Log Repository
        /// </summary>
        public LogRepositoryMock()
        {
            // Call for Sead data to be created
            Initialize();
        }

        /// <summary>
        /// Add the log item to the data store
        /// </summary>
        /// <param name="data">
        /// The new log item to add to the data store
        /// </param>
        /// <returns>return the passed in log item</returns>
        public LogModel Create(LogModel data)
        {
            dataset.Add(data);
            return data;
        }

        /// <summary>
        /// Return the requested log item from the data store
        /// if not found, return null
        /// </summary>
        /// <param name="id">the item to find</param>
        /// <returns>the item from the datastore, or null</returns>
        public LogModel Read(String id)
        {
            // Get the first instance of the record
            var myData = dataset.First(m => m.ID == id);
            return myData;
        }

        /// <summary>
        /// Update the item in the data store
        /// use the ID from the item passed in to find the item and then update it
        /// </summary>
        /// <param name="data">the item to update</param>
        /// <returns>the updated item</returns>
        public LogModel Update(LogModel data)
        {
            // Get the first instance of the record
            var myData = dataset.First(m => m.ID == data.ID);
            if (myData == null)
            {
                return null;
            }

            myData.Update(data);
            return data;
        }

        /// <summary>
        /// Remove the item from the data store
        /// Look it up by ID, if found, remove it, and return true
        /// else return false
        /// </summary>
        /// <param name="id">the item to remove by ID</param>
        /// <returns>true if removed</returns>
        public Boolean Delete(String id)
        {
            // Get the first instance of the record
            var myData = dataset.First(m => m.ID == id);
            if (myData == null)
            {
                return false;
            }

            var myResult = dataset.Remove(myData);
            return myResult;
        }

        /// <summary>
        /// Return all items in the data store
        /// </summary>
        /// <returns>a list of all the items in the data store</returns>
        public List<LogModel> Index()
        {
            return dataset;
        }

        /// <summary>
        /// Sets Initial Seed Data
        /// </summary>
        public void Initialize()
        {
            dataset.Add(new LogModel { AppVersion = "1", PhoneID = "ABC", Value = "2.1", RecordedDateTime = DateTime.Now, Location = "Lagos, Nigeria" });
            dataset.Add(new LogModel { AppVersion = "2", PhoneID = "MNO", Value = "5.2", RecordedDateTime = DateTime.Parse("01/23/2019"), Location = "Lagos, Nigeria" });
            dataset.Add(new LogModel { AppVersion = "3", PhoneID = "ZYX", Value = "8.5", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Lagos, Nigeria" });
            dataset.Add(new LogModel { AppVersion = "3.3", PhoneID = "ZYXa", Value = "3.6", RecordedDateTime = DateTime.Now.AddYears(-1), Location = "Lagos, Nigeria" });
        }
    }
}