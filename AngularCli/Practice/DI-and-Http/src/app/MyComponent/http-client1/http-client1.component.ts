import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { IEmployee } from '../employee';
import { HttpserviceService } from '../httpservice.service';

@Component({
  selector: 'app-http-client1',
  template:`
  <div *ngFor="let emp of employees">
  <div>{{emp.Id}}-{{emp.name}}-{{emp.contactno}}</div>
  <div>{{emp.Address}}</div>
  </div>
  `,
  styleUrls: ['./http-client1.component.scss']
})
export class HttpClient1Component implements OnInit {

  
public employees:IEmployee[]=[];
constructor(private _employees:HttpserviceService){

}
ngOnInit(){
  this._employees.getEmployee().subscribe(data=>{this.employees=data});
}


}
