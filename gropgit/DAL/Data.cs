namespace gropgit.DAL
{
    public class Data
    {
        private readonly string _connectionString = "server=BINYAMUN\\SA;initial catalog=shoes_and_hats; user id=sa;" +
          "password=1234;TrustServerCertificate=Yes";

        //private readonly string _connectionString = "server=MOSHE-TZEL123\\SA;initial catalog=ShoesAndHats; user id=SA;" +
        //   "password=1234;TrustServerCertificate=Yes";


        private static Data _data;
        private DataLayer DataLayer;
        private Data()
        {
            DataLayer = new DataLayer(_connectionString);
        }
        public static DataLayer Get
        {
            get
            {
                if (_data == null)

                    _data = new Data();
                return _data.DataLayer;

            }
        }
    }
}
