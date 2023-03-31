using RestaurantManagementSystem.DomainEntities;
using System.Data;

using RestaurantManagementSystem.DataAccessLayer;
namespace RestaurantManagementSystem.BusinessLogicLayer
{
    public class RestaurantMgmtBLL
    {
        

        public static bool CreateRestaurant(Restaurant restaurant)
        {
            int AffectedRow = RestaurantMgmtDal.InsertRestaurant(restaurant);
            if(AffectedRow > 0 ) 
            { return true; }
            else 
            { return false; }
        }
        public static IEnumerable<DataRow> ReadRestaurantList()
        {
            DataTable restaurantTable = RestaurantMgmtDal.SelectRestaurantList();
            if (restaurantTable == null) { return null; }
            return restaurantTable.AsEnumerable();
        }

        public static IEnumerable<DataRow>  ReadCuisineList()
        {
            
            DataTable cuisineTable = RestaurantMgmtDal.SelectCuisineList();
            if (cuisineTable == null ) { return null; }
            return cuisineTable.AsEnumerable();


        }
        public static IEnumerable<DataRow>SearchRestaurant(int cuisine)
        {
          DataTable restaurantTable= RestaurantMgmtDal.SelectRestaurantsByCuisine(cuisine);

            return restaurantTable.AsEnumerable();
        }
    }
}