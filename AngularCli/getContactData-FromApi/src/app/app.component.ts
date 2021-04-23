import { Component, OnInit } from '@angular/core';
import { ContactServiceService } from './contact-service.service';
import { Icontact } from './IContact';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  constructor(private _contactService:ContactServiceService){

  }
public _contacts:Icontact[]=[];
  ngOnInit(){
this._contactService.getEmployee().subscribe(data=>{this._contacts,console.log(data)});
  }
}
