namespace StudentRecordManagementSystem.Utility
{
    public class ConnectionString
    {
        private static string cName = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=StudentManagement;Integrated Security=True;";

        public static string CName
        {
            get => cName;
        }
    }
}
