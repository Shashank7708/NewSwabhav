import { Route } from '@angular/compiler/src/core';
import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ContactServiceService } from 'src/app/contact-service.service';
import { Contact } from '../contact';

@Component({
  selector: 'show-contact',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.scss']
})
export class ShowComponent implements OnInit {
constructor(private http:ContactServiceService,private _router:Router) { }
  
public contacts:Contact[]=[];

ngOnInit(): void {
  this.getdata();
}
getdata(){
    this.http.getContact().subscribe(data=>{console.log(data),this.contacts=data});
  }
  
  

 addClick(){
  this._router.navigateByUrl("/add-contact");
 }

editClick(contact1:any){
  this._router.navigateByUrl("/edit-contact/"+contact1.id,{state:contact1});
}

deleteClick(id:any){
  this.http.deletecontact(id).subscribe(data=>{console.log(data),
                                               this.getdata()}
  ,);
}
 
getAddress(contactid:any){
 // console.log(contactid);
this._router.navigateByUrl("/"+contactid+"/show-address",{state:contactid});
}
}
