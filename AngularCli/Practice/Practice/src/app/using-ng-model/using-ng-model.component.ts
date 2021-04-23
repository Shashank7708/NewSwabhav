import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-using-ng-model',
  templateUrl: './using-ng-model.component.html',
  styleUrls: ['./using-ng-model.component.scss']
})
export class UsingNgModelComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
name:string="Welcom!Calculate";
public price:number=0;
public discount:number=0;
public finalprice=0;
calculate(){
this.finalprice=this.price-this.discount*this.price/100;;
}
}
