//Problem 6.	Create a database called SoftUniTwin
//Your task is to create a database called SoftUniTwin with the same structure as SoftUni using the features from DbContext. Find for the API for schema generation in MSDN or in Google.

namespace SoftUniTwin
{
    using UsingDB;

    class SoftUniTwin
    {
        static void Main()
        {
            // The connection string in App.config is changed
            // catalog=SoftUniTwin
            // This method recreate only structure of existing database without the data.
            CloneDb();
        }

        static void CloneDb()
        {
            var db = new SoftUniEntities();
            using (db)
            {
                db.Database.CreateIfNotExists();
            }
        }
    }
}
