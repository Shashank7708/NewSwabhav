import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { TenentService } from 'src/app/Servcices/tenent.service';
import { Tenent } from '../tenent';
import { TenentUser } from '../Tenent-User';

@Component({
  selector: 'tenent-register',
  templateUrl: './tenent-register.component.html',
  styleUrls: ['./tenent-register.component.scss']
})
export class TenentRegisterComponent implements OnInit {

  constructor(private service:TenentService) { }
tenent:TenentUser=new TenentUser();
addtenent:any;
Tenent:Tenent=new Tenent();
result:any=""
Role="Admin"
  ngOnInit(): void {
this.addtenent=new FormGroup({
  Name:new FormControl({value:this.tenent.name},[Validators.required]),
  Strength:new FormControl({value:this.tenent.strength},[Validators.required]),
  UserName:new FormControl({value:this.tenent.username},[Validators.required,Validators.email]),
  Password:new FormControl({value:this.tenent.password},[Validators.required])
}
  )
  }

  onSubmit(){
    console.log(this.tenent);
    this.service.addTenent(this.tenent).subscribe(res=>{
      this.Tenent=JSON.parse(res),
      console.log(this.Tenent.id);
      this.service.addUser(this.Tenent.id,this.tenent,this.Role).subscribe(res=>{
        console.log(res);
       },err=>console.log(err));
      },err=>console.log(err));
  }

}
