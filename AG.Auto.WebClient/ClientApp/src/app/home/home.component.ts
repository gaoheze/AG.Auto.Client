import { Component,OnInit } from '@angular/core';
import * as XLSX from 'xlsx';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  excel_data = Array();
  query_data = Array();
  query_where = {
    // 铁水温度
    q_iron_temperature_from: 1150,
    // 铁水温度
    q_iron_temperature_to: 1450,
    q_iron_si:0.040,
    q_iron_si_from: 0.01,
    q_iron_si_to: 2.0,
    q_steel_temperature_from: 1600,
    q_steel_temperature_to: 1750,
    q_steel_temperature_si:0.020,
    q_blow_checked: false,
  }

  constructor() { }
  ngOnInit() {
    console.log("hello ngOnInit");
  }
  // 导出
  daochu() {
    /* generate worksheet */
    const ws: XLSX.WorkSheet = XLSX.utils.aoa_to_sheet(this.excel_data);
    const ws2: XLSX.WorkSheet = XLSX.utils.aoa_to_sheet(this.excel_data);

    /* generate workbook and add the worksheet */
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');
    XLSX.utils.book_append_sheet(wb, ws2, 'Sheet2');

    console.log(wb)
    /* save to file */
    XLSX.writeFile(wb, 'SheetJS.xlsx');
  }

  // 导入
  daoru(evt: any) {
    /* wire up file reader */
    const target: DataTransfer = <DataTransfer>(evt.target);
    if (target.files.length !== 1) throw new Error('Cannot use multiple files');
    const reader: FileReader = new FileReader();
    reader.onload = (e: any) => {
      /* read workbook */
      const bstr: string = e.target.result;
      const wb: XLSX.WorkBook = XLSX.read(bstr, { type: 'binary' });

      /* grab first sheet */
      const wsname: string = wb.SheetNames[0];
      const ws: XLSX.WorkSheet = wb.Sheets[wsname];

     /* save data */
     let xlsdata = [];
      xlsdata = (XLSX.utils.sheet_to_json(ws, { header: 0 }));
      console.log(xlsdata)
      this.excel_data = xlsdata;
      this.select();
      console.log(this.excel_data)
      //evt.target.value = "" // 清空
    };
    reader.readAsBinaryString(target.files[0]);

  }

  select() {
    this.query_data = this.excel_data.filter((item, index, array) => {
      return (
        (item["温度"] >= this.query_where.q_iron_temperature_from && item["温度"] <= this.query_where.q_iron_temperature_to) &&
        item["铁水成分：P"] >= this.query_where.q_iron_si &&
        item["出钢温度"] !== null && item["出钢温度"] !== "" &&       
        (item["出钢温度"] >= this.query_where.q_steel_temperature_from && item["出钢温度"] <= this.query_where.q_steel_temperature_to) &&
        //item["出钢：P"] <= this.query_where.q_steel_temperature_si &&
        (item["铁水成分：SI"] >= this.query_where.q_iron_si_from && item["铁水成分：SI"] <= this.query_where.q_iron_si_to) &&
        item["是否点吹"] === (this.query_where.q_blow_checked ? 1 : 0) 
        );
    });
  }
}
