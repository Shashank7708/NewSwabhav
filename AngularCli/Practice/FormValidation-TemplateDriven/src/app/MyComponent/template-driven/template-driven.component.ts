import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import {FormControl,FormGroup,Validators} from "@angular/forms";
@Component({
  selector: 'app-template-driven',
  templateUrl: './template-driven.component.html',
  styleUrls: ['./template-driven.component.scss']
})
export class TemplateDrivenComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
 public name:any;
 public password:any;
public  email:any;
loginUser(signInForm:NgForm){
console.log(signInForm);
}

}
