using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    /// <summary>
    /// Interface (Type of Abstraction)
    /// The class that interfaces if must implement the listed methods.
    /// 
    /// However when implemented (inherited polymporphism, the class can shape the method to it own use
    /// </summary>
    public interface IRestaurantData
    {
        /// <summary>
        /// Search the list of restaurants by its name
        /// </summary>
        /// <param name="name">If empty returns all restaurants</param>
        /// <returns>Collection of restaurant objects</returns>
        IEnumerable<Restaurant> GetRestaurantsByName(string name);

        /// <summary>
        /// Uses the Restaurant UID to return a single restaurant
        /// </summary>
        /// <param name="id">Restaurant UID</param>
        /// <returns>Single restaurant object</returns>
        Restaurant GetById(int id);

        /// <summary>
        /// Add restaurant to list of restaurants
        /// </summary>
        /// <param name="newRestaurant"></param>
        /// <returns></returns>
        Restaurant Add(Restaurant newRestaurant);

        /// <summary>
        /// Update an existing restaurant
        /// </summary>
        /// <param name="updatedRestaurant"></param>
        /// <returns></returns>
        Restaurant Update(Restaurant updatedRestaurant);

        /// <summary>
        /// Delete an existing restaurant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Restaurant Delete(int id);

        int Commit();

        int GetCountOfRestaurants();

        
    }
}
