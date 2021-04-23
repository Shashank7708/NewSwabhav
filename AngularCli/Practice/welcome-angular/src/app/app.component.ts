import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'welcome To angular';
  image="../assets/java2.jpg";
  name3:string="";
  public arr:string[]=[];
  age1:string="";
  onclick(name:string,age:string){
    this.name3=name;
  
    this.age1=age;
  }

}
