import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'first-app';
  cost:number=0;
  

  pricecalculate(price:string,dis:string){
    this.cost=parseInt(price)-parseInt(dis)/100*parseInt(price);
  }


}
