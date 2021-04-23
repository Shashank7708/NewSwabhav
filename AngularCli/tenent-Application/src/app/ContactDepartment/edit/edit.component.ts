import { Component, OnInit,Input } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ContactServiceService } from 'src/app/contact-service.service';
import { Contact } from '../contact';

@Component({
  selector: 'edit-contact',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {
contact:Contact =new Contact();
editcontact:any;

  constructor(private service:ContactServiceService,private _router:Router ) { }

ngOnInit(): void { 
  console.log(this.contact.id);
  this.contact=history.state;
  console.log(this.contact.id);
  this.editcontact=new FormGroup({
  Id:new FormControl({value:this.contact.id,disabled:true}),
  Name:new FormControl({value:this.contact.name},[Validators.required]),
  Mobileno:new FormControl({value:this.contact.mobileno},[Validators.required,Validators.minLength(10),Validators.maxLength(10)]),

  })
}


public onSubmit(){
  console.log(this.contact.id);
  console.log(this.contact.name);
  console.log(this.contact.mobileno);
  this.service.editContact(this.contact.id,this.editcontact.getRawValue()).subscribe(data=>console.log(data));
 // this._router.navigateByUrl("/home");
 }

}
