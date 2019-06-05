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
            if (data == null)
            {
                return null;
            }

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
            var myData = dataset.FirstOrDefault(m => m.ID == id);

            if (myData == null)
            {
                return null;
            }

            // Found what was looking for, so all OK
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
            var myData = Read(data.ID);
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
            var myData = Read(id);
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

            dataset.Add(new LogModel { Value = "12.1", RecordedDateTime = DateTime.Now, Location = "Aba, Nigeria", UserID = "1234", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "27405281", AppVersion = "2.01", OsVersion = "4.0", LightLevel = "0.235", SaturationLevel = "12", HueLevel = "9", ClinicID = "3" });
            dataset.Add(new LogModel {Value = "25.2", RecordedDateTime = DateTime.Parse("03/23/2019"), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "1.01", OsVersion = "4.1", LightLevel = "0.52", SaturationLevel = "10", HueLevel = "9", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "38.5", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Abuja, Nigeria", UserID = "6749", PhoneHome = "Abuja, Nigeria", PhoneID = "99503231", AppVersion = "2.11", OsVersion = "4.4", LightLevel = "0.12", SaturationLevel = "5", HueLevel = "10", ClinicID = "2" });
            dataset.Add(new LogModel {Value = "32.6", RecordedDateTime = DateTime.Now.AddYears(-1), Location = "Lagos, Nigeria", UserID = "3578", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528682", AppVersion = "2.11", OsVersion = "4.4", LightLevel = "0.21", SaturationLevel = "5", HueLevel = "10", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "34.0", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Dutse, Nigeria", UserID = "6749", PhoneHome = "Abuja, Nigeria", PhoneID = "99503231", AppVersion = "2.11", OsVersion = "4.0", LightLevel = "0.33", SaturationLevel = "4", HueLevel = "8", ClinicID = "4" });
            dataset.Add(new LogModel { Value = "25.5", RecordedDateTime = DateTime.Now.AddDays(-7), Location = "Aba, Nigeria", UserID = "1234", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "27405281", AppVersion = "2.11", OsVersion = "4.1", LightLevel = "0.45", SaturationLevel = "2", HueLevel = "7", ClinicID = "3" });
            dataset.Add(new LogModel { Value = "17.5", RecordedDateTime = DateTime.Now.AddDays(-15), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "2.01", OsVersion = "5.2", LightLevel = "0.54", SaturationLevel = "1", HueLevel = "7", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "17.5", RecordedDateTime = DateTime.Now.AddDays(-12), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "2.01", OsVersion = "5.3", LightLevel = "0.65", SaturationLevel = "6", HueLevel = "5", ClinicID = "1" });

            dataset.Add(new LogModel { Value = "29.1", RecordedDateTime = DateTime.Now, Location = "Aba, Nigeria", UserID = "1234", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "27405281", AppVersion = "2.01", OsVersion = "4.4", LightLevel = "1.235", SaturationLevel = "6", HueLevel = "10", ClinicID = "3" });
            dataset.Add(new LogModel { Value = "35.2", RecordedDateTime = DateTime.Parse("03/25/2019"), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "1.01", OsVersion = "4.0", LightLevel = "0.782", SaturationLevel = "6", HueLevel = "8", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "28.5", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Abuja, Nigeria", UserID = "6749", PhoneHome = "Abuja, Nigeria", PhoneID = "99503231", AppVersion = "2.11", OsVersion = "4.4", LightLevel = "0.246", SaturationLevel = "5", HueLevel = "7", ClinicID = "2" });
            dataset.Add(new LogModel { Value = "30.6", RecordedDateTime = DateTime.Now.AddYears(-1), Location = "Lagos, Nigeria", UserID = "3578", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528682", AppVersion = "2.11", OsVersion = "4.4", LightLevel = "0.327", SaturationLevel = "5", HueLevel = "9", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "23.0", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Dutse, Nigeria", UserID = "6749", PhoneHome = "Abuja, Nigeria", PhoneID = "99503231", AppVersion = "2.11", OsVersion = "4.1", LightLevel = "0.612", SaturationLevel = "10", HueLevel = "6", ClinicID = "4" });
            dataset.Add(new LogModel { Value = "15.5", RecordedDateTime = DateTime.Now.AddDays(-7), Location = "Aba, Nigeria", UserID = "1234", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "27405281", AppVersion = "2.11", OsVersion = "4.1", LightLevel = "0.227", SaturationLevel = "15", HueLevel = "7", ClinicID = "3" });
            dataset.Add(new LogModel { Value = "27.5", RecordedDateTime = DateTime.Now.AddDays(-15), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "2.01", OsVersion = "5.3", LightLevel = "0.78", SaturationLevel = "12", HueLevel = "8", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "21.5", RecordedDateTime = DateTime.Now.AddDays(-12), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "2.01", OsVersion = "5.3", LightLevel = "0.84", SaturationLevel = "99", HueLevel = "9", ClinicID = "1" });

            dataset.Add(new LogModel { Value = "28.1", RecordedDateTime = DateTime.Now, Location = "Aba, Nigeria", UserID = "1234", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "27405281", AppVersion = "2.01", OsVersion = "6.0", LightLevel = "0.413", SaturationLevel = "10", HueLevel = "9", ClinicID = "3" });
            dataset.Add(new LogModel { Value = "5.2", RecordedDateTime = DateTime.Parse("01/26/2019"), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "1.01", OsVersion = "4.0", LightLevel = "0.728", SaturationLevel = "8", HueLevel = "8", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "18.5", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Abuja, Nigeria", UserID = "6749", PhoneHome = "Abuja, Nigeria", PhoneID = "99503231", AppVersion = "2.11", OsVersion = "4.4", LightLevel = "0.634", SaturationLevel = "5", HueLevel = "9", ClinicID = "2" });
            dataset.Add(new LogModel { Value = "4.6", RecordedDateTime = DateTime.Now.AddYears(-1), Location = "Lagos, Nigeria", UserID = "3578", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528682", AppVersion = "2.11", OsVersion = "4.1", LightLevel = "0.583", SaturationLevel = "2", HueLevel = "6", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "29.0", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Dutse, Nigeria", UserID = "6749", PhoneHome = "Abuja, Nigeria", PhoneID = "99503231", AppVersion = "2.11", OsVersion = "4.4", LightLevel = "0.216", SaturationLevel = "4", HueLevel = "5", ClinicID = "4" });
            dataset.Add(new LogModel { Value = "25.5", RecordedDateTime = DateTime.Now.AddDays(-7), Location = "Aba, Nigeria", UserID = "1234", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "27405281", AppVersion = "2.11", OsVersion = "5.3", LightLevel = "0.562", SaturationLevel = "1", HueLevel = "3", ClinicID = "3" });
            dataset.Add(new LogModel { Value = "37.5", RecordedDateTime = DateTime.Now.AddDays(-15), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "2.01", OsVersion = "6.0", LightLevel = "0.234", SaturationLevel = "5", HueLevel = "1", ClinicID = "1" });
            dataset.Add(new LogModel { Value = "31.5", RecordedDateTime = DateTime.Now.AddDays(-12), Location = "Lagos, Nigeria", UserID = "3426", PhoneHome = "Port Harcourt, Nigeria", PhoneID = "53528681", AppVersion = "2.01", OsVersion = "4.1", LightLevel = "0.8", SaturationLevel = "0", HueLevel = "1", ClinicID = "1" });

        }
    }
}