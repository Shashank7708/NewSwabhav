import { getLocaleNumberFormat } from '@angular/common';
import { Route } from '@angular/compiler/src/core';
import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ContactServiceService } from 'src/app/contact-service.service';
import { Tenent } from 'src/app/LoginAndRegister/tenent';
import { User } from 'src/app/LoginAndRegister/User';
import { TenentService } from 'src/app/Servcices/tenent.service';
import { Contact } from '../contact';

@Component({
  selector: 'show-contact',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.scss']
})
export class ShowComponent implements OnInit {
constructor(private service:TenentService,private route:Router) { }
  
public contacts:Contact[]=[];

user:User=new User();
tenent:Tenent=new Tenent();
ngOnInit(): void {
  this.user=JSON.parse(localStorage.getItem('user')||"{}");
  this.tenent=JSON.parse(localStorage.getItem('tenent')||"{}");
  this.service.getContactOfUser(this.tenent.id,this.user.id).subscribe(
    res=>{console.log(res);this.contacts=res}
  )
}

  
 addClick(){
  this.route.navigateByUrl("/tenent/user/add-contact");
 }

 editClick(contact:Contact){
   console.log(contact);
  localStorage.setItem('contact-edit',JSON.stringify(contact));
  this.route.navigateByUrl("/tenent/user/contact/edit");
}

deleteClick(id:any){
  this.service.deletecontact(this.tenent.id,this.user.id,id).subscribe(
    res=>console.log(res),err=>console.log(err),
  )
}
 
getAddress(contact:any){
 localStorage.setItem('contact',JSON.stringify(contact));
this.route.navigateByUrl("tenent/user/contatc/address");
}


backtoList(){
  this.route.navigateByUrl("/tenent/user-list");
}
}
