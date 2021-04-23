import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { ContactServiceService } from 'src/app/contact-service.service';
import { Address } from '../address';

@Component({
  selector: 'add-address',
  templateUrl: './add-address.component.html',
  styleUrls: ['./add-address.component.scss']
})
export class AddAddressComponent implements OnInit {

  constructor(private service:ContactServiceService,private _router:ActivatedRoute,private route:Router) { }
contactid:any;
address:Address=new Address();
addAddress:any;
ngOnInit(): void {
    this._router.paramMap.subscribe((param:ParamMap)=>{
                 this.contactid = param.get('id');

    this.addAddress=new FormGroup({
        Id:new FormControl({value:this.address.id,disabled:true}),
        City:new FormControl({value:this.address.city},[Validators.required]),
        State:new FormControl({value:this.address.state},[Validators.required]),
        Country:new FormControl({value:this.address.country},[Validators.required]),
        })
      
  })
}

onSubmit(){
  this.service.AddAddress(this.contactid,this.addAddress.getRawValue()).subscribe(data=>console.log(data));
  
this.route.navigateByUrl("/"+this.contactid+"/show-address");
}

BackToList(){    
  this.route.navigateByUrl("/"+this.contactid+"/show-address");
}

}
