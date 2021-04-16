import { ReadVarExpr } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Todo } from "../../Todo";
import {Router} from "@angular/router";

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})
export class TodosComponent implements OnInit {

 todos:Todo[];
  constructor() { 
    this.todos=[
      {
        sno:1,
        title:"This is title",
        active:true
      },
      {
        sno:2,
        title:"This is 2nd title",
        active:true
      },
      {
        sno:3,
        title:"This is 3rd title",
        active:true
      }
    ]
  }




  ngOnInit(): void {
  }
  url="assets/java3.jpg";

  onfileSelect(e){
    if(e.target.files){
     var reade=new  FileReader();
     reade.readAsDataURL(e.target.file[0]);
     reade.onload=(event:any)=>{
       this.url=event.target.result;
     }
    }
  
  }

  
  btnclick=function(){
    this.router.navigator(['./java.html']);
  };
  

}