import { Component } from '@angular/core';
import {IStudent} from "./student"

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'student-table';
  student:IStudent[]=[{rollno:1,name:"Vishal",cgpa:6.7},
{rollno:2,name:"Sumit",cgpa:7.5},
{rollno:3,name:"Rohan",cgpa:8}];


  


}
  ///"./node_modules/bootstrap/dist/css/bootstrap.css"  In angular.json