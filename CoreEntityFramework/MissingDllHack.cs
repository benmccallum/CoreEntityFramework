namespace CoreEntityFramework
{
    using System.Data.Entity;
    
    // A hack to prove to VS build process that the EntityFramework.SqlServer.dll file is required for all consumers of this class library
    // and should therefore be output in the bin of the build output.
    // See: http://stackoverflow.com/a/22315164/725626
    internal static class MissingDllHack
    {
        static void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
