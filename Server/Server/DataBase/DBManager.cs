using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class DBManager
    {
        private static DBManager _instance;
        public static DBManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DBManager();
                return _instance;
            }
        }

        IMongoDatabase database;
        public void ConnectDB(string connectionString)
        {
            //var settings = MongoClientSettings.FromConnectionString("mongodb+srv://hankangwen:mongo112233HKW@cluster0.97wapoy.mongodb.net/?retryWrites=true&w=majority");
            //var settings = MongoClientSettings.FromConnectionString("mongodb+srv://hankangwen:mongo112233HKW@cluster0.12umxd5.mongodb.net/test");
            var settings = MongoClientSettings.FromConnectionString(connectionString);

            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            database = client.GetDatabase("test");
            Console.WriteLine("Connected to the database successfully!");
        }

        /// <summary>
        /// 创建集合
        /// </summary>
        /// <param name="collectionName"></param>
        public void CreateCollection(string collectionName)
        {
            var list = database.ListCollectionNames().ToList();
            foreach (var item in list) {
                if(item == collectionName) {
                    Console.WriteLine("Create collection:[{0}] Failed, collection is already create!", collectionName);
                    return;
                }
            }

            database.CreateCollection(collectionName);
            Console.WriteLine("Create collection:[{0}] successfully!", collectionName);
        }

        /// <summary>
        /// 获取/选择集合
        /// </summary>
        /// <param name="collectionName"></param>
        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            Console.WriteLine("Select collection tutorial2 successfully!");
            return collection;
        }

        /// <summary>
        /// 插入文档
        /// </summary>
        /// <param name="collectionName"></param>
        public void InsertOneDocument(string collectionName)
        {
            BsonDocument document = new BsonDocument("title", "MongoDB")
                .Add("description", "database")
                .Add("likes", 100)
                .Add("url", "www.bianchengbang.net")
                .Add("by", "编程帮");
            GetCollection(collectionName).InsertOne(document);
            Console.WriteLine("InsertOnce document successfully");
        }

        public void InsertManyDocument(string collectionName)
        {
            BsonDocument document1 = new BsonDocument("title", "MongoDB")
                .Add("description", "database")
                .Add("likes", 100)
                .Add("url", "www.bianchengbang.net")
                .Add("by", "编程帮");
            BsonDocument document2 = new BsonDocument("title", "html")
                .Add("description", "database")
                .Add("likes", 200)
                .Add("url", "www.bianchengbang.net/html")
                .Add("by", "编程帮");
            List<BsonDocument> list = new List<BsonDocument>();
            list.Add(document1);
            list.Add(document2);
            GetCollection(collectionName).InsertMany(list);
            Console.WriteLine("InsertMany document successfully");
        }

        /// <summary>
        /// 查询文档
        /// </summary>
        /// <param name="collectionName"></param>
        public void ForeachCollection(string collectionName)
        {
            var collection = GetCollection(collectionName);
            var filter = new BsonDocument();
            var list2 = Task.Run(async () => await collection.Find(filter).ToListAsync()).Result;
            list2.ForEach(p =>
            {
                Console.WriteLine(p);
            });
        }

        /// <summary>
        /// 更新文档
        /// </summary>
        /// <param name="collectionName"></param>
        public void UpdateOneDocument(string collectionName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("title", "html");
            var update = Builders<BsonDocument>.Update
                .Set("likes", 520)
                .CurrentDate("lastModified");
            GetCollection(collectionName).UpdateOne(filter, update);
            Console.WriteLine("Update document successfully!");
        }

        /// <summary>
        /// 删除文档
        /// </summary>
        /// <param name="collectionName"></param>
        public void DeleteOneDocument(string collectionName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("title", "MongoDB");
            GetCollection(collectionName).DeleteOne(filter);
            Console.WriteLine("Delete document successfully!");
        }

        /// <summary>
        /// 删除集合
        /// </summary>
        /// <param name="collectionName"></param>
        public void DropCollectionAsync(string collectionName)
        {
            Task.Run(async () =>
            {
                await database.DropCollectionAsync(collectionName);
            });
            Console.WriteLine("Drop collection successfully!");
        }

        /// <summary>
        /// 列出所有集合
        /// </summary>
        public void PrintCollectionNames()
        {
            var list = database.ListCollectionNames().ToList();
            foreach (var item in list) {
                Console.WriteLine(item);
            }

            // 输出集合user的内容
            const string collectionName = "user";   // 集合名称
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = new BsonDocument();
            var list2 = Task.Run(async () => await collection.Find(filter).ToListAsync()).Result;
            list2.ForEach(p =>
            {
                Console.WriteLine("姓名：" + p["name"].ToString() + ",电话:" + p["phone"].ToString());
            });
        }
    }
}
