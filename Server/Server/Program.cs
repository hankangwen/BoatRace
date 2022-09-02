using DataBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boat Race Server Start.");

            var appSettings = ConfigurationManager.AppSettings;
            #region 连接数据库
            int connectDB = Int32.Parse(appSettings["OpenDB"]);
            if (connectDB == 1) {   //是否启用数据库
                var dbMgr = DBManager.Instance;
                dbMgr.ConnectDB(ConfigurationManager.ConnectionStrings["mongoDB"].ConnectionString);
                //创建user集合
                dbMgr.CreateCollection("user");
                dbMgr.PrintCollectionNames();
            }
            #endregion

            #region 启动服务器
            string ip = appSettings["IP"];
            int port = Int32.Parse(appSettings["Port"]);
            EchoServer server = new EchoServer(ip, port);
            server.Start();
            #endregion

            Console.WriteLine("Boat Race Server Stop.");
            Console.ReadKey();
        }
    }
}
