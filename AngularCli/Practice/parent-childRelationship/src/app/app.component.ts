import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'parent-childRelationship';
  ratingHandler($event:any){
    console.log("Master says: "+$event);
  }
public message:any;
public name="Vishwas";

}
