import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-binding',
  templateUrl: './binding.component.html',
  styleUrls: ['./binding.component.scss']
})
export class BindingComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
 lastName:string=""; 
  firstname:string="";
  nameChange(event:any){
    console.log(event);
    this.firstname=event;
  }

}
