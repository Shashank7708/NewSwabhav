import { JsonpClientBackend } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contact } from 'src/app/ContactDepartment/contact';
import { TenentService } from 'src/app/Servcices/tenent.service';
import { Tenent } from '../tenent';
import { User } from '../User';

@Component({
  selector: 'user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  constructor(private service:TenentService,private route:Router) { }
users:User[]=[];
tenent:Tenent=new Tenent();
ngOnInit(): void {
  this.tenent=JSON.parse(localStorage.getItem('tenent')||'{}');
  this.service.getUserOftenent(this.tenent.id).subscribe(
    res=>{this.users=res,console.log(res)},err=>console.log(err),
  )
  }

  addClick(){
    console.log("addclick"),
    console.log(this.tenent);
    this.route.navigateByUrl("tenent/user-register");
  }

  editClick(user:User){
    localStorage.setItem('user-edit',JSON.stringify(user));
    this.route.navigateByUrl("tenent/user/edit");
  }
  deleteClick(userid:any){
    console.log(userid);
    console.log(this.tenent.id);
    this.service.deleteUser(this.tenent.id,userid).subscribe(res=>console.log(res),err=>console.log(err))
  }
  getContacts(user:User){
    localStorage.setItem('user',JSON.stringify(user));
    this.route.navigateByUrl("/tenent/user/show-contact");
  }
  

}
