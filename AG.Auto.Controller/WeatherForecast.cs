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

    //���ʵ�������ƺͱ�����һ�¿��Լ���SugarTable����ָ������
    [SugarTable("Student")]
    public class StudentModel
    {
        //ָ�������������У���Ȼ���ݿ���ҲҪ���������������вŻ���Ч
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //���ʵ�������ƺͱ�����һ�¿��Լ���SugarTable����ָ������
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
        /// ������
        /// </summary>
        public virtual string Order_code { set; get; }

        #endregion Model
    }
}
