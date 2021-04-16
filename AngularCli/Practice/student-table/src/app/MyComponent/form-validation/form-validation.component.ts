import { Component, OnInit } from '@angular/core';
import {FormControl,FormGroup,Validator} from '@angular/forms';
@Component({
  selector: 'app-form-validation',
  templateUrl: './form-validation.component.html',
  styleUrls: ['./form-validation.component.scss']
})
export class FormValidationComponent implements OnInit {

  constructor() { }
username:string="";
password:string="";
  ngOnInit(): void {
  }
  createFormControls():void{
    this.username = new FormControl('', Validators.required);
    this.password = new FormControl('', Validators.required);
  }

  createForm() { 
    this.loginForm = new FormGroup({
      username: this.username,
      password: this.password
    });
  }

}
