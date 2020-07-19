using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Sugar.Enties
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("NC_ORDER")]
    public partial class NC_ORDER
    {
           public NC_ORDER(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ORDER_ID {get;set;}

           /// <summary>
           /// Desc:订单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ORDER_CODE {get;set;}

           /// <summary>
           /// Desc:图号编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ITEM_CODE {get;set;}

           /// <summary>
           /// Desc:图号名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ITEM_NAME {get;set;}

           /// <summary>
           /// Desc:产品类型编码，01：零部件；02：虚拟件；03：工艺试验件；04：工装
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PRODUCT_TYPE_CODE {get;set;}

           /// <summary>
           /// Desc:责任部门
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RESPONSIBLE_DEPT {get;set;}

           /// <summary>
           /// Desc:责任部门编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RESPONSIBLE_DEPTCODE {get;set;}

           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal QUANTITY {get;set;}

           /// <summary>
           /// Desc:预计产出数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OUTPUTQTY {get;set;}

           /// <summary>
           /// Desc:订单分配状态：10未分配；20分配中；30分配完成
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DISTRIBUTION_STATE {get;set;}

           /// <summary>
           /// Desc:订单已分配数量（投产数量）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ORDER_ALLOCATED_QUANTITY {get;set;}

           /// <summary>
           /// Desc:订单待分配数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ORDER_UNALLOCATED_QUANTITY {get;set;}

           /// <summary>
           /// Desc:订单交付数量-入库数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ORDER_DELIVER_QUANTITY {get;set;}

           /// <summary>
           /// Desc:订单状态：10未执行；20执行中；30完成
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ORDER_STATUS {get;set;}

           /// <summary>
           /// Desc:投产批次
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BATCHNO {get;set;}

           /// <summary>
           /// Desc:节点批次
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NODEBATCHNO {get;set;}

           /// <summary>
           /// Desc:版本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VERSION {get;set;}

           /// <summary>
           /// Desc:任务号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TASK_CODE {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TASK_NAME {get;set;}

           /// <summary>
           /// Desc:内控日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? INTCONTROL_DATE {get;set;}

           /// <summary>
           /// Desc:投产计划ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PRODUCTIONPLANID {get;set;}

           /// <summary>
           /// Desc:ERP生产计划ID（作为返回ERP使用）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ERPPLANORDERID {get;set;}

           /// <summary>
           /// Desc:考核编码，1是；0否
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ASSESSMENT_CODE {get;set;}

           /// <summary>
           /// Desc:订单优先级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PRIORITY_CODE {get;set;}

           /// <summary>
           /// Desc:型号代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MODEL_CODE {get;set;}

           /// <summary>
           /// Desc:交付日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DELIVERY_DATE {get;set;}

           /// <summary>
           /// Desc:相关部门
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RELEVANT_DEPT {get;set;}

           /// <summary>
           /// Desc:相关部门编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RELEVANT_DEPTCODE {get;set;}

           /// <summary>
           /// Desc:外协编码：1：外协；0：非外协
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SUBCONTRACT_CODE {get;set;}

           /// <summary>
           /// Desc:订单来源：1：ERP；2：MES手工创建
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ORDER_SOURCE {get;set;}

           /// <summary>
           /// Desc:密级编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DECLASSIFIED_CODE {get;set;}

           /// <summary>
           /// Desc:是否满足创建工单条件：1：满足；0：不满足
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? IS_SATISFYCREATEWORKORDER {get;set;}

           /// <summary>
           /// Desc:ERP计划任务ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLAN_TASKID {get;set;}

           /// <summary>
           /// Desc:ERP物料ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MATERIAL_ID {get;set;}

           /// <summary>
           /// Desc:ERP物料编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MATERIAL_CODE {get;set;}

           /// <summary>
           /// Desc:ERP计划开始日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PLANSTARTDATE {get;set;}

           /// <summary>
           /// Desc:TC中的BOMID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BOMID {get;set;}

           /// <summary>
           /// Desc:ERP所属任务
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WES_ID {get;set;}

           /// <summary>
           /// Desc:ERP所属项目ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PROJECT_ID {get;set;}

           /// <summary>
           /// Desc:ERP最后修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ERP_LASTMODIFIEDTIME {get;set;}

           /// <summary>
           /// Desc:ERP状态（暂停、作废）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BILLSTATEID {get;set;}

           /// <summary>
           /// Desc:数据状态：是否删除（软删除），1、启用；0、未启用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DEL_STATE {get;set;}

           /// <summary>
           /// Desc:删除人编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DEL_USER_CODE {get;set;}

           /// <summary>
           /// Desc:删除时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DEL_DATE {get;set;}

           /// <summary>
           /// Desc:创建人编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REGISTER_CODE {get;set;}

           /// <summary>
           /// Desc:创建人名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REGISTER_NAME {get;set;}

           /// <summary>
           /// Desc:创建人所属部门编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REGISTER_ORG_CODE {get;set;}

           /// <summary>
           /// Desc:创建人所属部门名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REGISTER_ORG_NAME {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CREATE_DATE {get;set;}

           /// <summary>
           /// Desc:修改人编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MODIFY_CODE {get;set;}

           /// <summary>
           /// Desc:修改人名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MODIFY_NAME {get;set;}

           /// <summary>
           /// Desc:修改人所属部门编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MODIFY_ORG_CODE {get;set;}

           /// <summary>
           /// Desc:修改人所属部门名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MODIFY_ORG_NAME {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATE_DATE {get;set;}

           /// <summary>
           /// Desc:投产类型：P：批产，G：按件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PRODUCTMODE {get;set;}

           /// <summary>
           /// Desc:库存组织
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IMORG {get;set;}

           /// <summary>
           /// Desc:拆分状态：0，未拆分；1，已拆分
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SPLITSTATE {get;set;}

           /// <summary>
           /// Desc:阶段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STAGE {get;set;}

           /// <summary>
           /// Desc:技术状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RELEASESTATUS {get;set;}

           /// <summary>
           /// Desc:料单齐套状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MATBILLSTATUS {get;set;}

           /// <summary>
           /// Desc:车间订单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WORKORDER {get;set;}

           /// <summary>
           /// Desc:质量等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QUALITYLEVEL {get;set;}

           /// <summary>
           /// Desc:计划标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLANMARK {get;set;}

           /// <summary>
           /// Desc:计划员编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLANUSERCODE {get;set;}

           /// <summary>
           /// Desc:计划员名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLANUSERNAME {get;set;}

           /// <summary>
           /// Desc:调度员编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DISPACHUSERCODE {get;set;}

           /// <summary>
           /// Desc:调度员姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DISPACHUSERNAME {get;set;}

           /// <summary>
           /// Desc:订单类型：0：正常；1：返修
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORDERTYPE {get;set;}

           /// <summary>
           /// Desc:物料齐套状态：0 未齐套；1 部分齐套； 2 已齐套
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MATERIALSTATUS {get;set;}

           /// <summary>
           /// Desc:????齐套状态：0 未齐套；1 部分齐套； 2 已齐套
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TOOLLINGSTATUS {get;set;}

           /// <summary>
           /// Desc:????齐套状态：0 未齐套；1 部分齐套； 2 已齐套
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TOOLSTATUS {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SECRETRANKNAME {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SECRETRANKCODE {get;set;}

    }
}
