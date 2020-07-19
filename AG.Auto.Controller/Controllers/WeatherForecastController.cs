using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;
using Sugar.Enties;

namespace AG.Auto.Controller.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        public async Task<IEnumerable<NC_ORDER>> Orders()
        {

            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                    ConnectionString = "Data Source=10.10.200.101/test;User ID=mesdb;Password=mesdb;",
                    DbType = DbType.Oracle,//设置数据库类型
                    IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                    InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
             });
            //用来打印Sql方便你调式    
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
            /*查询*/
            var total = 20;
            var list = db.Queryable<NC_ORDER>().ToPageListAsync(1,20);//查询所有
            //var getById = db.Queryable<StudentModel>().InSingle(1);//根据主键查询
            //var getByWhere = db.Queryable<StudentModel>().Where(it => it.Id == 1).ToList();//根据条件查询
            //var total = 0;
            //var getPage = db.Queryable<StudentModel>().Where(it => it.Id == 1).ToPageList(1, 2, ref total);//根据分页查询
            return list.Result;
        }
    }
}
