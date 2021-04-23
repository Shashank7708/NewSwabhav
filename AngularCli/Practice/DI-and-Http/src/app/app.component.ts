import { Component, OnInit } from '@angular/core';
import { __metadata } from 'tslib';
import { DependencyInjectionService } from './dependency-injection.service';

@Component({
  selector: 'app-root',
  template:`
  <div *ngFor="let emp of employees">
  <div>{{emp.id}}.{{emp.name}}-{{emp.age}}</div>
</div>
  ` ,
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{

public employees:any[]=[];
constructor(private _employees:DependencyInjectionService){

}
ngOnInit(){
  this.employees=this._employees.getEmployee();
}

}
