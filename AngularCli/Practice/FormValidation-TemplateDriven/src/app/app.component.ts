import { Component } from '@angular/core';
import {FormControl,FormGroup,Validators} from "@angular/forms";


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'FormValidation-TemplateDriven';
email:any;
loginform=new FormGroup({
  email:new FormControl('',Validators.required),
  password:new FormControl(''),
})
get email1(){return this.loginform.get('email')}

}
