import { Component,OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  template:'./app.component.html',
   styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  constructor(){
    console.log("begining of the code");
  }
  
  title = 'calculate-discount';
  cost:number=0;
  public prices:number=0;

  pricecalculate(price:string,dis:string){
    this.cost=parseInt(price)-parseInt(dis)/100*parseInt(price);
    console.log("in priceCalculator Method");
  }
ngOnInit(){

}
}
