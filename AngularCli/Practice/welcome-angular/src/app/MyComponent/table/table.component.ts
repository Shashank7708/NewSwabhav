import { Component, OnInit } from '@angular/core';
import {product} from '../Product'

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.scss']
})
export class TableComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {}
   arrofproduct :Array<product>=[];

   onCLick(name1:string,price1:string)
   {
    console.log(name1+" helo "+price1);
    let a:number=parseInt(price1);
    this.arrofproduct.push(new product(name1,a));
   }

}
