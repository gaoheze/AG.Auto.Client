import { Component, OnInit } from '@angular/core';
import * as XLSX from 'xlsx';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public data = Array();
  //public data2 = [];
  //data = [
  //  ['1', 'a', 'aa'],
  //  ['2', 'b', 'bb'],
  //  ['3', 'c', 'cc']
  //]
  //public currentPage = 1; // 当前页 （请求数据）
  //public pageSize = 2;    // 每页记录数 （请求数据）
  //public totalCount = 0;   // 总记录数 （响应数据）
  //public totalPages = 0;   // 总页数 （根据 总记录数、每页记录数 计算 ）
  //public rows = Array();
  //// 要在分页工具条显示所有页码
  //public pageList = new Array();
  //prev() { };
  //next() { };
  //selectPage(page) {
  //  // 分割数据
  //  this.rows = this.datas.filter((item, index, array) => {
  //    return index <2
  //  });
  //  this.totalCount = this.datas.length;
  //  this.totalPages = Math.ceil(this.totalCount);

  //  //this.pageSize = this.datas.length;
  //  this.currentPage = page;
  //  let begin;
  //  let end;
  //  begin = this.currentPage - 5;
  //  if (begin<1) {
  //    begin = 1;
  //  }
  //  end = begin + 9;
  //  if (end>this.totalPages) {
  //    end = this.totalPages;
  //  }
  //  begin = end - 9;
  //  if (begin <1) {
  //    begin = 1;
  //  }
  //  for (var i = begin; i <= end; i++) {
  //    this.pageList.push(i);
  //  }
  //}
  //isActivePage(page) {
  //  return page === this.currentPage;
  //}
  constructor() { }
  ngOnInit() {
    console.log("hello ngOnInit");
  }
  // 导出
  daochu() {
    /* generate worksheet */
    const ws: XLSX.WorkSheet = XLSX.utils.aoa_to_sheet(this.data);
    const ws2: XLSX.WorkSheet = XLSX.utils.aoa_to_sheet(this.data);

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
      this.data = xlsdata.filter((item, index, array) => {        
        return item["是否点吹"] === 0 &&
          item["出钢温度"] != null &&
          item["出钢温度"] != "" &&
          (item["温度"] >= 1150 && item["温度"] <= 1450) &&
          (item["出钢温度"] >= 1600 && item["出钢温度"] <= 1750) &&
          item["铁水成分：P"] >= 0.040 ;
      });
      console.log(this.data)
      //evt.target.value = "" // 清空
    };
    reader.readAsBinaryString(target.files[0]);

  }
}
