import { Component,OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  template:
  <input [(ngModel)]="prices" type="text">{{prices}}
  ,

  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'calculate-discount';
  cost:number=0;
  public prices:number=0;

  pricecalculate(price:string,dis:string){
    this.cost=parseInt(price)-parseInt(dis)/100*parseInt(price);
  }
ngOnInit(){

}
}
