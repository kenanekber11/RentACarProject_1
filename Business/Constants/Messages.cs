using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Car added successfully";
        public static string ProductNameInvalid = "Invalid Car Name";
        public static string MaintenanceTime = "There is maintenance in the system";
        public static string ProductListed = "Cars are listed";
        public static string CarUpdated = "Car updated successfully";
        public static string CarDeleted = "Car deleted successfully";

        
        public static string ColorAdded = "Color added successfully";
        public static string ColorListed = "Colors are listed";

        public static string RentalAdded = "You rent the car succesfully";
        public static string RentalDateInvalid = "The car is not in the stocks";
      
        public static string RentalListed = "All Rents are listed";
        public static string AuthorizationDenied = "You don't have access for this operation!";
        public static string UserRegistered = "Registration is successfull";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password is wrong";
        public static string SuccessfulLogin = "Logged in successfully";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access Token created";
    }
}
