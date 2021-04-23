import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { ContactServiceService } from 'src/app/contact-service.service';
import { Address } from '../address';

@Component({
  selector: 'edit-address',
  templateUrl: './edit-address.component.html',
  styleUrls: ['./edit-address.component.scss']
})
export class EditAddressComponent implements OnInit {
  contactid:any;
  address:Address=new Address();
  editAddress:any;
  constructor(private service:ContactServiceService,private route:Router,private _router:ActivatedRoute) { }

  ngOnInit(): void {
    this.address=history.state;
    this._router.paramMap.subscribe((param:ParamMap)=>{
      this.contactid = param.get('id');
  });
  this.editAddress=new FormGroup({
    Id:new FormControl({value:this.address.id,disabled:true}),
    City:new FormControl({value:this.address.city},[Validators.required]),
    State:new FormControl({value:this.address.state},[Validators.required]),
    Country:new FormControl({value:this.address.country},[Validators.required]),
    })
}

onSubmit(){
  this.service.editaddress(this.contactid,this.address.id,this.editAddress.getRawValue())
                                                                          .subscribe(data=>console.log(data));
  
  this.route.navigateByUrl("/"+this.contactid+"/show-address");
}

BackToList(){    
  this.route.navigateByUrl("/"+this.contactid+"/show-address");
}
}
