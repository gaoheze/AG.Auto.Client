using SqlSugar;
using System;

namespace AG.Auto.Controller
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    //如果实体类名称和表名不一致可以加上SugarTable特性指定表名
    [SugarTable("Student")]
    public class StudentModel
    {
        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //如果实体类名称和表名不一致可以加上SugarTable特性指定表名
    [SugarTable("NC_ORDER")]
    public class OrderEntity
    {
        #region Model
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public virtual int Orderid { set; get; }
        /// <summary>
        /// 订单号
        /// </summary>
        public virtual string Order_code { set; get; }

        #endregion Model
    }
}
